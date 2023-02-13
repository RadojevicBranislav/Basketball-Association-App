using DataLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UgovorRepository
    {

        public List<Ugovor> GetUgovors()
        {
            using(SqlConnection conn = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection= conn;               

                sql.CommandText = "SELECT * FROM Ugovori";

                conn.Open();

                SqlDataReader dataReader = sql.ExecuteReader();

                List<Ugovor> ls = new List<Ugovor>();

                
                while(dataReader.Read())
                {
                    Ugovor u = new Ugovor();

                    u.datum_potpisivanja = dataReader.GetDateTime(0);

                    u.datum_isteka = dataReader.GetDateTime(1);

                    u.id_kosarkasa = dataReader.GetInt32(2);

                    u.id_kluba = dataReader.GetInt32(3);

                    ls.Add(u);
                }

                return ls;
            }
        }

        public int InsertUgovor(Ugovor ugovor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("INSERT INTO Ugovori VALUES('{0}','{1}',{2},{3})", 
                    ugovor.datum_potpisivanja, ugovor.datum_isteka,ugovor.id_kosarkasa,ugovor.id_kluba);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

    }
}
