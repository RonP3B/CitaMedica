using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class CreateDoctor : Form
    {
        private string imagePath = "";

        public CreateDoctor()
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
            

            string nombre, telefono, usuario, clave, foto;

            nombre = txt_nombre.Text;
            telefono = txt_telefono.Text;
            usuario = txt_usuario.Text;
            clave = txt_contrasennia.Text;
            foto = txt_foto.Text;


            if (nombre != "" && telefono != "" && usuario != "" && clave != "" && foto != "")
            {
                DoctorModel newDoctor = new DoctorModel();
                DoctorData ObjDoctorData = new DoctorData();

                newDoctor.NombreDoctor = txt_nombre.Text;
                newDoctor.TelefonoDoctor = txt_telefono.Text;
                newDoctor.UserDoctor = txt_usuario.Text;
                newDoctor.PasswordDoctor = txt_contrasennia.Text;
                newDoctor.FotoDoctor = imagePath;

                ObjDoctorData.CreateDoctor(newDoctor);

                RadMessageBox.Show(
                       this,
                       "Doctor creado con éxito",
                       "Mensaje del sistema",
                       MessageBoxButtons.OK,
                       RadMessageIcon.Info
                );

                Close();


            } else
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
