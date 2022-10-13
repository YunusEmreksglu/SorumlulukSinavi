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
using System.Collections;


namespace SorumlulukSınavı_Deneme2
{
    public partial class frm_Sonuc : Form
    {
        public frm_Sonuc()
        {
            InitializeComponent();
        }
        SQLKod SQL = new SQLKod();

        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut;
        OleDbDataReader oku;

        public string veriler = "";
        //string lbt = "";
        //int sayi = 0;
        ArrayList idler = new ArrayList();
        public string donem = "";
        public static string boslukK(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }


        public void listB()
        {

            /*dataGridView1.DataSource = SQL.TabloOlustur("select tbl_Sonuc.id, tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler, tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Donem.Donemler, tbl_Sinav.OgrenciSayisi, tbl_Sonuc.Sinav_id " +
                                                        "from((((tbl_Sonuc " +
                                                        "INNER JOIN tbl_Ogretmen on tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                                                        "INNER JOIN tbl_Brans on tbl_Ogretmen.Brans_id = tbl_Brans.id) " +
                                                        "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id ) " +
                                                        "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id ) " +
                                                        "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                                                        "where tbl_Sonuc.Sinav_id = " + veriler.Split('_')[0].ToString() + "",
                                                        baglanti);*/
            dataGridView1.DataSource = SQL.TabloOlustur("select tbl_Sonuc.id, tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev ,tbl_Sonuc.Sinav_id " +
                                                         "from((tbl_Sonuc " +
                                                         "INNER JOIN tbl_Ogretmen on tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                                                         "INNER JOIN tbl_Brans on tbl_Ogretmen.Brans_id = tbl_Brans.id) " +
                                                         "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id  " +
                                                         "where tbl_Sonuc.Sinav_id = " + veriler.Split(' ')[1].ToString() + "",
                                                         baglanti);

        }




        private void frm_Sonuc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baglanti = SQL.baglanti();

            frm_Sinav_Ekle fr = new frm_Sinav_Ekle();

            comboBox1.DataSource = SQL.TabloOlustur("select * from tbl_Ogretmen where tbl_Ogretmen.Durum="+true+ " ORDER BY İsim_Soyisim ASC ", SQL.baglanti());
            comboBox1.DisplayMember = "İsim_Soyisim";
            comboBox1.ValueMember = "id";

            textBox1.Text = veriler.Split(' ')[4];
            textBox2.Text = veriler.Split(' ')[3];
            textBox3.Text = veriler.Split(' ')[2];
            textBox4.Text = veriler.Split(' ')[5];
            textBox5.Text = donem;
            textBox6.Text = veriler.Split(' ')[6];

            listB();
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["Sinav_id"].Visible = false;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("select * from tbl_Ogretmen where İsim_Soyisim='" + comboBox1.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                oku.Read();
                textBox7.Text = oku[2].ToString();
                oku.Close();
                komut = new OleDbCommand("select * from tbl_Brans where id=" + textBox7.Text + "", baglanti);
                oku = komut.ExecuteReader();
                oku.Read();
                textBox7.Text = oku[1].ToString();
                oku.Close();
                baglanti.Close();
            }
            catch (Exception)
            {

                oku.Close();
                baglanti.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();



            int c = Convert.ToInt32(SQL.Yazma(SQL.TabloOlustur("select * from tbl_Ogretmen", baglanti), "İsim_Soyisim", comboBox1.Text, "id"));


            komut = new OleDbCommand("SELECT COUNT( * ) FROM (tbl_Sonuc " +
                                      "inner join tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                                      "inner join tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                                      "where Ogretmen_İsim_id =" + c + " and tbl_Sinav.Saat ='" + textBox2.Text + "' and tbl_Sinav.Tarih =#" + textBox3.Text.Split('.')[1] + "/" + textBox3.Text.Split('.')[0] + "/" + textBox3.Text.Split('.')[2] + "# and tbl_Donem.id=" + SQL.Yazma(SQL.TabloOlustur("select * from tbl_Donem", baglanti), "Donemler", textBox5.Text, "id") + " and tbl_Sonuc.Gorev='Gözetmen'", baglanti);

            int b = Convert.ToInt32(komut.ExecuteScalar());
           

            komut = new OleDbCommand("Select Count(*)From tbl_Sonuc where Sinav_id =" + veriler.Split(' ')[1].ToString() + " and Ogretmen_İsim_id="+ c + " and Gorev = 'Komisyon'", baglanti);
            
            int k = Convert.ToInt32(komut.ExecuteScalar());

            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Boşlukları Doldurun");
            }

