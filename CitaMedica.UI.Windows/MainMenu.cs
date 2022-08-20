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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
            Lbl_user.Text = "Usuario: " + Program.Username;
        }

        public void addDocument(string title, Form childForm, Form parent)
        {
            childForm.Text = title;
            childForm.MdiParent = parent;
            childForm.Show();
        }

        private void btn_acercaDe_Click(object sender, EventArgs e)
        {
            About childForm = new About();
            addDocument("Acerca del programa", childForm, this);
        }

        private void btn_tratamientos_Click(object sender, EventArgs e)
        {
            Treatments childForm = new Treatments();
            addDocument("Ventana tratamientos", childForm, this);
        }

        private void btn_doctores_Click(object sender, EventArgs e)
        {
            Doctors childForm = new Doctors();
            addDocument("Ventana doctores", childForm, this);
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            Appoinments childForm = new Appoinments();
            addDocument("Ventana citas", childForm, this);
        }

        private void btn_pacientes_Click(object sender, EventArgs e)
        {
            Patients childForm = new Patients();
            addDocument("Ventana pacientes", childForm, this);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();

            this.IsMdiContainer = true;
            this.radDock1.AutoDetectMdiChildren = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = "Hora actual: " + DateTime.Now.ToShortTimeString();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
             DialogResult response = RadMessageBox.Show(
                 this,
                 "Estas seguro que deseas salir del programa",
                 "Mensaje del sistema",
                 MessageBoxButtons.YesNo,
                 RadMessageIcon.Question
            );

            if (response == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
