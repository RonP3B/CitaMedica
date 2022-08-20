using CitaMedica.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitaMedica.Data.DataManagement
{
    public class DoctorData
    {
        public bool isAuthenticated(string user, string password)
        {

            string query = "SELECT * FROM Doctor WHERE UserDoctor = '" + user + "' AND PasswordDoctor = '" + password + "'";
            bool result = false;

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                ObjMySqlConnection.Open();
                MySqlDataReader ObjMySqlDataReader = ObjMySqlCommand.ExecuteReader();
                result = ObjMySqlDataReader.HasRows;
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                    "Ha ocurrido una excepción al intentar verificar el usuario\nExcepción: " + e
                );
            }

            finally
            {
                ObjMySqlConnection.Close();
            }

            return result;
        }

        public void CreateDoctor (DoctorModel newDoctor)
        {
            string query = 
                "INSERT INTO Doctor " +
                    "(FotoDoctor, IdDoctor, NombreDoctor, UserDoctor, PasswordDoctor, TelefonoDoctor)" +
                " VALUES" +
                    "(?FotoDoctor, NULL, ?NombreDoctor, ?UserDoctor, ?PasswordDoctor, ?TelefonoDoctor);";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {

                ObjMySqlCommand.Parameters.AddWithValue("?FotoDoctor", newDoctor.FotoDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?NombreDoctor", newDoctor.NombreDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?UserDoctor", newDoctor.UserDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?PasswordDoctor", newDoctor.PasswordDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?TelefonoDoctor", newDoctor.TelefonoDoctor);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                  "Ha ocurrido un error al crear el usuario\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }

        public DataTable getAllDoctors()
        {
            string query = "SELECT * FROM Doctor";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                MySqlDataAdapter ObjMySqlDataAdapter = new MySqlDataAdapter(ObjMySqlCommand);


                DataTable ObjDataTable = new DataTable();
                ObjMySqlDataAdapter.Fill(ObjDataTable);

                return ObjDataTable;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "Ha ocurrido  un error al obtener los doctores\nExcepción: " + e
                );
            }

            return null;

        }

        public void updateDoctor(int Id, DoctorModel updatedDoctor)
        {
            if (updatedDoctor == null) return;
       
            string query = 
                "UPDATE " +
                    "Doctor SET NombreDoctor = ?Nombre," +
                    "UserDoctor = ?User," +
                    "PasswordDoctor = ?Pass," +
                    "TelefonoDoctor = ?Tel " +
                "WHERE " +
                    " Doctor.IdDoctor = ?ID";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                ObjMySqlCommand.Parameters.AddWithValue("?Nombre", updatedDoctor.NombreDoctor); 
                ObjMySqlCommand.Parameters.AddWithValue("?User", updatedDoctor.UserDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?Pass", updatedDoctor.PasswordDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?Tel", updatedDoctor.TelefonoDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?ID", Id);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "Ha ocurrido un error al intentar actualizar el doctor\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
    }

        public Tuple<DataTable, DoctorModel> readDoctor(int id)
        {

            string query = "SELECT * FROM Doctor WHERE IdDoctor = ?Id";

            DataTable ObjDataTable = null;
            DoctorModel searchedDoctor = null;

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);


            try
            {
                MySqlDataAdapter ObjSqlDataAdapter = new MySqlDataAdapter(ObjMySqlCommand);
                ObjMySqlCommand.Parameters.AddWithValue("?Id", id);


                ObjDataTable = new DataTable();
                ObjSqlDataAdapter.Fill(ObjDataTable);

                if (ObjDataTable.Rows.Count == 1)
                {
                    DataRow row = ObjDataTable.Rows[0];
                    searchedDoctor = new DoctorModel();

                    searchedDoctor.IdDoctor = Convert.ToInt32(row["IdDoctor"]);
                    searchedDoctor.FotoDoctor = row["FotoDoctor"] == null ? "" : row["FotoDoctor"].ToString();
                    searchedDoctor.NombreDoctor = row["NombreDoctor"] == null ? "" : row["NombreDoctor"].ToString();
                    searchedDoctor.TelefonoDoctor = row["TelefonoDoctor"] == null ? "" : row["TelefonoDoctor"].ToString();
                    searchedDoctor.UserDoctor = row["UserDoctor"] == null ? "" : row["UserDoctor"].ToString();
                    searchedDoctor.PasswordDoctor = row["PasswordDoctor"] == null ? "" : row["PasswordDoctor"].ToString();

                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "No fue posible obtener la entidad\nExcepción: " + e
                );
            }

            return Tuple.Create(ObjDataTable, searchedDoctor);
        }

        public void deleteDoctor(int ID)
        {
            if (ID < 1) return;

            string query = "DELETE FROM Doctor WHERE Doctor.IdDoctor = ?id";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                ObjMySqlCommand.Parameters.AddWithValue("?id", ID);
                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "Ha ocurrido un error al intentar eliminar el Doctor\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }
    }
}
