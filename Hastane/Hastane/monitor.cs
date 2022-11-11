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
    public partial class monitor : Form
    {
        public monitor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbCommand komut2;
        
        OleDbCommand polgetirkomut;
        private void monitor_Load(object sender, EventArgs e)
        {
          
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
            baglanti.Open();



         /* poliklinikkomut = new OleDbCommand("Select * from personeller where personelid="+girisekrani.kullaniciid+"",baglanti);
            int poldegeri = Convert.ToInt16(poliklinikkomut.ExecuteScalar());
            polgetirkomut = new OleDbCommand("select * from poliklinikler where poliklinikid="+poldegeri+"",baglanti);
            OleDbDataReader poloku = polgetirkomut.ExecuteReader();
            while (poloku.Read())
            {
                label2.Text = poloku["poliklinikadi"].ToString();
            }
*/
            int klinikdegeri=0;
            string sicildeger = "";
            komut = new OleDbCommand("SELECT * FROM Personel where personelid=" + girisekrani.kullaniciid + "", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktor_ismi.Text = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                klinikdegeri=Convert.ToInt16(dr["klinikid"]);
                sicildeger=dr["sicilno"].ToString();
            }
            polgetirkomut = new OleDbCommand("select * from poliklinikler where poliklinikid="+klinikdegeri+"",baglanti);
            OleDbDataReader poloku=polgetirkomut.ExecuteReader();
            while (poloku.Read())
            {
                label2.Text = poloku["poliklinikadi"].ToString();
            }
            pictureBox1.Image =Image.FromFile(".\\personelresim\\" + sicildeger + ".png"); 
            //pictureBox1.Image = Image.FromFile(".\\hastaresim\\" + sicildeger + ".png");
            DateTime kayittarihi = DateTime.Today;
            DateTime son = new DateTime(kayittarihi.Year, kayittarihi.Month, kayittarihi.Day);
            komut2 = new OleDbCommand("Select * from Randevular1 where DoktorAdi=@DoktorAdi and Tarih=@tarih  order by Randevuid Asc", baglanti);
            komut2.Parameters.AddWithValue("@DoktorAdi", doktor_ismi.Text);
            komut2.Parameters.AddWithValue("@tarih", son.ToShortDateString());
            OleDbDataReader ddr = komut2.ExecuteReader();
            while (ddr.Read())
            {
                dataGridView1.Rows.Add(ddr["Ad"].ToString(), ddr["Soyad"].ToString(), ddr["saat"].ToString(), son.ToString("dd MMMM yyyy"));
            }


            baglanti.Close();
            
            timer1.Start();
            timer2.Start();
            timer2.Interval = 1000;
            doktorekran ana = (doktorekran)Application.OpenForms["doktorekran"];
            siradaki.Text = ana.hastaisimsoyisim;
            
            

        }
      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }
        int sure = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (doktorekran.monitordurumu2 == true)
            {

                doktorekran.monitordurumu2 = false;
                this.Close();
            }
            sure++;
            if (sure%2==0)
            {
                siradaki.BackColor=Color.Red;
            }
            else
            {
                siradaki.BackColor = Color.White;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
