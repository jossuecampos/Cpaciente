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
    class Usuarios:ConexionDatos 
    {
        public string MostrarUsuario(string codigo)
        {
            conectarbd.Open();
            comando = new SqlCommand(("select concat(nombres, ' ', apellidos) as Empleado from personal where CodigoPersonal = " + codigo), conectarbd);
            lector = comando.ExecuteReader();

            if (lector.Read())
                return lector[0].ToString();
            else
                return "Usuario no encontrado";

            conectarbd.Close();
        }
    }
}
