namespace CapaPresentacion
{
    partial class FrmNuevoPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoPerfil));
            this.pnlNuevoPerfil = new System.Windows.Forms.Panel();
            this.grbPerfilTesis = new System.Windows.Forms.GroupBox();
            this.cmbTutorElegido = new System.Windows.Forms.ComboBox();
            this.btnElegirTutor = new System.Windows.Forms.Button();
            this.dtFechaAprobacion = new System.Windows.Forms.DateTimePicker();
            this.dtFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.txtTemaTesis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarNuevop = new System.Windows.Forms.Button();
            this.btnGuardarNuevoP = new System.Windows.Forms.Button();
            this.grbAlumno = new System.Windows.Forms.GroupBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelularAlum = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailAlum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoAlum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreAlum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegistroAlum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlNuevoPerfil.SuspendLayout();
            this.grbPerfilTesis.SuspendLayout();
            this.grbAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNuevoPerfil
            // 
            this.pnlNuevoPerfil.BackColor = System.Drawing.Color.Silver;
            this.pnlNuevoPerfil.Controls.Add(this.grbPerfilTesis);
            this.pnlNuevoPerfil.Controls.Add(this.btnCancelarNuevop);
            this.pnlNuevoPerfil.Controls.Add(this.btnGuardarNuevoP);
            this.pnlNuevoPerfil.Controls.Add(this.grbAlumno);
            this.pnlNuevoPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNuevoPerfil.Location = new System.Drawing.Point(5, 4);
            this.pnlNuevoPerfil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlNuevoPerfil.Name = "pnlNuevoPerfil";
            this.pnlNuevoPerfil.Size = new System.Drawing.Size(2125, 1368);
            this.pnlNuevoPerfil.TabIndex = 34;
            this.pnlNuevoPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNuevoPerfil_Paint);
            // 
            // grbPerfilTesis
            // 
            this.grbPerfilTesis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbPerfilTesis.BackColor = System.Drawing.Color.Silver;
            this.grbPerfilTesis.Controls.Add(this.cmbTutorElegido);
            this.grbPerfilTesis.Controls.Add(this.btnElegirTutor);
            this.grbPerfilTesis.Controls.Add(this.dtFechaAprobacion);
            this.grbPerfilTesis.Controls.Add(this.dtFechaRecepcion);
            this.grbPerfilTesis.Controls.Add(this.txtTemaTesis);
            this.grbPerfilTesis.Controls.Add(this.label1);
            this.grbPerfilTesis.Controls.Add(this.label2);
            this.grbPerfilTesis.Controls.Add(this.label3);
            this.grbPerfilTesis.Controls.Add(this.label6);
            this.grbPerfilTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPerfilTesis.Location = new System.Drawing.Point(144, 606);
            this.grbPerfilTesis.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grbPerfilTesis.Name = "grbPerfilTesis";
            this.grbPerfilTesis.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grbPerfilTesis.Size = new System.Drawing.Size(1771, 448);
            this.grbPerfilTesis.TabIndex = 36;
            this.grbPerfilTesis.TabStop = false;
            this.grbPerfilTesis.Text = "PERFIL TESIS";
            // 
            // cmbTutorElegido
            // 
            this.cmbTutorElegido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTutorElegido.FormattingEnabled = true;
            this.cmbTutorElegido.Location = new System.Drawing.Point(478, 335);
            this.cmbTutorElegido.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmbTutorElegido.Name = "cmbTutorElegido";
            this.cmbTutorElegido.Size = new System.Drawing.Size(618, 47);
            this.cmbTutorElegido.TabIndex = 8;
            // 
            // btnElegirTutor
            // 
            this.btnElegirTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnElegirTutor.FlatAppearance.BorderSize = 0;
            this.btnElegirTutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnElegirTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirTutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElegirTutor.Location = new System.Drawing.Point(1176, 335);
            this.btnElegirTutor.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnElegirTutor.Name = "btnElegirTutor";
            this.btnElegirTutor.Size = new System.Drawing.Size(201, 58);
            this.btnElegirTutor.TabIndex = 4;
            this.btnElegirTutor.Text = "Elegir";
            this.btnElegirTutor.UseVisualStyleBackColor = false;
            this.btnElegirTutor.Click += new System.EventHandler(this.btnElegirTutor_Click);
            // 
            // dtFechaAprobacion
            // 
            this.dtFechaAprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaAprobacion.Location = new System.Drawing.Point(1115, 219);
            this.dtFechaAprobacion.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtFechaAprobacion.Name = "dtFechaAprobacion";
            this.dtFechaAprobacion.Size = new System.Drawing.Size(256, 46);
            this.dtFechaAprobacion.TabIndex = 3;
            // 
            // dtFechaRecepcion
            // 
            this.dtFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRecepcion.Location = new System.Drawing.Point(478, 219);
            this.dtFechaRecepcion.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtFechaRecepcion.Name = "dtFechaRecepcion";
            this.dtFechaRecepcion.Size = new System.Drawing.Size(256, 46);
            this.dtFechaRecepcion.TabIndex = 2;
            // 
            // txtTemaTesis
            // 
            this.txtTemaTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemaTesis.Location = new System.Drawing.Point(478, 105);
            this.txtTemaTesis.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTemaTesis.Name = "txtTemaTesis";
            this.txtTemaTesis.Size = new System.Drawing.Size(893, 46);
            this.txtTemaTesis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Aprobación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Recepción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tema:";
            // 
            // btnCancelarNuevop
            // 
            this.btnCancelarNuevop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarNuevop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelarNuevop.FlatAppearance.BorderSize = 0;
            this.btnCancelarNuevop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevop.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevop.Location = new System.Drawing.Point(1429, 1092);
            this.btnCancelarNuevop.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCancelarNuevop.Name = "btnCancelarNuevop";
            this.btnCancelarNuevop.Size = new System.Drawing.Size(233, 78);
            this.btnCancelarNuevop.TabIndex = 39;
            this.btnCancelarNuevop.Text = "Cancelar";
            this.btnCancelarNuevop.UseVisualStyleBackColor = false;
            this.btnCancelarNuevop.Click += new System.EventHandler(this.btnCancelarNuevop_Click);
            // 
            // btnGuardarNuevoP
            // 
            this.btnGuardarNuevoP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarNuevoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarNuevoP.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoP.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevoP.Location = new System.Drawing.Point(1677, 1092);
            this.btnGuardarNuevoP.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGuardarNuevoP.Name = "btnGuardarNuevoP";
            this.btnGuardarNuevoP.Size = new System.Drawing.Size(233, 78);
            this.btnGuardarNuevoP.TabIndex = 38;
            this.btnGuardarNuevoP.Text = "Guardar";
            this.btnGuardarNuevoP.UseVisualStyleBackColor = false;
            this.btnGuardarNuevoP.Click += new System.EventHandler(this.btnGuardarNuevoP_Click);
            // 
            // grbAlumno
            // 
            this.grbAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbAlumno.BackColor = System.Drawing.Color.Silver;
            this.grbAlumno.Controls.Add(this.cmbCarrera);
            this.grbAlumno.Controls.Add(this.label7);
            this.grbAlumno.Controls.Add(this.txtCelularAlum);
            this.grbAlumno.Controls.Add(this.txtTelefonoAlum);
            this.grbAlumno.Controls.Add(this.label8);
            this.grbAlumno.Controls.Add(this.label5);
            this.grbAlumno.Controls.Add(this.txtEmailAlum);
            this.grbAlumno.Controls.Add(this.label10);
            this.grbAlumno.Controls.Add(this.txtApellidoAlum);
            this.grbAlumno.Controls.Add(this.label11);
            this.grbAlumno.Controls.Add(this.txtNombreAlum);
            this.grbAlumno.Controls.Add(this.label12);
            this.grbAlumno.Controls.Add(this.txtRegistroAlum);
            this.grbAlumno.Controls.Add(this.label13);
            this.grbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlumno.Location = new System.Drawing.Point(144, 166);
            this.grbAlumno.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.grbAlumno.Name = "grbAlumno";
            this.grbAlumno.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.grbAlumno.Size = new System.Drawing.Size(1771, 402);
            this.grbAlumno.TabIndex = 35;
            this.grbAlumno.TabStop = false;
            this.grbAlumno.Text = "ALUMNO";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(1192, 114);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(508, 47);
            this.cmbCarrera.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(999, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Carrera:";
            // 
            // txtCelularAlum
            // 
            this.txtCelularAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularAlum.Location = new System.Drawing.Point(1192, 230);
            this.txtCelularAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtCelularAlum.Name = "txtCelularAlum";
            this.txtCelularAlum.Size = new System.Drawing.Size(508, 46);
            this.txtCelularAlum.TabIndex = 7;
            // 
            // txtTelefonoAlum
            // 
            this.txtTelefonoAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlum.Location = new System.Drawing.Point(1192, 172);
            this.txtTelefonoAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTelefonoAlum.MaxLength = 10;
            this.txtTelefonoAlum.Name = "txtTelefonoAlum";
            this.txtTelefonoAlum.Size = new System.Drawing.Size(508, 46);
            this.txtTelefonoAlum.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(980, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1003, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Celular:";
            // 
            // txtEmailAlum
            // 
            this.txtEmailAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAlum.Location = new System.Drawing.Point(303, 288);
            this.txtEmailAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtEmailAlum.Name = "txtEmailAlum";
            this.txtEmailAlum.Size = new System.Drawing.Size(583, 46);
            this.txtEmailAlum.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email:";
            // 
            // txtApellidoAlum
            // 
            this.txtApellidoAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAlum.Location = new System.Drawing.Point(303, 230);
            this.txtApellidoAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtApellidoAlum.Name = "txtApellidoAlum";
            this.txtApellidoAlum.Size = new System.Drawing.Size(583, 46);
            this.txtApellidoAlum.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Apellido:";
            // 
            // txtNombreAlum
            // 
            this.txtNombreAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlum.Location = new System.Drawing.Point(303, 172);
            this.txtNombreAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtNombreAlum.Name = "txtNombreAlum";
            this.txtNombreAlum.Size = new System.Drawing.Size(583, 46);
            this.txtNombreAlum.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(93, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 39);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre:";
            // 
            // txtRegistroAlum
            // 
            this.txtRegistroAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroAlum.Location = new System.Drawing.Point(303, 114);
            this.txtRegistroAlum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtRegistroAlum.Name = "txtRegistroAlum";
            this.txtRegistroAlum.Size = new System.Drawing.Size(583, 46);
            this.txtRegistroAlum.TabIndex = 1;
            this.txtRegistroAlum.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegistroAlum_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = "Registro:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmNuevoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2135, 1376);
            this.Controls.Add(this.pnlNuevoPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2135, 1376);
            this.Name = "FrmNuevoPerfil";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Perfil";
            this.pnlNuevoPerfil.ResumeLayout(false);
            this.grbPerfilTesis.ResumeLayout(false);
            this.grbPerfilTesis.PerformLayout();
            this.grbAlumno.ResumeLayout(false);
            this.grbAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNuevoPerfil;
        private System.Windows.Forms.GroupBox grbAlumno;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelularAlum;
        private System.Windows.Forms.TextBox txtTelefonoAlum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailAlum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellidoAlum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreAlum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRegistroAlum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grbPerfilTesis;
        private System.Windows.Forms.Button btnElegirTutor;
        private System.Windows.Forms.DateTimePicker dtFechaAprobacion;
        private System.Windows.Forms.DateTimePicker dtFechaRecepcion;
        private System.Windows.Forms.TextBox txtTemaTesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarNuevop;
        private System.Windows.Forms.Button btnGuardarNuevoP;
        private System.Windows.Forms.ComboBox cmbTutorElegido;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}