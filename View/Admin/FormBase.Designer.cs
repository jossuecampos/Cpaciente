namespace cPaciente.View.Admin
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlMenuBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnClinica = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnColapsar = new System.Windows.Forms.PictureBox();
            this.btnRotar = new System.Windows.Forms.PictureBox();
            this.toolTipBase = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.tlMenuBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnColapsar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.SkyBlue;
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.tlMenuBase);
            resources.ApplyResources(this.panelLateral, "panelLateral");
            this.panelLateral.Name = "panelLateral";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tlMenuBase
            // 
            resources.ApplyResources(this.tlMenuBase, "tlMenuBase");
            this.tlMenuBase.Controls.Add(this.btnFullScreen, 0, 6);
            this.tlMenuBase.Controls.Add(this.btnSalir, 0, 8);
            this.tlMenuBase.Controls.Add(this.btnCitas, 0, 4);
            this.tlMenuBase.Controls.Add(this.btnPerfil, 0, 1);
            this.tlMenuBase.Controls.Add(this.btnClinica, 0, 2);
            this.tlMenuBase.Controls.Add(this.btnPersonal, 0, 3);
            this.tlMenuBase.Controls.Add(this.btnColapsar, 0, 0);
            this.tlMenuBase.Controls.Add(this.btnRotar, 0, 9);
            this.tlMenuBase.Name = "tlMenuBase";
            // 
            // btnFullScreen
            // 
            resources.ApplyResources(this.btnFullScreen, "btnFullScreen");
            this.btnFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnFullScreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFullScreen.Name = "btnFullScreen";
            this.toolTipBase.SetToolTip(this.btnFullScreen, resources.GetString("btnFullScreen.ToolTip"));
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir.Name = "btnSalir";
            this.toolTipBase.SetToolTip(this.btnSalir, resources.GetString("btnSalir.ToolTip"));
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCitas
            // 
            resources.ApplyResources(this.btnCitas, "btnCitas");
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnCitas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCitas.Name = "btnCitas";
            this.toolTipBase.SetToolTip(this.btnCitas, resources.GetString("btnCitas.ToolTip"));
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPerfil
            // 
            resources.ApplyResources(this.btnPerfil, "btnPerfil");
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPerfil.Name = "btnPerfil";
            this.toolTipBase.SetToolTip(this.btnPerfil, resources.GetString("btnPerfil.ToolTip"));
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnClinica
            // 
            resources.ApplyResources(this.btnClinica, "btnClinica");
            this.btnClinica.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClinica.FlatAppearance.BorderSize = 0;
            this.btnClinica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClinica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnClinica.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClinica.Name = "btnClinica";
            this.toolTipBase.SetToolTip(this.btnClinica, resources.GetString("btnClinica.ToolTip"));
            this.btnClinica.UseVisualStyleBackColor = true;
            this.btnClinica.Click += new System.EventHandler(this.btnClinica_Click);
            // 
            // btnPersonal
            // 
            resources.ApplyResources(this.btnPersonal, "btnPersonal");
            this.btnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPersonal.Name = "btnPersonal";
            this.toolTipBase.SetToolTip(this.btnPersonal, resources.GetString("btnPersonal.ToolTip"));
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnColapsar
            // 
            resources.ApplyResources(this.btnColapsar, "btnColapsar");
            this.btnColapsar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColapsar.Name = "btnColapsar";
            this.btnColapsar.TabStop = false;
            this.btnColapsar.Click += new System.EventHandler(this.btnColapsar_Click);
            // 
            // btnRotar
            // 
            resources.ApplyResources(this.btnRotar, "btnRotar");
            this.btnRotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.TabStop = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // panelContenido
            // 
            resources.ApplyResources(this.panelContenido, "panelContenido");
            this.panelContenido.Name = "panelContenido";
            // 
            // FormBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLateral);
            this.Name = "FormBase";
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.tlMenuBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnColapsar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClinica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.PictureBox btnColapsar;
        private System.Windows.Forms.PictureBox btnRotar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.ToolTip toolTipBase;

        //PictureBox para modificar tamaño de Panel Lateral
        private System.Drawing.Size anchoNormal = new System.Drawing.Size(160, 511);
        private System.Drawing.Size pLateralNormal = new System.Drawing.Size(160, 511);
        private System.Drawing.Size pLateralMin = new System.Drawing.Size(45, 522);
        //Posición donde aparece la imagen de cambiar panel de derecha a izquierda
        private System.Drawing.Point cPanelMinIzquierda = new System.Drawing.Point(19, 488);
        private System.Drawing.Point cPanelMaxIzquierda = new System.Drawing.Point(124, 488);
        private System.Drawing.Point cPanelDerecha = new System.Drawing.Point(2, 488);
        //Posición del PictureBox para cambiar tamaño de Panel Lateral
        private System.Drawing.Point botonColapsarMaxIzquierda = new System.Drawing.Point(128, 2);
        private System.Drawing.Point botonColapsarMinIzquierda = new System.Drawing.Point(23, 2);
        private System.Drawing.Point botonColapsarDerecha = new System.Drawing.Point(2, 2);

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.TableLayoutPanel tlMenuBase;
        private System.Windows.Forms.Button btnFullScreen;
    }
}