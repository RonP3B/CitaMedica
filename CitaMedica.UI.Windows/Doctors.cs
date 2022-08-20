using CitaMedica.Data.DataManagement;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class Doctors : Form
    {
        DoctorData objDoctorData = new DoctorData();

        public Doctors()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            DataTable table = objDoctorData.getAllDoctors();
            fillTable(table);
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            CreateDoctor createDoctor = new CreateDoctor();
            createDoctor.ShowDialog();

            DataTable table = objDoctorData.getAllDoctors();
            fillTable(table);
        }

        private void fillTable(DataTable table)
        {
            table.Columns.Add("Foto", Type.GetType("System.Byte[]")).SetOrdinal(0);
            
            foreach (DataRow row in table.Rows)
            {
                row["Foto"] = File.ReadAllBytes(row["FotoDoctor"].ToString());
            }
   
            table.Columns.Remove("FotoDoctor");

            dataView.DataSource = table;
            dataView.AutoResizeColumns();
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

            if (dataView.SelectedRows.Count == 1)
            {
                int selectedRow = dataView.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdDoctor"].Value);

                UpdateDoctor updateDoctor = new UpdateDoctor(id);
                updateDoctor.ShowDialog();

                DataTable table = objDoctorData.getAllDoctors();
                fillTable(table);
            }
            else
            {
                RadMessageBox.Show(
                   this,
                   "Debes seleccionar al doctor que deseas editar",
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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            SearchDoctor searchDoctor = new SearchDoctor();
            searchDoctor.ShowDialog();


            if (searchDoctor.id == -1) return;

            if (searchDoctor.id != 0)
            {
                DataTable dataTable = objDoctorData.readDoctor(searchDoctor.id).Item1;

                if (dataTable.Rows.Count == 0)
                {
                    RadMessageBox.Show(
                        this,
                        "El doctor que buscó no existe",
                        "Mensaje del sistema",
                        MessageBoxButtons.OK,
                        RadMessageIcon.Info
                    );

                    return;
                }

                fillTable(dataTable);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count == 1)
            {

                int selectedRow = dataView.SelectedRows[0].Index;
                int Id = Convert.ToInt32(dataView.Rows[selectedRow].Cells["IdDoctor"].Value);
                string nombre = dataView.Rows[selectedRow].Cells["NombreDoctor"].Value.ToString();

                DialogResult response = RadMessageBox.Show(
                    this,
                    "Estas seguro que desea eliminar al doctor '" + nombre + "'",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    RadMessageIcon.Exclamation
                );

                if (response == DialogResult.Yes)
                {
                    objDoctorData.deleteDoctor(Id);

                    RadMessageBox.Show(
                           this,
                           "El Doctor: '" + nombre + "' ha sido eliminado",
                           "Mensaje del sistema",
                           MessageBoxButtons.OK,
                           RadMessageIcon.Info
                    );

                    DataTable table = objDoctorData.getAllDoctors();
                    fillTable(table);

                }
                
            }

            else
            {
                RadMessageBox.Show(
                    this,
                    "Debes seleccionar al doctor que deseas eliminar",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation
                );
            }
        }
    }
}
