namespace cPaciente.View.Medico
{
    partial class FormInicio
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
            this.tlInicio = new System.Windows.Forms.TableLayoutPanel();
            this.lbSaludo = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timerInicio = new System.Windows.Forms.Timer(this.components);
            this.tlInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlInicio
            // 
            this.tlInicio.ColumnCount = 3;
            this.tlInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlInicio.Controls.Add(this.lbSaludo, 1, 1);
            this.tlInicio.Controls.Add(this.lbFecha, 1, 3);
            this.tlInicio.Controls.Add(this.lbHora, 1, 5);
            this.tlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlInicio.Location = new System.Drawing.Point(0, 0);
            this.tlInicio.Name = "tlInicio";
            this.tlInicio.RowCount = 7;
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.90728F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24503F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.622517F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24503F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.622517F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24503F));
            this.tlInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11258F));
            this.tlInicio.Size = new System.Drawing.Size(736, 511);
            this.tlInicio.TabIndex = 0;
            // 
            // lbSaludo
            // 
            this.lbSaludo.AutoSize = true;
            this.lbSaludo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSaludo.Font = new System.Drawing.Font("Oswald", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaludo.Location = new System.Drawing.Point(39, 71);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(656, 67);
            this.lbSaludo.TabIndex = 0;
            this.lbSaludo.Text = "Bienvenido, @usuario";
            this.lbSaludo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFecha.Font = new System.Drawing.Font("Oswald", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(39, 171);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(656, 67);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHora.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(39, 271);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(656, 67);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerInicio
            // 
            this.timerInicio.Tick += new System.EventHandler(this.timerInicio_Tick);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlInicio);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.tlInicio.ResumeLayout(false);
            this.tlInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlInicio;
        private System.Windows.Forms.Label lbSaludo;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timerInicio;
    }
}