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
    public class PacienteData
    {
        public void CreatePatient(PacienteModel newPaciente)
        {
            string query =
                "INSERT INTO Paciente " +
                    "(FotoPaciente, IdPaciente, NombrePaciente, TelefonoPaciente, CorreoPaciente)" +
                " VALUES" +
                    "(?Foto, NULL, ?Nombre, ?Telefono, ?Correo);";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {

                ObjMySqlCommand.Parameters.AddWithValue("?Foto", newPaciente.FotoPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Nombre", newPaciente.NombrePaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Correo", newPaciente.CorreoPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Telefono", newPaciente.TelefonoPaciente);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                  "Ha ocurrido un error al crear el paciente\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }

        public DataTable getAllPatients()
        {
            string query = "SELECT * FROM Paciente";

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
                   "Ha ocurrido  un error al obtener los pacientes\nExcepción: " + e
                );
            }

            return null;

        }

        public void updatePatient(int Id, PacienteModel updatedPatient)
        {
            if (updatedPatient == null) return;

            string query =
                "UPDATE Paciente " +
                    "SET FotoPaciente = ?Foto," +
                    "NombrePaciente = ?Nombre," +
                    "TelefonoPaciente = ?Telefono," +
                    "CorreoPaciente =  ?Correo" +
                " WHERE Paciente.IdPaciente = ?ID";

            MySqlConnection ObjMySqlConnection = DBConnection.StringConnectionDB();
            MySqlCommand ObjMySqlCommand = new MySqlCommand(query, ObjMySqlConnection);

            try
            {
                ObjMySqlCommand.Parameters.AddWithValue("?Foto", updatedPatient.FotoPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Nombre", updatedPatient.NombrePaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Correo", updatedPatient.CorreoPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?Telefono", updatedPatient.TelefonoPaciente);
                ObjMySqlCommand.Parameters.AddWithValue("?ID", Id);

                ObjMySqlConnection.Open();
                ObjMySqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "Ha ocurrido un error al intentar actualizar el paciente\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }

        public Tuple<DataTable, PacienteModel> readPatient(int id)
        {

            string query = "SELECT * FROM Paciente WHERE IdPaciente = ?Id";

            DataTable ObjDataTable = null;
            PacienteModel searchedPatient = null;

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
                    searchedPatient = new PacienteModel();

                    searchedPatient.IdPaciente = Convert.ToInt32(row["IdPaciente"]);
                    searchedPatient.FotoPaciente = row["FotoPaciente"] == null ? "" : row["FotoPaciente"].ToString();
                    searchedPatient.NombrePaciente = row["NombrePaciente"] == null ? "" : row["NombrePaciente"].ToString();
                    searchedPatient.TelefonoPaciente = row["TelefonoPaciente"] == null ? "" : row["TelefonoPaciente"].ToString();
                    searchedPatient.CorreoPaciente = row["CorreoPaciente"] == null ? "" : row["CorreoPaciente"].ToString();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(
                   "No fue posible obtener el paciente\nExcepción: " + e
                );
            }

            return Tuple.Create(ObjDataTable, searchedPatient);
        }

        public void deletePatient(int ID)
        {
            if (ID < 1) return;

            string query = "DELETE FROM Paciente WHERE Paciente.IdPaciente = ?id";

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
                   "Ha ocurrido un error al intentar eliminar el paciente\nExcepción: " + e
                );
            }
            finally
            {
                ObjMySqlConnection.Close();
            }
        }
    }
}
