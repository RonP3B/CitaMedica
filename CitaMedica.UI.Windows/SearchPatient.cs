using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CitaMedica.UI.Windows
{
    public partial class SearchPatient : Form
    {
        public int id = 0;

        public SearchPatient()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            id = -1;
            Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text != "")
            {
                id = Convert.ToInt32(txt_Id.Text);
                Close();
            }
            else
            {
                RadMessageBox.Show(
                  this,
                   "Debes llenar el campo.",
                   "Mensaje del sistema",
                   MessageBoxButtons.OK,
                   RadMessageIcon.Exclamation
                );
            }
            Close();
        }
    }
}
