namespace cPaciente.View.Medico
{
    partial class FormHorario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tlHorario = new System.Windows.Forms.TableLayoutPanel();
            this.dgHorario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Horario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tlHorario
            // 
            this.tlHorario.ColumnCount = 1;
            this.tlHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlHorario.Controls.Add(this.dgHorario, 0, 2);
            this.tlHorario.Controls.Add(this.btnAgregar, 0, 1);
            this.tlHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlHorario.Location = new System.Drawing.Point(0, 0);
            this.tlHorario.Name = "tlHorario";
            this.tlHorario.RowCount = 4;
            this.tlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25865F));
            this.tlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5668F));
            this.tlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.174539F));
            this.tlHorario.Size = new System.Drawing.Size(736, 511);
            this.tlHorario.TabIndex = 1;
            // 
            // dgHorario
            // 
            this.dgHorario.AllowUserToAddRows = false;
            this.dgHorario.AllowUserToDeleteRows = false;
            this.dgHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHorario.Location = new System.Drawing.Point(3, 110);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.ReadOnly = true;
            this.dgHorario.Size = new System.Drawing.Size(730, 392);
            this.dgHorario.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Día";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora de llegada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora de salida";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Opciones";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlHorario);
            this.Name = "FormHorario";
            this.Text = "FormHorario";
            this.tlHorario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TableLayoutPanel tlHorario;
        private System.Windows.Forms.DataGridView dgHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}