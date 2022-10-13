using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorumlulukSınavı_Deneme2
{
    public partial class frm_Mudur : Form
    {
        public frm_Mudur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string kapama = "-";
        SQLKod SQl = new SQLKod();
        private void frm_Mudur_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            var results = from myRow in SQl.TabloOlustur("select * from tbl_Mudur", SQl.baglanti()).AsEnumerable()
                          select myRow;
            foreach (var item in results)
            {
                textBox1.Text =  item[1].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OleDbConnection baglanti = SQl.baglanti();
            OleDbCommand komut = new OleDbCommand();
            baglanti.Open();
            komut = new OleDbCommand("update tbl_Mudur set Mudur ='" + textBox1.Text + "' where id=1", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            kapama = "+";
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
