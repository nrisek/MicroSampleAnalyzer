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
    public class RepozitorijPacijenata
    {
        public static List<Pacijent> DohvatiPacijente()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();

            string sql = "SELECT * FROM Pacijent";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Pacijent pacijent = CreateObject(reader);
                pacijenti.Add(pacijent);
            }

            reader.Close();
            DB.CloseConnection();

            return pacijenti;
        }
        public static List<string> DohvatiPacijenteOIB()
        {
            List<string> pacijenti = new List<string>();

            string sql = "SELECT * FROM Pacijent";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Pacijent pacijent = CreateObject(reader);
                pacijenti.Add(pacijent.Oib);
            }

            reader.Close();
            DB.CloseConnection();
            return pacijenti;
        }
        public static string DohvatiPacijenta(string oib)
        {
            string sql = $"SELECT * FROM Pacijent WHERE OIB = '{oib}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            string imeIprezime = "";
            if (reader.HasRows == true)
            {
                reader.Read();
                imeIprezime = reader["ImeIPrezime"].ToString();
                reader.Close();
            }
            DB.CloseConnection();

            return imeIprezime;
        }
        public static string DohvatiOIBPacijenta(string imeIprezime)
        {
            List<string> pacijenti = new List<string>();
            string sql = "select * from Pacijent where ImeIPrezime='"+imeIprezime+"';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pacijent pacijent = CreateObject(reader);
                    pacijenti.Add(pacijent.Oib);
                }

                reader.Close();
                DB.CloseConnection();
                return pacijenti[0];
            }
            reader.Close();
            DB.CloseConnection();
            return null;
        }
        public static List<Pacijent> PretraziPacijente(string imeIprezime)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();

            string sql = "SELECT * FROM Pacijent where ImeIPrezime='" + imeIprezime + "';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Pacijent pacijent = CreateObject(reader);
                pacijenti.Add(pacijent);
            }

            reader.Close();
            DB.CloseConnection();

            return pacijenti;
        }
        public static void UnesiPacijenta(string oib, string imePrezime, string adresa, string tel, string god, string povij, string analize)
        {
            string sql = $"INSERT INTO Pacijent (OIB, ImeIPrezime, " +
                $"Adresa, Telefon, GodinaRodenja, PovijestBolesti, PrijasnjeAnalize) " +
                $"VALUES ('" + oib + "', '" + imePrezime + "','" + adresa + "','" + tel + "','" + god + "','" + povij + "','" + analize + "');";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Pacijent CreateObject(SqlDataReader reader)
        {
            string oib = reader["OIB"].ToString();
            string imeIPrezime = reader["ImeIPrezime"].ToString();
            string adresa = reader["Adresa"].ToString();
            string telefon = reader["Telefon"].ToString();
            string godina = reader["GodinaRodenja"].ToString();
            string povijest = reader["PovijestBolesti"].ToString();
            string prijasnje = reader["PrijasnjeAnalize"].ToString();

            string[] rijeci = imeIPrezime.Split(' ');

            var pacijent = new Pacijent
            {
                Oib = oib,
                Ime = rijeci[0],
                Prezime = rijeci[1],
                Adresa = adresa,
                Telefon = telefon,
                GodinaRodenja = godina,
                PovijestBolesti = povijest,
                PrijasnjeAnalize = prijasnje
            };
            return pacijent;
        }
    }
}
