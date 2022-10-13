using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace SorumlulukSınavı_Deneme2
{
    public class SQLKod
    {
        public OleDbConnection baglanti()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DT_SorumlulukS.mdb");
            return baglanti;
        }


        public string Yazma(DataTable DT, string ara, int kosul, string cikti)
        {
            ArrayList dizi = new ArrayList();

            var results = from myRow in DT.AsEnumerable()
                          where myRow.Field<int>(ara) == kosul
                          select myRow;
            foreach (var item in results)
            {
                dizi.Add(item[cikti].ToString());
            }
            return dizi[0].ToString();
        }

        public string Yazma(DataTable DT, string ara, string kosul, string cikti)
        {
            ArrayList dizi = new ArrayList();
            var results = from myRow in DT.AsEnumerable()
                          where (myRow.Field<string>(ara)).Trim() == kosul.Trim()
                          select myRow;
            foreach (var item in results)
            {
                dizi.Add(item[cikti].ToString());
            }
            return dizi[0].ToString();
        }
        public int Yazmaİ(DataTable DT, string ara, string kosul, string cikti)
        {
            ArrayList dizi = new ArrayList();
            var results = from myRow in DT.AsEnumerable()
                          where (myRow.Field<string>(ara)).Trim() == kosul.Trim()
                          select myRow;
            foreach (var item in results)
            {
                dizi.Add(item[cikti].ToString());
            }
            return Convert.ToInt32(dizi[0]);
        }

        public string Bul(DataTable DT,string Sonuc)
        {
            ArrayList dizi = new ArrayList();
            var results = from myRow in DT.AsEnumerable()
                          select myRow;
            foreach (var item in results)
            {
                dizi.Add(item[Sonuc].ToString());
            }
            return dizi[0].ToString();
        }


        public DataTable TabloOlustur(string ara, OleDbConnection baglanti)
        {
            string sqlKomut = ara;


            OleDbCommand komut = new OleDbCommand(sqlKomut, baglanti);
            OleDbDataAdapter  da = new OleDbDataAdapter (komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
