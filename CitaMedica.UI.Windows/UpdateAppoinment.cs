using CitaMedica.Data.DataManagement;
using CitaMedica.Data.Models;
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
    public partial class UpdateAppoinment : Form
    {
        CitaData citaData = new CitaData();
        CitaModel citaModel;

        public UpdateAppoinment(int id)
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("MaterialTeal");

            citaModel = citaData.readAppoinment(id).Item2;

            txt_idPaciente.Text = citaModel.IdPaciente.ToString();
            txt_idDoctor.Text = citaModel.IdDoctor.ToString();
            txt_lugar.Text = citaModel.LugarCita;
            txt_tratamiento.Text = citaModel.Tratamiento;
            fecha.Value = citaModel.FechaCita;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
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

                ObjCitaData.updateAppoinment(citaModel.IdCita, newCita);

                RadMessageBox.Show(
                       this,
                       "Cita editada con éxito",
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
