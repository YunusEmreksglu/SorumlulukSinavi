using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SorumlulukSınavı_Deneme2;

namespace SorumlulukSınavı_Deneme2
{
    public partial class frm_Donem : Form
    {
        public frm_Donem()
        {
            InitializeComponent();
        }

        private void frm_Donem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SorumlulukSınavıDataSet.tbl_Donem' table. You can move, or remove it, as needed.
            //this.tbl_DonemTableAdapter.Fill(this.dB_SorumlulukSınavıDataSet.tbl_Donem);
            SQLKod SQl = new SQLKod();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            comboBox1.DataSource = SQl.TabloOlustur("select * from tbl_Donem", SQl.baglanti());
            comboBox1.DisplayMember = "Donemler";
            comboBox1.ValueMember = "id";
            
        }
       
        public string Devam = "";
        string K = "-";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Devam=="Sınav")
            {
                panel1.Controls.Clear(); 
                frm_Sinav_Ekle fr = new frm_Sinav_Ekle();
                fr.TopLevel = false;
                fr.donemid = comboBox1.Text;
                panel1.Controls.Add(fr); 
                fr.Show(); 
                fr.Dock = DockStyle.Fill; 
                fr.BringToFront();
            }
            else if (Devam=="Sonuc")
            {
                panel1.Controls.Clear(); 
                frm_Sinav fr = new frm_Sinav();
                fr.TopLevel = false;
                fr.donemid = comboBox1.Text;
                panel1.Controls.Add(fr); 
                fr.Show(); 
                fr.Dock = DockStyle.Fill; 
                fr.BringToFront();
                K = "+";
                button1.Enabled = false;
                button2.Enabled = false;
                comboBox1.Enabled = false;
                linkLabel1.Enabled = false;
            }

        }
        public string Donem = "-";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Donem = "+";
            this.Close();


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel1.Controls.Count == 0 && K == "+" && Deyisken.SinavGB == "Çıkış")
            {
                this.Close();
            }
            if (panel1.Controls.Count == 0 && K == "+" && Deyisken.SinavGB == "Geri")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                comboBox1.Enabled = true;
                linkLabel1.Enabled = true;
            }
            if (panel1.Controls.Count == 0 && K == "+" && Deyisken.SinavGB == "Sinav Ekle")
            {
                Devam = "Sınav";
                panel1.Controls.Clear();
                frm_Sinav_Ekle fr = new frm_Sinav_Ekle();
                fr.TopLevel = false;
                fr.donemid = comboBox1.Text;
                panel1.Controls.Add(fr);
                fr.Show();
                fr.Dock = DockStyle.Fill;
                fr.BringToFront();
                button1.Enabled = true;
                button2.Enabled = true;
                comboBox1.Enabled = true;
                linkLabel1.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
