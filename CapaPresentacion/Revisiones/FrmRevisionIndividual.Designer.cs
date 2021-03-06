﻿namespace CapaPresentacion
{
    partial class FrmRevisionIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevisionIndividual));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chbEntregaAlumno = new System.Windows.Forms.CheckBox();
            this.chbEntregaTribunal = new System.Windows.Forms.CheckBox();
            this.chbDevolucionTribunal = new System.Windows.Forms.CheckBox();
            this.chbDevolucionAlumno = new System.Windows.Forms.CheckBox();
            this.chbLimiteSugerido = new System.Windows.Forms.CheckBox();
            this.chbEmpaste = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.alertEmpaste = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbEmpaste = new System.Windows.Forms.Label();
            this.dttEmpaste = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dttEntregaAlumno = new System.Windows.Forms.DateTimePicker();
            this.dttEntregaTribunal = new System.Windows.Forms.DateTimePicker();
            this.dttLimiteSugerido = new System.Windows.Forms.DateTimePicker();
            this.dttDevolucionTribunal = new System.Windows.Forms.DateTimePicker();
            this.dttDevolucionAlumno = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTribunal1 = new FontAwesome.Sharp.IconButton();
            this.btnTribunal2 = new FontAwesome.Sharp.IconButton();
            this.pnlResaltadoTrib2 = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTribunal = new System.Windows.Forms.ComboBox();
            this.txtEstadoDatos = new System.Windows.Forms.TextBox();
            this.pnlResaltadoTrib1 = new System.Windows.Forms.Panel();
            this.pnlRevision = new System.Windows.Forms.Panel();
            this.txtTotalRevision = new System.Windows.Forms.TextBox();
            this.cmbTribunalActual = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDefensa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdTesis = new System.Windows.Forms.TextBox();
            this.btnDefensaExterna = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdRevision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdDetalleRevision = new System.Windows.Forms.TextBox();
            this.rbTribunal2 = new System.Windows.Forms.RadioButton();
            this.rbTribunal1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.pnlRevision.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Habilitar Fecha";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // chbEntregaAlumno
            // 
            this.chbEntregaAlumno.AutoSize = true;
            this.chbEntregaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEntregaAlumno.Location = new System.Drawing.Point(308, 146);
            this.chbEntregaAlumno.Name = "chbEntregaAlumno";
            this.chbEntregaAlumno.Size = new System.Drawing.Size(72, 19);
            this.chbEntregaAlumno.TabIndex = 61;
            this.chbEntregaAlumno.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbEntregaAlumno, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbEntregaAlumno.UseVisualStyleBackColor = true;
            this.chbEntregaAlumno.CheckedChanged += new System.EventHandler(this.chbEntregaAlumno_CheckedChanged);
            // 
            // chbEntregaTribunal
            // 
            this.chbEntregaTribunal.AutoSize = true;
            this.chbEntregaTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEntregaTribunal.Location = new System.Drawing.Point(308, 210);
            this.chbEntregaTribunal.Name = "chbEntregaTribunal";
            this.chbEntregaTribunal.Size = new System.Drawing.Size(72, 19);
            this.chbEntregaTribunal.TabIndex = 62;
            this.chbEntregaTribunal.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbEntregaTribunal, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbEntregaTribunal.UseVisualStyleBackColor = true;
            this.chbEntregaTribunal.CheckedChanged += new System.EventHandler(this.chbEntregaTribunal_CheckedChanged);
            // 
            // chbDevolucionTribunal
            // 
            this.chbDevolucionTribunal.AutoSize = true;
            this.chbDevolucionTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDevolucionTribunal.Location = new System.Drawing.Point(309, 347);
            this.chbDevolucionTribunal.Name = "chbDevolucionTribunal";
            this.chbDevolucionTribunal.Size = new System.Drawing.Size(72, 19);
            this.chbDevolucionTribunal.TabIndex = 63;
            this.chbDevolucionTribunal.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbDevolucionTribunal, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbDevolucionTribunal.UseVisualStyleBackColor = true;
            this.chbDevolucionTribunal.CheckedChanged += new System.EventHandler(this.chbDevolucionTribunal_CheckedChanged);
            // 
            // chbDevolucionAlumno
            // 
            this.chbDevolucionAlumno.AutoSize = true;
            this.chbDevolucionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDevolucionAlumno.Location = new System.Drawing.Point(309, 412);
            this.chbDevolucionAlumno.Name = "chbDevolucionAlumno";
            this.chbDevolucionAlumno.Size = new System.Drawing.Size(72, 19);
            this.chbDevolucionAlumno.TabIndex = 64;
            this.chbDevolucionAlumno.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbDevolucionAlumno, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbDevolucionAlumno.UseVisualStyleBackColor = true;
            this.chbDevolucionAlumno.CheckedChanged += new System.EventHandler(this.chbDevolucionAlumno_CheckedChanged);
            // 
            // chbLimiteSugerido
            // 
            this.chbLimiteSugerido.AutoSize = true;
            this.chbLimiteSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLimiteSugerido.Location = new System.Drawing.Point(309, 279);
            this.chbLimiteSugerido.Name = "chbLimiteSugerido";
            this.chbLimiteSugerido.Size = new System.Drawing.Size(72, 19);
            this.chbLimiteSugerido.TabIndex = 65;
            this.chbLimiteSugerido.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbLimiteSugerido, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbLimiteSugerido.UseVisualStyleBackColor = true;
            this.chbLimiteSugerido.CheckedChanged += new System.EventHandler(this.chbLimiteSugerido_CheckedChanged);
            // 
            // chbEmpaste
            // 
            this.chbEmpaste.AutoSize = true;
            this.chbEmpaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmpaste.Location = new System.Drawing.Point(306, 484);
            this.chbEmpaste.Name = "chbEmpaste";
            this.chbEmpaste.Size = new System.Drawing.Size(72, 19);
            this.chbEmpaste.TabIndex = 66;
            this.chbEmpaste.Text = "Habilitar";
            this.toolTip1.SetToolTip(this.chbEmpaste, "Para elegir y guardar la fecha, debe habilitarla.");
            this.chbEmpaste.UseVisualStyleBackColor = true;
            this.chbEmpaste.CheckedChanged += new System.EventHandler(this.chbEmpaste_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(96, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 67;
            this.toolTip1.SetToolTip(this.button1, "Si esta fecha no está habilitada, no será guardada.");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(96, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 68;
            this.toolTip1.SetToolTip(this.button2, "Si esta fecha no está habilitada, no será guardada.");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(97, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 69;
            this.toolTip1.SetToolTip(this.button3, "Si esta fecha no está habilitada, no será guardada.");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(97, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 70;
            this.toolTip1.SetToolTip(this.button4, "Si esta fecha no está habilitada, no será guardada.");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // alertEmpaste
            // 
            this.alertEmpaste.BackColor = System.Drawing.Color.Transparent;
            this.alertEmpaste.FlatAppearance.BorderSize = 0;
            this.alertEmpaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.alertEmpaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.alertEmpaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertEmpaste.Image = ((System.Drawing.Image)(resources.GetObject("alertEmpaste.Image")));
            this.alertEmpaste.Location = new System.Drawing.Point(96, 476);
            this.alertEmpaste.Name = "alertEmpaste";
            this.alertEmpaste.Size = new System.Drawing.Size(32, 32);
            this.alertEmpaste.TabIndex = 71;
            this.toolTip1.SetToolTip(this.alertEmpaste, "Si esta fecha no está habilitada, no será guardada.");
            this.alertEmpaste.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(95, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 72;
            this.toolTip1.SetToolTip(this.button6, "Si esta fecha no está habilitada, no será guardada.");
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(800, 445);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 38);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(707, 445);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarNuevop_Click);
            // 
            // lbEmpaste
            // 
            this.lbEmpaste.AutoSize = true;
            this.lbEmpaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpaste.Location = new System.Drawing.Point(93, 454);
            this.lbEmpaste.Name = "lbEmpaste";
            this.lbEmpaste.Size = new System.Drawing.Size(148, 18);
            this.lbEmpaste.TabIndex = 28;
            this.lbEmpaste.Text = "Fecha de Empaste";
            // 
            // dttEmpaste
            // 
            this.dttEmpaste.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEmpaste.CustomFormat = "dd-MM-yyyy";
            this.dttEmpaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEmpaste.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttEmpaste.Location = new System.Drawing.Point(134, 479);
            this.dttEmpaste.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttEmpaste.Name = "dttEmpaste";
            this.dttEmpaste.Size = new System.Drawing.Size(157, 24);
            this.dttEmpaste.TabIndex = 29;
            this.dttEmpaste.Value = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(92, 116);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(363, 18);
            this.label26.TabIndex = 50;
            this.label26.Text = "Fecha en la que el estudiante entrega el trabajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fecha en la que se entrega el trabajo al tribunal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Fecha en la que el tribunal devuelve el trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fecha en la que se devolvió el trabajo al estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Fecha límite de devolución sugerida al tribunal";
            // 
            // dttEntregaAlumno
            // 
            this.dttEntregaAlumno.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEntregaAlumno.CustomFormat = "dd-MM-yyyy";
            this.dttEntregaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEntregaAlumno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttEntregaAlumno.Location = new System.Drawing.Point(134, 139);
            this.dttEntregaAlumno.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttEntregaAlumno.Name = "dttEntregaAlumno";
            this.dttEntregaAlumno.Size = new System.Drawing.Size(157, 24);
            this.dttEntregaAlumno.TabIndex = 52;
            this.dttEntregaAlumno.Value = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            // 
            // dttEntregaTribunal
            // 
            this.dttEntregaTribunal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEntregaTribunal.CustomFormat = "dd-MM-yyyy";
            this.dttEntregaTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttEntregaTribunal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttEntregaTribunal.Location = new System.Drawing.Point(134, 203);
            this.dttEntregaTribunal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttEntregaTribunal.Name = "dttEntregaTribunal";
            this.dttEntregaTribunal.Size = new System.Drawing.Size(157, 24);
            this.dttEntregaTribunal.TabIndex = 53;
            this.dttEntregaTribunal.Value = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            // 
            // dttLimiteSugerido
            // 
            this.dttLimiteSugerido.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttLimiteSugerido.CustomFormat = "dd-MM-yyyy";
            this.dttLimiteSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttLimiteSugerido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttLimiteSugerido.Location = new System.Drawing.Point(134, 272);
            this.dttLimiteSugerido.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttLimiteSugerido.Name = "dttLimiteSugerido";
            this.dttLimiteSugerido.Size = new System.Drawing.Size(157, 24);
            this.dttLimiteSugerido.TabIndex = 54;
            this.dttLimiteSugerido.Value = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            // 
            // dttDevolucionTribunal
            // 
            this.dttDevolucionTribunal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDevolucionTribunal.CustomFormat = "dd-MM-yyyy";
            this.dttDevolucionTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDevolucionTribunal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttDevolucionTribunal.Location = new System.Drawing.Point(135, 340);
            this.dttDevolucionTribunal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttDevolucionTribunal.Name = "dttDevolucionTribunal";
            this.dttDevolucionTribunal.Size = new System.Drawing.Size(157, 24);
            this.dttDevolucionTribunal.TabIndex = 55;
            this.dttDevolucionTribunal.Value = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            // 
            // dttDevolucionAlumno
            // 
            this.dttDevolucionAlumno.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDevolucionAlumno.CustomFormat = "dd-MM-yyyy";
            this.dttDevolucionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDevolucionAlumno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttDevolucionAlumno.Location = new System.Drawing.Point(135, 407);
            this.dttDevolucionAlumno.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttDevolucionAlumno.Name = "dttDevolucionAlumno";
            this.dttDevolucionAlumno.Size = new System.Drawing.Size(157, 24);
            this.dttDevolucionAlumno.TabIndex = 56;
            this.dttDevolucionAlumno.Value = new System.DateTime(2000, 12, 12, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTribunal1);
            this.panel1.Controls.Add(this.btnTribunal2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 60);
            this.panel1.TabIndex = 57;
            // 
            // btnTribunal1
            // 
            this.btnTribunal1.AutoSize = true;
            this.btnTribunal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTribunal1.FlatAppearance.BorderSize = 0;
            this.btnTribunal1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTribunal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTribunal1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTribunal1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTribunal1.IconColor = System.Drawing.Color.Black;
            this.btnTribunal1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTribunal1.IconSize = 16;
            this.btnTribunal1.Location = new System.Drawing.Point(0, 0);
            this.btnTribunal1.Name = "btnTribunal1";
            this.btnTribunal1.Size = new System.Drawing.Size(525, 61);
            this.btnTribunal1.TabIndex = 25;
            this.btnTribunal1.Text = "Tribunal 1";
            this.btnTribunal1.UseVisualStyleBackColor = false;
            this.btnTribunal1.Click += new System.EventHandler(this.btnTribunal1_Click);
            // 
            // btnTribunal2
            // 
            this.btnTribunal2.AutoSize = true;
            this.btnTribunal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTribunal2.FlatAppearance.BorderSize = 0;
            this.btnTribunal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTribunal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTribunal2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTribunal2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTribunal2.IconColor = System.Drawing.Color.Black;
            this.btnTribunal2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTribunal2.IconSize = 16;
            this.btnTribunal2.Location = new System.Drawing.Point(525, 0);
            this.btnTribunal2.Name = "btnTribunal2";
            this.btnTribunal2.Size = new System.Drawing.Size(525, 61);
            this.btnTribunal2.TabIndex = 26;
            this.btnTribunal2.Text = "Tribunal 2";
            this.btnTribunal2.UseVisualStyleBackColor = false;
            this.btnTribunal2.Click += new System.EventHandler(this.btnTribunal2_Click);
            // 
            // pnlResaltadoTrib2
            // 
            this.pnlResaltadoTrib2.BackColor = System.Drawing.Color.Crimson;
            this.pnlResaltadoTrib2.Location = new System.Drawing.Point(525, 50);
            this.pnlResaltadoTrib2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlResaltadoTrib2.Name = "pnlResaltadoTrib2";
            this.pnlResaltadoTrib2.Size = new System.Drawing.Size(525, 10);
            this.pnlResaltadoTrib2.TabIndex = 75;
            this.pnlResaltadoTrib2.Visible = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(533, 202);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(352, 235);
            this.txtObservaciones.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Observaciones";
            // 
            // cmbTribunal
            // 
            this.cmbTribunal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTribunal.FormattingEnabled = true;
            this.cmbTribunal.Location = new System.Drawing.Point(345, 622);
            this.cmbTribunal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTribunal.Name = "cmbTribunal";
            this.cmbTribunal.Size = new System.Drawing.Size(233, 25);
            this.cmbTribunal.TabIndex = 60;
            this.cmbTribunal.Visible = false;
            // 
            // txtEstadoDatos
            // 
            this.txtEstadoDatos.Location = new System.Drawing.Point(533, 137);
            this.txtEstadoDatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstadoDatos.Name = "txtEstadoDatos";
            this.txtEstadoDatos.ReadOnly = true;
            this.txtEstadoDatos.Size = new System.Drawing.Size(138, 20);
            this.txtEstadoDatos.TabIndex = 27;
            // 
            // pnlResaltadoTrib1
            // 
            this.pnlResaltadoTrib1.BackColor = System.Drawing.Color.Crimson;
            this.pnlResaltadoTrib1.Location = new System.Drawing.Point(0, 50);
            this.pnlResaltadoTrib1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlResaltadoTrib1.Name = "pnlResaltadoTrib1";
            this.pnlResaltadoTrib1.Size = new System.Drawing.Size(525, 10);
            this.pnlResaltadoTrib1.TabIndex = 74;
            // 
            // pnlRevision
            // 
            this.pnlRevision.BackColor = System.Drawing.Color.LightGray;
            this.pnlRevision.Controls.Add(this.txtTotalRevision);
            this.pnlRevision.Controls.Add(this.cmbTribunalActual);
            this.pnlRevision.Controls.Add(this.label9);
            this.pnlRevision.Controls.Add(this.txtIdDefensa);
            this.pnlRevision.Controls.Add(this.label10);
            this.pnlRevision.Controls.Add(this.txtIdTesis);
            this.pnlRevision.Controls.Add(this.btnDefensaExterna);
            this.pnlRevision.Controls.Add(this.label8);
            this.pnlRevision.Controls.Add(this.txtIdRevision);
            this.pnlRevision.Controls.Add(this.label7);
            this.pnlRevision.Controls.Add(this.txtIdDetalleRevision);
            this.pnlRevision.Controls.Add(this.pnlResaltadoTrib2);
            this.pnlRevision.Controls.Add(this.pnlResaltadoTrib1);
            this.pnlRevision.Controls.Add(this.rbTribunal2);
            this.pnlRevision.Controls.Add(this.txtEstadoDatos);
            this.pnlRevision.Controls.Add(this.rbTribunal1);
            this.pnlRevision.Controls.Add(this.button6);
            this.pnlRevision.Controls.Add(this.alertEmpaste);
            this.pnlRevision.Controls.Add(this.button4);
            this.pnlRevision.Controls.Add(this.button3);
            this.pnlRevision.Controls.Add(this.button2);
            this.pnlRevision.Controls.Add(this.button1);
            this.pnlRevision.Controls.Add(this.chbEmpaste);
            this.pnlRevision.Controls.Add(this.chbLimiteSugerido);
            this.pnlRevision.Controls.Add(this.chbDevolucionAlumno);
            this.pnlRevision.Controls.Add(this.chbDevolucionTribunal);
            this.pnlRevision.Controls.Add(this.chbEntregaTribunal);
            this.pnlRevision.Controls.Add(this.chbEntregaAlumno);
            this.pnlRevision.Controls.Add(this.cmbTribunal);
            this.pnlRevision.Controls.Add(this.label6);
            this.pnlRevision.Controls.Add(this.txtObservaciones);
            this.pnlRevision.Controls.Add(this.panel1);
            this.pnlRevision.Controls.Add(this.dttDevolucionAlumno);
            this.pnlRevision.Controls.Add(this.dttDevolucionTribunal);
            this.pnlRevision.Controls.Add(this.dttLimiteSugerido);
            this.pnlRevision.Controls.Add(this.dttEntregaTribunal);
            this.pnlRevision.Controls.Add(this.dttEntregaAlumno);
            this.pnlRevision.Controls.Add(this.label5);
            this.pnlRevision.Controls.Add(this.label2);
            this.pnlRevision.Controls.Add(this.label3);
            this.pnlRevision.Controls.Add(this.label4);
            this.pnlRevision.Controls.Add(this.label26);
            this.pnlRevision.Controls.Add(this.dttEmpaste);
            this.pnlRevision.Controls.Add(this.lbEmpaste);
            this.pnlRevision.Controls.Add(this.btnCancelar);
            this.pnlRevision.Controls.Add(this.btnGuardar);
            this.pnlRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevision.Location = new System.Drawing.Point(0, 0);
            this.pnlRevision.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRevision.Name = "pnlRevision";
            this.pnlRevision.Size = new System.Drawing.Size(1050, 720);
            this.pnlRevision.TabIndex = 35;
            // 
            // txtTotalRevision
            // 
            this.txtTotalRevision.Location = new System.Drawing.Point(608, 555);
            this.txtTotalRevision.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotalRevision.Name = "txtTotalRevision";
            this.txtTotalRevision.ReadOnly = true;
            this.txtTotalRevision.Size = new System.Drawing.Size(45, 20);
            this.txtTotalRevision.TabIndex = 86;
            this.txtTotalRevision.Text = "0";
            this.txtTotalRevision.Visible = false;
            // 
            // cmbTribunalActual
            // 
            this.cmbTribunalActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTribunalActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTribunalActual.FormattingEnabled = true;
            this.cmbTribunalActual.Location = new System.Drawing.Point(345, 654);
            this.cmbTribunalActual.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTribunalActual.Name = "cmbTribunalActual";
            this.cmbTribunalActual.Size = new System.Drawing.Size(233, 25);
            this.cmbTribunalActual.TabIndex = 85;
            this.cmbTribunalActual.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "idDefensa";
            this.label9.Visible = false;
            // 
            // txtIdDefensa
            // 
            this.txtIdDefensa.Location = new System.Drawing.Point(436, 579);
            this.txtIdDefensa.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdDefensa.Name = "txtIdDefensa";
            this.txtIdDefensa.ReadOnly = true;
            this.txtIdDefensa.Size = new System.Drawing.Size(45, 20);
            this.txtIdDefensa.TabIndex = 83;
            this.txtIdDefensa.Text = "0";
            this.txtIdDefensa.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(303, 552);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 82;
            this.label10.Text = "idTesis";
            this.label10.Visible = false;
            // 
            // txtIdTesis
            // 
            this.txtIdTesis.Location = new System.Drawing.Point(436, 554);
            this.txtIdTesis.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdTesis.Name = "txtIdTesis";
            this.txtIdTesis.ReadOnly = true;
            this.txtIdTesis.Size = new System.Drawing.Size(45, 20);
            this.txtIdTesis.TabIndex = 81;
            this.txtIdTesis.Text = "0";
            this.txtIdTesis.Visible = false;
            // 
            // btnDefensaExterna
            // 
            this.btnDefensaExterna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDefensaExterna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefensaExterna.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDefensaExterna.FlatAppearance.BorderSize = 0;
            this.btnDefensaExterna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnDefensaExterna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnDefensaExterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefensaExterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefensaExterna.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDefensaExterna.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnDefensaExterna.IconColor = System.Drawing.Color.White;
            this.btnDefensaExterna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDefensaExterna.IconSize = 32;
            this.btnDefensaExterna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefensaExterna.Location = new System.Drawing.Point(739, 117);
            this.btnDefensaExterna.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefensaExterna.Name = "btnDefensaExterna";
            this.btnDefensaExterna.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDefensaExterna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDefensaExterna.Size = new System.Drawing.Size(143, 46);
            this.btnDefensaExterna.TabIndex = 80;
            this.btnDefensaExterna.Text = "Agregar Defensa";
            this.btnDefensaExterna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefensaExterna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDefensaExterna.UseVisualStyleBackColor = false;
            this.btnDefensaExterna.Click += new System.EventHandler(this.btnDefensaExterna_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 79;
            this.label8.Text = "idRevision";
            this.label8.Visible = false;
            // 
            // txtIdRevision
            // 
            this.txtIdRevision.Location = new System.Drawing.Point(218, 576);
            this.txtIdRevision.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdRevision.Name = "txtIdRevision";
            this.txtIdRevision.ReadOnly = true;
            this.txtIdRevision.Size = new System.Drawing.Size(45, 20);
            this.txtIdRevision.TabIndex = 78;
            this.txtIdRevision.Text = "0";
            this.txtIdRevision.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "idDetalleRevision";
            this.label7.Visible = false;
            // 
            // txtIdDetalleRevision
            // 
            this.txtIdDetalleRevision.Location = new System.Drawing.Point(218, 552);
            this.txtIdDetalleRevision.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdDetalleRevision.Name = "txtIdDetalleRevision";
            this.txtIdDetalleRevision.ReadOnly = true;
            this.txtIdDetalleRevision.Size = new System.Drawing.Size(45, 20);
            this.txtIdDetalleRevision.TabIndex = 76;
            this.txtIdDetalleRevision.Text = "0";
            this.txtIdDetalleRevision.Visible = false;
            // 
            // rbTribunal2
            // 
            this.rbTribunal2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTribunal2.AutoSize = true;
            this.rbTribunal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbTribunal2.Location = new System.Drawing.Point(189, 653);
            this.rbTribunal2.Name = "rbTribunal2";
            this.rbTribunal2.Size = new System.Drawing.Size(106, 24);
            this.rbTribunal2.TabIndex = 24;
            this.rbTribunal2.Text = "Tribunal 2";
            this.rbTribunal2.UseVisualStyleBackColor = true;
            this.rbTribunal2.Visible = false;
            this.rbTribunal2.CheckedChanged += new System.EventHandler(this.rbTribunal2_CheckedChanged);
            // 
            // rbTribunal1
            // 
            this.rbTribunal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTribunal1.AutoSize = true;
            this.rbTribunal1.Checked = true;
            this.rbTribunal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbTribunal1.Location = new System.Drawing.Point(82, 655);
            this.rbTribunal1.Name = "rbTribunal1";
            this.rbTribunal1.Size = new System.Drawing.Size(106, 24);
            this.rbTribunal1.TabIndex = 23;
            this.rbTribunal1.TabStop = true;
            this.rbTribunal1.Text = "Tribunal 1";
            this.rbTribunal1.UseVisualStyleBackColor = true;
            this.rbTribunal1.Visible = false;
            this.rbTribunal1.CheckedChanged += new System.EventHandler(this.rbTribunal1_CheckedChanged);
            // 
            // FrmRevisionIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.pnlRevision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRevisionIndividual";
            this.Text = "FrmNuevoLicenciado";
            this.Load += new System.EventHandler(this.FrmRevisionIndividual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRevision.ResumeLayout(false);
            this.pnlRevision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbEmpaste;
        private System.Windows.Forms.DateTimePicker dttEmpaste;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dttEntregaAlumno;
        private System.Windows.Forms.DateTimePicker dttEntregaTribunal;
        private System.Windows.Forms.DateTimePicker dttLimiteSugerido;
        private System.Windows.Forms.DateTimePicker dttDevolucionTribunal;
        private System.Windows.Forms.DateTimePicker dttDevolucionAlumno;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTribunal1;
        private FontAwesome.Sharp.IconButton btnTribunal2;
        private System.Windows.Forms.Panel pnlResaltadoTrib2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTribunal;
        private System.Windows.Forms.CheckBox chbEntregaAlumno;
        private System.Windows.Forms.CheckBox chbEntregaTribunal;
        private System.Windows.Forms.CheckBox chbDevolucionTribunal;
        private System.Windows.Forms.CheckBox chbDevolucionAlumno;
        private System.Windows.Forms.CheckBox chbLimiteSugerido;
        private System.Windows.Forms.CheckBox chbEmpaste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button alertEmpaste;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtEstadoDatos;
        private System.Windows.Forms.Panel pnlResaltadoTrib1;
        private System.Windows.Forms.Panel pnlRevision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdDetalleRevision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdRevision;
        private FontAwesome.Sharp.IconButton btnDefensaExterna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdDefensa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdTesis;
        private System.Windows.Forms.RadioButton rbTribunal2;
        private System.Windows.Forms.RadioButton rbTribunal1;
        private System.Windows.Forms.ComboBox cmbTribunalActual;
        private System.Windows.Forms.TextBox txtTotalRevision;
    }
}