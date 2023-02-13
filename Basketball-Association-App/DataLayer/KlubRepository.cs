using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KlubRepository
    {

        public List<Klub> GetKlubs()
        {

            using (SqlConnection conn = new SqlConnection(ConstantParameters.connString))
            {
                
                SqlCommand sql = new SqlCommand();

                sql.Connection = conn;
                
                sql.CommandText = ("SELECT * FROM Klubovi");

                List<Klub> ls = new List<Klub>();

                conn.Open();

                SqlDataReader dataReader = sql.ExecuteReader();

                while(dataReader.Read())
                {
                    Klub k = new Klub();

                    k.Id = dataReader.GetInt32(0);

                    k.Naziv = dataReader.GetString(1);

                    k.Lokacija = dataReader.GetString(2);

                    ls.Add(k);

                }

                return ls;
            }

        }

        public int InsertKlub(Klub klub)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("INSERT INTO Klubovi VALUES('{0}',{1},)", klub.Naziv, klub.Lokacija);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

        public int Deleteklub(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("DELETE FROM Klubovi WHERE Id={0}", id);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

        public int UpdateKlubName(int id, string newName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("UPDATE Klubovi SET naziv={1} WHERE Id={0}", id, newName);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

        public Klub GetKlubById(int id)
        {

            using(SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("SELECT * FROM Klubovi WHERE Id={0}", id);

                sqlConnection.Open();

                SqlDataReader dataReader= sql.ExecuteReader();

                Klub klub = new Klub();

                klub.Id = dataReader.GetInt32(0);

                klub.Naziv = dataReader.GetString(1);

                klub.Lokacija= dataReader.GetString(2);

                return klub;
            }

        }
    }

    
}
