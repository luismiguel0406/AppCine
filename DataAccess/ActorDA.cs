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

        public DataTable Actors()
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

        public void AddActor(string Name, DateTime birthDay, string gender,byte photo, string details)
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

                    //metodo para la foto

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }

        }
        //editar actores

        public void editActor(int idActor, string Name, DateTime birthDay, string gender, byte photo, string details)
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

                    //metodo para la foto
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
    }
}
