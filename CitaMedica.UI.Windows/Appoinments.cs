using CitaMedica.Data.DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class Appoinments : Form
    {
        CitaData citaData = new CitaData();

        public Appoinments()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void fillTable(DataTable table)
        {
            dataView.DataSource = table;
            dataView.AutoResizeColumns();
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {

                int selectedRow = dataView.SelectedRows[0].Index;
                int Id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdCita"].Value);

                DialogResult response = RadMessageBox.Show(
                    this,
                    "Estas seguro que desea eliminar la cita de id '" + Id + "'",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    RadMessageIcon.Exclamation
                );

                if (response == DialogResult.Yes)
                {
                    citaData.deleteAppoinment(Id);

                    RadMessageBox.Show(
                           this,
                           "La cita de id: '" + Id + "' ha sido eliminado",
                           "Mensaje del sistema",
                           MessageBoxButtons.OK,
                           RadMessageIcon.Info
                    );

                    DataTable table = citaData.getAllAppoinments();
                    fillTable(table);

                }

            }

            else
            {
                RadMessageBox.Show(
                    this,
                    "Debes seleccionar la cita que deseas eliminar",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation
                );
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SearchAppoinment searchAppoinment = new SearchAppoinment();
            searchAppoinment.ShowDialog();

            if (searchAppoinment.id == -1) return;

            if (searchAppoinment.id != 0)
            {
                DataTable dataTable = citaData.readAppoinment(searchAppoinment.id).Item1;

                if (dataTable.Rows.Count == 0)
                {
                    RadMessageBox.Show(
                        this,
                        "La cita que buscó no existe",
                        "Mensaje del sistema",
                        MessageBoxButtons.OK,
                        RadMessageIcon.Info
                    );

                    return;
                }

                fillTable(dataTable);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {
                int selectedRow = dataView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdCita"].Value);

                UpdateAppoinment updatePatient = new UpdateAppoinment(id);
                updatePatient.ShowDialog();

                DataTable table = citaData.getAllAppoinments();
                fillTable(table);
            }
            else
            {
                RadMessageBox.Show(
                   this,
                   "Debes seleccionar la cita que deseas editar",
                   "Mensaje del sistema",
                   MessageBoxButtons.OK,
                   RadMessageIcon.Exclamation
               );
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            CreateAppoinment createAppoinment = new CreateAppoinment();
            createAppoinment.ShowDialog();

            DataTable table = citaData.getAllAppoinments();
            fillTable(table);
        }

        private void Appoinments_Load(object sender, EventArgs e)
        {
            DataTable table = citaData.getAllAppoinments();
            fillTable(table);
        }

        private void dataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataView.Rows.Count > 0) dataView.Rows[0].Selected = false;
        }
    }
}
