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
    public partial class Treatments : Form
    {
        public Treatments()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show(
               this,
               "El formulario se ha enviado correctamente",
               "Mensaje del sistema",
               MessageBoxButtons.OK,
               RadMessageIcon.Info
            );

            Close();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show(
               this,
               "El formulario se ha guardado correctamente",
               "Mensaje del sistema",
               MessageBoxButtons.OK,
               RadMessageIcon.Info
            );

            Close();
        }
    }
}
