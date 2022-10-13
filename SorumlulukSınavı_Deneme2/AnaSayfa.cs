using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorumlulukSınavı_Deneme2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        public void Kontrol()
        {
            //if (File.Exists("DT_SorumlulukS.mdb"))
            //{
            //    label4.Text = "✓";
            //    label4.ForeColor = Color.Green;
            //    foreach (Control item in this.Controls)
            //    {
            //        item.Enabled = true;
            //    }

            //}
            //else
            //{
            //    label4.Text = "X";
            //    label4.ForeColor = Color.Red;
            //    foreach (Control item in this.Controls)
            //    {
            //        item.Enabled = true;
            //    }
            //    linkLabel1.Enabled = true;
            //    label4.Enabled = false;
            //}
            //label4.Enabled = false;
        }

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            frm_Veriler fr = new frm_Veriler();
            fr.veri = ((Button)sender).Tag.ToString();
            fr.ShowDialog();
        }

        public void donemSo()
        {
            frm_Donem fr = new frm_Donem();
            fr.Devam = "Sonuc";
            fr.ShowDialog();
            if (fr.Donem == "+")
            {
                frm_Veriler fr2 = new frm_Veriler();
                fr2.veri = "Do";
                fr2.ShowDialog();
                donemSo();
            }
        }
        public void donemSi()
        {
            frm_Donem fr = new frm_Donem();
            fr.Devam = "Sınav";
            fr.ShowDialog();
            if (fr.Donem == "+")
            {
                frm_Veriler fr2 = new frm_Veriler();
                fr2.veri = "Do";
                fr2.ShowDialog();
                donemSi();
            }
        }
        private void btn_basla_Click(object sender, EventArgs e)
        {
            donemSo();
        }

        private void btn_Sinav_Click(object sender, EventArgs e)
        {
            donemSi();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.label5, "Müdür değiştirmek için tıklayın");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Kontrol();
            SQLKod sql = new SQLKod();
            var results = from myRow in sql.TabloOlustur("select * from tbl_Mudur", sql.baglanti()).AsEnumerable()
                          select myRow;
            foreach (var item in results)
            {
                label5.Text="Müdür: " + item[1].ToString();
            }

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:\\";
            file.Filter = "Access Dosyası |*.mdb";
            file.ShowDialog();
            string DosyaYolu = file.FileName;
            string DosyaAdi = file.SafeFileName;
            string VrYk = "-";
            foreach (string item in DosyaYolu.Split('\\'))
            {
                if (item == "Eski Veri Tabanları")
                {
                    VrYk = "+";
                }
                else { }
            }
            if (VrYk=="+")
	        {
                DialogResult dr = MessageBox.Show("Değiştirmek İstermisiniz", "Uyarı..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    File.Copy("DT_SorumlulukS.mdb", "Eski Veri Tabanları\\" + "Y" + DateTime.Now.Year.ToString() + " A" + DateTime.Now.Month.ToString() + " G" + DateTime.Now.Day.ToString() + " S" + DateTime.Now.Hour.ToString() + " D" + DateTime.Now.Minute.ToString() + " Sa" + DateTime.Now.Second.ToString() + " _" + "DT_SorumlulukS.mdb");
                    File.Delete("DT_SorumlulukS.mdb");
                    File.Copy(DosyaYolu, "DT_SorumlulukS.mdb");
                }
                if (dr == DialogResult.No)
                {

                }

		 
	        }
            else if (File.Exists(DosyaAdi))
            {
                DialogResult dr = MessageBox.Show("Değiştirmek İstermisiniz", "Uyarı..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr==DialogResult.Yes)
                {

                    File.Copy("DT_SorumlulukS.mdb", "Eski Veri Tabanları\\" + "Y"+DateTime.Now.Year.ToString() + " A" + DateTime.Now.Month.ToString() + " G" +DateTime.Now.Day.ToString()+" S"+ DateTime.Now.Hour.ToString()+" D"+ DateTime.Now.Minute.ToString()+" Sa"+ DateTime.Now.Second.ToString()+ " _" + DosyaAdi);
                    File.Delete("DT_SorumlulukS.mdb");
                    File.Copy(DosyaYolu, DosyaAdi);
                   

                }
                if (dr == DialogResult.No)
                {
                    
                }
                
            }
            else
            {
                try
                {
                    File.Copy(DosyaYolu, DosyaAdi);
                }
                catch (Exception) { }
                
            }
            Kontrol();
        }

        private void btn_SSG_Click(object sender, EventArgs e)
        {
            frm_SorumlulukPDFCıktı fr = new frm_SorumlulukPDFCıktı();
            fr.ShowDialog();
        }

        private void AnaSayfa_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SQLKod sql = new SQLKod();
            frm_Mudur fr = new frm_Mudur();
            fr.ShowDialog(); // Bu yöntem için ShowDialog() mutlak gerekliliktir.

            string kapama = fr.kapama;

            if (kapama == "+")
            {
                var results = from myRow in sql.TabloOlustur("select * from tbl_Mudur", sql.baglanti()).AsEnumerable()
                              select myRow;
                foreach (var item in results)
                {
                    label5.Text = "Müdür: " + item[1].ToString();

                }
            }
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
