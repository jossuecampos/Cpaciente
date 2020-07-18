using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cPaciente.View.Admin;

namespace cPaciente.View
{
    public partial class FormLogin : Form
    {
       
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Controller.InicioSesion log = new Controller.InicioSesion();
            string user = txtUser.Text;
            string pass = txtxPassword.Text;

            if (log.AutorizarIngreso(user, pass) == true)
            { 
                Hide();
            }
            else
                MessageBox.Show("Acceso denegado", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception) { }
        }
    }
}
