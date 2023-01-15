using DataLayer.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KosarkasRepository
    {

        public List<Kosarkas> GetKosarkasi()
        {
            using (SqlConnection conn = new SqlConnection(ConstantParameters.connString))
            {

                SqlCommand sql = new SqlCommand();

                sql.Connection = conn;

                sql.CommandText = ("SELECT * FROM Kosarkasi");

                List<Kosarkas> ls = new List<Kosarkas>();

                conn.Open();

                SqlDataReader dataReader = sql.ExecuteReader();

                while (dataReader.Read())
                {
                    Kosarkas k = new Kosarkas();

                    k.Id = dataReader.GetInt32(0);

                    k.Ime = dataReader.GetString(1);

                    k.Prezime = dataReader.GetString(2);

                    k.datum_rodjenja = dataReader.GetDateTime(3);

                    ls.Add(k);

                }

                return ls;
            }

        }


        public int InsertKosarkas(Kosarkas kosarkas)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("INSERT INTO Kosarkasi VALUES('{0}',{1},)", kosarkas.Ime, kosarkas.Prezime, kosarkas.datum_rodjenja);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }

        public int DeleteKosarkas(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConstantParameters.connString))
            {
                SqlCommand sql = new SqlCommand();

                sql.Connection = sqlConnection;

                sql.CommandText = string.Format("DELETE FROM Kosarkasi WHERE Id={0}", id);

                sqlConnection.Open();

                return sql.ExecuteNonQuery();
            }
        }


    }
}
