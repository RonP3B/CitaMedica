using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class CreateAppoinment : Form
    {
        public CreateAppoinment()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_crear_Click(object sender, System.EventArgs e)
        {
            string idPaciente, idDoctor, lugar, tratamiento;

            idPaciente = txt_idPaciente.Text;
            idDoctor = txt_idDoctor.Text;
            lugar = txt_lugar.Text;
            tratamiento = txt_tratamiento.Text;

            if (idPaciente != "" && idDoctor != "" && lugar != "" && tratamiento != "")
            {
                CitaModel newCita = new CitaModel();
                CitaData ObjCitaData = new CitaData();

                newCita.IdPaciente = Convert.ToInt32(idPaciente);
                newCita.IdDoctor = Convert.ToInt32(idDoctor);
                newCita.LugarCita = lugar;
                newCita.Tratamiento = tratamiento;
                newCita.FechaCita = fecha.Value;

                ObjCitaData.CreateAppoinment(newCita);

                RadMessageBox.Show(
                       this,
                       "Cita creada con éxito",
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
