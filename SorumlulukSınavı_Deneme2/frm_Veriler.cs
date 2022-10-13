using SorumlulukSınavı_Deneme2;
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
    public partial class frm_Veriler : Form
    {
        public frm_Veriler()
        {
            InitializeComponent();
        }
        SQLKod SQl = new SQLKod();
        OleDbConnection  baglanti = new OleDbConnection ();
        OleDbCommand  komut = new OleDbCommand ();
        public string veri = "";
        public void TBL()
        {
            switch (veri)
            {
                case "B": dataGridView1.DataSource = SQl.TabloOlustur("select * from tbl_Brans where Durum="+ (checkBox1.Checked!=true) + " ORDER BY Branslar ASC ", SQl.baglanti()); comboBox1.Hide();  break;
                case "D": dataGridView1.DataSource = SQl.TabloOlustur("select * from tbl_Ders where Durum=" + (checkBox1.Checked != true) + " ORDER BY Dersler ASC", SQl.baglanti()); comboBox1.Hide(); break;
                case "O": dataGridView1.DataSource = SQl.TabloOlustur("select tbl_Ogretmen.id,İsim_Soyisim ,tbl_Brans.Branslar from tbl_Ogretmen inner join tbl_Brans on tbl_Ogretmen.Brans_id=tbl_Brans.id where tbl_Ogretmen.Durum="+ (checkBox1.Checked!=true) + " ORDER BY Branslar ASC", SQl.baglanti()); break;
                case "MY": dataGridView1.DataSource = SQl.TabloOlustur("select * from tbl_MudurY where tbl_MudurY.Durum=" + (checkBox1.Checked != true) + ";", SQl.baglanti()); comboBox1.Hide(); break;
                case "Do": dataGridView1.DataSource = SQl.TabloOlustur("select * from tbl_Donem ORDER BY Donemler ASC", SQl.baglanti()); comboBox1.Hide(); checkBox1.Hide(); btn_sil.Hide(); break;

            }
        }
        private void Veriler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            comboBox1.DataSource = SQl.TabloOlustur("select * from tbl_Brans where durum="+true+"", SQl.baglanti());
            comboBox1.DisplayMember = "Branslar";
            comboBox1.ValueMember = "id";

            baglanti = SQl.baglanti();

            TBL();

            this.dataGridView1.Columns["id"].Visible = false;
            if (veri == "B" || veri == "D" || veri == "MY")
            {
                this.dataGridView1.Columns["Durum"].Visible = false;    
            }

            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            switch (veri)
            {
                case "B":
                    {
                        
                        
                        komut = new OleDbCommand ("SELECT COUNT( * ) FROM tbl_Brans where Branslar ='" + textBox1.Text + "'", baglanti);

                        int b = Convert.ToInt32(komut.ExecuteScalar());
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        else if (b >= 1) { MessageBox.Show("Ekleyemezsiniz"); baglanti.Close(); break; }

                        string kayit = "insert into tbl_Brans(Branslar) values (@Branslar)";

                        komut = new OleDbCommand (kayit, baglanti);
                        komut.Parameters.AddWithValue("@Branslar", textBox1.Text);
                        break;
                    }
                case "D":
                    {
                        
                        komut = new OleDbCommand ("SELECT COUNT( * ) FROM tbl_Ders where Dersler ='" + textBox1.Text + "'", baglanti);

                        int b = Convert.ToInt32(komut.ExecuteScalar());
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        else if (b >= 1) { MessageBox.Show("Ekleyemezsiniz"); baglanti.Close(); break; }

                        string kayit = "insert into tbl_Ders(Dersler) values (@Dersler)";

                        komut = new OleDbCommand (kayit, baglanti);
                        komut.Parameters.AddWithValue("@Dersler", textBox1.Text);
                        break;
                    }
                case "O":
                    {
                        komut = new OleDbCommand ("SELECT COUNT( * ) FROM tbl_Ogretmen where İsim_Soyisim ='" + textBox1.Text + "'", baglanti);

                        int b = Convert.ToInt32(komut.ExecuteScalar());
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        else if (b >= 1) { MessageBox.Show("Ekleyemezsiniz"); baglanti.Close(); break; }

                        string kayit = "insert into tbl_Ogretmen(İsim_Soyisim,Brans_id) values (@İsim_Soyisim,@Brans_id)";

                        komut = new OleDbCommand (kayit, baglanti);
                        komut.Parameters.AddWithValue("@İsim_Soyisim", textBox1.Text);
                        komut.Parameters.AddWithValue("@Brans_id", SQl.Yazma(SQl.TabloOlustur("select * from tbl_Brans", baglanti), "Branslar", comboBox1.Text, "id"));
                        break;
                    }
                case "MY":
                    {
                        komut = new OleDbCommand("SELECT COUNT( * ) FROM tbl_MudurY where İsim_Soyisim ='" + textBox1.Text + "'", baglanti);

                        int b = Convert.ToInt32(komut.ExecuteScalar());
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        else if (b >= 1) { MessageBox.Show("Ekleyemezsiniz"); baglanti.Close(); break; }

                        string kayit = "insert into tbl_MudurY(İsim_Soyisim) values (@İsim_Soyisim)";

                        komut = new OleDbCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@İsim_Soyisim", textBox1.Text);
       
                        break;
                    }
                case "Do":
                    {
                        komut = new OleDbCommand ("SELECT COUNT( * ) FROM tbl_Donem where Donemler ='" + textBox1.Text + "'", baglanti);

                        int b = Convert.ToInt32(komut.ExecuteScalar());
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        else if (b >= 1) { MessageBox.Show("Ekleyemezsiniz"); baglanti.Close(); break; }

                        string kayit = "insert into tbl_Donem(Donemler) values (@Donemler)";

                        komut = new OleDbCommand (kayit, baglanti);
                        komut.Parameters.AddWithValue("@Donemler", textBox1.Text);
                        break;
                    }

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            TBL();
        }
        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "";
            switch (veri)
            {
                case "B":
                    {
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        kayit = "update tbl_Brans set Branslar='"+textBox1.Text+"' where id="+ dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() + "";
                        break;
                    }
                case "D":
                    {
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        kayit = "update tbl_Ders set Dersler='" + textBox1.Text + "' where id=" + dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() + "";
                        break;
                    }
                case "O":
                    {
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        kayit = "update tbl_Ogretmen set İsim_Soyisim='" + textBox1.Text + "', Brans_id="+ Convert.ToInt32(SQl.Yazma(SQl.TabloOlustur("select * from tbl_Brans", baglanti), "Branslar", comboBox1.Text, "id")) + " where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + "";
                        break;
                    }
                case "MY":
                    {
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        kayit = "update tbl_MudurY set İsim_Soyisim='" + textBox1.Text + "' where id=" + dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() + "";
                        break;
                    }
                case "Do":
                    {
                        if (textBox1.Text == "") { MessageBox.Show("Boşlukları Doldurun"); baglanti.Close(); break; }
                        kayit = "update tbl_Donem set Donemler='" + textBox1.Text + "' where id=" + dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() + "";
                        break;
                    }

            }
            komut = new OleDbCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            TBL();
        }
        private void btn_Ekle_GeriGetir(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "";
            switch (veri)
            {

                case "B":
                    {
                        kayit = "update tbl_Brans set tbl_Brans.Durum=" + true + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "D":
                    {
                        kayit = "update tbl_Ders set tbl_Ders.Durum=" + true + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "O":
                    {
                        kayit = "update tbl_Ogretmen set tbl_Ogretmen.Durum=" + true + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "MY":
                    {
                        kayit = "update tbl_MudurY set tbl_MudurY.Durum=" + true + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
            }
            komut = new OleDbCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            TBL();


        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "";
            switch (veri)
            {

                case "B":
                    {
                        kayit = "update tbl_Brans set tbl_Brans.Durum=" + false + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "D":
                    {
                        kayit = "update tbl_Ders set tbl_Ders.Durum=" + false + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "O":
                    {
                        kayit = "update tbl_Ogretmen set tbl_Ogretmen.Durum=" + false + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
                case "MY":
                    {
                        kayit = "update tbl_MudurY set tbl_MudurY.Durum=" + false + "  where id=" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value) + ";";
                        break;
                    }
            }
            komut = new OleDbCommand(kayit, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            TBL();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TBL();
            if (checkBox1.Checked == true)
            {
                textBox1.Hide();
                comboBox1.Hide();
                btn_sil.Hide();
                btn_Degistir.Hide();
                btn_Ekle.Left -= 280;
                btn_Ekle.Text = "Silinenlerden Kaldır";
                btn_Ekle.Width = 200;
                btn_Ekle.Click -= btn_Ekle_Click;
                btn_Ekle.Click += btn_Ekle_GeriGetir;
                btn_Ekle.TextAlign = ContentAlignment.MiddleCenter;
                btn_Ekle.BackgroundImage = null;

            }
            else
            {
                textBox1.Show();
                if (veri == "O") { comboBox1.Show(); }
                btn_sil.Show();
                btn_Degistir.Show();
                btn_Ekle.Left += 280;
                btn_Ekle.Text = "Ekle";
                btn_Ekle.Width = 75;
                btn_Ekle.Click += btn_Ekle_Click;
                btn_Ekle.Click -= btn_Ekle_GeriGetir;
                btn_Ekle.TextAlign = ContentAlignment.TopLeft;
                btn_Ekle.BackgroundImage = Image.FromFile("Resimler/Arti.png");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();



            }
            catch (Exception) { }

        }
    }
}



























//3399485