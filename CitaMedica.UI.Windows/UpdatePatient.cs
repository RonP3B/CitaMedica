using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class UpdatePatient : Form
    {

        PacienteData pacienteData = new PacienteData();
        PacienteModel pacienteModel;

        public UpdatePatient(int id)
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");

            pacienteModel = pacienteData.readPatient(id).Item2;

            txt_nombre.Text = pacienteModel.NombrePaciente;
            txt_telefono.Text = pacienteModel.TelefonoPaciente;
            txt_Correo.Text = pacienteModel.CorreoPaciente;
            txt_foto.Text = pacienteModel.FotoPaciente;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string nombre, telefono, correo, foto;

            nombre = txt_nombre.Text;
            telefono = txt_telefono.Text;
            correo = txt_Correo.Text;
            foto = txt_foto.Text;


            if (nombre != "" && telefono != "" && correo != "" && foto != "")
            {
                PacienteModel newPatient = new PacienteModel();

                newPatient.NombrePaciente = nombre;
                newPatient.TelefonoPaciente = telefono;
                newPatient.FotoPaciente = foto;
                newPatient.CorreoPaciente = correo;

                pacienteData.updatePatient(pacienteModel.IdPaciente, newPatient);

                RadMessageBox.Show(
                  this,
                   "El paciente se ha editado con éxito.",
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
