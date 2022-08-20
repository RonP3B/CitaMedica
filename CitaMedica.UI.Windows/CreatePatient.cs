using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class CreatePatient : Form
    {
        private string imagePath = "";

        public CreatePatient()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "JPG File|*.jpg|PNG File|*.png|ICO File|*.ico|All File|*.*"
            };

            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = open_file_dialog.FileName;
                txt_foto.Text = open_file_dialog.SafeFileName;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string nombre, telefono, Correo, foto;

            nombre = txt_nombre.Text;
            telefono = txt_telefono.Text;
            Correo = txt_Correo.Text;
            foto = txt_foto.Text;


            if (nombre != "" && telefono != "" && Correo != "" && foto != "")
            {
                PacienteModel newPaciente = new PacienteModel();
                PacienteData ObjPacienteData = new PacienteData();

                newPaciente.NombrePaciente = txt_nombre.Text;
                newPaciente.TelefonoPaciente = txt_telefono.Text;
                newPaciente.CorreoPaciente = txt_Correo.Text;
                newPaciente.FotoPaciente = imagePath;

                ObjPacienteData.CreatePatient(newPaciente);

                RadMessageBox.Show(
                       this,
                       "Paciente creado con éxito",
                       "Mensaje del sistema",
                       MessageBoxButtons.OK,
                       RadMessageIcon.Info
                );

                Close();

            }
            else
            {
                RadMessageBox.Show(
                       this,
                       "Debes llenar todos los campos",
                       "Mensaje del sistema",
                       MessageBoxButtons.OK,
                       RadMessageIcon.Exclamation
                );
            }
        }
    }
}
