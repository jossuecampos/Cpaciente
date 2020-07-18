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
    public partial class FormBase : Form
    {
        Button botonActual;
        bool pantallaCompleta;
        public string codigoUser;
        public FormBase()
        {
            InitializeComponent();
            toolTipBase.Active = false;
            
         //   AbrirFormulario<FormInicio>();

            //formulario = new MiForm();
          
        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            log.Show();
            Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Mi Perfil";
                AbrirFormulario<FormPerfil>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnClinica_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Clínica";
                AbrirFormulario<FormClinica>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Personal";
                AbrirFormulario<FormPersonal>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Cita";
                AbrirFormulario<FormCita>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenido.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario != null)
            {
                formulario.Close();
            }

            formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formulario);
            panelContenido.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        private void CambioColor()
        {
            Button[] boton = { btnPerfil, btnClinica, btnPersonal, btnCitas, btnSalir };
            foreach (Button btn in boton)
            {
                btn.BackColor = Color.SkyBlue;
            }
            botonActual.BackColor = Color.PowderBlue;
        }

        private void btnColapsar_Click(object sender, EventArgs e)
        {
            pLateralNormal = new Size(160, panelLateral.Size.Height);
            pLateralMin = new Size(45, panelLateral.Size.Height);

            if (panelLateral.Size == pLateralNormal)
            {
                OcultarTextoBotones();
                panelLateral.Size = pLateralMin;

                if (panelLateral.Dock == DockStyle.Left)
                {
                    btnRotar.Location = cPanelMinIzquierda;
                    btnColapsar.Location = botonColapsarMinIzquierda;
                }
                else
                {
                    btnRotar.Location = cPanelDerecha;
                    btnColapsar.Location = botonColapsarDerecha;
                }
                toolTipBase.Active = true;
            }
            else
            {
                MostrarTextoBotones();
                panelLateral.Size = pLateralNormal;

                if (panelLateral.Dock == DockStyle.Left)
                {
                    btnRotar.Location = cPanelMaxIzquierda;
                    btnColapsar.Location = botonColapsarMaxIzquierda;
                }
                else
                {
                    btnRotar.Location = cPanelDerecha;
                    btnColapsar.Location = botonColapsarDerecha;
                }

                toolTipBase.Active = false;
            }
        }

        private void OcultarTextoBotones()
        {
            btnPerfil.Text = String.Empty;
            btnClinica.Text = String.Empty;
            btnPersonal.Text = String.Empty;
            btnCitas.Text = String.Empty;
            btnSalir.Text = String.Empty;
        }

        private void MostrarTextoBotones()
        {
            btnPerfil.Text = "  Mi Perfil";
            btnClinica.Text = "Clínica";
            btnPersonal.Text = "   Personal";
            btnCitas.Text = "          Citas";
            btnSalir.Text = "           Salir";
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            if (panelLateral.Dock == DockStyle.Left)
            {
                btnColapsar.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                btnRotar.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom);
                panelLateral.Dock = DockStyle.Right;
                btnRotar.Location = cPanelDerecha;
                btnColapsar.Location = botonColapsarDerecha;
            }
            else
            {
                btnColapsar.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
                btnRotar.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
                panelLateral.Dock = DockStyle.Left;
                if (panelLateral.Size == pLateralNormal)
                {
                    btnRotar.Location = cPanelMaxIzquierda;
                    btnColapsar.Location = botonColapsarMaxIzquierda;
                }
                else
                {
                    btnRotar.Location = cPanelMinIzquierda;
                    btnColapsar.Location = botonColapsarMinIzquierda;
                }
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (pantallaCompleta)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(900,550);
                this.CenterToScreen();
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
            }

            pantallaCompleta = !pantallaCompleta;
        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.Show();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

            Admin.FormInicio fi = new Admin.FormInicio();
           // MessageBox.Show(codigoUser);
            fi.TopLevel = false;
            fi.FormBorderStyle = FormBorderStyle.None;
            fi.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(fi);
            panelContenido.Tag = fi;
            fi.codEmpleado = codigoUser;
            fi.Show();
            fi.BringToFront();
        }
    }
}
