using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SorumlulukSınavı_Deneme2
{
    public partial class frm_SorumlulukPDFCıktı : Form
    {
        public frm_SorumlulukPDFCıktı()
        {
            InitializeComponent();
        }

        SQLKod SQl = new SQLKod();
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut;
        OleDbDataReader oku;
        string PDFT = "";
        private void frm_SorumlulukPDFCıktı_Load(object sender, EventArgs e)
        {
            panel2.Location = new System.Drawing.Point(152, 12);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SQLKod SQl = new SQLKod();
            comboBox1.DataSource = SQl.TabloOlustur("select * from tbl_Donem", SQl.baglanti());
            comboBox1.DisplayMember = "Donemler";
            comboBox1.ValueMember = "id";

            comboBox2.DataSource = SQl.TabloOlustur("select * from tbl_Ogretmen where Durum=" + true + "", SQl.baglanti());
            comboBox2.DisplayMember = "İsim_Soyisim";
            comboBox2.ValueMember = "id";

            comboBox3.DataSource = SQl.TabloOlustur("select * from tbl_MudurY where Durum=" + true + "", SQl.baglanti());
            comboBox3.DisplayMember = "İsim_Soyisim";
            comboBox3.ValueMember = "id";



            comboBox4.DataSource = SQl.TabloOlustur("select DISTINCT tbl_Sinav.Tarih from tbl_Sinav where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " ", SQl.baglanti());
            comboBox4.DisplayMember = "Tarih";
            comboBox4.ValueMember = "Tarih";
            dataGridView1.DataSource = null;
        }


        public void Ogrenciler()
        {
            PDFogrenci pdfogrnc = new PDFogrenci();
            baglanti = SQl.baglanti();
            baglanti.Open();
            komut = new OleDbCommand("SELECT DISTINCT Tarih "+
                                     "from tbl_Sinav "+
                                     "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " " +
                                     "ORDER BY Tarih ASC "
                                     , baglanti);
            
            oku = komut.ExecuteReader();
            string html = "<html xmlns='http://www.w3.org/1999/xhtml' xml:lang='tr' lang='tr'>" + pdfogrnc.ilk() + "<body>" + pdfogrnc.baslık(comboBox1.Text);

            while (oku.Read())
            {
                html += ""+pdfogrnc.SinavBaslik(oku[0].ToString().Split(' ')[0]) ;
                var results = from myRow in SQl.TabloOlustur("SELECT * from tbl_Sinav "+
                                                             "where Gecerlilik="+ true + " and Dönem_id=" + SQl.Yazma(SQl.TabloOlustur("select * from tbl_Donem", baglanti), "Donemler", comboBox1.Text, "id") + " " ,baglanti).AsEnumerable()
                              where (myRow.Field<DateTime>("Tarih")) == Convert.ToDateTime("#"+oku[0].ToString().Split(' ')[0].Replace('.', '/')+"#")
                              select myRow;
                foreach (var Sinav in results)
                {
                    if (Convert.ToBoolean(Sinav[7])==true)
                    {
                        html += pdfogrnc.Sinav(Sinav[2].ToString(), SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "id", Convert.ToInt16(Sinav[1]), "Dersler"), SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "id", Convert.ToInt16(Sinav[1]), "Dersler").Split('-')[1], Sinav[4].ToString(), Sinav[6].ToString());
 
                    }
                }
            }
            


            html += "</tbody></table>" + pdfogrnc.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ",baglanti),"Mudur")) + "</body></html>";
            html = html.Replace("{Now}", DateTime.Now.ToString());
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.GeneratePdf(html, null, "Out.pdf");
           
            MessageBox.Show("Çıktı Alındı");
            baglanti.Close();
        }

        public void Ogretmenler()
        {
            PDFogretmenler pdfogretmen = new PDFogretmenler();
            baglanti = SQl.baglanti();
            baglanti.Open();
            komut = new OleDbCommand("SELECT DISTINCT Tarih " +
                                     "from tbl_Sinav " +
                                     "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " " +
                                     "ORDER BY Tarih ASC "
                                     , baglanti);

            oku = komut.ExecuteReader();


            string html = "<html xmlns='http://www.w3.org/1999/xhtml' xml:lang='tr' lang='tr'>" + pdfogretmen.ilk() + "<body>" + pdfogretmen.baslık(comboBox1.Text);

            while (oku.Read())
            {
                html += "" + pdfogretmen.SinavBaslik(oku[0].ToString().Split(' ')[0], CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)(Convert.ToDateTime(oku[0].ToString().Split(' ')[0])).DayOfWeek]);
                var results = from myRow in SQl.TabloOlustur("SELECT * from tbl_Sinav " +
                                                             "where Gecerlilik=" + true + " and Dönem_id=" + SQl.Yazma(SQl.TabloOlustur("select * from tbl_Donem", baglanti), "Donemler", comboBox1.Text, "id") + " ", baglanti).AsEnumerable()
                              where (myRow.Field<DateTime>("Tarih")) == Convert.ToDateTime("#" + oku[0].ToString().Split(' ')[0].Replace('.', '/') + "#")
                              select myRow;
                foreach (var Sinav in results)
                {
                    if (Convert.ToBoolean(Sinav[7]) == true)
                    {
                        html += pdfogretmen.Sinav(Sinav[2].ToString(), SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "id", Convert.ToInt16(Sinav[1]), "Dersler"), SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ders", baglanti), "id", Convert.ToInt16(Sinav[1]), "Dersler").Split('-')[1], Sinav[4].ToString(), Sinav[6].ToString(), SQl.Yazma(SQl.TabloOlustur("select * from tbl_MudurY", baglanti), "id", Convert.ToInt16(Sinav[8]), "İsim_Soyisim"));
                        var resultsO = from myRow in SQl.TabloOlustur("SELECT * from tbl_Sonuc " +
                                                                     "where Sinav_id=" + Sinav[0] + "", baglanti).AsEnumerable()
                                      select myRow;
                        foreach (var ogretmen in resultsO)
                        {
                            
                            string Bid = SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ogretmen", baglanti), "id", Convert.ToInt32(ogretmen[1]), "Brans_id");
                            html += pdfogretmen.ogr(SQl.Yazma(SQl.TabloOlustur("select * from tbl_Ogretmen", baglanti), "id", Convert.ToInt32(ogretmen[1]), "İsim_Soyisim"), SQl.Yazma(SQl.TabloOlustur("select * from tbl_Brans", baglanti), "id", Convert.ToInt32(Bid), "Branslar"), ogretmen[2].ToString());

                        }
                    }
                }
            }

            html += "</tbody></table>" + pdfogretmen.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ",baglanti),"Mudur")) + "</body></html>";
                html = html.Replace("{Now}", DateTime.Now.ToString());
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
            htmlToPdf.GeneratePdf(html, null, "OutOgretmenler.pdf");
            MessageBox.Show("Çıktı Alındı");
            baglanti.Close();
        }

        public void Ogretmen()
        {

            PDFogretmen pdfogretmen = new PDFogretmen();
            baglanti = SQl.baglanti();
            baglanti.Open();


            if (checkBox1.Checked==true)
            {
                System.IO.Directory.Delete(@"Ogretmenler",true);
                System.IO.Directory.CreateDirectory(@"Ogretmenler");
  
                var ogrid = from myRow in SQl.TabloOlustur("SELECT id ,İsim_Soyisim from tbl_Ogretmen where Durum = " + true + " ", baglanti).AsEnumerable()
                              select myRow;

                foreach (var item in ogrid)
                {

                    komut = new OleDbCommand("SELECT DISTINCT Tarih " +
                                             "from tbl_Sinav " +
                                             "inner join tbl_Sonuc on tbl_Sinav.id=tbl_Sonuc.Sinav_id " +
                                             "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id=" + item[0].ToString() + " " +
                                             "ORDER BY Tarih ASC "
                                             , baglanti);

                    oku = komut.ExecuteReader();

                    string html = "";
                    html += "" + pdfogretmen.ilk();
                    html += "<body>" + pdfogretmen.baslık(comboBox1.Text);
                    html += pdfogretmen.ogr(item[1].ToString(), SQl.Bul(SQl.TabloOlustur("select tbl_Brans.Branslar from tbl_Ogretmen inner join tbl_Brans on tbl_Ogretmen.Brans_id = tbl_Brans.id where tbl_Ogretmen.id=" + item[0].ToString() + "", baglanti), "Branslar"));
                    html += "" + pdfogretmen.sinavB();
                    while (oku.Read())
                    {

                        var results = from myRow in SQl.TabloOlustur("SELECT tbl_Sinav.Tarih, tbl_Ders.Dersler, tbl_Sonuc.Gorev, tbl_Sinav.Saat, tbl_Sinav.SinavTip " +
                                                                     "from (tbl_Sinav " +
                                                                     "inner join tbl_Sonuc on tbl_Sinav.id = tbl_Sonuc.Sinav_id) " +
                                                                     "inner join tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id " +
                                                                     "where Gecerlilik =" + true + " and Dönem_id = " + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id =" + item[0].ToString() + "", baglanti).AsEnumerable()
                                      where (myRow.Field<DateTime>("Tarih")) == Convert.ToDateTime("#" + oku[0].ToString().Split(' ')[0].Replace('.', '/') + "#")
                                      select myRow;
                        foreach (var Sinav in results)
                        {

                            html += pdfogretmen.Sinav(Sinav[0].ToString().Split(' ')[0], Sinav[1].ToString(), Sinav[1].ToString().Split('-')[1], Sinav[2].ToString(), Sinav[3].ToString(), Sinav[4].ToString(), "aaa");

                        }
                    }
                    html += "</tbody></table>" + pdfogretmen.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ",baglanti),"Mudur"));
                    html = html.Replace("{Now}", DateTime.Now.ToString());
                    var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                    htmlToPdf.GeneratePdf(html, null, "Ogretmenler/OutOgretmen(" + item[1]+").pdf");
                }

            }
            else
            {

                komut = new OleDbCommand("SELECT DISTINCT Tarih " +
                                         "from tbl_Sinav " +
                                         "inner join tbl_Sonuc on tbl_Sinav.id=tbl_Sonuc.Sinav_id " +
                                         "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id=" + comboBox2.SelectedValue + " " +
                                         "ORDER BY Tarih ASC "
                                         , baglanti);

                oku = komut.ExecuteReader();

                string html = "";
                html += "" + pdfogretmen.ilk();
                html += "<body>" + pdfogretmen.baslık(comboBox1.Text);
                html += pdfogretmen.ogr(comboBox2.Text, SQl.Bul(SQl.TabloOlustur("select tbl_Brans.Branslar from tbl_Ogretmen inner join tbl_Brans on tbl_Ogretmen.Brans_id = tbl_Brans.id where tbl_Ogretmen.id=" + comboBox2.SelectedValue + "", baglanti), "Branslar"));
                html += "" + pdfogretmen.sinavB();
                while (oku.Read())
                {

                        var results = from myRow in SQl.TabloOlustur("SELECT tbl_Sinav.Tarih, tbl_Ders.Dersler, tbl_Sonuc.Gorev, tbl_Sinav.Saat, tbl_Sinav.SinavTip " +
                                             "from (tbl_Sinav " +
                                             "inner join tbl_Sonuc on tbl_Sinav.id = tbl_Sonuc.Sinav_id) " +
                                             "inner join tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id " +
                                             "where Gecerlilik =" + true + " and Dönem_id = " + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id =" + comboBox2.SelectedValue + "", baglanti).AsEnumerable()
                                      where (myRow.Field<DateTime>("Tarih")) == Convert.ToDateTime("#" + oku[0].ToString().Split(' ')[0].Replace('.', '/') + "#")
                                      select myRow;


                        foreach (var Sinav in results)
                        {

                            html += pdfogretmen.Sinav(Sinav[0].ToString().Split(' ')[0], Sinav[1].ToString(), Sinav[1].ToString().Split('-')[1], Sinav[2].ToString(), Sinav[3].ToString(), Sinav[4].ToString(), "aaa");

                        }
                        html += "</tbody></table>" + pdfogretmen.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ", baglanti), "Mudur"));
                        html = html.Replace("{Now}", DateTime.Now.ToString());
                        var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                        htmlToPdf.GeneratePdf(html, null, "OutOgretmen.pdf");
                    

                }



            }
            MessageBox.Show("Çıktı Alındı ");
            baglanti.Close();


        }

        public void Ogretmenlerimza()
        {
            if (comboBox4.Text == null || comboBox4.Text == "")
            {

            }
            else
            {
                DateTime saat = Convert.ToDateTime("#" + comboBox4.Text.ToString().Split(' ')[0].Replace('.', '/') + "#");

                PDFogretmenimza pdfogrnc = new PDFogretmenimza();
                baglanti = SQl.baglanti();
                baglanti.Open();

                if (checkBox2.Checked==true)
                {
                    System.IO.Directory.Delete(@"OgretmenImzaListesi", true);
                    

                    var tari = from myRow in SQl.TabloOlustur("SELECT Tarih from tbl_Sinav where Dönem_id = " + comboBox1.SelectedValue + " ", baglanti).AsEnumerable()
                                select myRow;
                    foreach (var tarih in tari)
                    {
                        komut = new OleDbCommand("SELECT  tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler ,tbl_Donem.Donemler, tbl_Sinav.Tarih , tbl_Sinav.Saat from ((((tbl_Sonuc " +
                          "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                          "INNER JOIN tbl_Ogretmen ON tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                          "INNER JOIN tbl_Brans ON tbl_Ogretmen.Brans_id = tbl_Brans.id ) " +
                          "INNER JOIN tbl_Ders On tbl_Sinav.Ders_id = tbl_Ders.id) " +
                          "INNER JOIN tbl_Donem ON tbl_Sinav.Dönem_id = tbl_Donem.id " +
                          "where tbl_Sinav.Gecerlilik=" + true + " and tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Tarih=" + Convert.ToString("#" + tarih[0].ToString().Split('.')[1] + "/" + tarih[0].ToString().Split('.')[0] + "/" + tarih[0].ToString().Split('.')[2].Split(' ')[0] + "#") + "" +
                          "ORDER BY tbl_Ders.Dersler DESC"
                          , baglanti);

                        oku = komut.ExecuteReader();
                        oku.Read();

                        var results = from myRow in SQl.TabloOlustur("SELECT DISTINCT tbl_Ders.Dersler ,tbl_Sinav.Tarih from tbl_Sinav " +
                                                         "inner join tbl_Ders on tbl_Sinav.Ders_id =tbl_Ders.id " +
                                                         "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue, baglanti).AsEnumerable()
                                      where (myRow.Field<DateTime>("Tarih")) == saat
                                      select myRow;

                        string html = pdfogrnc.ilk() + "<body>" + pdfogrnc.baslık(comboBox1.Text) + "" + pdfogrnc.SinavBaslik(tarih[0].ToString().Split('.')[0] + "." + tarih[0].ToString().Split('.')[1] + "." + tarih[0].ToString().Split('.')[2].Split(' ')[0].Split(' ')[0]) +
                        "<h2 style='padding - top: 0px; padding - left: 9px; text - indent: 0pt; text-align: center; '>Sınavı Yapılan Dersler</h2> ";
                        //html += "</tbody></table>" + pdfogrnc.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ",baglanti),"Mudur")) + "</body></html>";
                        foreach (var item in results)
                        {
                            html += pdfogrnc.dersler(item[0].ToString());
                        }
                        html += pdfogrnc.tabloBası();
                        oku.Close();

                        oku = komut.ExecuteReader();

                        while (oku.Read())
                        {
                            html += pdfogrnc.tablodevamı(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[6].ToString(), oku[3].ToString());
                        };
                        html += pdfogrnc.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ", baglanti), "Mudur")) + "</body></html>";
                        html = html.Replace("{Now}", DateTime.Now.ToString());
                        var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                        System.IO.Directory.CreateDirectory(@"OgretmenImzaListesi");
                        htmlToPdf.GeneratePdf(html, null, "OgretmenImzaListesi/Outimza(" + tarih[0].ToString().Split('.')[0] + " " + tarih[0].ToString().Split('.')[1] + " " + tarih[0].ToString().Split('.')[2].Split(' ')[0] + ").pdf");
                    }
                }
                else
                {
                    komut = new OleDbCommand("SELECT  tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler ,tbl_Donem.Donemler, tbl_Sinav.Tarih , tbl_Sinav.Saat from ((((tbl_Sonuc " +
                          "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                          "INNER JOIN tbl_Ogretmen ON tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                          "INNER JOIN tbl_Brans ON tbl_Ogretmen.Brans_id = tbl_Brans.id ) " +
                          "INNER JOIN tbl_Ders On tbl_Sinav.Ders_id = tbl_Ders.id) " +
                          "INNER JOIN tbl_Donem ON tbl_Sinav.Dönem_id = tbl_Donem.id " +
                          "where tbl_Sinav.Gecerlilik=" + true + " and tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Tarih=" + Convert.ToString("#" + comboBox4.Text.Split('.')[1] + "/" + comboBox4.Text.Split('.')[0] + "/" + comboBox4.Text.Split('.')[2] + "#") + "" +
                          "ORDER BY tbl_Ders.Dersler DESC"
                          , baglanti);

                    oku = komut.ExecuteReader();
                    oku.Read();

                    var results = from myRow in SQl.TabloOlustur("SELECT DISTINCT tbl_Ders.Dersler ,tbl_Sinav.Tarih from tbl_Sinav " +
                                                     "inner join tbl_Ders on tbl_Sinav.Ders_id =tbl_Ders.id " +
                                                     "where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue, baglanti).AsEnumerable()
                                  where (myRow.Field<DateTime>("Tarih")) == saat
                                  select myRow;

                    string html = pdfogrnc.ilk() + "<body>" + pdfogrnc.baslık(comboBox1.Text) + "" + pdfogrnc.SinavBaslik(comboBox4.Text) +
                    "<h2 style='padding - top: 0px; padding - left: 9px; text - indent: 0pt; text-align: center; '>Sınavı Yapılan Dersler</h2> ";
                    //html += "</tbody></table>" + pdfogrnc.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ",baglanti),"Mudur")) + "</body></html>";
                    foreach (var item in results)
                    {
                        html += pdfogrnc.dersler(item[0].ToString());
                    }
                    html += pdfogrnc.tabloBası();
                    oku.Close();

                    oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        html += pdfogrnc.tablodevamı(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[6].ToString(), oku[3].ToString());
                    };
                    html += pdfogrnc.son(SQl.Bul(SQl.TabloOlustur("select Mudur from tbl_Mudur ", baglanti), "Mudur")) + "</body></html>";
                    html = html.Replace("{Now}", DateTime.Now.ToString());
                    var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                    htmlToPdf.GeneratePdf(html, null, "Outimza.pdf");
                }

    
 

                MessageBox.Show("Çıktı Alındı");
                baglanti.Close();
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            if (radioButton1.Checked==true)
            {
                panel3.Location = new System.Drawing.Point(120, 58);
                panel4.Visible = false;
                label2.Visible = false;
                comboBox2.Visible = false;

                panel1.Visible = false;
                panel2.Location= new System.Drawing.Point(152, 12);
                PDFT = "Ogrenciler";
                dataGridView1.DataSource = SQl.TabloOlustur("select tbl_Sinav.id, tbl_Ders.Dersler, tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Donem.Donemler, tbl_Sinav.OgrenciSayisi " +
                                            "from (tbl_Sinav " +
                                            "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id) " +
                                            "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                                            "where tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Gecerlilik=true ORDER BY  tbl_Sinav.Tarih ASC  ",
                                            SQl.baglanti());
                this.dataGridView1.Columns["id"].Visible = false;

            }
            else if (radioButton2.Checked == true)
            {
                panel3.Location = new System.Drawing.Point(120, 58);
                panel4.Visible = false;
                label2.Visible = false;
                comboBox2.Visible = false;
                panel1.Visible = false;
                panel2.Location = new System.Drawing.Point(152, 12);

                PDFT = "Ogretmenler";
                dataGridView1.DataSource = SQl.TabloOlustur("select tbl_Sinav.id, tbl_Ders.Dersler, tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Donem.Donemler, tbl_Sinav.OgrenciSayisi " +
                            "from (tbl_Sinav " +
                            "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id) " +
                            "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                            "where tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Gecerlilik=true ORDER BY  tbl_Sinav.Tarih ASC  ",
                            SQl.baglanti());
                this.dataGridView1.Columns["id"].Visible = false;

            }
            else if (radioButton3.Checked == true)
            {
                panel3.Location = new System.Drawing.Point(120, 58);
                panel4.Visible = false;
                label2.Visible = true;
                comboBox2.Visible = true;
                panel1.Visible = true;
                panel2.Location = new System.Drawing.Point(33, 12);
                PDFT = "Ogretmen";
                dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Sinav.Tarih, tbl_Ders.Dersler, tbl_Sonuc.Gorev, tbl_Sinav.Saat, tbl_Sinav.SinavTip " +
                                                             "from (tbl_Sinav " +
                                                             "inner join tbl_Sonuc on tbl_Sinav.id = tbl_Sonuc.Sinav_id) " +
                                                             "inner join tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id " +
                                                             "where Gecerlilik =" + true + " and Dönem_id = " + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id =" + comboBox2.SelectedValue + " ORDER BY  tbl_Sinav.Tarih ASC ", SQl.baglanti());


            }
            else if (radioButton4.Checked == true)
            {
                panel2.Location = new System.Drawing.Point(152, 12);
                panel3.Location = new System.Drawing.Point(33, 58);
                panel4.Visible = true;
                panel1.Visible = false;
                try
                {

                    dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler ,tbl_Donem.Donemler, tbl_Sinav.Tarih , tbl_Sinav.Saat from ((((tbl_Sonuc " +
                             "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                             "INNER JOIN tbl_Ogretmen ON tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                             "INNER JOIN tbl_Brans ON tbl_Ogretmen.Brans_id = tbl_Brans.id ) " +
                             "INNER JOIN tbl_Ders On tbl_Sinav.Ders_id = tbl_Ders.id) " +
                             "INNER JOIN tbl_Donem ON tbl_Sinav.Dönem_id = tbl_Donem.id " +
                             "where tbl_Sinav.Gecerlilik=" + true + " and tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Tarih=" + Convert.ToString("#" + comboBox4.Text.Split('.')[1]+"/" + comboBox4.Text.Split('.')[0] + "/" + comboBox4.Text.Split('.')[2] +"#") + ""+
                             "ORDER BY tbl_Ders.Dersler DESC"
                             , SQl.baglanti());
                }
                catch { }

                PDFT = "Ogretmenlerimza";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (PDFT)
            {
                case "Ogrenciler": Ogrenciler(); break;
                case "Ogretmenler": Ogretmenler(); break;
                case "Ogretmen": Ogretmen(); break;
                case "Ogretmenlerimza": Ogretmenlerimza(); break;

                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Visible == true)
            {
                dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Sinav.Tarih, tbl_Ders.Dersler, tbl_Sonuc.Gorev, tbl_Sinav.Saat, tbl_Sinav.SinavTip " +
                                 "from (tbl_Sinav " +
                                 "inner join tbl_Sonuc on tbl_Sinav.id = tbl_Sonuc.Sinav_id) " +
                                 "inner join tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id " +
                                 "where Gecerlilik =" + true + " and Dönem_id = " + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id =" + comboBox2.SelectedValue + " ORDER BY  tbl_Sinav.Tarih ASC ", SQl.baglanti());
            }
  
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                axAcroPDF1.Dock = DockStyle.Fill;
                button3.Visible = true;
                panel4.Visible = false;
                radioButton4.Visible = false;
                axAcroPDF1.Visible = true;
                this.WindowState = FormWindowState.Maximized;
                this.ControlBox = false;
                switch (PDFT)
                {
                    case "Ogrenciler": axAcroPDF1.LoadFile("Out.pdf"); break;
                    case "Ogretmenler": axAcroPDF1.LoadFile("OutOgretmenler.pdf"); break;
                    case "Ogretmen": axAcroPDF1.LoadFile("OutOgretmen.pdf"); break;
                    case "Ogretmenlerimza": axAcroPDF1.LoadFile("Outimza.pdf"); break;
                    default:
                        break;
                }
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button3.Visible = false;
            axAcroPDF1.Visible=false;
            this.ControlBox = true;
            panel4.Visible = true;
            radioButton4.Visible = true;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                comboBox4.Text = "";
                comboBox4.DataSource = SQl.TabloOlustur("select DISTINCT tbl_Sinav.Tarih from tbl_Sinav where Gecerlilik=" + true + " and Dönem_id=" + comboBox1.SelectedValue + " ", SQl.baglanti());
                comboBox4.DisplayMember = "Tarih";
                comboBox4.ValueMember = "Tarih";

            }
            catch { }

            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                dataGridView1.DataSource = SQl.TabloOlustur("select tbl_Sinav.id, tbl_Ders.Dersler, tbl_Sinav.Saat, tbl_Sinav.Tarih, tbl_Sinav.SinavTip, tbl_Donem.Donemler, tbl_Sinav.OgrenciSayisi " +
                "from (tbl_Sinav " +
                "INNER JOIN tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id) " +
                "INNER JOIN tbl_Donem on tbl_Sinav.Dönem_id = tbl_Donem.id " +
                "where tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Gecerlilik=true",
                SQl.baglanti());

            }
            else if (radioButton3.Checked == true)
            {
                dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Sinav.Tarih, tbl_Ders.Dersler, tbl_Sonuc.Gorev, tbl_Sinav.Saat, tbl_Sinav.SinavTip " +
                 "from (tbl_Sinav " +
                 "inner join tbl_Sonuc on tbl_Sinav.id = tbl_Sonuc.Sinav_id) " +
                 "inner join tbl_Ders on tbl_Sinav.Ders_id = tbl_Ders.id " +
                 "where Gecerlilik =" + true + " and Dönem_id = " + comboBox1.SelectedValue + " and tbl_Sonuc.Ogretmen_İsim_id =" + comboBox2.SelectedValue + "", SQl.baglanti());
            }
            else if (radioButton4.Checked ==true )
            {
                if (comboBox4.Text!="" )
                {
                         dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler ,tbl_Donem.Donemler, tbl_Sinav.Tarih , tbl_Sinav.Saat from ((((tbl_Sonuc " +
                        "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                        "INNER JOIN tbl_Ogretmen ON tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                        "INNER JOIN tbl_Brans ON tbl_Ogretmen.Brans_id = tbl_Brans.id ) " +
                        "INNER JOIN tbl_Ders On tbl_Sinav.Ders_id = tbl_Ders.id) " +
                        "INNER JOIN tbl_Donem ON tbl_Sinav.Dönem_id = tbl_Donem.id " +
                        "where tbl_Sinav.Gecerlilik=" + true + " and tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Tarih=" + Convert.ToString("#" + comboBox4.Text.Split('.')[1]+"/" + comboBox4.Text.Split('.')[0] + "/" + comboBox4.Text.Split('.')[2] +"#") + ""+
                        "ORDER BY tbl_Ders.Dersler DESC"
                        , SQl.baglanti());
                }
                else
                {
                    dataGridView1.DataSource = null;
                }

            }



        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.Text != "")
                {
                    dataGridView1.DataSource = SQl.TabloOlustur("SELECT tbl_Ogretmen.İsim_Soyisim, tbl_Brans.Branslar, tbl_Sonuc.Gorev, tbl_Ders.Dersler ,tbl_Donem.Donemler, tbl_Sinav.Tarih , tbl_Sinav.Saat from ((((tbl_Sonuc " +
                   "INNER JOIN tbl_Sinav on tbl_Sonuc.Sinav_id = tbl_Sinav.id) " +
                   "INNER JOIN tbl_Ogretmen ON tbl_Sonuc.Ogretmen_İsim_id = tbl_Ogretmen.id) " +
                   "INNER JOIN tbl_Brans ON tbl_Ogretmen.Brans_id = tbl_Brans.id ) " +
                   "INNER JOIN tbl_Ders On tbl_Sinav.Ders_id = tbl_Ders.id) " +
                   "INNER JOIN tbl_Donem ON tbl_Sinav.Dönem_id = tbl_Donem.id " +
                   "where tbl_Sinav.Gecerlilik=" + true + " and tbl_Sinav.Dönem_id=" + comboBox1.SelectedValue + " and tbl_Sinav.Tarih=" + Convert.ToString("#" + comboBox4.Text.Split('.')[1] + "/" + comboBox4.Text.Split('.')[0] + "/" + comboBox4.Text.Split('.')[2] + "#") + "" +
                   "ORDER BY tbl_Ders.Dersler DESC"
                   , SQl.baglanti());
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch { }

        }
    }
}
