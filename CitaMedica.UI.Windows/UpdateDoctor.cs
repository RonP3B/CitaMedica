using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class UpdateDoctor : Form
    {

        DoctorData doctorData = new DoctorData();
        DoctorModel doctorModel;

        public UpdateDoctor(int id)
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");

            doctorModel = doctorData.readDoctor(id).Item2;

            txt_nombre.Text= doctorModel.NombreDoctor;
            txt_telefono.Text = doctorModel.TelefonoDoctor;
            txt_usuario.Text = doctorModel.UserDoctor;
            txt_contrasennia.Text = doctorModel.PasswordDoctor;
            txt_foto.Text = doctorModel.FotoDoctor;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_actulizar_Click(object sender, EventArgs e)
        {
            string nombre, telefono, usuario, clave, foto;

            nombre = txt_nombre.Text;
            telefono = txt_telefono.Text;
            usuario = txt_usuario.Text;
            clave = txt_contrasennia.Text;
            foto = txt_foto.Text;


            if (nombre != "" && telefono != "" && usuario != "" && clave != "" && foto != "")
            {
                DoctorModel newDoctor = new DoctorModel();

                newDoctor.NombreDoctor = nombre;
                newDoctor.TelefonoDoctor = telefono;
                newDoctor.FotoDoctor = foto;
                newDoctor.UserDoctor = usuario;
                newDoctor.PasswordDoctor = clave;


                doctorData.updateDoctor(doctorModel.IdDoctor, newDoctor);

                RadMessageBox.Show(
                  this,
                   "El doctor se ha editado con éxito.",
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
