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
    class Clinica : ConexionDatos
    {

        public string ObtenerDato(string dato) {
            string resultado;
            try
            {
                conectarbd.Open();
                comando = new SqlCommand("select " + dato + " from clinica", conectarbd);
                lector = comando.ExecuteReader();

                if (lector.Read())
                    resultado = lector[0].ToString();
                else
                    resultado = "Error al cargar";
                conectarbd.Close();

            }
            catch (Exception)
            {
                resultado = "Error de consulta a la base de datos";
            }
            return resultado;
        }


        public string ObtenerNombre() {
            return ObtenerDato("nombre");

        }

        public string ObtenerCorreo() {

            return ObtenerDato("correo");
        }

        public string ObtenerTelefono() {
            return ObtenerDato("telefono");
        }

        public string ObtenerDireccion() {
            string resultado;
            try
            {
                conectarbd.Open();
                comando = new SqlCommand("execute Verdireccio", conectarbd);
                lector = comando.ExecuteReader();

                if (lector.Read())
                    resultado = lector[0].ToString();
                else
                    resultado = "Error al cargar";
                conectarbd.Close();

            }
            catch (Exception)
            {
                resultado = "Error de consulta a la base de datos";
            }
            return resultado;
        }
    }
}
