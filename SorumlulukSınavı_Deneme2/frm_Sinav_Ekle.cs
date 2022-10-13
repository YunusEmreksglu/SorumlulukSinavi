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
    public partial class frm_Sinav_Ekle : Form
    {
        public frm_Sinav_Ekle()
        {
            InitializeComponent();
        }

        SQLKod SQl = new SQLKod();
        OleDbConnection  baglanti = new OleDbConnection ();
        OleDbCommand  komut;
        OleDbDataReader  oku;
        public string donemid = "";

        public void Dgw()
        {
            dataGridView1.DataSource = SQl.TabloOlustur("select tbl_Sinav.id, tbl_Ders.Dersler, tbl_MudurY.İsim_Soyisim ,tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Donem.Donemler, tbl_Sinav.OgrenciSayisi " +
                                                        "from ((tbl_Sinav " +
                                                        "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id)" +
                                                        "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id) " +
                                                        "INNER JOIN tbl_MudurY on tbl_Sinav.MudurY_id = tbl_MudurY.id "+
                                                        "where tbl_Sinav.Dönem_id=" + donemid + "", 
                                                        SQl.baglanti());

        }



        private void Sinav_Ekle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baglanti = SQl.baglanti();


            comboBox1.DataSource = SQl.TabloOlustur("select * from tbl_Ders where durum="+true+"", SQl.baglanti());
            comboBox1.DisplayMember = "Dersler";
            comboBox1.ValueMember = "id";

            comboBox4.DataSource = SQl.TabloOlustur("select * from tbl_MudurY where Durum="+true+"", SQl.baglanti());
            comboBox4.DisplayMember = "İsim_Soyisim";
            comboBox4.ValueMember = "id";

            textBox1.Text = donemid;


            baglanti.Open();


          
             komut = new OleDbCommand ("select * from tbl_Donem where Donemler='" + donemid + "'", baglanti);
             oku = komut.ExecuteReader();
             oku.Read();
             donemid = oku[0].ToString();
             oku.Close();
             baglanti.Close();



             Dgw();
            this.dataGridView1.Columns["id"].Visible = false;



            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            int a = Convert.ToInt16(SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "Dersler", comboBox1.Text, "id"));
            komut = new OleDbCommand ("SELECT COUNT( * ) FROM tbl_Sinav where Ders_id=" + a + " and Saat= '"+ comboBox2.Text + "' and Tarih=#"+ dateTimePicker1.Value.ToString().Split(' ')[0].Replace('.','/')+ "# and SinavTip='"+comboBox3.Text+"'", baglanti);
            int b = Convert.ToInt32(komut.ExecuteScalar());
            komut = new OleDbCommand("SELECT COUNT( * ) FROM tbl_Sinav where Ders_id="+ a +" and  Dönem_id="+ donemid+"", baglanti);
            int k = Convert.ToInt32(komut.ExecuteScalar());
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Boşlukları Doldurun");
                
            }
            

            

            else if (k >= 1) { MessageBox.Show("Bir Dönemde sadece bir sınav olabilir", "Ekleyemezsiniz"); }
            else
            {

                string kayit = "insert into tbl_Sinav(Ders_id,Saat,Tarih,SinavTip,Dönem_id,OgrenciSayisi,MudurY_id) values (@Ders_id,@Saat,@Tarih,@SinavTip,@Dönem_id,@OgrenciSayisi,@MudurY_id)";

                komut = new OleDbCommand (kayit, baglanti);

                komut.Parameters.AddWithValue("@Ders_id", SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "Dersler", comboBox1.Text, "id"));

                komut.Parameters.AddWithValue("@Saat", comboBox2.Text);

                komut.Parameters.AddWithValue("@Tarih", (dateTimePicker1.Value.ToString()).Split(' ')[0]);

                komut.Parameters.AddWithValue("@SinavTip", comboBox3.Text);

                komut.Parameters.AddWithValue("@Dönem_id", SQl.Yazma(SQl.TabloOlustur("select * from tbl_Donem", baglanti), "Donemler", textBox1.Text, "id"));

                komut.Parameters.AddWithValue("@OgrenciSayisi", textBox2.Text);

                komut.Parameters.AddWithValue("@MudurY_id", comboBox4.SelectedValue.ToString());

                komut.ExecuteNonQuery();

                baglanti.Close();

                Dgw();
                MessageBox.Show("Sinav Başarılı Bir Şekilde Eklendi");

            }
            
      
        }

        private void button2_Click(object sender, EventArgs e)
        {

            komut = new OleDbCommand ("select count(Sinav_id)from tbl_Sonuc where Sinav_id="+dataGridView1.SelectedRows[0].Cells[0].Value+"", baglanti);
            baglanti.Open();
            int g = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            if (g==0)
            {
                komut = new OleDbCommand ("DELETE FROM tbl_Sinav WHERE id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Dgw();
            }
            else if (g > 0)
            {
                DialogResult dr = MessageBox.Show("Eklediğiniz Öğretmenlerde Silinecek", "Uyarı..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    komut = new OleDbCommand("DELETE FROM tbl_Sonuc WHERE Sinav_id=@Sinav_id", baglanti);
                    komut.Parameters.AddWithValue("@Sinav_id", dataGridView1.SelectedRows[0].Cells[0].Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();


                    komut = new OleDbCommand("DELETE FROM tbl_Sinav WHERE id=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Dgw();

                }
                if (dr == DialogResult.No)
                {

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boşlukları Doldurun");

            }
            else
            {

                string kayit = "update tbl_Sinav set Saat=@Saat,Tarih=@Tarih,SinavTip=@SinavTip,Dönem_id=@Dönem_id,OgrenciSayisi=@OgrenciSayisi,MudurY_id=@MudurY_id where id="+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString() +"";

                komut = new OleDbCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@Saat", comboBox2.Text);

                komut.Parameters.AddWithValue("@Tarih", (dateTimePicker1.Value.ToString()).Split(' ')[0]);

                komut.Parameters.AddWithValue("@SinavTip", comboBox3.Text);

                komut.Parameters.AddWithValue("@Dönem_id", SQl.Yazma(SQl.TabloOlustur("select * from tbl_Donem", baglanti), "Donemler", textBox1.Text, "id"));

                komut.Parameters.AddWithValue("@OgrenciSayisi", textBox2.Text);

                komut.Parameters.AddWithValue("@MudurY_id", comboBox4.SelectedValue.ToString());

                komut.ExecuteNonQuery();

                baglanti.Close();

                Dgw();
                MessageBox.Show("Sinav Başarılı Bir Şekilde Güncellendi");

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { 
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            }

            else
            {
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            }        
        }
    }
}
