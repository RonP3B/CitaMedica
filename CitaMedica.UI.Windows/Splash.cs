using CitaMedica.Data;
using System;
using System.Windows.Forms;

namespace CitaMedica.UI.Windows
{
    public partial class Splash : Form
    {
        private int Start = 0;

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start += 2;
            progressBar.Value = Start;

            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DBConnection.StringConnectionDB();
        }
    }
}
