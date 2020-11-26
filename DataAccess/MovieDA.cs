using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace DataAccess
{
    public class MovieDA:conexionbd
    {
        public DataTable getMovies()
        {

            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "Movies";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;

                }

            }
            
        }
        //agregar pelicula

        public void addMovie(string title,string genre,DateTime releaseDate,Byte photo,string actors)
        {

            using(var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "AppMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@genres", genre);
                    command.Parameters.AddWithValue("@releaseDate", releaseDate);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@actors", actors);
                   
                    memorystream 

                }
            }
        }
    }
}
