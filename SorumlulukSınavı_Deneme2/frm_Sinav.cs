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


namespace SorumlulukSınavı_Deneme2
{
    public partial class frm_Sinav : Form
    {
        public frm_Sinav()
        {
            InitializeComponent();
        }

        SQLKod SQL = new SQLKod();
        OleDbConnection  baglanti = new OleDbConnection ();
        OleDbCommand  komut1;
        OleDbCommand  komut2;
        OleDbDataReader  oku;


        string cbox = "";
        public string donemid = "";
        string donemisim = "";

        public static string boslukK(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        } 

        public void CB()
        {
            comboBox1.Items.Clear();
            DataTable tbl = new DataTable();
            tbl = SQL.TabloOlustur("select tbl_Sinav.Gecerlilik,tbl_Sinav.id, tbl_Ders.Dersler, tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Sinav.OgrenciSayisi " +
                                                        "from (tbl_Sinav " +
                                                        "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id )" +
                                                        "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                                                        "where tbl_Sinav.Dönem_id=" + donemid + " order by tbl_Sinav.Tarih,tbl_Sinav.Saat",
                                                        baglanti);
            //comboBox1.ValueMember = "id";
            //comboBox1.DataSource=SQL.TabloOlustur("select * from tbl_Sinav", SQL.baglanti());
            var results = from myRow in tbl.AsEnumerable()
                          select myRow;
            foreach (var item in results)
            {

                    if (Convert.ToBoolean(item[0].ToString()) == true)
                    {
                        cbox += "✓ ";
                    }
                    else
                    {
                        cbox += "x ";
                    }
                cbox += item[1] +" "+ Convert.ToDateTime(item[4]).ToString("dd/MM/yyy") +" "+ item[3] +" "+ item[2] +" "+ item[5] +" "+ item[6] ;
                    comboBox1.Items.Add(cbox);
                    cbox = "";
            }

        }

        private void frm_Sinav_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SorumlulukSınavıDataSet.tbl_Sinav' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dB_SorumlulukSınavıDataSet.tbl_Ders' table. You can move, or remove it, as needed.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baglanti = SQL.baglanti();
            baglanti.Open();

            donemisim = donemid;

            komut2 = new OleDbCommand ("select * from tbl_Donem where Donemler='" + donemid + "'", baglanti);
            oku = komut2.ExecuteReader();
            oku.Read();
            donemid = oku[0].ToString();
            oku.Close();

            CB();

            baglanti.Close();

        }
        string K = "-";
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {
                panel1.Controls.Clear(); // Panel'in içini temizliyoruz..
                frm_Sonuc fr = new frm_Sonuc();
                fr.TopLevel = false;
                panel1.Controls.Add(fr);
                fr.donem = donemisim;
                fr.veriler = comboBox1.Text;
                fr.Show();
                fr.Dock = DockStyle.Fill;
                fr.BringToFront();
                K = "+";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                comboBox1.Enabled = false;
                linkLabel1.Enabled = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Deyisken.SinavGB = "Sinav Ekle";
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel1.Controls.Count==0 && K=="+" && Deyisken.SonucGB=="Çıkış")
            {
                Deyisken.SinavGB = "Çıkış";
                this.Close();
            }
            if (panel1.Controls.Count == 0 && K == "+" && Deyisken.SonucGB == "Geri")
            {
                CB();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                comboBox1.Enabled = true;
                linkLabel1.Enabled = true;
                Deyisken.SonucGB = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panel1.Controls.Count.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Deyisken.SinavGB = "Geri";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Deyisken.SinavGB = "Çıkış";
        }
    }
}
