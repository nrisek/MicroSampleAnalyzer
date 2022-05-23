using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroSampleAnalyzer.Models;
using DBLayer;
using System.Data.SqlClient;

namespace MicroSampleAnalyzer.Repositories
{
    public class RepozitorijUzoraka
    {
        public static List<Uzorak> DohvatiUzorke()
        {
            List<Uzorak> uzorci = new List<Uzorak>();

            string sql = "SELECT * FROM Uzorak";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Uzorak uzorak = CreateObject(reader);
                uzorci.Add(uzorak);
            }

            reader.Close();
            DB.CloseConnection();

            return uzorci;
        }
        public static Uzorak DohvatiUzorak(int id)
        {
            string sql = $"SELECT * FROM Uzorak WHERE ID =" + id + ";";
            return PronadiUzorak(sql);
        }
        public static void SpremiPromjene(string datum, string zaprimioOib, string pacijentOib, string opis, int id)
        {
            Uzorak uzorak = new Uzorak();
            uzorak.DatumZaprimanja = datum;
            uzorak.ZaprimioOIB = zaprimioOib;
            uzorak.PacijentOIB = pacijentOib;
            uzorak.Opis = opis;
            UpdateUzorak(uzorak, id);
        }
        public static void UpdateUzorak(Uzorak uzorak, int id)
        {
            string sql = $"UPDATE Uzorak SET DatumZaprimanja = '{uzorak.DatumZaprimanja}', DjelatnikOIB = '{uzorak.ZaprimioOIB}', PacijentOIB = '{uzorak.PacijentOIB}', Opis = '{uzorak.Opis}' WHERE ID = {id};";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DeleteUzorak(int id)
        {
            string sql = $"Delete from Uzorak where ID={id};";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Uzorak PronadiUzorak(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Uzorak uzorak = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                uzorak = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return uzorak;
        }
        public static List<Uzorak> PretraziUzorke(string imeIprezime)
        {
            //Dohvati OIB pacijenta
            string oib = RepozitorijPacijenata.DohvatiOIBPacijenta(imeIprezime);

            List<Uzorak> uzorci = new List<Uzorak>();

            string sql = "SELECT * FROM Uzorak where PacijentOIB='" + oib + "';";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Uzorak uzorak = CreateObject(reader);
                uzorci.Add(uzorak);
            }

            reader.Close();
            DB.CloseConnection();

            return uzorci;
        }
        public static void UnesiUzorak(string zaprimioOib, string pacijentOib, string opis)
        {
            string sql = $"INSERT INTO Uzorak (DatumZaprimanja, DjelatnikOIB, PacijentOIB, Opis) VALUES (GETDATE(), '"+zaprimioOib+"', '"+pacijentOib+"', '"+opis+"');";
       
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static int DohvatiIdUnesenogUzorka() //koristi se kod QR kod-a
        {
            List<int> idevi = new List<int>();
            string sql = "SELECT ID FROM Uzorak";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                idevi.Add(reader.GetInt32(0));
            }
            reader.Close();
            DB.CloseConnection();
            int zadnji = idevi[idevi.Count - 1];
            return zadnji; //ovo je ID trenutno unesenog uzorka
        }
        private static Uzorak CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string datumZaprimanja = reader["DatumZaprimanja"].ToString();
            string zaposlenikOIB = reader["DjelatnikOIB"].ToString();
            string pacijentOIB = reader["PacijentOIB"].ToString();
            string opis = reader["Opis"].ToString();

            var uzorak = new Uzorak
            {
                Id = id,
                DatumZaprimanja = datumZaprimanja,
                ZaprimioOIB = zaposlenikOIB,
                PacijentOIB = pacijentOIB,
                Opis = opis
            };
            return uzorak;
        }
    }
}
