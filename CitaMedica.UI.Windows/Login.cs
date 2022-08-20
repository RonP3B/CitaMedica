using CitaMedica.Data.DataManagement;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            DoctorData ObjDoctorData = new DoctorData();

            string User = "", Pass = "";

            User = txt_usuario.Text;
            Pass = txt_pass.Text;

            if (User == "" || Pass == "")
            {

                RadMessageBox.Show(
                   this,
                   "Debes llenar los campos",
                   "Mensaje del sistema",
                   MessageBoxButtons.OK,
                   RadMessageIcon.Exclamation
               );
            }

            else if (ObjDoctorData.isAuthenticated(User, Pass))
            {
                Program.UserAuthenticated = true;
                Program.Username = User;
                Close();
            }

            else
            {
                Program.UserAuthenticated = false;

                RadMessageBox.Show(
                    this,
                    "Datos ingresados incorrectos",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation
                );
            }
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            CreateDoctor createDoctor = new CreateDoctor();
            createDoctor.ShowDialog();
        }
    }
}
