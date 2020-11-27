using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;



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
        
        public void addMovie(string title,string genre,DateTime releaseDate,byte[] photo,string actors)
        {
                        
            using(var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "AddMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@genres", genre);
                    command.Parameters.AddWithValue("@releaseDate", releaseDate);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@actors", actors);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    
                }
            }
        }
        //editar pelicula
        public void editMovie(int idMovie, string title, string genre, DateTime releaseDate, byte[] photo, string actors)
        {
            photo = null;

            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "editMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@releaseDate", releaseDate);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@actors", actors);
                    command.Parameters.AddWithValue("@idMovie", idMovie);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }

        }

        //eliminar pelicula
        public void deleteMovie(int idMovie)
        {
            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "deleteMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idMovie", idMovie);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        //imagen pelicula

        public byte[] getPhotoMovie(int id,byte[]photo)
        {
            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    byte[] result;
                    command.Connection = db;
                    command.CommandText = "getPhotoMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idMovie", id);
                    var reader = command.ExecuteReader();
                    reader.Read();
                    photo = (byte[])reader["Foto"];
                    result = photo;
                    command.Parameters.Clear();
                    return result;

                }
                
            }
            
            

        }
    }
}
