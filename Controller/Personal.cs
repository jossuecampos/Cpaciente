using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace cPaciente.Controller
{
    class Personal:ConexionDatos 
    {
        public void ListarEmpleados(DataGridView dg) {
            CargarDatagrid("select concat(p.nombres, ' ', p.Apellidos) as [Nombre], p.Telefono, p.Email, c.Nombre_Cargo as [Cargo] from personal p inner join cargos c on c.IDCargo = p.IDCargo", dg);
        }

        public void FiltrarEmpleado(DataGridView dg, string filtro, string valor) {
            string consulta = "select concat(p.nombres, ' ', p.Apellidos) as [Nombre], p.Telefono, p.Email, c.Nombre_Cargo as [Cargo] from personal p inner join cargos c on c.IDCargo = p.IDCargo where " + filtro + "='" + valor+"';";
            CargarDatagrid(consulta, dg);
        }
    }
}
