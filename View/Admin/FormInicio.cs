using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPaciente.View.Admin
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            timerInicio.Enabled = true;
        }


        private void timerInicio_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbFecha.Text = fecha.Substring(0, 1).ToUpper() + fecha.Substring(1, fecha.Length - 1);

            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
