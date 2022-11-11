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
    public partial class adminpanel : Form
    {
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbCommand komut2;
        OleDbCommand komut3;
        OleDbCommand komut4;
        OleDbCommand komut5;
        OleDbCommand komut6;
        public adminpanel()
        {
            InitializeComponent();
        }
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            kamerapicturebox.Image = bmp;


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            girisekrani grs = new girisekrani();
            grs.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 38)
            {
                panel1.Visible = false;
                bunifuImageButton1.Location = new Point(152, 6);
                panel1.Width = 189;
                PanelAnimator.ShowSync(panel1);
                LogoAnimator.ShowSync(bunifuImageButton1);
                
            }
            else
            {
                
                panel1.Visible = false;
                panel1.Width = 38;
                bunifuImageButton1.Location = new Point(5, 10);
                PanelAnimator.ShowSync(panel1);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kamerabtn_Click(object sender, EventArgs e)
        {
            if (sicilno_txt.TextLength < 7)
            {
                MessageBox.Show("Sicil Numaranızı doğru girin");
            }
            else
            {
                string sicilno = "";
                sicilno = sicilno_txt.Text;
                kamerapicturebox.Image.Save(".\\personelresim\\" + sicilno + ".png");
            }
        }

        private void kamera2btn_Click(object sender, EventArgs e)
        {
            kamerapicturebox.Visible = true;
            kamerabtn.Visible = true;
            label44.Visible = true;
            cam = new VideoCaptureDevice(webcam[kamera_cmb.SelectedIndex].MonikerString);

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in webcam)
            {

                kamera_cmb.Items.Add(item.Name);

            }
            kamera_cmb.SelectedIndex = 0;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
            baglanti.Open();
            komut2 = new OleDbCommand("SELECT * FROM Poliklinikler order by poliklinikid asc", baglanti);
            OleDbDataReader ddr = komut2.ExecuteReader();
            while (ddr.Read())
            {
                pol_cmb.Items.Add(ddr["poliklinikadi"].ToString());
            }
            komut = new OleDbCommand("select * from unvanlar order by unvanid asc",baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                unvan_cmb.Items.Add(dr["unvanadi"].ToString());
            }
            komut3 =new OleDbCommand("Select * from iller order by ilplaka asc",baglanti);
            OleDbDataReader iloku = komut3.ExecuteReader();
            while (iloku.Read())
            {
                dogumyeri_cmb.Items.Add(iloku["iladi"].ToString());
            }

            baglanti.Close();
            
        }

        private void kamera3btn_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {

                cam.Stop();
                kamerabtn.Visible = false;
                label44.Visible = false;
                kamerapicturebox.Visible = false;

            }
        }

        private void personeleklebtn_Click(object sender, EventArgs e)
        {

            
                string ad = "", soyad = "", adres1 = "", sicilno = "", email = "";
                int dogumyeriid = 0, poliklinikid = 0, unvanid = 0;

                sicilno = sicilno_txt.Text;
                ad = personeladi.Text;
                soyad = personelsoyadi.Text;
                adres1 = adres.Text;
                email = mail.Text;

                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");

                baglanti.Open();


                string telefon1 = "";
                telefon1 = telefon.Text;

                DateTime kayittarihi = DateTime.Today;
                DateTime son = new DateTime(kayittarihi.Year, kayittarihi.Month, kayittarihi.Day);
                DateTime tarih = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
                komut = new OleDbCommand("SELECT unvanid FROM unvanlar where unvanadi='" + unvan_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                unvanid = Convert.ToInt16(komut.ExecuteScalar());
                komut2 = new OleDbCommand("SELECT poliklinikid FROM poliklinikler where poliklinikadi='" + pol_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                poliklinikid = Convert.ToInt16(komut2.ExecuteScalar());
                komut3 = new OleDbCommand("SELECT ilplaka FROM iller where iladi='" + dogumyeri_cmb.SelectedItem.ToString().Trim() + "'", baglanti);
                dogumyeriid = Convert.ToInt16(komut3.ExecuteScalar());



                komut5 = new OleDbCommand("select Count (personelid) FROM personel ", baglanti);
                int iddegeri = Convert.ToInt16(komut5.ExecuteScalar()) + 1;
                komut5 = new OleDbCommand("select Count(sicilno) FROM personel where sicilno = '" + sicilno + "'", baglanti);

                int sorgusayisi = Convert.ToInt16(komut5.ExecuteScalar());


                if (sorgusayisi > 0)
                {
                    MessageBox.Show("Kayıt var");

                }

                else
                {
                    string sorgu = "Insert into personel(personelid,sicilno,ad,soyad,adres,telefon,email,dogumtarihi,dogumyeri,unvanid,klinikid) values(@personelid,@sicilno,@ad,@soyad,@adres,@telefon,@email,@dogumtarihi,@dogumyeri,@unvanid,@klinikid) ";
                    komut4 = new OleDbCommand(sorgu, baglanti);

                    komut4.Parameters.AddWithValue("@personelid", iddegeri);
                    komut4.Parameters.AddWithValue("@sicilno", sicilno);
                    komut4.Parameters.AddWithValue("@ad", ad);
                    komut4.Parameters.AddWithValue("@soyad", soyad);
                    komut4.Parameters.AddWithValue("@adres", adres1);
                    komut4.Parameters.AddWithValue("@telefon", telefon1);
                    komut4.Parameters.AddWithValue("@email", email);
                    komut4.Parameters.AddWithValue("@dogumtarihi", tarih);
                    komut4.Parameters.AddWithValue("@dogumyeri", dogumyeri_cmb.SelectedItem);
                    komut4.Parameters.AddWithValue("@unvanid", unvanid);
                    komut4.Parameters.AddWithValue("@klinikid", poliklinikid);
                    komut4.ExecuteNonQuery();
                    
                   
                    
                    string ksorgu = "Insert into kullanicilar(kullaniciid,kullaniciadi,sifre,personelid)values(@kullaniciid,@kullaniciadi,@sifre,@personelid)";
                komut6 = new OleDbCommand(ksorgu,baglanti);
                komut6.Parameters.AddWithValue("@kullaniciid", iddegeri);
                komut6.Parameters.AddWithValue("@kullaniciadi", kullaniciadi.Text);
                komut6.Parameters.AddWithValue("@sifre",sifre.Text);
                komut6.Parameters.AddWithValue("@personelid", unvanid);
                komut6.ExecuteNonQuery(); 
                    MessageBox.Show("Kayit Gerçekleşti");

                }
                
                    



                baglanti.Close();
            
                
        }
    }
}
