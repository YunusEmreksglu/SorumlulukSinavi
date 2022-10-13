using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorumlulukSınavı_Deneme2
{
    class PDFogrenci
    {
        public string ilk()
        {
            string bas = "<head>" +
                "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>" +
                "<title>Baslık</title><style type='text/css'> * {margin:0; padding:0; text-indent:0; }" +
                " h1 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 12pt; } #ogretmen tr:nth-child(even){    background: #CCC  }   " +
                " .s1 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 10pt; }" +
                " .s2 { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: bold; text-decoration: none; font-size: 14pt; }" +
                " .s3 { color: black; font-family:Arial, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 10pt; }" +
                " h2 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 10pt; }" +
                " h3 { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: bold; text-decoration: none; font-size: 9pt; }" +
                " p { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 9pt; margin:0pt; }" +
                " .s4 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: normal; text-decoration: none; font-size: 11pt; }" +
                " li {display: block; }" +
                " #l1 {padding-left: 0pt;counter-reset: c1 1; }" +
                " #l1> li>*:first-child:before {counter-increment: c1; content: counter(c1, decimal)'. '; color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 9pt; }" +
                " #l1> li:first-child>*:first-child:before {counter-increment: c1 0;  }" +
                " table, tbody {vertical-align: top; overflow: visible; }" +
                "</style>" +
                "</head>";
            return bas;
        }

        public string baslık(string Donem)
        {
            string baslık = "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
            "<h1 style='padding-top: 4pt;padding-left: 212.667;text-indent: 0pt;text-align: left;'>" + Donem + "</h1>" +
            "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
            "<table style='border-collapse:collapse' cellspacing='0' id='ogretmen'><tbody>" +
            "<tbody>" +
            "<tr style='height:48pt'> " +
           "<td style='width:53pt;border-bottom-style:solid;border-bottom-width:2pt;border-bottom-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p><p class='s1' style='padding-top: 20.333;padding-left: 3pt;text-indent: 0pt;text-align: left;'>Sınav Tarih</p></td>" +
           "<td style='width:231pt;border-bottom-style:solid;border-bottom-width:2pt;border-bottom-color:#808080'><p class='s2' style='padding-left: 90pt;text-indent: 0pt;line-height: 17pt;text-align: left;'>Sınav Programı</p><p style='text-indent: 0pt;text-align: left;'><br></p><p class='s1' style='padding-left: 28pt;text-indent: 0pt;text-align: left;'>Sınav Saati Sınavı Yapılacak Dersin Adı</p></td>" +
           "<td style='width:52pt;border-bottom-style:solid;border-bottom-width:2pt;border-bottom-color:#808080'><p style='text-indent: 0pt;text-align: left;padding-top: 36px;'> Sınav Şekli</p></td>" +
           "<td style='width:45pt;border-bottom-style:solid;border-bottom-width:2pt;border-bottom-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p><p class='s1' style='padding-top: 19.333;padding-right: 9pt;text-indent: 0pt;text-align: right;'>Sınıflar</p></td>" +
           "<td style='width:59pt;border-bottom-style:solid;border-bottom-width:2pt;border-bottom-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p><p class='s1' style='padding-top: 19.333;padding-left: 8pt;text-indent: 0pt;text-align: left;'>Öğr.Sayısı</p></td>" +
           "</tr>";
            return baslık;
        }

        public string son(string mudur)
        {

            string son = "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
                     "<h3 style='padding-top: 2pt;padding-left: 7pt;text-indent: 0pt;text-align: left;'>NOT :</h3>" +
                     "<ol id='l1'><li data-list-text='1.'>" +
                     "<p style='padding-top: 2pt;padding-left: 14pt;text-indent: -10pt;line-height: 11pt;text-align: left;'>Öğrenciler sınavlara okul kıyafetleri ile geleceklerdir.</p></li><li data-list-text='2.'>" +
                     "<p style='padding-left: 4pt;text-indent: 0pt;text-align: left;'>Öğrenciler sınav saatinden en az yarım saat önce okula gelmiş olacaklardır. Vaktinde gelmeyenler sınav salonuna alınmayacaklardır.</p></li><li data-list-text='3.'>" +
                     "<p style='padding-left: 14pt;text-indent: -10pt;line-height: 11pt;text-align: left;'>Öğrenciler; sınavı yapılacak dersin özelliğine göre yanlarında malzemelerini getireceklerdir.</p></li><li data-list-text='4.'>" +
                     "<p style='padding-left: 4pt;text-indent: 0pt;text-align: left;'>Sınav salonuna kitap, defter vb. eşyaların getirilmesi yasaktır. Sınav anında yasaklanmış davranışlarda bulunanlar sınav salonundan çıkarılır ve haklarında disiplin işlemi uygulanır.</p></li></ol>" +
                     "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
                     "<p style='padding-top: 5pt;padding-left: 334pt;text-indent: 0pt;text-align: center;'>Tasdik Olunur</p><p class='s4' style='padding-top: 7pt;padding-left: 335pt;text-indent: 0pt;text-align: center;'>"+mudur+"</p><p style='padding-top: 3pt;padding-left: 335pt;text-indent: 0pt;text-align: center;'>Okul Müdürü</p>";
            return son;
        }

        public string SinavBaslik(string tarih)
        {

            string SinavBaslik = "<tr style='height:14pt'>" +
                                "<td style='width:53pt;border-top-style:solid;border-top-width:2pt;border-top-color:#808080'><p class='s3' style='padding-top: 1pt;padding-left: 3pt;text-indent: 0pt;text-align: left;'>" + tarih + "</p></td>" +
                                "<td style='width:52pt;border-top-style:solid;border-top-width:2pt;border-top-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                                "<td style='width:45pt;border-top-style:solid;border-top-width:2pt;border-top-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                                "<td style='width:59pt;border-top-style:solid;border-top-width:2pt;border-top-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                                "<td style='width:59pt;border-top-style:solid;border-top-width:2pt;border-top-color:#808080'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                                "</tr>";
            return SinavBaslik;
        }

        public string Sinav(string Saat, string ders, string Sınıf, string sinavtipi, string ogrenciSayısı)
        {
            string Sinav = "<td style='width:53pt; '><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                         //"<tr style='height:14pt'>" +
                         "<td style='width:231pt; '><p class='s3' style='padding-left: 40pt;text-indent: 0pt;text-align: left;'>" + Saat + " " + ders + "</p></td>" +
                         "<td style='width:52pt; '><p class='s3' style='padding-right: 22px;text-indent: 0pt;text-align: right;'>" + sinavtipi + "</p></td>" +
                         "<td style='width:45pt; '><p class='s3' style='padding-right: 23.667;text-indent: 0pt;text-align: right;'>" + Sınıf + "</p></td>" +
                         "<td style='width:59pt; '><p class='s3' style='padding-right: 31.667;text-indent: 0pt;text-align: right;'>" + ogrenciSayısı + "</p></td>" +
                         "</tr>";
            return Sinav;
        }

        public string Cizgi()
        {
            string Cizgi = "<tr style='height:3pt'>" +
                          "<td style='width:53pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:231pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:52pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:45pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:59pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "/tr>";
            return Cizgi;

        }


    }

    class PDFogretmenler
    {
        public string ilk()
        {
            string bas = "<head>                                                     " +
                         "<meta http-equiv = 'Content-Type' content = 'text/html; charset=utf-8'>     " +
                         "     <title> file_1650523972494 </title>                                    " +
                         "     <style type = 'text/css'>                                                " +
                         "          * {                                                                   " +
                         "        margin: 0;                                                              " +
                         "        padding: 0;                                                             " +
                         "            text-indent: 0;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "        h1 {                                                                    " +
                         "        color: black;                                                           " +
                         "            font-family: 'Times New Roman', serif;                            " +
                         "            font-style: italic;                                               " +
                         "            font-weight: bold;                                                " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 14pt;                                                  " +
                         "        }                                                                       " +
                         "        #ogretmen tr:nth-child(even){                                                   "+
                         "            background: #CCC                                                     "+
                         "        }                                                                        "+
                         "                                                                                " +
                         "        h2 {                                                                    " +
                         "        color: black;                                                           " +
                         "            font-family: 'Times New Roman', serif;                            " +
                         "            font-style: italic;                                               " +
                         "            font-weight: bold;                                                " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 12pt;                                                  " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s1 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: Tahoma, sans-serif;                                " +
                         "            font-style: normal;                                               " +
                         "            font-weight: bold;                                                " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 14pt;                                                  " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "        h3 {                                                                    " +
                         "        color: black;                                                           " +
                         "            font-family: 'Times New Roman', serif;                            " +
                         "            font-style: italic;                                               " +
                         "            font-weight: bold;                                                " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s2 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: Arial, sans-serif;                                 " +
                         "            font-style: normal;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s3 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: Arial, sans-serif;                                 " +
                         "            font-style: normal;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s4 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: Tahoma, sans-serif;                                " +
                         "            font-style: normal;                                               " +
                         "            font-weight: bold;                                                " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s5 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: 'Times New Roman', serif;                            " +
                         "            font-style: normal;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "        p {                                                                     " +
                         "        color: black;                                                           " +
                         "            font-family: Tahoma, sans-serif;                                " +
                         "            font-style: normal;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 8pt;                                                   " +
                         "        margin: 0pt;                                                            " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s6 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: Tahoma, sans-serif;                                " +
                         "            font-style: normal;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 9pt;                                                   " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "    .s7 {                                                                       " +
                         "        color: black;                                                           " +
                         "            font-family: 'Times New Roman', serif;                            " +
                         "            font-style: italic;                                               " +
                         "            font-weight: normal;                                              " +
                         "            text-decoration: none;                                            " +
                         "            font-size: 11pt;                                                  " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "        li {                                                                    " +
                         "        display: block;                                                         " +
                         "        }                                                                       " +
                         "                                                                                " +
                         "#l1 {                                                                              " +
                         "            padding-left: 0pt;                                                    " +
                         "            counter-reset: c1 1;                                                  " +
                         "        }                                                                           " +
                         "                                                                                    " +
                         "#l1>li>*:first-child:before {                                                      " +
                         "        counter-increment: c1;                                                      " +
                         "            content: counter(c1, decimal)'. ';                                      " +
                         "            color: black;                                                           " +
                         "            font-family: Tahoma, sans-serif;                                        " +
                         "            font-style: normal;                                                     " +
                         "            font-weight: normal;                                                    " +
                         "            text-decoration: none;                                                  " +
                         "            font-size: 8pt;                                                         " +
                         "        }                                                                           " +
                         "                                                                                    " +
                         "#l1>li:first-child>*:first-child:before {                                          " +
                         "    counter-increment: c1 0;                                                        " +
                         "        }                                                                           " +
                         "                                                                                    " +
                         "table,                                                                              " +
                         "        tbody {                                                                     " +
                         "            vertical-align: top;                                                    " +
                         "            overflow: visible;                                                      " +
                         "        }                                                                           " +
                         "    </style>                                                                        " +
                         "</head>                                                                            ";
            return bas;
        }

        public string baslık(string Donem)
        {                                                                                                                                                                                                             
            string baslık = " <h1 style = 'padding-top: 2pt;padding-left: 73pt;text-indent: 0pt;text-align: center;width: 851px'> Abdurrahman ve Nermin Bilimli "                                                   +
                        "             Mesleki ve Teknik Anadolu Lisesi</h1>                                                                                       "                                                 +
                        "         <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                                                                                                     " +
                        "          <h1 style = 'padding-top: 4pt;padding-left: 80pt;text-indent: 0pt;text-align: center;width:803px'> 2021-2022 Eğitim ve Öğretim                                                " +
                        "        Yılı </h1>                                                                                                                                                                        " +
                        "    <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                                                                                                          " +
                        "     <h2 style = 'padding-top: 4pt;padding-left: 28pt;text-indent: 0pt;text-align: center;width:938px'> ŞUBAT-22 Sorumluluk </h2>                                                     " +
                        "            <p class='s1' style='padding-top: 3pt;padding-left: 103pt;text-indent: 0pt;text-align: center;width:742px'>Sınav Programı</p>                                                  " +
                        "    <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                                                                                                           " +
                        "             <table style= 'border-collapse:collapse' cellspacing= '0'>                                                                                                                   " +
                        "                 <tr style= 'height:22px'>                                                                                                                                                " +
                        "                     <td style= 'width:53pt;border-bottom-width:2pt'>                                                                                                                     " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 0pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sına Tarihi</p>                                          " +
                        "                     </td>                                                                                                                                                                  " +
                        "            <td style = 'width:53pt;border-bottom-width:1pt'>                                                                                                                              " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 0pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sınav Saati</p>                                          " +
                        "                     </td>                                                                                                                                                                  " +
                        "            <td style = 'width:110pt;border-bottom-width:1pt'>                                                                                                                             " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 3pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sınavı Yapılacak Dersin Adı</p>                          " +
                        "                     </td>                                                                                                                                                                  " +
                        "            <td style = 'width:53pt;border-bottom-width:1pt'>                                                                                                                              " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 3pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sınav Şekli</p>                                          " +
                        "                     </td>                                                                                                                                                                  " +
                        "            <td style = 'width:46pt;border-bottom-width:1pt'>                                                                                                                              " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 3pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sınıflar </p>                                          " +
                        "                     </td>                                                                                                                                                                " +
                        "                     <td style= 'width:200pt ;border-bottom-width:1pt'>                                                                                                                   " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 3pt;padding-left: 12pt;text-indent: 0pt;text-align: left;'> Sınav Görevlilerinin Adı Soyadı, Branşı ve Görevleri</p> " +
                        "                     </td>                                                                                                                                                                  " +
                        "            <td style = 'width: 269px;border-bottom-width:1pt'>                                                                                                                            " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 1pt;padding-left: 90pt;text-indent: 0pt;text-align: left;'> Görevli Müd.Yrd.</p>                                     " +
                        "            </td>                                                                                                                                                                           " +
                        "            <td style = 'width:269px;border-bottom-width:1pt'>                                                                                                                             " +
                        "                         <p style= 'padding-top: 4pt;padding-bottom: 3pt;padding-left: 0pt;text-indent: 0pt;text-align: left;'> Öğr.Sayısı </p>                                         " +
                        "                     </td>                                                                                                                                                                " +
                        "                 </tr>                                                                                                                                                                    " +
                        "             </table>                                                                                                                                                                     ";
                     return baslık;                                                                                                                                                                                  
        }

        public string son(string mudur)
        {

            string son = "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
                     "<h3 style='padding-top: 2pt;padding-left: 7pt;text-indent: 0pt;text-align: left;'>NOT :</h3>" +
                     "<ol id='l1'><li data-list-text='1.'>" +
                     "<p style='padding-top: 2pt;padding-left: 14pt;text-indent: -10pt;line-height: 11pt;text-align: left;'>Öğrenciler sınavlara okul kıyafetleri ile geleceklerdir.</p></li><li data-list-text='2.'>" +
                     "<p style='padding-left: 4pt;text-indent: 0pt;text-align: left;'>Öğrenciler sınav saatinden en az yarım saat önce okula gelmiş olacaklardır. Vaktinde gelmeyenler sınav salonuna alınmayacaklardır.</p></li><li data-list-text='3.'>" +
                     "<p style='padding-left: 14pt;text-indent: -10pt;line-height: 11pt;text-align: left;'>Öğrenciler; sınavı yapılacak dersin özelliğine göre yanlarında malzemelerini getireceklerdir.</p></li><li data-list-text='4.'>" +
                     "<p style='padding-left: 4pt;text-indent: 0pt;text-align: left;'>Sınav salonuna kitap, defter vb. eşyaların getirilmesi yasaktır. Sınav anında yasaklanmış davranışlarda bulunanlar sınav salonundan çıkarılır ve haklarında disiplin işlemi uygulanır.</p></li></ol>" +
                     "<p style='text-indent: 0pt;text-align: left;'><br></p>" +
                     "<p style='padding-top: 5pt;padding-left: 334pt;text-indent: 0pt;text-align: center;'>Tasdik Olunur</p><p class='s4' style='padding-top: 7pt;padding-left: 335pt;text-indent: 0pt;text-align: center;'>"+mudur+"</p><p style='padding-top: 3pt;padding-left: 335pt;text-indent: 0pt;text-align: center;'>Okul Müdürü</p>";
            return son;
        }

        public string SinavBaslik(string tarih,string Gun)
        {

            string SinavBaslik = "<table style = 'border-collapse:collapse;margin-left:5.199pt' cellspacing = '0' id='ogretmen'>                        " +
                                "<tbody>                                                                                                 " +
                                "    <tr style = 'height:12pt'>                                                                          " +
                                "         <td style = 'width:46pt;border-top-style:solid;border-top-width:2pt'>                          " +
                                "              <p class='s3' style='padding-right: 3pt;text-indent: 0pt;text-align: right;'>"+tarih+"</p> " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:174pt;border-top-style:solid;border-top-width:2pt'>                              " +
                                "         <p class='s3' style='padding-left: 4pt;text-indent: 0pt;text-align: left;'>"+ Gun + "</p>             " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:42pt;border-top-style:solid;border-top-width:2pt'>                               " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:33pt;border-top-style:solid;border-top-width:2pt'>                               " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:113pt;border-top-style:solid;border-top-width:2pt'>                              " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:112pt;border-top-style:solid;border-top-width:2pt'>                              " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:70pt;border-top-style:solid;border-top-width:2pt'>                               " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:117pt;border-top-style:solid;border-top-width:2pt'>                              " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                " +
                                "     <td style = 'width:39pt;border-top-style:solid;border-top-width:2pt'>                               " +
                                "         <p style='text-indent: 0pt;text-align: left;'><br></p>                                          " +
                                "     </td>                                                                                                "+
                                " </tr>";
            return SinavBaslik;
        }

        public string Sinav(string Saat, string ders, string Sınıf, string sinavtipi, string ogrenciSayısı,string MudurY)
        {
            string Sinav = "<tr style = 'height:12pt'>                                                                                    " +
                          "    <td style = 'width:46pt'>                                                                                  " +
                          "         <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                          " +
                          "      </td>                                                                                                    " +
                          "      <td style = 'width:174pt'>                                                                               " +
                          "           <p class='s3' style='padding-left: 19pt;text-indent: 0pt;text-align: left;'>"+Saat+" "+ ders + "</p>" +
                          "   </td>                                                                                                         " +
                          //"      <td style = 'width:50pt'>                                                                               " +
                          //"           <p class='s3' style='padding-left: 19pt;text-indent: 0pt;text-align: left;'>" + ders + "</p>" +
                          //"   </td> "+
                          "   <td style = 'width:42pt'>                                                                                    " +
                          "       <p class='s3' style='padding-left: 7pt;text-indent: 0pt;text-align: left;'>"+sinavtipi+"</p>                    " +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:33pt'>                                                                                    " +
                          "       <p class='s3' style='padding-left: 3pt;text-indent: 0pt;text-align: center;'>"+ Sınıf + "</p>                       " +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:113pt'>                                                                                   " +
                          "       <p style='text-indent: 0pt;text-align: left;'><br></p>                                                   " +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:112pt'>                                                                                   " +
                          "       <p style='text-indent: 0pt;text-align: left;'><br></p>                                                   " +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:70pt'>                                                                                    " +
                          "       <p style='text-indent: 0pt;text-align: left;'><br></p>                                                   " +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:117pt'>                                                                                   " +
                          "       <p class='s3' style='padding-left: 11pt;padding-right: 12pt;text-indent: 0pt;text-align: center;'>       " +
                          "           "+MudurY+"</p>" +
                          "   </td>                                                                                                         " +
                          "   <td style = 'width:39pt'>                                                                                    " +
                          "       <p class='s3' style='padding-right: 11pt;text-indent: 0pt;text-align: right;'>"+ ogrenciSayısı + "</p>                     " +
                          "   </td>                                                                                                       " +
                          "</tr>                                                                                                            ";
            return Sinav;
        }
        public string ogr(string adı,string brans, string gorevi)
        {
            string Ogretmen = "<tr style = 'height:13pt'>                                                                                       " +
                            "       <td style = 'width:46pt'>                                                                                  " +
                            "            <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                          " +
                            "         </td>                                                                                                    " +
                            "         <td style = 'width:174pt'>                                                                               " +
                            "              <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                        " +
                            "           </td>                                                                                                  " +
                            "           <td style = 'width:42pt'>                                                                              " +
                            "                <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                      " +
                            "             </td>                                                                                                " +
                            "             <td style = 'width:33pt'>                                                                            " +
                            "                  <p style = 'text-indent: 0pt;text-align: left;'><br></p>                                    " +
                            "               </td>                                                                                              " +
                            "               <td style = 'width:113pt'>                                                                         " +
                            "                    <p class='s3' style='padding-left: 10pt;text-indent: 0pt;text-align: left;'>"+adı+"</p>   " +
                            "                                                                                                                    " +
                            "     </td>                                                                                                          " +
                            "     <td style = 'width:112pt'>                                                                                    " +
                            "                     <p class='s3' style='padding-left: 13pt;text-indent: 0pt;text-align: left;'>"+brans+"</p>         " +
                            "                                                                                                                    " +
                            "     </td>                                                                                                          " +
                            "     <td style = 'width:70pt'>                                                                                     " +
                            "         <p class='s3' style='padding-left: 22pt;text-indent: 0pt;text-align: left;'>"+gorevi+"</p>                  " +
                            "     </td> <td></td> <td></td>"+
                            " " +
                            " </tr>                                                                                                              ";


            return Ogretmen;
        }

        public string Cizgi()
        {
            string Cizgi = "<tr style='height:3pt'>" +
                          "<td style='width:53pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:231pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:52pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:45pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "<td style='width:59pt;border-top-style:solid;border-top-width:1pt;border-bottom-style:solid;border-bottom-width:1pt'><p style='text-indent: 0pt;text-align: left;'><br></p></td>" +
                          "/tr>";
            return Cizgi;

        }
    }

    class PDFogretmen
    {
        public string ilk()
        {
            string ilk= "<head>" +
                "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>" +
                "<title>Baslık</title><style type='text/css'> * {margin:0; padding:0; text-indent:0; }" +
                " h1 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 12pt; }" +
                " .s1 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 10pt; }" +
                " .s2 { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: bold; text-decoration: none; font-size: 14pt; }" +
                " .s3 { color: black; font-family:Arial, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 10pt; }" +
                " h2 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: bold; text-decoration: none; font-size: 10pt; }" +
                " h3 { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: bold; text-decoration: none; font-size: 9pt; }" +
                " p { color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 9pt; margin:0pt; }" +
                " .s4 { color: black; font-family:'Times New Roman', serif; font-style: italic; font-weight: normal; text-decoration: none; font-size: 11pt; }" +
                " li {display: block; }" +
                " #l1 {padding-left: 0pt;counter-reset: c1 1; }" +
                " #l1> li>*:first-child:before {counter-increment: c1; content: counter(c1, decimal)'. '; color: black; font-family:Tahoma, sans-serif; font-style: normal; font-weight: normal; text-decoration: none; font-size: 9pt; }" +
                " #l1> li:first-child>*:first-child:before {counter-increment: c1 0;  }" +
                " table, tbody {vertical-align: top; overflow: visible; }" +
                "</style>" +
                "</head>";
            return ilk;

        }
        public string baslık(string Donem) {                                                                                                                               
            string baslık = "<meta http-equiv='Content - Type' content='text / html; charset = utf - 8' >"+
                            "<table>                                                                                                                                      " +
                            "    <div style = 'position:absolute;top:0.87in;left:4.95in;width:0.34in;line-height:0.18in;'><span                                         "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Tahoma;color:#000000'> T.C.</span><span                "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Tahoma;color:#000000'> </span><br>                    "+
                            "    </div>                                                                                                                                  "+
                            "    <div style = 'position:absolute;top:1.11in;left:3.90in;width:2.52in;line-height:0.18in;'><span                                         "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Tahoma;color:#000000'> BAĞCILAR                           "+
                            "            KAYMAKAMLIĞI </span><span                                                                                                      "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Tahoma;color:#000000'> </span><br>                    "+
                            "    </div>                                                                                                                                  "+
                            "    <div style = 'position:absolute;top:1.39in;left:2.57in;width:5.23in;line-height:0.16in;'><span                                         "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Times New Roman;color:#000000'> Abdurrahman               "+
                            "            ve Nermin Bilimli Mesleki ve Teknik Anadolu Lisesi</span><span                                                                 "+
                            "            styfle = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Times New Roman;color:#000000'>                          "+
                            "        </span><br>                                                                                                                       "+
                            "    </div>                                                                                                                                  "+
                            "    <div style = 'position:absolute;top:1.65in;left:4.70in;width:1.03in;line-height:0.16in;'><span                                         "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Times New Roman;color:#000000'> Müdürlüğü </span><span "+
                            "            style = 'font-style:normal;font-weight:bold;font-size:12pt;font-family:Times New Roman;color:#000000'></span><br>            "+
                            "    </div>                                                                                                                                  "+
                            "                                                                                                                                              "+                                                                                                           
                            "</table>                                                                                                                                                                                                                                                 "+
                            "                            <div style = 'position:absolute;top:3.59in;left:1.05in;'><span                                                                                                                                                              "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> &emsp; &emsp; &emsp; &emsp; &emsp; Ayırtman olarak                                                                                                 "+
                            "            bulunduğunuz sınav günlerinde belirtilen saatte okulda hazır bulunmanız, sınav için müfredat programı ve                                                                                                                                       "+
                            "            <br> ders araçlarını yanınızda getirmeniz gerekmektedir. Herhangi bir nedenle görevinize gelmeyecek iseniz mazeretinizi sınav gününden ön-                                                                                                   "+
                            "                                                                                                                                                                                                                                                           "+
                            "              <br> ce mutlaka Okul Müdürlüğüne haber vermek durumunda olduğunuzu unutmayınız.                                                                                                                                                            "+
                            "        diğer </span><span style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'>                                                                                                                              "+
                            "                                                                                                                                                                                                                                                           "+
                            "        </span><br>                                                                                                                                                                                                                                    "+
                            "    </div>                                                                                                                                                                                                                                               "+
                            "                                                                                                                                                                                                                                                           "+
                            "                                                                                                                                                                                                                                                           "+
                            "    <div style = 'position:absolute;top:3.21in;left:1.05in;'><span                                                                                                                                                                                      "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> &emsp; &emsp; &emsp; &emsp; &emsp; "+Donem.Split('-')[0]+" - "+ Donem.Split('-')[1] + "  Öğretim Yılı "+Donem.Split('-')[2]+"  SORUMLULUK SINAVLARI  sınavında okulumuzda görevli olduğunuz  günler    " +
                            "                     <br> aşağıya çıkartılmıştır.                                                                                                                                                                                                          "+
                            "                                                                                                                                                                                                                                                           "+
                            "                  </span><br></div>                                                                                                                                                                                                                  "+
                            "                                                                                                                                                                                                                                                           "+
                            "                                                                                                                                                                                                                                                           "+
                            "                  <div style = 'position:absolute;top:4.17in;left:1.05in;'><span                                                                                                                                                                        "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> &emsp; &emsp; &emsp; &emsp; &emsp; Görevli                                                                                                         "+
                            "                 öğretmenlerin belirtilen hususlara titizlik göstererek emir gereğince hareket etmelerini rica eder,                                                                                                                                       "+
                            "                 çalışmalarınızda başarı -                                                                                                                                                                                                                 "+
                            "                                                                                                                                                                                                                                                           "+
                            "                 <br> lar dilerim.</span><span                                                                                                                                                                                                        "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> </span><br>                                                                                                                                    "+
                            "</div>                                                                                                                                                                                                                                                   "+
                            "                                                                                                                                                                                                                                                           "+
                            "                                                                                                                                                                                                                                                           "+
                            "                                                                                                                                                                                                                                                           "+
                            "                                                                                                                                                                                                                                                           "+
                            "<div style = 'position:absolute;top:2.27in;left:1.05in;'><span                                                                                                                                                                                          "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Konu: Sınav                                                                                                                                        "+
                            "        günleriniz.</span><span                                                                                                                                                                                                                         "+
                            "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> </span><br>                                                                                                                                    "+
                            "</div>                                                                                                                                                                                                                                                   "+
                            "                                                                                                                                                                                                                                                           "+
                            "<div style = 'position:absolute;top:4.82in;left:0.89in;width:1.51in;line-height:0.15in;'><span                                                                                                                                                          "+
                            "    style = 'font-style:normal;font-weight:bold;font-size:10pt;font-family:Tahoma;color:#000000'> Sınav                                                                                                                                                   "+
                            "    Görevleriniz:</span><span                                                                                                                                                                                                                           "+
                            "    style = 'font-style:normal;font-weight:bold;font-size:10pt;font-family:Tahoma;color:#000000'> </span><br>                                                                                                                                         "+
                            "</div>";


            return baslık;
        }
        public string sinavB()
        {                                                                                                                                                                                 
            string sinavB="<table border = '1' style = 'position:absolute;top:5.06in;left:1.05in;'>                                                                                     "+
                            "                                                                                                                                                             "+
                            "                                                                                                                                                             "+
                            "                                                                                                                                                             "+
                            "<tbody align = 'center'>                                                                                                                                   "+
                            "                                                                                                                                                             "+
                            "     <tr>                                                                                                                                                  "+
                            "                                                                                                                                                             "+
                            "         <td width = '70.7285px' style = 'width: 47.719;'><span                                                                                           "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> S.                                              "+
                            "             Tarihi </span></td>                                                                                                                         "+
                            "     <td width = '178.905000px' style = 'width: 158.891;'><span                                                                                           "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Dersin                                          "+
                            "             Adı </span></td>                                                                                                                            "+
                            "     <td width = '54.397500px'><span                                                                                                                      "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Sınıflar </span>                              "+
                            "     </td>                                                                                                                                                 "+
                            "     <td width = '70'><span                                                                                                                               "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Görevi </span>                                "+
                            "     </td>                                                                                                                                                 "+
                            "     <td><span                                                                                                                                            "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000;width: 1auto;height: 1px;width: 50px;'> Gör.      "+
                            "             Baş.Saati </span></td>                                                                                                                      "+
                            "     <td width = '56px;'><span                                                                                                                            "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Sınav                                           "+
                            "             Şekli </span></td>                                                                                                                          "+
                            "     <td style = 'width: 220.712;'><span                                                                                                                  "+
                            "             style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Açıklamalar </span>                           "+
                            "     </td>                                                                                                                                                 "+
                            " </tr>";
            return sinavB;
        }
        
        public string son(string mudur) {                                                                                                                      
            string son="<div style = 'position:absolute;top:7.39in;left:6.48in;width:0.93in;line-height:0.13in;'><span                                      "+
                        "        style = 'font-style:italic;font-weight:normal;font-size:9pt;font-family:Arial;color:#000000'> "+ mudur + "                         "+
                        "         </span><span style = 'font-style:italic;font-weight:normal;font-size:9pt;font-family:Arial;color:#000000'>           "+
                        "                                                                                                                                      "+
                        "        </span><br></div>                                                                                                       "+
                        "    <div style = 'position:absolute;top:7.61in;left:6.58in;width:0.72in;line-height:0.11in;'><span                                 "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> Okul                           "+
                        "        Müdürü </span><span style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'>         "+
                        "                                                                                                                                      "+
                        "        </span><br>                                                                                                               "+
                        "    </div>                                                                                                                          "+
                        "    <div style = 'position:absolute;top:7.23in;left:2.09in;width:0.67in;line-height:0.12in;'><span                                 "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Aslını                        "+
                        "        aldım.</span><span style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'>         "+
                        "                                                                                                                                      "+
                        "       </span><br>                                                                                                                "+
                        "   </div>                                                                                                                           "+
                        "   <div style = 'position:absolute;top:7.37in;left:2.27in;width:0.30in;line-height:0.12in;'><span                                  "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> İmza </span><span          "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> </span><br>               "+
                        "</div>                                                                                                                              "+
                        "<div style = 'position:absolute;top:7.02in;left:2.13in;width:0.62in;line-height:0.12in;'><span                                     "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:9pt;font-family:Times New Roman;color:#000080'>... /                 "+
                        "        ... / .....</span><span                                                                                                    "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:9pt;font-family:Times New Roman;color:#000080'>                      "+
                        "    </span><br></div>                                                                                                           "+
                        "                                                                                                                                      "+
                        "                                                                                                                                      "+
                        "</body>                                                                                                                             "+
                        "                                                                                                                                      "+
                        "</html>";
            return son;
        }
        public string Sinav(string Tarih, string ders, string Sınıf, string gorev,string saat,string sinavtipi, string aciklama) {
            string sinav="<tr>                                                                                                                             "+
                         "    <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'>"+ Tarih + "                  "+
                         "         </td>                                                                                                                    "+
                         "                                                                                                                                    "+
                         "         <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'>"+ ders + "         "+
                         "          </td>                                                                                                                   "+
                         "                                                                                                                                    "+
                         "          <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> "+ Sınıf + " </td>            "+
                         "                                                                                                                                    "+
                         "           <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> "+ gorev + " </td>     "+
                         "                                                                                                                                    "+
                         "            <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> "+ saat + " </td>       "+
                         "                                                                                                                                    "+
                         "                 <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> "+ sinavtipi + " </td> "+
                         "                                                                                                                                    "+
                         "                  <td style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Arial;color:#000000'> "+ aciklama + ""+
                         "        </td>                                                                                                                    "+
                         "                                                                                                                                    "+
                         "</tr>";

            return sinav;
        }
        public string ogr(string adı, string brans) {
            string ogr="<div style = 'position:absolute;top:2.07in;left:1.47in;width:0.28in;line-height:0.12in;'><span                             "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> 531 /</span><spans     "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> </span><br>          "+
                        "</div>                                                                                                                         "+
                        "                                                                                                                                 "+
                        "                                                                                                                                 "+
                        "                                                                                                                                 "+
                        "<div style = 'position:absolute;top:2.65in;left:1.56in;'><span                                                                "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> Sayın: "+ adı + "     "+
                        "        </span><span style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'>          "+
                        "                                                                                                                                 "+
                        "       </span><br>                                                                                                           "+
                        "   </div>                                                                                                                      "+
                        "                                                                                                                                 "+
                        "                                                                                                                                 "+
                        "   <div style = 'position:absolute;top:2.83in;left:2in;'><span                                                                "+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'>"+ brans + "  </span><span"+
                        "        style = 'font-style:normal;font-weight:normal;font-size:8pt;font-family:Tahoma;color:#000000'> </span><br>          "+
                        "</div>";
            return ogr;
        }
    }

    class PDFogretmenimza
    {
        public string ilk()
        {
           
            string bas ="<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>       "+
                       "<title></title>                                                           "+
                       "<style type='text/css'>                                                   "+
                       "    * {                                                                   "+
                       "        margin: 0;                                                        "+
                       "        padding: 0;                                                       "+
                       "        text-indent: 0;                                                   "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    h1 {                                                                  "+
                       "        color: black;                                                     "+
                       "        font-family: 'Times New Roman', serif;                            "+
                       "        font-style: italic;                                               "+
                       "        font-weight: bold;                                                "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 12pt;                                                  "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    h2 {                                                                  "+
                       "        color: black;                                                     "+
                       "        font-family: 'Times New Roman', serif;                            "+
                       "        font-style: italic;                                               "+
                       "        font-weight: bold;                                                "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 11pt;                                                  "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    .s1 {                                                                 "+
                       "        color: black;                                                     "+
                       "        font-family: Arial, sans-serif;                                   "+
                       "        font-style: normal;                                               "+
                       "        font-weight: normal;                                              "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 8pt;                                                   "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    p {                                                                   "+
                       "        color: black;                                                     "+
                       "        font-family: Arial, sans-serif;                                   "+
                       "        font-style: normal;                                               "+
                       "        font-weight: normal;                                              "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 9pt;                                                   "+
                       "        margin: 0pt;                                                      "+
                       "    }"+
                       //"	body{margin:0 auto;text-align:center; width:960px;}"+
                       "                                                                          "+
                       "    .s2 {                                                                 "+
                       "        color: black;                                                     "+
                       "        font-family: 'Times New Roman', serif;                            "+
                       "        font-style: italic;                                               "+
                       "        font-weight: bold;                                                "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 10pt;                                                  "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    .s3 {                                                                 "+
                       "        color: black;                                                     "+
                       "        font-family: Arial, sans-serif;                                   "+
                       "        font-style: normal;                                               "+
                       "        font-weight: normal;                                              "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 8pt;                                                   "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    .s4 {                                                                 "+
                       "        color: black;                                                     "+
                       "        font-family: Arial, sans-serif;                                   "+
                       "        font-style: italic;                                               "+
                       "        font-weight: normal;                                              "+
                       "        text-decoration: none;                                            "+
                       "        font-size: 9pt;                                                   "+
                       "    }                                                                     "+
                       "                                                                          "+
                       "    table,                                                                "+
                       "    tbody {                                                               "+
                       " margin:0 auto;text-align:center; width:960px;" +
                       "        vertical-align: top;                                              "+
                       "        overflow: visible;                                                "+
                       "    }                                                                     "+
                       "</style>                                                                  "+
                       "</head>                                                                   ";
            return bas;
        } //1

        public string baslık(string Donem) 
        {
            string baslık = "<h1 style='padding-top: 3pt;padding-left: 0px;text-indent: 0pt;text-align: center;'>" + Donem + "</h1>" +
                           "<h1 style='padding-top: 3pt;padding-left: 0px;text-indent: 0pt;text-align: center'>                 "+
                           "    SORUMLULUK</h1>                                                                                          "+
                           "<p style='padding-left: 13pt;text-indent: 0pt;line-height: 1pt;text-align: left;'>                                "+
                           "</p><p style='text-indent: 0pt;text-align: left;'><br></p>                                                        ";
            return baslık;
        } //2

        public string son(string mudur)
        {

            string son =" </tbody></table>                                                                                                           "+
                        "<p style='text-indent: 0pt;text-align: left;'><br></p>                                                             "+
                        "<p style='text-indent: 0pt;text-align: left;'><br></p>                                                             "+
                        //"<p class='s1' style='padding-top: 4pt;padding-left: 0;text-indent: 0pt;padding-left: 434px;'>6.06.2022</p>         "+
                        "                                                                                                                   "+
                        "<p class='s4' style='padding-top: 4pt;padding-left: 0;text-indent: 0pt;padding-right: 100px; text-align:right'>" + mudur + "</p>       " +
                        "<p class='s1' style='padding-top: 4pt;padding-left: 0;text-indent: 0pt;padding-right: 110px;text-align:right'>Okul Müdürü</p>       " +
                        "<p style='text-indent: 0pt;text-align: left;'><br></p>                                                             ";
            return son;
        }  //8

        public string SinavBaslik(string tarih)
        {

            string SinavBaslik = "<h2 style='padding-top: 3pt;padding-left: 0px;text-indent: 0pt;text-align: center;'>Görev Tarihi</h2>             " +
                                "<p class='s1' style='padding-top: 3pt;padding-left: 0px;text-indent: 0pt;text-align: center;'>" + tarih + "             " +
                                "</p>                                                                                                                           ";
    
            return SinavBaslik;
        }  //3

        //<h2 style="padding-top: 0px; padding-left: 9px;text-indent: 0pt;text-align: left;">Sınavı Yapılan Dersler</h2> //4

        public string dersler(string ders) 
        {
            return "<p style='padding-top: 0px; padding-left: 9px;text-indent: 0pt;text-align: center;'>" + ders + "</p>";
        }  //5

        public string tabloBası()
        {
            string Cizgi ="<p style='text-indent: 0pt;text-align: left;'><br></p>"+
                            "<table style='border-collapse:collapse;margin-left:5.63195pt' cellspacing='0'>                                                                                                                                           "+
                          "<tbody>                                                                                                                                                                                                                  "+
                          "<tr style='height:26pt'>                                                                                                                                                                                                 "+
                          "    <td style='width:97pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>  "+
                          "        <p class='s2' style='padding-top: 7pt;padding-left: 21pt;text-indent: 0pt;text-align: center;'>Görevliler                                                                                                          " +
                          "        </p>                                                                                                                                                                                                             "+
                          "    </td>                                                                                                                                                                                                                "+
                          "    <td style='width:108pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'> "+
                          "        <p class='s2' style='padding-top: 7pt;padding-left: 36pt;padding-right: 41pt;text-indent: 0pt;text-align: center;'>                                                                                              "+
                          "            Branşı</p>                                                                                                                                                                                                   "+
                          "    </td>" +
                          "<td style='width:108pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>" +
                          "          <p class='s2' style='padding-top: 7pt;padding-left: 40px;padding-right: 40px;text-indent: 0pt;text-align: center;'>" +
                          "Dersleri</p>" +
                          "</td>                                                                                                                                                                                                                   " +
                          "    <td style='width:49pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>  "+
                          "        <p class='s2' style='padding-top: 7pt;padding-left: 11pt;text-indent: 0pt;text-align: center;'>Görevi</p>                                                                                                          " +
                          "    </td>                                                                                                                                                                                                                "+
                          "    <td style='width:51pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>  "+
                          "        <p class='s2' style='padding-top: 1pt;padding-left: 6pt;padding-right: 4pt;text-indent: 0pt;text-align: center;'>                                                                                                "+
                          "            Gör.Baş.</p>                                                                                                                                                                                                 "+
                          "        <p class='s2' style='padding-left: 6pt;padding-right: 4pt;text-indent: 0pt;text-align: center;'>Saati                                                                                                            "+
                          "        </p>                                                                                                                                                                                                             "+
                          "    </td>                                                                                                                                                                                                                "+
                          "    <td style='width:61pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>  "+
                          "        <p class='s2' style='padding-top: 7pt;padding-left: 20pt;text-indent: 0pt;text-align: center;'>İmza</p>                                                                                                            " +
                          "    </td>                                                                                                                                                                                                                "+
                          "                                                                                                                                                                                                                         "+
                          "</tr>                                                                                                                                                                                                                    ";
            return Cizgi;                                                                                                                                                                                                                           
                                                                                                                                                                                                                                                    
        }  //6

        public string tablodevamı(string ogretmen,string bra, string gorev,string saat,string ders)
        {
            string a ="<tr style='height:15pt'>                                                                                                                                                                                                  "+
                      "<td style='width:97pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>       "+
                      "    <p class='s3' style='padding-top: 2pt;padding-left: 1pt;text-indent: 0pt;text-align: center;'>" + ogretmen + "                                                                                                                  " +
                      "        </p>                                                                                                                                                                                                       "+
                      "</td>                                                                                                                                                                                                                     "+
                      "<td style='width:108pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>      "+
                      "    <p class='s3' style='padding-top: 2pt;padding-left: 2pt;text-indent: 0pt;text-align: center;'>" + bra + "                                                                                                                       " +
                      "    </p>                                                                                                                                                                                                                  "+
                      "</td>" +
                      "<td style = 'width:51pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt' >"+
                      "<p class='s3' style='padding-top: 2pt;padding-left: 4pt;padding-right: 4pt;text-indent: 0pt;text-align: center;'>"+
                      "   "+ ders+"</p>"+
                      "</td>"+
                      "<td style='width:49pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>       "+
                      "    <p class='s3' style='padding-top: 2pt;padding-left: 2pt;text-indent: 0pt;text-align: center;'>" + gorev + "</p>                                                                                                                 " +
                      "</td>                                                                                                                                                                                                                     "+
                      "<td style='width:51pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>       "+
                      "    <p class='s3' style='padding-top: 2pt;padding-left: 4pt;padding-right: 4pt;text-indent: 0pt;text-align: center;'>                                                                                                     "+
                      "        "+saat+"</p>                                                                                                                                                                                                         " +
                      "</td>                                                                                                                                                                                                                     "+
                      "<td style='width:61pt;border-top-style:solid;border-top-width:1pt;border-left-style:solid;border-left-width:1pt;border-bottom-style:solid;border-bottom-width:1pt;border-right-style:solid;border-right-width:1pt'>       "+
                      "    <p style='text-indent: 0pt;text-align: left;'><br></p>                                                                                                                                                                "+
                      "</td>                                                                                                                                                                                                                     "+
                      "</tr>                                                                                                                                                                                                                     ";
            return a;

        }  //7
    }
}
