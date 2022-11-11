using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MjpegProcessor;
using System.Data.OleDb;

namespace Hastane
{

    public partial class Personelekran : Form
    {
        private int sure = 120;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbCommand komut2;
        OleDbCommand ilkomut;
        OleDbCommand kankomut;
        OleDbCommand komut6;

        public Personelekran()
        {
            InitializeComponent();
        }
       
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)

        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            kamerapicturebox.Image = bmp;


        }
        private void kamera2btn_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[kamera_cmb.SelectedIndex].MonikerString);

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }
        private void kamera3btn_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)

            {

                cam.Stop();

            }
        }
       
        private void kamerabtn_Click(object sender, EventArgs e)
        {


           
        }
        
        private void Personelekran_Load(object sender, EventArgs e)
        {
            


            
            timer1.Start();
            
            tarihDuzenleme();
            foreach (Control item in panel2.Controls)
            {
                if (item.Text != "Randevu Saatini Seçin")
                {
                    if (item.BackColor != Color.Red)
                    {
                        item.Click += new EventHandler(asd_Click);
                    }
                }
            }
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in webcam)

            {

                kamera_cmb.Items.Add(item.Name);

            }
            kamera_cmb.SelectedIndex = 0;
           
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
            baglanti.Open();

            
            komut = new OleDbCommand("SELECT * FROM Personel where personelid=" + girisekrani.kullaniciid + "", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                personel_ismi.Text = dr["ad"].ToString() + " " + dr["soyad"].ToString();

            }

            //POLİKLİNİK

            komut2 = new OleDbCommand("SELECT * FROM Poliklinikler", baglanti);
            OleDbDataReader ddr = komut2.ExecuteReader();
            while (ddr.Read())
            {
                pol_cmb.Items.Add(ddr["poliklinikadi"].ToString());
            }

            //Poliklinik Bitiş

       
            baglanti.Close();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            girisekrani grs = new girisekrani();
            grs.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            #region Kayan Menü
            if (bunifuGradientPanel2.Width == 60)
            {
                bunifuGradientPanel2.Visible = false;
                bunifuImageButton2.Location = new Point(152, 6);
                bunifuGradientPanel2.Width = 206;
                bunifuTransition1.ShowSync(bunifuGradientPanel2);
                bunifuTransition2.ShowSync(bunifuImageButton1);

            }
            else
            {


                bunifuGradientPanel2.Visible = false;
                bunifuGradientPanel2.Width = 60;
                bunifuImageButton2.Location = new Point(12, 10);
                bunifuTransition1.ShowSync(bunifuGradientPanel2);
            }
            #endregion
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            randevu_panel.Visible = true;
            hastaekle_panel.Visible = false;
            randevukontrolpanel.Visible = false;
        }

        private void pol_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Seçilen Poliklinikden Doktorların Çekilmesi
            string doktordegeri = "";
            string combobox = pol_cmb.SelectedItem.ToString();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Hastane.accdb");
            baglanti.Open();
            komut = new OleDbCommand("Select * from Poliklinikler WHERE poliklinikadi='" + combobox + "'", baglanti);
            OleDbDataReader or = komut.ExecuteReader();
            while (or.Read())
            {
                doktordegeri = or["poliklinikid"].ToString();

            }


            komut2 = new OleDbCommand("Select * from Personel WHERE klinikid=" + doktordegeri + "", baglanti);
            OleDbDataReader br = komut2.ExecuteReader();
            while (br.Read())
            {
                doktor_cmb.Items.Add(br["ad"].ToString() + " " + br["soyad"].ToString());
            }
            baglanti.Close();
            #endregion
        }
        public string secilentarih;
        private void monthCalendar_randevuTarihleri_DateSelected(object sender, DateRangeEventArgs e)
        {
            Personelekran frm3 = new Personelekran();

            
        }
        DateTime datee = DateTime.Now;
        bool ayniSaatVarmi = false;
        void tarihDuzenleme()
        {
            int i = 0;
            while (cmBoxRandevTarihi.Items.Count != 5)
            {
                if (datee.AddDays(i).DayOfWeek.ToString() != "Saturday" && datee.AddDays(i).DayOfWeek.ToString() != "Sunday")
                {
                    cmBoxRandevTarihi.Items.Add(datee.AddDays(i).ToShortDateString());
                }
                i++;
            }
        }
        void secilenTarihBugunmu()
        {

            foreach (Control saatlerYesil in panel2.Controls)
            {
                if (saatlerYesil.Text != "Randevu Saatini Seçin")
                {
                    saatlerYesil.BackColor = Color.LawnGreen;
                }
            }

            DateTime date = DateTime.Now;

            if (date.ToShortDateString() == cmBoxRandevTarihi.Text)
            {
                
                int dakika = date.Minute;
                int saat = date.Hour;
                foreach (Control item in panel2.Controls)
                {
                    if (item.Text != "Randevu Saatini Seçin")
                    {
                        if (int.Parse(item.Text.Substring(0, 2)) < saat)
                        {
                            item.BackColor = Color.Red;
                            item.Cursor = Cursors.Default;
                        }
                        if (int.Parse(item.Text.Substring(0, 2)) == saat)
                        {
                            if (int.Parse(item.Text.Substring(3)) <= dakika)
                            {
                                item.BackColor = Color.Red;
                                item.Cursor = Cursors.Default;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Control item in panel2.Controls)
                {
                    if (item.Text != "Randevu Saatini Seçin")
                    {
                        item.BackColor = Color.LawnGreen;
                        item.Cursor = Cursors.Hand;
                    }
                }
            }



            /////VERİ TABANINDAN GÜN ÇEKİLECEK

            try
            {
                baglanti.Open();

                OleDbCommand cmd = new OleDbCommand("Select * From Randevular1 where DoktorAdi='" + doktor_cmb.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    foreach (Control item in panel2.Controls)
                    {
                        if (rd["Saat"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                            item.Cursor = Cursors.Default;
                        }
                    }
                }
                
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        void asd_Click(object sender, EventArgs e)
        {
            secilenTarihBugunmu();
            ayniSaatVarmi = false;
            foreach (Control saatler in panel2.Controls)
            {
                if (saatler.Text == sender.ToString().Substring(34))
                {
                    if (saatler.BackColor != Color.Red)
                    {
                        baglanti.Open();
                        OleDbCommand cmdAyniSaatteVarmi = new OleDbCommand("Select * From Randevular1 where Tc='" + tckimlik_txt.Text + "' and Tarih='" + cmBoxRandevTarihi.Text + "'", baglanti);
                        cmdAyniSaatteVarmi.ExecuteNonQuery();
                        OleDbDataReader saatKontrol = cmdAyniSaatteVarmi.ExecuteReader();
                        while (saatKontrol.Read())
                        {
                            if (saatler.Text == saatKontrol["Saat"].ToString())
                            {
                                ayniSaatVarmi = true;
                                MessageBox.Show("Aynı Gün ve Saatte Yalnızca Bir Adet Randevu Alabilirsiniz");
                                baglanti.Close();
                                break;
                            }

                        }
                        baglanti.Close();
                    }
                    if (saatler.BackColor != Color.Red)
                    {
                        if (ayniSaatVarmi == false)
                        {
                            baglanti.Close();
                            DialogResult evetmi;
                            evetmi = MessageBox.Show(cmBoxRandevTarihi.Text + " Tarihinde " + sender.ToString().Substring(34) + " Saatinde " + pol_cmb.Text + " Kliniğinde \n" +doktor_cmb.Text + " Tarafından Muayene İçin Randevu Alınıyor ", "", MessageBoxButtons.YesNo);
                            if (evetmi.ToString() == "Yes")
                            {
                                try
                                {
                                    baglanti.Open();

                                    string ad = "";
                                    string soyad = "";
                                    
                                    komut6 = new OleDbCommand("Select * from hastalar where tckimlikno='"+tckimlik_txt.Text+"'", baglanti);

                              
                                   OleDbDataReader or = komut6.ExecuteReader();
                                    while (or.Read())
                                    {
                                        ad = or["ad"].ToString();
                                        soyad = or["soyad"].ToString();

                                    }
                          
                                    
                                    OleDbCommand cmd = new OleDbCommand("insert into Randevular1 (Tc,KlinikAdi,DoktorAdi,Tarih,Saat,Ad,Soyad) values ('" + tckimlik_txt.Text + "','" + pol_cmb.Text + "','" + doktor_cmb.Text + "','" + cmBoxRandevTarihi.Text + "','" + saatler.Text + "','" + ad + "','" + soyad + "')", baglanti);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Randevu İşleminiz Başarıyla Gerçekleşmiştir");
                                    baglanti.Close();
                                    
                                    
                                    
                                }
                                catch (Exception hata)
                                {
                                    MessageBox.Show(hata.Message);
                                }
                            }

                            break;
                        }
                    }
                }
            }
        }

        private void hastaekle_btn_Click(object sender, EventArgs e)
        {
            hastaekle_panel.Visible = true;
            randevu_panel.Visible = false;
            randevukontrolpanel.Visible = false;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
            baglanti.Open();

            ilkomut = new OleDbCommand("Select * from iller", baglanti);
            OleDbDataReader iloku = ilkomut.ExecuteReader();
            while (iloku.Read())
            {
                iller_cmb.Items.Add(iloku["iladi"].ToString());
                dogumyeri_cmb.Items.Add(iloku["iladi"].ToString());
            }

            kankomut = new OleDbCommand("Select * from kangrubu", baglanti);
            OleDbDataReader kanoku = kankomut.ExecuteReader();
            while (kanoku.Read())
            {
                kangrubu_cmb.Items.Add(kanoku["kangrubuadi"].ToString());
            }
            baglanti.Close();
        }

        private void kamerabtn_Click_1(object sender, EventArgs e)
        {
            if (tcno_text.TextLength < 11)
            {
                MessageBox.Show("Tc Kimlik Numaranızı doğru girin");
            }
            else
            {
                string tcno = "";
                tcno = tcno_text.Text;
                kamerapicturebox.Image.Save(".\\hastaresim\\" + tcno + ".png");
            }
        }

        private void kamera2btn_Click_1(object sender, EventArgs e)
        {
            kamerapicturebox.Visible = true;
            kamerabtn.Visible = true;
            label44.Visible = true;
            cam = new VideoCaptureDevice(webcam[kamera_cmb.SelectedIndex].MonikerString);

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }

        private void kamera3btn_Click_1(object sender, EventArgs e)
        {
            if (cam.IsRunning)

            {

                cam.Stop();
                kamerabtn.Visible = false;
                label44.Visible = false;
                kamerapicturebox.Visible = false;

            }
        }
        
        private void iller_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ildegeri = "";

            string combobox = iller_cmb.SelectedItem.ToString();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Hastane.accdb");
            baglanti.Open();
            komut = new OleDbCommand("Select * from iller WHERE iladi='" + combobox + "'", baglanti);
            OleDbDataReader or = komut.ExecuteReader();
            while (or.Read())
            {
                ildegeri = or["ilplaka"].ToString();

            }


            komut2 = new OleDbCommand("Select * from ilceler WHERE ilid=" + ildegeri + "", baglanti);
            OleDbDataReader br = komut2.ExecuteReader();
            while (br.Read())
            {
                ilceler_cmb.Items.Add(br["ilceadi"].ToString());



            }
            baglanti.Close();

        }

        private void tcno_text_Click(object sender, EventArgs e)
        {
            tcno_text.Text = "";
            tcno_text.MaxLength = 11;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.MaxLength = 25;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.MaxLength = 25;
        }
        OleDbCommand komut3;//Dogum yeri
        OleDbCommand komut4;//hasta ekleme işlemi komutu
        OleDbCommand komut5;//aynı hasta varmı
        
        private void hastaeklebtn_Click(object sender, EventArgs e)
        {


           try
          {

                string ad = "", soyad = "", adres = "", tckimlik = "", cinsiyet = "", medenihal = "";
                int ilid = 0, ilceid = 0, kangrubuid = 0, dogumyeriid = 0;
                tckimlik = tcno_text.Text;
                ad = textBox1.Text;
                soyad = textBox2.Text;
                adres = richTextBox1.Text;

                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");

                baglanti.Open();

                if (radioButton1.Checked == true)
                {
                    cinsiyet = "E";
                }
                if (radioButton2.Checked == true)
                {
                    cinsiyet = "K";
                }
                if (radioButton3.Checked == true)
                {
                    medenihal = "Evli";
                }
                if (radioButton4.Checked == true)
                {
                    medenihal = "Bekar";
                }
                string meslek = "", telefon = "";
                int vergino = 0;
                vergino = Convert.ToInt32(vergi_txt.Text);
                telefon = telefon_txt.Text;
                meslek = meslek_txt.Text;

                DateTime kayittarihi = DateTime.Today;
                DateTime son = new DateTime(kayittarihi.Year, kayittarihi.Month, kayittarihi.Day);
                DateTime tarih = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);



                komut = new OleDbCommand("SELECT ilplaka FROM iller where iladi='" + iller_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                ilid = Convert.ToInt16(komut.ExecuteScalar());
                komut2 = new OleDbCommand("SELECT ilceid FROM ilceler where ilceadi='" + ilceler_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                ilceid = Convert.ToInt16(komut2.ExecuteScalar());
                komut3 = new OleDbCommand("SELECT ilplaka FROM iller where iladi='" + dogumyeri_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                dogumyeriid = Convert.ToInt16(komut3.ExecuteScalar());
                kankomut = new OleDbCommand("SELECT kangrubuid FROM kangrubu where kangrubuadi='" + kangrubu_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                kangrubuid = Convert.ToInt16(kankomut.ExecuteScalar());
                //   string sorgu = "Insert into hastalar (ad,soyad,adres,telefon,tckimlikno,dogumtarihi,cinsiyet,medenihali,meslek,vergino,kayittarihi,kangrubuid,kayıtilid,kayitilceid,dogumyeriid) values (' " + ad + "','" + soyad + "','" + adres + "','" + telefon + "','" + tckimlik + "','" + tarih + "','" + cinsiyet + "','" + medenihal + "','" + meslek + "','" +Convert.ToInt16 (vergino) + "','" +son + "','" +Convert.ToInt16( kangrubuid) + "','" + Convert.ToInt16(ilid) + "','" + Convert.ToInt16(ilceid) + "','" + Convert.ToInt16(dogumyeriid) + "')";

                komut5 = new OleDbCommand("select Count(tckimlikno) FROM hastalar where tckimlikno = '" + tckimlik + "'", baglanti);

                int sorgusayisi = Convert.ToInt16(komut5.ExecuteScalar());


              if (sorgusayisi >0)
              {
                  MessageBox.Show("Kayıt var");
              
              }
              else
              {
                  string sorgu = "Insert into hastalar(ad,soyad,adres,telefon,tckimlikno,dogumtarihi,cinsiyet,medenihali,meslek2,vergino,kayittarihi,kangrubuid,kayıtilid,kayitilceid,dogumyeriid) values(@ad,@soyad,@adres,@telefon,@tckimlikno,@dogumtarihi,@cinsiyet,@medenihali,@meslek2,@vergino,@kayittarihi,@kangrubuid,@kayıtilid,@kayitilceid,@dogumyeriid) ";
                  komut4 = new OleDbCommand(sorgu, baglanti);
                  komut4.Parameters.AddWithValue("@ad", ad);
                  komut4.Parameters.AddWithValue("@soyad", soyad);
                  komut4.Parameters.AddWithValue("@adres", adres);
                  komut4.Parameters.AddWithValue("@telefon", telefon);
                  komut4.Parameters.AddWithValue("@tckimlikno", tckimlik);
                  komut4.Parameters.AddWithValue("@dogumtarihi", tarih);
                  komut4.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                  komut4.Parameters.AddWithValue("@medenihali", medenihal);
                  komut4.Parameters.AddWithValue("@meslek2", meslek);
                  komut4.Parameters.AddWithValue("@vergino", vergino);
                  komut4.Parameters.AddWithValue("@kayittarihi", son);
                  komut4.Parameters.AddWithValue("@kangrubuid", kangrubuid);
                  komut4.Parameters.AddWithValue("@kayıtilid", ilid);
                  komut4.Parameters.AddWithValue("@kayitilceid", ilceid);
                  komut4.Parameters.AddWithValue("@dogumyeriid", dogumyeriid);



                  komut4.ExecuteNonQuery();
                  MessageBox.Show("Kayit Gerçekleşti");
              }
                       

         
                    
              

                baglanti.Close();

            }
           catch(Exception hata)
            {
               MessageBox.Show(hata.Message);
           }
       }

        private void cmBoxRandevTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            asd_Click(sender, e);
            panel2.Visible = true;
            secilenTarihBugunmu(); 
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            }

        private void doktor_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBoxRandevTarihi.Select();
            cmBoxRandevTarihi.Items.Clear();
            cmBoxRandevTarihi.Text = "";
            panel2.Visible = false;
            tarihDuzenleme();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void meslek_txt_Click(object sender, EventArgs e)
        {
            meslek_txt.Text = "";
            meslek_txt.MaxLength = 25;
        }

        private void vergi_txt_Click(object sender, EventArgs e)
        {
            vergi_txt.Text = "";
        }

        private void hastaekle_panel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            randevu_panel.Visible = false;
            hastaekle_panel.Visible = false;
            randevukontrolpanel.Visible = true;
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sorgutcno.Text.Length<11)
                {
                    MessageBox.Show("Doğru Bir TC Girin");

                }
                else
                {
                   dataGridView2.Rows.Clear();
                baglanti.Open();
                komut2 = new OleDbCommand("Select * from Randevular1 where Tc=@tcno order by Tarih Desc", baglanti);
                komut2.Parameters.AddWithValue("@tcno", sorgutcno.Text);


                OleDbDataReader randevukontrol = komut2.ExecuteReader();
                while (randevukontrol.Read())
                {
                    dataGridView2.Rows.Add(randevukontrol["Randevuid"].ToString(), randevukontrol["Tc"].ToString(), randevukontrol["Ad"].ToString(), randevukontrol["Soyad"].ToString(), randevukontrol["saat"].ToString(), randevukontrol["tarih"].ToString(),randevukontrol["doktoradi"].ToString());
                }
                baglanti.Close(); 
                }
                
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                randevusil_label.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }
        }

        private void randevusil_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("DELETE from Randevular1 WHERE Randevuid=@randevuid",baglanti);
            komut.Parameters.AddWithValue("@randevuid", Convert.ToInt16(randevusil_label.Text));
            komut.ExecuteNonQuery();
            
            baglanti.Close();
        }

        private void sorgutcno_Click(object sender, EventArgs e)
        {
            sorgutcno.Text = "";
        }

        private void sorgutcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }
        }
    }


