using CitaMedica.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CitaMedica.Data.DataManagement
{
    public class CitaData
    {
        public void CreateAppoinment(CitaModel newCita)
        {
            string query =
                "INSERT INTO Cita " +
                    "(IdCita, IdDoctor, IdPaciente, Tratamiento, LugarCita, FechaCita)" +
                " VALUES" +
                    "(NULL, ?IdDoctor, ?IdPaciente, ?Tratamiento, ?LugarCita ,?FechaCita);";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {

                ObjMySqlCommand.Parameters.AddWithValue("?IdDoctor", newCita.IdDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?IdPaciente", newCita.IdPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Tratamiento", newCita.Tratamiento);
                ObjMySqlCommand.Parameters.AddWithValue("?FechaCita", newCita.FechaCita);
                ObjMySqlCommand.Parameters.AddWithValue("?LugarCita", newCita.LugarCita);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                  "Ha ocurrido un error al la cita\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }

        public DataTable getAllAppoinments()
        {
            string query = "SELECT * FROM Cita";

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
                   "Ha ocurrido  un error al obtener las citas\nExcepción: " + e
                );
            }

            return null;

        }

        public void updateAppoinment(int Id, CitaModel updatedAppoiment)
        {
            if (updatedAppoiment == null) return;

            string query =
                "UPDATE Cita " +
                    "SET IdDoctor = ?IdDoctor," +
                    "IdPaciente = ?IdPaciente," +
                    "Tratamiento = ?Tratamiento," +
                    "LugarCita = ?LugarCita," +
                    "FechaCita = ?FechaCita" +
                " WHERE Cita.IdCita = ?ID";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                ObjMySqlCommand.Parameters.AddWithValue("?IdDoctor", updatedAppoiment.IdDoctor);
                ObjMySqlCommand.Parameters.AddWithValue("?IdPaciente", updatedAppoiment.IdPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Tratamiento", updatedAppoiment.Tratamiento);
                ObjMySqlCommand.Parameters.AddWithValue("?LugarCita", updatedAppoiment.LugarCita);
                ObjMySqlCommand.Parameters.AddWithValue("?FechaCita", updatedAppoiment.FechaCita);
                ObjMySqlCommand.Parameters.AddWithValue("?ID", Id);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "Ha ocurrido un error al intentar actualizar la cita\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }

        public Tuple<DataTable, CitaModel> readAppoinment(int id)
        {

            string query = "SELECT * FROM Cita WHERE IdCita = ?Id";

            DataTable ObjDataTable = null;
            CitaModel searchedAppoinment = null;

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
                    searchedAppoinment = new CitaModel();

                    searchedAppoinment.IdCita = Convert.ToInt32(row["IdCita"]);
                    searchedAppoinment.IdPaciente = Convert.ToInt32(row["IdPaciente"]);
                    searchedAppoinment.IdDoctor = Convert.ToInt32(row["IdDoctor"]);
                    searchedAppoinment.Tratamiento = row["Tratamiento"] == null ? "" : row["Tratamiento"].ToString();
                    searchedAppoinment.LugarCita = row["LugarCita"] == null ? "" : row["LugarCita"].ToString();
                    searchedAppoinment.FechaCita = (DateTime) row["FechaCita"];
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "No fue posible obtener la cita\nExcepción: " + e
                );
            }

            return Tuple.Create(ObjDataTable, searchedAppoinment);
        }

        public void deleteAppoinment(int ID)
        {
            if (ID < 1) return;

            string query = "DELETE FROM Cita WHERE Cita.IdCita = ?id";

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
                   "Ha ocurrido un error al intentar eliminar la cita\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }
    }
}
