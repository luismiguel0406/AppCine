using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
   public class ActorDA:conexionbd
    {

        public DataTable getActors()
        {

            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "Actors";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }

        //agregar actores

        public void AddActor(string Name, DateTime birthDay, string gender,byte[] photo, string details)
        {
            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "AddActor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@birthDay", birthDay);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@details", details);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }

        }
        //editar actores

        public void editActor(int idActor, string Name, DateTime birthDay, string gender, byte[] photo, string details)
        {
            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "editActor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@birthDay", birthDay);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@photo", photo);
                    command.Parameters.AddWithValue("@details", details);
                    command.Parameters.AddWithValue("@idActor", idActor);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }

        }
        //eliminar actor

        public void deleteActor(int idActor) {

            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = "DeleteMovie";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idActor", idActor);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        //obtener foto del actor
        public byte[] getPhotoActor(int id, byte[] photo)
        {
            using (var db = getConnection())
            {
                db.Open();
                using (var command = new SqlCommand())
                {
                    byte[] result;
                    command.Connection = db;
                    command.CommandText = "getPhotoActor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idActor", id);
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
