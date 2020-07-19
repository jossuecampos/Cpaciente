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
    public partial class FormClinica : Form
    {
        Controller.Clinica c = new Controller.Clinica();


        public FormClinica()
        {
            InitializeComponent();
        }

        private void FormClinica_Load(object sender, EventArgs e)
        {
            lbNombre.Text = c.ObtenerNombre();
            lbCorreoActual.Text  = c.ObtenerCorreo();
            lbTelActual.Text = c.ObtenerTelefono();
            lbDirActual.Text = c.ObtenerDireccion();
            c.CargarComboBox("select * from Departamentos", cbDepartamento, "Nombre_Departamento", "IDDepartamento");
            cbDepartamento.SelectedValue = 6;
            tbCorreo.Text = c.ObtenerCorreo();
            tbDir.Text = c.ObtenerDireccion();
            tbTel.Text = c.ObtenerTelefono();
        }

        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            c.CargarComboBox("select IDMunicipio, Nombre_Municipio from Municipios where IDDepartamento = "+cbDepartamento.SelectedValue, cbMunicipio, "Nombre_Municipio", "IDMunicipio");
        }
    }
}
