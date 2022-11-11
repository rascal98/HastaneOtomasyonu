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
    public partial class girisekrani : Form
    {
        public void cikisbtn()
        {
            Application.Exit();
        }
        public girisekrani()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hastane.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader dr ;
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            cikisbtn();
        }

       

        private void kullanici_txt_Click(object sender, EventArgs e)
        {
            kullanici_txt.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            kullanici_txt.Text = "";
        }

        private void girisekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void sifre_txt_Click(object sender, EventArgs e)
        {
            sifre_txt.Text = "";
            sifre_txt.PasswordChar = '*';
        }
        public static string kullaniciid;
        #region Kullanıcı Adı Şifre

        private void kullaniciadisifre()
        {
            string ad = kullanici_txt.Text;
            string sifre = sifre_txt.Text;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=hastane.accdb");
            komut = new OleDbCommand("select * from kullanicilar where kullaniciadi='" + kullanici_txt.Text.ToString() + "' AND sifre='" + sifre_txt.Text.ToString() + "'", baglanti);
            baglanti.Open();
            komut.Connection = baglanti;


            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kullaniciid = dr["kullaniciid"].ToString();
                string personeldeger = dr["personelid"].ToString();
                if (personeldeger == "1")
                {
                    Personelekran f2 = new Personelekran();
                    f2.Show();
                }
                if (personeldeger == "2")
                {
                    doktorekran de = new doktorekran();
                    de.Show();

                }
                if (personeldeger == "3")
                {
                    adminpanel ap = new adminpanel();
                    ap.Show();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }


            baglanti.Close();
            this.Hide();

        }
        #endregion
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            kullaniciadisifre();
        }

        private void sifre_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                kullaniciadisifre();
            }
        }

        private void kullanici_txt_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void girisekrani_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void kullanici_txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                sifre_txt.Text = "";
                sifre_txt.PasswordChar = '*';
               
            }
        }

        

     
       

        

      

       
    }
}
