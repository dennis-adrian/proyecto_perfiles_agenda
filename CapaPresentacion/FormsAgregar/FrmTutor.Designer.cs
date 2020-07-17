﻿namespace CapaPresentacion
{
    partial class FrmTutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTutor));
            this.btnSeleccionarLicenciado = new System.Windows.Forms.Button();
            this.btnEditarLicenciado = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbid_licenciado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarInstitucion = new System.Windows.Forms.Button();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.cmbCarreraLicenciado = new System.Windows.Forms.ComboBox();
            this.rbDocenteNo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbDocenteSi = new System.Windows.Forms.RadioButton();
            this.btnGuardarLicenciado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailLicenciado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApellidoLicenciado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreLicenciado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgLicenciados = new System.Windows.Forms.DataGridView();
            this.pnlBarraTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLicenciados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarLicenciado
            // 
            this.btnSeleccionarLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSeleccionarLicenciado.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLicenciado.Location = new System.Drawing.Point(362, 439);
            this.btnSeleccionarLicenciado.Name = "btnSeleccionarLicenciado";
            this.btnSeleccionarLicenciado.Size = new System.Drawing.Size(122, 30);
            this.btnSeleccionarLicenciado.TabIndex = 24;
            this.btnSeleccionarLicenciado.Text = "Seleccionar";
            this.btnSeleccionarLicenciado.UseVisualStyleBackColor = false;
            this.btnSeleccionarLicenciado.Click += new System.EventHandler(this.btnSeleccionarLicenciado_Click);
            // 
            // btnEditarLicenciado
            // 
            this.btnEditarLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarLicenciado.FlatAppearance.BorderSize = 0;
            this.btnEditarLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnEditarLicenciado.Location = new System.Drawing.Point(492, 439);
            this.btnEditarLicenciado.Name = "btnEditarLicenciado";
            this.btnEditarLicenciado.Size = new System.Drawing.Size(122, 30);
            this.btnEditarLicenciado.TabIndex = 25;
            this.btnEditarLicenciado.Text = "Editar";
            this.btnEditarLicenciado.UseVisualStyleBackColor = false;
            this.btnEditarLicenciado.Click += new System.EventHandler(this.btnEditarLicenciado_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.label12);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1025, 27);
            this.pnlBarraTitulo.TabIndex = 27;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(507, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Licenciados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(990, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.lbid_licenciado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAgregarInstitucion);
            this.panel1.Controls.Add(this.btnAgregarCarrera);
            this.panel1.Controls.Add(this.cmbInstitucion);
            this.panel1.Controls.Add(this.cmbCarreraLicenciado);
            this.panel1.Controls.Add(this.rbDocenteNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbDocenteSi);
            this.panel1.Controls.Add(this.btnGuardarLicenciado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmailLicenciado);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtApellidoLicenciado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreLicenciado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(627, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 471);
            this.panel1.TabIndex = 28;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "externo",
            "interno"});
            this.cmbTipo.Location = new System.Drawing.Point(131, 297);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 26);
            this.cmbTipo.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(97, 425);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 33);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbid_licenciado
            // 
            this.lbid_licenciado.AutoSize = true;
            this.lbid_licenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid_licenciado.Location = new System.Drawing.Point(226, 8);
            this.lbid_licenciado.Name = "lbid_licenciado";
            this.lbid_licenciado.Size = new System.Drawing.Size(0, 18);
            this.lbid_licenciado.TabIndex = 36;
            this.lbid_licenciado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tipo :";
            // 
            // btnAgregarInstitucion
            // 
            this.btnAgregarInstitucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAgregarInstitucion.FlatAppearance.BorderSize = 0;
            this.btnAgregarInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInstitucion.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInstitucion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInstitucion.Location = new System.Drawing.Point(342, 337);
            this.btnAgregarInstitucion.Name = "btnAgregarInstitucion";
            this.btnAgregarInstitucion.Size = new System.Drawing.Size(29, 26);
            this.btnAgregarInstitucion.TabIndex = 33;
            this.btnAgregarInstitucion.Text = "+";
            this.btnAgregarInstitucion.UseVisualStyleBackColor = false;
            this.btnAgregarInstitucion.Click += new System.EventHandler(this.btnAgregarInstitucion_Click);
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAgregarCarrera.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrera.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrera.Location = new System.Drawing.Point(342, 381);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(29, 26);
            this.btnAgregarCarrera.TabIndex = 32;
            this.btnAgregarCarrera.Text = "+";
            this.btnAgregarCarrera.UseVisualStyleBackColor = false;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.btnAgregarCarrera_Click);
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Location = new System.Drawing.Point(128, 337);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(208, 26);
            this.cmbInstitucion.TabIndex = 9;
            // 
            // cmbCarreraLicenciado
            // 
            this.cmbCarreraLicenciado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreraLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreraLicenciado.FormattingEnabled = true;
            this.cmbCarreraLicenciado.Location = new System.Drawing.Point(128, 381);
            this.cmbCarreraLicenciado.Name = "cmbCarreraLicenciado";
            this.cmbCarreraLicenciado.Size = new System.Drawing.Size(208, 26);
            this.cmbCarreraLicenciado.TabIndex = 10;
            // 
            // rbDocenteNo
            // 
            this.rbDocenteNo.AutoSize = true;
            this.rbDocenteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocenteNo.Location = new System.Drawing.Point(212, 255);
            this.rbDocenteNo.Name = "rbDocenteNo";
            this.rbDocenteNo.Size = new System.Drawing.Size(49, 24);
            this.rbDocenteNo.TabIndex = 7;
            this.rbDocenteNo.TabStop = true;
            this.rbDocenteNo.Text = "No";
            this.rbDocenteNo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Institucion :";
            // 
            // rbDocenteSi
            // 
            this.rbDocenteSi.AutoSize = true;
            this.rbDocenteSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocenteSi.Location = new System.Drawing.Point(131, 254);
            this.rbDocenteSi.Name = "rbDocenteSi";
            this.rbDocenteSi.Size = new System.Drawing.Size(43, 24);
            this.rbDocenteSi.TabIndex = 6;
            this.rbDocenteSi.TabStop = true;
            this.rbDocenteSi.Text = "Si";
            this.rbDocenteSi.UseVisualStyleBackColor = true;
            // 
            // btnGuardarLicenciado
            // 
            this.btnGuardarLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarLicenciado.FlatAppearance.BorderSize = 0;
            this.btnGuardarLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarLicenciado.Location = new System.Drawing.Point(242, 425);
            this.btnGuardarLicenciado.Name = "btnGuardarLicenciado";
            this.btnGuardarLicenciado.Size = new System.Drawing.Size(129, 33);
            this.btnGuardarLicenciado.TabIndex = 11;
            this.btnGuardarLicenciado.Text = "Guardar";
            this.btnGuardarLicenciado.UseVisualStyleBackColor = false;
            this.btnGuardarLicenciado.Click += new System.EventHandler(this.btnGuardarLicenciado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Docente :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Carrera :";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(131, 214);
            this.txtCelular.MaxLength = 12;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(208, 24);
            this.txtCelular.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celular :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(131, 177);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(208, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono :";
            // 
            // txtEmailLicenciado
            // 
            this.txtEmailLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLicenciado.Location = new System.Drawing.Point(131, 134);
            this.txtEmailLicenciado.Name = "txtEmailLicenciado";
            this.txtEmailLicenciado.Size = new System.Drawing.Size(208, 24);
            this.txtEmailLicenciado.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(131, 95);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(208, 24);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Descripcion :";
            // 
            // txtApellidoLicenciado
            // 
            this.txtApellidoLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoLicenciado.Location = new System.Drawing.Point(131, 54);
            this.txtApellidoLicenciado.Name = "txtApellidoLicenciado";
            this.txtApellidoLicenciado.Size = new System.Drawing.Size(208, 24);
            this.txtApellidoLicenciado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido :";
            // 
            // txtNombreLicenciado
            // 
            this.txtNombreLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLicenciado.Location = new System.Drawing.Point(131, 15);
            this.txtNombreLicenciado.Name = "txtNombreLicenciado";
            this.txtNombreLicenciado.Size = new System.Drawing.Size(208, 24);
            this.txtNombreLicenciado.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Licenciados Disponibles";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgLicenciados);
            this.panel2.Location = new System.Drawing.Point(16, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 335);
            this.panel2.TabIndex = 32;
            // 
            // dtgLicenciados
            // 
            this.dtgLicenciados.AllowUserToAddRows = false;
            this.dtgLicenciados.AllowUserToDeleteRows = false;
            this.dtgLicenciados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLicenciados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgLicenciados.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgLicenciados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLicenciados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgLicenciados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLicenciados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLicenciados.ColumnHeadersHeight = 34;
            this.dtgLicenciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgLicenciados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLicenciados.EnableHeadersVisualStyles = false;
            this.dtgLicenciados.GridColor = System.Drawing.Color.White;
            this.dtgLicenciados.Location = new System.Drawing.Point(0, 0);
            this.dtgLicenciados.Name = "dtgLicenciados";
            this.dtgLicenciados.ReadOnly = true;
            this.dtgLicenciados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLicenciados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgLicenciados.RowHeadersVisible = false;
            this.dtgLicenciados.RowHeadersWidth = 52;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgLicenciados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLicenciados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLicenciados.Size = new System.Drawing.Size(602, 335);
            this.dtgLicenciados.TabIndex = 0;
            this.dtgLicenciados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLicenciados_CellContentClick);
            // 
            // FrmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1025, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.btnEditarLicenciado);
            this.Controls.Add(this.btnSeleccionarLicenciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTutor";
            this.Text = "FrmTutor";
            this.Load += new System.EventHandler(this.FrmTutor_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLicenciados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionarLicenciado;
        private System.Windows.Forms.Button btnEditarLicenciado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarLicenciado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarInstitucion;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCarreraLicenciado;
        private System.Windows.Forms.RadioButton rbDocenteNo;
        private System.Windows.Forms.RadioButton rbDocenteSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailLicenciado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellidoLicenciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreLicenciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgLicenciados;
        private System.Windows.Forms.Label lbid_licenciado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}