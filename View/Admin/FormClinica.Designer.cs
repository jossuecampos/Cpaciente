namespace cPaciente.View.Admin
{
    partial class FormClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClinica));
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.tlPersonal = new System.Windows.Forms.TableLayoutPanel();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tlHorario = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.lbHorario = new System.Windows.Forms.Label();
            this.gbUbicacion = new System.Windows.Forms.GroupBox();
            this.tlUbicacion = new System.Windows.Forms.TableLayoutPanel();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.lbDir = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.tlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlPerfil = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.pbImgPerfil = new System.Windows.Forms.PictureBox();
            this.tlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lbDirActual = new System.Windows.Forms.Label();
            this.lbTelActual = new System.Windows.Forms.Label();
            this.lbCorreoActual = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tlPanel.SuspendLayout();
            this.gbContacto.SuspendLayout();
            this.tlPersonal.SuspendLayout();
            this.tlHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).BeginInit();
            this.gbUbicacion.SuspendLayout();
            this.tlUbicacion.SuspendLayout();
            this.tlBotones.SuspendLayout();
            this.tlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfil)).BeginInit();
            this.tlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 4;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.534734F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.22283F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5163F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.534734F));
            this.tlPanel.Controls.Add(this.gbContacto, 1, 1);
            this.tlPanel.Controls.Add(this.gbUbicacion, 2, 1);
            this.tlPanel.Controls.Add(this.tlBotones, 2, 2);
            this.tlPanel.Controls.Add(this.tlPerfil, 1, 0);
            this.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlPanel.Location = new System.Drawing.Point(0, 0);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 3;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.62366F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.37634F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlPanel.Size = new System.Drawing.Size(736, 511);
            this.tlPanel.TabIndex = 0;
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.tlPersonal);
            this.gbContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContacto.Location = new System.Drawing.Point(14, 257);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(371, 205);
            this.gbContacto.TabIndex = 9;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contácto";
            // 
            // tlPersonal
            // 
            this.tlPersonal.ColumnCount = 2;
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlPersonal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlPersonal.Controls.Add(this.lbCorreo, 0, 1);
            this.tlPersonal.Controls.Add(this.tbCorreo, 1, 1);
            this.tlPersonal.Controls.Add(this.lbTel, 0, 2);
            this.tlPersonal.Controls.Add(this.tbTel, 1, 2);
            this.tlPersonal.Controls.Add(this.tlHorario, 1, 3);
            this.tlPersonal.Controls.Add(this.lbHorario, 0, 3);
            this.tlPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonal.Location = new System.Drawing.Point(3, 26);
            this.tlPersonal.Name = "tlPersonal";
            this.tlPersonal.RowCount = 5;
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPersonal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPersonal.Size = new System.Drawing.Size(365, 176);
            this.tlPersonal.TabIndex = 15;
            // 
            // lbCorreo
            // 
            this.lbCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(3, 20);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(140, 39);
            this.lbCorreo.TabIndex = 15;
            this.lbCorreo.Text = "Correo:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(149, 23);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(213, 23);
            this.tbCorreo.TabIndex = 18;
            // 
            // lbTel
            // 
            this.lbTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(3, 59);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(140, 39);
            this.lbTel.TabIndex = 16;
            this.lbTel.Text = "Teléfono:";
            // 
            // tbTel
            // 
            this.tbTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTel.Location = new System.Drawing.Point(149, 62);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(213, 23);
            this.tbTel.TabIndex = 19;
            // 
            // tlHorario
            // 
            this.tlHorario.ColumnCount = 2;
            this.tlHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlHorario.Controls.Add(this.numericUpDown1, 1, 0);
            this.tlHorario.Controls.Add(this.nudHoraInicio, 0, 0);
            this.tlHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlHorario.Location = new System.Drawing.Point(149, 101);
            this.tlHorario.Name = "tlHorario";
            this.tlHorario.RowCount = 1;
            this.tlHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlHorario.Size = new System.Drawing.Size(213, 33);
            this.tlHorario.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(109, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 24);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nudHoraInicio
            // 
            this.nudHoraInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoraInicio.Location = new System.Drawing.Point(3, 3);
            this.nudHoraInicio.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.nudHoraInicio.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHoraInicio.Name = "nudHoraInicio";
            this.nudHoraInicio.Size = new System.Drawing.Size(100, 24);
            this.nudHoraInicio.TabIndex = 0;
            this.nudHoraInicio.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbHorario
            // 
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(3, 98);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(131, 31);
            this.lbHorario.TabIndex = 20;
            this.lbHorario.Text = "Horario:";
            // 
            // gbUbicacion
            // 
            this.gbUbicacion.Controls.Add(this.tlUbicacion);
            this.gbUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUbicacion.Location = new System.Drawing.Point(391, 257);
            this.gbUbicacion.Name = "gbUbicacion";
            this.gbUbicacion.Size = new System.Drawing.Size(329, 205);
            this.gbUbicacion.TabIndex = 10;
            this.gbUbicacion.TabStop = false;
            this.gbUbicacion.Text = "Ubicación";
            // 
            // tlUbicacion
            // 
            this.tlUbicacion.ColumnCount = 2;
            this.tlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlUbicacion.Controls.Add(this.tbDir, 1, 3);
            this.tlUbicacion.Controls.Add(this.lbDir, 0, 3);
            this.tlUbicacion.Controls.Add(this.lbDepartamento, 0, 1);
            this.tlUbicacion.Controls.Add(this.lbMunicipio, 0, 2);
            this.tlUbicacion.Controls.Add(this.cbMunicipio, 1, 2);
            this.tlUbicacion.Controls.Add(this.cbDepartamento, 1, 1);
            this.tlUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUbicacion.Location = new System.Drawing.Point(3, 26);
            this.tlUbicacion.Name = "tlUbicacion";
            this.tlUbicacion.RowCount = 4;
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlUbicacion.Size = new System.Drawing.Size(323, 176);
            this.tlUbicacion.TabIndex = 17;
            // 
            // tbDir
            // 
            this.tbDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDir.Location = new System.Drawing.Point(132, 126);
            this.tbDir.Multiline = true;
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(188, 47);
            this.tbDir.TabIndex = 22;
            // 
            // lbDir
            // 
            this.lbDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDir.Location = new System.Drawing.Point(3, 123);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(123, 53);
            this.lbDir.TabIndex = 17;
            this.lbDir.Text = "Dirección:";
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartamento.Location = new System.Drawing.Point(3, 20);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(123, 51);
            this.lbDepartamento.TabIndex = 14;
            this.lbDepartamento.Text = "Departamento:";
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMunicipio.Location = new System.Drawing.Point(3, 71);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(123, 52);
            this.lbMunicipio.TabIndex = 15;
            this.lbMunicipio.Text = "Municipio:";
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(132, 74);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(188, 24);
            this.cbMunicipio.TabIndex = 15;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(132, 23);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(188, 24);
            this.cbDepartamento.TabIndex = 0;
            this.cbDepartamento.SelectedValueChanged += new System.EventHandler(this.cbDepartamento_SelectedValueChanged);
            // 
            // tlBotones
            // 
            this.tlBotones.ColumnCount = 2;
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Controls.Add(this.btnActualizar, 0, 0);
            this.tlBotones.Controls.Add(this.btnCancelar, 1, 0);
            this.tlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBotones.Location = new System.Drawing.Point(391, 468);
            this.tlBotones.Name = "tlBotones";
            this.tlBotones.RowCount = 1;
            this.tlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlBotones.Size = new System.Drawing.Size(329, 40);
            this.tlBotones.TabIndex = 14;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Location = new System.Drawing.Point(3, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(158, 34);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(167, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tlPerfil
            // 
            this.tlPerfil.ColumnCount = 2;
            this.tlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlPerfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tlPerfil.Controls.Add(this.btnCambiarImagen, 0, 3);
            this.tlPerfil.Controls.Add(this.pbImgPerfil, 0, 1);
            this.tlPerfil.Controls.Add(this.tlDatos, 1, 1);
            this.tlPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPerfil.Location = new System.Drawing.Point(14, 3);
            this.tlPerfil.Name = "tlPerfil";
            this.tlPerfil.RowCount = 5;
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.82645F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.30303F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65289F));
            this.tlPerfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21763F));
            this.tlPerfil.Size = new System.Drawing.Size(371, 248);
            this.tlPerfil.TabIndex = 15;
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarImagen.Location = new System.Drawing.Point(3, 172);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(144, 35);
            this.btnCambiarImagen.TabIndex = 0;
            this.btnCambiarImagen.Text = "Cambiar imagen";
            this.btnCambiarImagen.UseVisualStyleBackColor = true;
            // 
            // pbImgPerfil
            // 
            this.pbImgPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbImgPerfil.Image")));
            this.pbImgPerfil.Location = new System.Drawing.Point(3, 32);
            this.pbImgPerfil.Name = "pbImgPerfil";
            this.pbImgPerfil.Size = new System.Drawing.Size(144, 129);
            this.pbImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgPerfil.TabIndex = 2;
            this.pbImgPerfil.TabStop = false;
            // 
            // tlDatos
            // 
            this.tlDatos.ColumnCount = 1;
            this.tlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDatos.Controls.Add(this.lbDirActual, 0, 4);
            this.tlDatos.Controls.Add(this.lbTelActual, 0, 3);
            this.tlDatos.Controls.Add(this.lbCorreoActual, 0, 2);
            this.tlDatos.Controls.Add(this.lbNombre, 0, 1);
            this.tlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDatos.Location = new System.Drawing.Point(153, 32);
            this.tlDatos.Name = "tlDatos";
            this.tlDatos.RowCount = 5;
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDatos.Size = new System.Drawing.Size(215, 129);
            this.tlDatos.TabIndex = 3;
            // 
            // lbDirActual
            // 
            this.lbDirActual.AutoSize = true;
            this.lbDirActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDirActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirActual.Location = new System.Drawing.Point(3, 100);
            this.lbDirActual.Name = "lbDirActual";
            this.lbDirActual.Size = new System.Drawing.Size(52, 29);
            this.lbDirActual.TabIndex = 4;
            this.lbDirActual.Text = "Dirección";
            this.lbDirActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTelActual
            // 
            this.lbTelActual.AutoSize = true;
            this.lbTelActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTelActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelActual.Location = new System.Drawing.Point(3, 75);
            this.lbTelActual.Name = "lbTelActual";
            this.lbTelActual.Size = new System.Drawing.Size(62, 25);
            this.lbTelActual.TabIndex = 3;
            this.lbTelActual.Text = "Teléfono";
            this.lbTelActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCorreoActual
            // 
            this.lbCorreoActual.AutoSize = true;
            this.lbCorreoActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCorreoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreoActual.Location = new System.Drawing.Point(3, 50);
            this.lbCorreoActual.Name = "lbCorreoActual";
            this.lbCorreoActual.Size = new System.Drawing.Size(49, 25);
            this.lbCorreoActual.TabIndex = 2;
            this.lbCorreoActual.Text = "Correo";
            this.lbCorreoActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(3, 25);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(93, 25);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.tlPanel);
            this.Name = "FormClinica";
            this.Text = "FormClinica";
            this.Load += new System.EventHandler(this.FormClinica_Load);
            this.tlPanel.ResumeLayout(false);
            this.gbContacto.ResumeLayout(false);
            this.tlPersonal.ResumeLayout(false);
            this.tlPersonal.PerformLayout();
            this.tlHorario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).EndInit();
            this.gbUbicacion.ResumeLayout(false);
            this.tlUbicacion.ResumeLayout(false);
            this.tlUbicacion.PerformLayout();
            this.tlBotones.ResumeLayout(false);
            this.tlPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPerfil)).EndInit();
            this.tlDatos.ResumeLayout(false);
            this.tlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.GroupBox gbUbicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlPersonal;
        private System.Windows.Forms.TableLayoutPanel tlUbicacion;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.TableLayoutPanel tlBotones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel tlPerfil;
        private System.Windows.Forms.Button btnCambiarImagen;
        private System.Windows.Forms.PictureBox pbImgPerfil;
        private System.Windows.Forms.TableLayoutPanel tlDatos;
        private System.Windows.Forms.Label lbDirActual;
        private System.Windows.Forms.Label lbTelActual;
        private System.Windows.Forms.Label lbCorreoActual;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.TableLayoutPanel tlHorario;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nudHoraInicio;
    }
}