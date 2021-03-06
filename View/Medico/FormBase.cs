﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPaciente.View.Medico
{
    public partial class FormBase : Form
    {
        Button botonActual;
        bool pantallaCompleta;

        public FormBase()
        {
            InitializeComponent();
            toolTipBase.Active = false;
            AbrirFormulario<FormInicio>();
        }        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Horarios";
                AbrirFormulario<FormHorario>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Consultas";
                AbrirFormulario<FormConsulta>();
                botonActual = (Button)sender;
                CambioColor();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (sender != botonActual)
            {
                this.Text = "cPaciente - Citas";
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
            Button[] boton = { btnPerfil, btnConsulta, btnHorarios, btnCitas, btnSalir };
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
            btnConsulta.Text = String.Empty;
            btnHorarios.Text = String.Empty;
            btnCitas.Text = String.Empty;
            btnSalir.Text = String.Empty;
        }

        private void MostrarTextoBotones()
        {
            btnPerfil.Text = "  Mi Perfil";
            btnHorarios.Text = "  Horarios";
            btnConsulta.Text = "     Consultas";
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

    }
}
