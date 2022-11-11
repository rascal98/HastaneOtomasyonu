using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hastane
{
    public partial class doktorekran : Form
    {
        public doktorekran()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbConnection baglanti;

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        OleDbCommand komut2;
        private void doktorekran_Load(object sender, EventArgs e)
        {  
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
            baglanti.Open();
            
            try
            {
                ilac_cmb.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("Select * From ilac", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ilac_cmb.Items.Add(rd["ilacadi"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            try
            {
                icd_cmb.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("Select * From hastaliklar", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    icd_cmb.Items.Add(rd["ICD"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            

            komut = new OleDbCommand("SELECT * FROM Personel where personelid=" + girisekrani.kullaniciid + "", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktor_ismi.Text = dr["ad"].ToString() + " " + dr["soyad"].ToString();
            }
            DateTime kayittarihi = DateTime.Today;
            DateTime son = new DateTime(kayittarihi.Year, kayittarihi.Month, kayittarihi.Day);
            komut2 = new OleDbCommand("Select * from Randevular1 where DoktorAdi=@DoktorAdi and Tarih=@tarih  order by Randevuid Asc", baglanti);
            komut2.Parameters.AddWithValue("@DoktorAdi", doktor_ismi.Text);
            komut2.Parameters.AddWithValue("@tarih",son.ToShortDateString());
            OleDbDataReader ddr = komut2.ExecuteReader();
            while (ddr.Read())
            {
                dataGridView1.Rows.Add(ddr["Tc"].ToString(), ddr["Ad"].ToString(), ddr["Soyad"].ToString(), ddr["saat"].ToString(), son.ToString("dd MMMM yyyy"));
            }
            
            
            baglanti.Close();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            girisekrani grs = new girisekrani();
            grs.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        string hstlkid = "";//ilid
        string taniid = "";//ilceid
        void tanilariGoster()
        {
            baglanti.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("Select * From tanilar where hstlkid=@id", baglanti);
                cmd.Parameters.AddWithValue("@id", hstlkid);

                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tani_cmb.Items.Add(rd["tani"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();

        }
        /*void hastaliklariGoster()//illeriGoster()
        {
            baglanti.Open();
            try
            {
                icd_cmb.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("Select * From hastaliklar", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    icd_cmb.Items.Add(rd["ICD"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
        }*/
        void hastalikidsiniBul()//ilidsinibul
        {
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From hastaliklar where ICD='" + icd_cmb.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hstlkid = dr["ICD"].ToString();
                }
                baglanti.Close();
                tanilariGoster();//ilceleriGoster();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
        }

        void taniidsiniBul()//ilceidsinibul
        {
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From tanilar where tani='" + tani_cmb.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    taniid = dr["id"].ToString();
                }
                baglanti.Close();
                //hastaneleriGoster();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
        }




       /* void ilacGoster()
        {
            baglanti.Open();
            try
            {
                ilac_cmb.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("Select * From ilaclar", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ilac_cmb.Items.Add(rd["ilacadi"].ToString());
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            baglanti.Close();
        }*/
        public string hastaisimsoyisim="";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox2.Image = null;
            try
            {
                hastaisimsoyisim = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
                hastatc_txt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                hastaadi_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                hastasoyadi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                randevusaat_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                randevutarih_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
                string resimtcdegeri = dataGridView1.SelectedCells[0].Value.ToString();
                pictureBox2.Image = Image.FromFile(".\\hastaresim\\" + resimtcdegeri + ".png");
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Hastanın Resmi Yok!!");
                
            }
           
        }

        private void printpreview_btn_Click(object sender, EventArgs e)
        {             
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        string tcno;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap bmp = Properties.Resources.saglik;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 300, 25, newImage.Width, newImage.Height);
                e.Graphics.DrawString("Doktor Adı: " + doktor_ismi.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));
                e.Graphics.DrawString("Tarih:    " + DateTime.Now, new Font("Century Gothic", 12), Brushes.Black, new Point(550, 460));
                e.Graphics.DrawString(DashLabel.Text, new Font("Century Gothic", 12), Brushes.Black, new Point(25, 520));
                e.Graphics.DrawString("Hasta Adı: " + hastaadi_txt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 540));
                e.Graphics.DrawString("Hasta Soyadı: " + hastasoyadi_txt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 560));
                e.Graphics.DrawString("Hasta Tc: " + hastatc_txt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 580));
                e.Graphics.DrawString("Randevu Tarih: " + randevutarih_txt.Text + "                      Randevu Saat:  " + randevusaat_txt.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 600));
                e.Graphics.DrawString(DashLabel.Text, new Font("Century Gothic", 12), Brushes.Black, new Point(25, 620));
                e.Graphics.DrawString("HASTALIK TANIMI ", new Font("Century Gothic", 13, FontStyle.Regular), Brushes.Black, new Point(25, 640));
                e.Graphics.DrawString("Hastalık Adı: " + icd_cmb.SelectedItem.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 660));
                e.Graphics.DrawString("Tanı: " + tani_cmb.SelectedItem.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 680));
                e.Graphics.DrawString("İlaç: " + ilac_cmb.SelectedItem.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 700));
                e.Graphics.DrawString("Açıklama: " + aciklama_rich.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(25, 720));
                tcno = hastatc_txt.Text;
                Image i = Image.FromFile(".\\hastaresim\\" + tcno + ".png");
                Point p = new Point(100, 100);
                e.Graphics.DrawImage(i, 25, 350, 100, 100);
            
            }
            catch (Exception )
            {

                MessageBox.Show("Boş alanları doldur");
            }
            
                
           
                
           
           
            
        }

        private void icd_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tani_cmb.Items.Clear();
           
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From hastaliklar where ICD='" + icd_cmb.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hstlkid = dr["ICD"].ToString();
                }
                baglanti.Close();
                tanilariGoster();//ilceleriGoster();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From tanilar where tani='" + tani_cmb.Text + "'", baglanti);
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    taniid = dr["id"].ToString();
                }
                baglanti.Close();
                //hastaneleriGoster();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                baglanti.Close();
            }
            
        }
      
        public static bool monitordurumu = false;
        public static bool monitordurumu2 = false;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
        
            monitor mr = new monitor();
           
            
            
            if (monitordurumu==false)
            {
             
                mr.Show();

                monitordurumu=true;
            }
            else   if (monitordurumu == true)
            {
                monitordurumu2 = true;
              
                monitordurumu = false;
            }
          
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        
      
    }
}