            else if (b >= 1 && comboBox2.Text!="Komisyon")
            {
                string kod = "SELECT tbl_Ders.Dersler, tbl_Sinav.Saat,tbl_Sinav.Tarih FROM ( tbl_Sonuc inner join tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id)  inner join tbl_Ders on tbl_Sinav.Ders_id=tbl_Ders.id where Ogretmen_İsim_id =" + c + "  and tbl_Sinav.Saat ='" + textBox2.Text + "' and tbl_Sinav.Tarih =#" + textBox3.Text.Split('.')[1] + "/" + textBox3.Text.Split('.')[0] + "/" + textBox3.Text.Split('.')[2] + "#";

                MessageBox.Show("Ekleyemezsiniz, " + SQL.Bul(SQL.TabloOlustur(kod, baglanti), "Dersler") + ". Sınıf Saat: " + SQL.Bul(SQL.TabloOlustur(kod, baglanti), "Saat") + " Tarih: " + SQL.Bul(SQL.TabloOlustur(kod, baglanti), "Tarih").Split(' ')[0] + " " + comboBox1.Text + " " + "Hocanın başka bir sorumluluk sınavıyla meşgul ");
            }
            else if (k==1 && comboBox2.Text!="Gözetmen")
            {
                MessageBox.Show("Aynı Öğretmeni iki defa Komisyon olarak atayamazsınız");
            }
            else
            {

                string kayit = "insert into tbl_Sonuc(Ogretmen_İsim_id,Gorev,Sinav_id) values (@Ogretmen_İsim_id,@Gorev,@Sinav_id)";

                OleDbCommand komutE = new OleDbCommand(kayit, baglanti);

                komutE.Parameters.AddWithValue("@Ogretmen_İsim_id", SQL.Yazma(SQL.TabloOlustur("select * from tbl_Ogretmen", baglanti), "İsim_Soyisim", comboBox1.Text, "id"));

                komutE.Parameters.AddWithValue("@Gorev", comboBox2.Text);

                komutE.Parameters.AddWithValue("@Sinav_id", veriler.Split(' ')[1].ToString());

                komutE.ExecuteNonQuery();



                listB();
                MessageBox.Show("Öğtermen Başarılı Bir Şekilde Kaydoldu");
            }

            baglanti.Close();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from tbl_Sonuc where id=@id";
            //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
            OleDbCommand silKomutu = new OleDbCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            silKomutu.ExecuteNonQuery();
            listB();
            MessageBox.Show("Silindi");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select Count(*)From tbl_Sonuc where Sinav_id =" + veriler.Split(' ')[1].ToString() + " and   Gorev = 'Komisyon'", baglanti);
            int Y = Convert.ToInt32(komut.ExecuteScalar());
            komut = new OleDbCommand("Select Count(*)From tbl_Sonuc where Sinav_id =" + veriler.Split(' ')[1].ToString() + " and   Gorev = 'Gözetmen'", baglanti);
            int G = Convert.ToInt32(komut.ExecuteScalar());

            if (Y < 2)
            {
                komut = new OleDbCommand("update tbl_Sinav set Gecerlilik=" + false + " where id=" + veriler.Split(' ')[1].ToString() + "", baglanti);
                komut.ExecuteNonQuery();

                DialogResult YN = MessageBox.Show("Komisyon Eksik Yinede Çıkmak İstermisiniz", "Error", MessageBoxButtons.YesNo);
                if (YN == DialogResult.Yes)
                {
                    Deyisken.SonucGB = "Geri";
                    this.Close();
                }
                if (YN == DialogResult.No)
                {

                }
            }
            else
            {
                komut = new OleDbCommand("update tbl_Sinav set Gecerlilik=" + true + " where id=" + veriler.Split(' ')[1].ToString() + "", baglanti);
                komut.ExecuteNonQuery();
                Deyisken.SonucGB = "Geri";
                this.Close();
            }
            baglanti.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select Count(*)From tbl_Sonuc where Sinav_id =" + veriler.Split(' ')[1].ToString() + " and   Gorev = 'Komisyon'", baglanti);
            int Y = Convert.ToInt32(komut.ExecuteScalar());
            komut = new OleDbCommand("Select Count(*)From tbl_Sonuc where Sinav_id =" + veriler.Split(' ')[1].ToString() + " and   Gorev = 'Gözetmen'", baglanti);
            int G = Convert.ToInt32(komut.ExecuteScalar());

            if (Y < 2 )
            {
                komut = new OleDbCommand("update tbl_Sinav set Gecerlilik=" + false + " where id=" + veriler.Split(' ')[1].ToString() + "", baglanti);
                komut.ExecuteNonQuery();
                
                DialogResult YN= MessageBox.Show("Komisyon Eksik Yinede Çıkmak İstermisiniz","Error",MessageBoxButtons.YesNo);
                if (YN==DialogResult.Yes)
                {
                    Deyisken.SonucGB = "Çıkış";
                    this.Close();
                }
                if (YN == DialogResult.No)
                {
                    
                }
            }
            else
            {
                komut = new OleDbCommand("update tbl_Sinav set Gecerlilik=" + true + " where id=" + veriler.Split(' ')[1].ToString() + "", baglanti);
                komut.ExecuteNonQuery();
                Deyisken.SonucGB = "Çıkış";
                this.Close();
            }
            baglanti.Close();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




//komut = new OleDbCommand ("select * from tbl_Ders where Dersler='" + veriler.Split('-')[0] + "'", baglanti);
//oku = komut.ExecuteReader();
//oku.Read();
//textBox1.Text = oku[1].ToString();
//oku.Read();