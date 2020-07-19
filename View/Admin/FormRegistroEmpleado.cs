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
    public partial class FormRegistroEmpleado : Form
    {
        Controller.ConexionDatos cd = new Controller.ConexionDatos();
        public FormRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRegistroEmpleado_Load(object sender, EventArgs e)
        {
            cd.CargarComboBox("Select IDDepartamento, Nombre_Departamento from departamentos", cboDepartamento, "Nombre_Departamento", "IDDepartamento");
            cd.CargarComboBox("Select IDCargo, Nombre_Cargo from cargos", cboCargo, "Nombre_Cargo", "IDCargo");
        }

        private void cboDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            cd.CargarComboBox("Select IDMunicipio, Nombre_Municipio from municipios where IDDepartamento = "+cboDepartamento.SelectedValue, cboMunicipio, "Nombre_Municipio", "IDMunicipio");
        }
    }
}
