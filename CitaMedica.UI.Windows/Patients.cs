using CitaMedica.Data.DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class Patients : Form
    {
        PacienteData pacienteData = new PacienteData();

        public Patients()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void fillTable(DataTable table)
        {
            table.Columns.Add("Foto", Type.GetType("System.Byte[]")).SetOrdinal(0);

            foreach (DataRow row in table.Rows)
            {
                row["Foto"] = File.ReadAllBytes(row["FotoPaciente"].ToString());
            }

            table.Columns.Remove("FotoPaciente");


            dataView.DataSource = table;
            dataView.AutoResizeColumns();
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            CreatePatient createPatient = new CreatePatient();
            createPatient.ShowDialog();

            DataTable table = pacienteData.getAllPatients();
            fillTable(table);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            DataTable table = pacienteData.getAllPatients();
            fillTable(table);
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {
                int selectedRow = dataView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdPaciente"].Value);

                UpdatePatient updatePatient = new UpdatePatient(id);
                updatePatient.ShowDialog();

                DataTable table = pacienteData.getAllPatients();
                fillTable(table);
            }
            else
            {
                RadMessageBox.Show(
                   this,
                   "Debes seleccionar al paciente que deseas editar",
                   "Mensaje del sistema",
                   MessageBoxButtons.OK,
                   RadMessageIcon.Exclamation
               );
            }
        }

        private void dataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataView.Rows.Count > 0) dataView.Rows[0].Selected = false;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {

                int selectedRow = dataView.SelectedRows[0].Index;
                int Id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdPaciente"].Value);
                string nombre = dataView.Rows[selectedRow].Cells["NombrePaciente"].Value.ToString();

                DialogResult response = RadMessageBox.Show(
                    this,
                    "Estas seguro que desea eliminar al paciente '" + nombre + "'",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    RadMessageIcon.Exclamation
                );

                if (response == DialogResult.Yes)
                {
                    pacienteData.deletePatient(Id);

                    RadMessageBox.Show(
                           this,
                           "El paciente: '" + nombre + "' ha sido eliminado",
                           "Mensaje del sistema",
                           MessageBoxButtons.OK,
                           RadMessageIcon.Info
                    );

                    DataTable table = pacienteData.getAllPatients();
                    fillTable(table);

                }

            }

            else
            {
                RadMessageBox.Show(
                    this,
                    "Debes seleccionar al paciente que deseas eliminar",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation
                );
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            SearchPatient searchPatient = new SearchPatient();
            searchPatient.ShowDialog();


            if (searchPatient.id == -1) return;

            if (searchPatient.id != 0)
            {
                DataTable dataTable = pacienteData.readPatient(searchPatient.id).Item1;

                if (dataTable.Rows.Count == 0)
                {
                    RadMessageBox.Show(
                        this,
                        "El paciente que buscó no existe",
                        "Mensaje del sistema",
                        MessageBoxButtons.OK,
                        RadMessageIcon.Info
                    );

                    return;
                }

                fillTable(dataTable);
            }
        }
    }
}
