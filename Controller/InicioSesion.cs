using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace cPaciente.Controller
{
    class InicioSesion:ConexionDatos
    {
     

        public string ObtenerCodigo(string usuario, string contraseña)
        {
            string codigo;
            try
            {
                conectarbd.Open();
                string consulta = string.Format("select * from usuarios where Usuario ='{0}' and contraseña='{1}';", usuario, contraseña);
                comando = new System.Data.SqlClient.SqlCommand(consulta, conectarbd);
                adaptador = new System.Data.SqlClient.SqlDataAdapter(comando);
                datos = new DataTable();
                adaptador.Fill(datos);
                if (datos.Rows.Count == 1)
                {
                    codigo = datos.Rows[0]["CodigoPersonal"].ToString();
                }
                else
                    codigo = "0";
            }
            catch (Exception){
                codigo = "0";
            }
            conectarbd.Close();

            return codigo;
        }

        public bool AutorizarIngreso(string user, string pass) {
            string codigo;
            try
                {
                    codigo = ObtenerCodigo(user, pass);
                    conectarbd.Open();
                    string consulta = string.Format("select idcargo from personal where CodigoPersonal = "+codigo);
                    comando = new System.Data.SqlClient.SqlCommand(consulta, conectarbd);
                    adaptador = new System.Data.SqlClient.SqlDataAdapter(comando);
                    datos = new DataTable();
                    adaptador.Fill(datos);

                if (datos.Rows[0]["idcargo"].ToString() == "1")
                {
                    View.Admin.FormBase afb = new View.Admin.FormBase();
                    afb.codigoUser = codigo;
                    afb.Show();
                }

                else if (datos.Rows[0]["idcargo"].ToString() == "2")
                {
                    View.Medico.FormBase mfb = new View.Medico.FormBase();
                    mfb.codigoUser = codigo;
                    mfb.Show();

                }
                else {
                    View.Secretaria.FormBase sfb = new View.Secretaria.FormBase();
                    sfb.codigoUser = codigo;
                    sfb.Show();
                }
                    return true;


                }
                catch (Exception) {
                    return false;
                }
             } 
         
        }
        
    }

