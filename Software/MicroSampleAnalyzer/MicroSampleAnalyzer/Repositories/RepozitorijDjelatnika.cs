using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using MicroSampleAnalyzer.Models;

namespace MicroSampleAnalyzer.Repositories
{
    public class RepozitorijDjelatnika
    {
        public static string DohvatiDjelatnika(string oib)
        {
            string sql = $"SELECT * FROM Djelatnik WHERE OIB = '{oib}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            string ime = "";
            string prezime = "";
            if (reader.HasRows == true)
            {
                reader.Read();
                ime = reader["Ime"].ToString();
                prezime = reader["Prezime"].ToString();
                reader.Close();
            }
            DB.CloseConnection();

            return ime+" "+prezime;
        }
        public static string DohvatiDjelatnikaOIB(string ime, string prezime)
        {
            string sql = $"SELECT * FROM Djelatnik WHERE Ime = '"+ime+"' AND Prezime = '"+prezime+"';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            string oib = "";
            if (reader.HasRows == true)
            {
                reader.Read();
                oib = reader["OIB"].ToString();
                reader.Close();
            }
            DB.CloseConnection();

            return oib;
        }
        public static List<string> DohvatiDjelatnike()
        {
            List<string> djelatnici = new List<string>();

            string sql = "SELECT * FROM Djelatnik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Djelatnik pacijent = CreateObject(reader);
                djelatnici.Add(pacijent.ToString());
            }

            reader.Close();
            DB.CloseConnection();
            return djelatnici;
        }
        private static Djelatnik CreateObject(SqlDataReader reader)
        {
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();

            var djelatnik = new Djelatnik
            {
                Ime = ime,
                Prezime = prezime
            };
            return djelatnik;
        }
    }
}
