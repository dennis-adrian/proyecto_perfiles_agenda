namespace CapaPresentacion
{
    partial class FrmPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfiles));
            this.pnlBuscar2 = new System.Windows.Forms.Panel();
            this.btnEditarRevisiones = new System.Windows.Forms.Button();
            this.btnBuscarPerfil = new System.Windows.Forms.Button();
            this.txtBuscarPerfil = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgPerfilesTesis = new System.Windows.Forms.DataGridView();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstado_Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFacultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha_Recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerfilesTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscar2
            // 
            this.pnlBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBuscar2.Controls.Add(this.btnEditarRevisiones);
            this.pnlBuscar2.Controls.Add(this.btnBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.txtBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.label14);
            this.pnlBuscar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar2.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar2.Name = "pnlBuscar2";
            this.pnlBuscar2.Size = new System.Drawing.Size(1080, 56);
            this.pnlBuscar2.TabIndex = 2;
            // 
            // btnEditarRevisiones
            // 
            this.btnEditarRevisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarRevisiones.FlatAppearance.BorderSize = 0;
            this.btnEditarRevisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarRevisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRevisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRevisiones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarRevisiones.Location = new System.Drawing.Point(15, 13);
            this.btnEditarRevisiones.Name = "btnEditarRevisiones";
            this.btnEditarRevisiones.Size = new System.Drawing.Size(240, 33);
            this.btnEditarRevisiones.TabIndex = 26;
            this.btnEditarRevisiones.Text = "Editar Revisiones";
            this.btnEditarRevisiones.UseVisualStyleBackColor = false;
            this.btnEditarRevisiones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscarPerfil.FlatAppearance.BorderSize = 0;
            this.btnBuscarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarPerfil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPerfil.Location = new System.Drawing.Point(933, 13);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Size = new System.Drawing.Size(96, 26);
            this.btnBuscarPerfil.TabIndex = 25;
            this.btnBuscarPerfil.Text = "Buscar";
            this.btnBuscarPerfil.UseVisualStyleBackColor = false;
            this.btnBuscarPerfil.Click += new System.EventHandler(this.btnBuscarPerfil_Click);
            // 
            // txtBuscarPerfil
            // 
            this.txtBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerfil.Location = new System.Drawing.Point(667, 13);
            this.txtBuscarPerfil.Name = "txtBuscarPerfil";
            this.txtBuscarPerfil.Size = new System.Drawing.Size(247, 27);
            this.txtBuscarPerfil.TabIndex = 24;
            this.txtBuscarPerfil.TextChanged += new System.EventHandler(this.txtBuscarPerfil_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(467, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre Estudiante";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dtgPerfilesTesis
            // 
            this.dtgPerfilesTesis.AllowUserToAddRows = false;
            this.dtgPerfilesTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPerfilesTesis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPerfilesTesis.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgPerfilesTesis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPerfilesTesis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgPerfilesTesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPerfilesTesis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPerfilesTesis.ColumnHeadersHeight = 34;
            this.dtgPerfilesTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPerfilesTesis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaId,
            this.ColumnaNumero,
            this.ColumnaEstado_Proyecto,
            this.ColumnaRegistro,
            this.ColumnaEstudiante,
            this.ColumnaCarrera,
            this.ColumnaFacultad,
            this.ColumnaTema,
            this.ColumnaTutor,
            this.ColumnaEmail,
            this.ColumnaTelefono,
            this.ColumnaFecha_Recepcion});
            this.dtgPerfilesTesis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPerfilesTesis.EnableHeadersVisualStyles = false;
            this.dtgPerfilesTesis.GridColor = System.Drawing.Color.Silver;
            this.dtgPerfilesTesis.Location = new System.Drawing.Point(0, 56);
            this.dtgPerfilesTesis.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPerfilesTesis.Name = "dtgPerfilesTesis";
            this.dtgPerfilesTesis.ReadOnly = true;
            this.dtgPerfilesTesis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPerfilesTesis.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPerfilesTesis.RowHeadersVisible = false;
            this.dtgPerfilesTesis.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPerfilesTesis.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPerfilesTesis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPerfilesTesis.Size = new System.Drawing.Size(1080, 744);
            this.dtgPerfilesTesis.TabIndex = 3;
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "Id";
            this.ColumnaId.MinimumWidth = 6;
            this.ColumnaId.Name = "ColumnaId";
            this.ColumnaId.ReadOnly = true;
            this.ColumnaId.Visible = false;
            // 
            // ColumnaNumero
            // 
            this.ColumnaNumero.HeaderText = "Nro";
            this.ColumnaNumero.MinimumWidth = 6;
            this.ColumnaNumero.Name = "ColumnaNumero";
            this.ColumnaNumero.ReadOnly = true;
            // 
            // ColumnaEstado_Proyecto
            // 
            this.ColumnaEstado_Proyecto.HeaderText = "Estado_Proyecto";
            this.ColumnaEstado_Proyecto.MinimumWidth = 6;
            this.ColumnaEstado_Proyecto.Name = "ColumnaEstado_Proyecto";
            this.ColumnaEstado_Proyecto.ReadOnly = true;
            // 
            // ColumnaRegistro
            // 
            this.ColumnaRegistro.HeaderText = "Registro";
            this.ColumnaRegistro.MinimumWidth = 6;
            this.ColumnaRegistro.Name = "ColumnaRegistro";
            this.ColumnaRegistro.ReadOnly = true;
            // 
            // ColumnaEstudiante
            // 
            this.ColumnaEstudiante.HeaderText = "Estudiante";
            this.ColumnaEstudiante.MinimumWidth = 6;
            this.ColumnaEstudiante.Name = "ColumnaEstudiante";
            this.ColumnaEstudiante.ReadOnly = true;
            // 
            // ColumnaCarrera
            // 
            this.ColumnaCarrera.HeaderText = "Carrera";
            this.ColumnaCarrera.MinimumWidth = 6;
            this.ColumnaCarrera.Name = "ColumnaCarrera";
            this.ColumnaCarrera.ReadOnly = true;
            // 
            // ColumnaFacultad
            // 
            this.ColumnaFacultad.HeaderText = "Facultad";
            this.ColumnaFacultad.MinimumWidth = 6;
            this.ColumnaFacultad.Name = "ColumnaFacultad";
            this.ColumnaFacultad.ReadOnly = true;
            // 
            // ColumnaTema
            // 
            this.ColumnaTema.HeaderText = "Tema";
            this.ColumnaTema.MinimumWidth = 6;
            this.ColumnaTema.Name = "ColumnaTema";
            this.ColumnaTema.ReadOnly = true;
            // 
            // ColumnaTutor
            // 
            this.ColumnaTutor.HeaderText = "Tutor";
            this.ColumnaTutor.MinimumWidth = 6;
            this.ColumnaTutor.Name = "ColumnaTutor";
            this.ColumnaTutor.ReadOnly = true;
            // 
            // ColumnaEmail
            // 
            this.ColumnaEmail.HeaderText = "Email";
            this.ColumnaEmail.MinimumWidth = 6;
            this.ColumnaEmail.Name = "ColumnaEmail";
            this.ColumnaEmail.ReadOnly = true;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.HeaderText = "Telefono";
            this.ColumnaTelefono.MinimumWidth = 6;
            this.ColumnaTelefono.Name = "ColumnaTelefono";
            this.ColumnaTelefono.ReadOnly = true;
            // 
            // ColumnaFecha_Recepcion
            // 
            this.ColumnaFecha_Recepcion.HeaderText = "Fecha_Recepcion";
            this.ColumnaFecha_Recepcion.MinimumWidth = 6;
            this.ColumnaFecha_Recepcion.Name = "ColumnaFecha_Recepcion";
            this.ColumnaFecha_Recepcion.ReadOnly = true;
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 800);
            this.Controls.Add(this.dtgPerfilesTesis);
            this.Controls.Add(this.pnlBuscar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPerfiles";
            this.Text = "FrmPerfiles";
            this.pnlBuscar2.ResumeLayout(false);
            this.pnlBuscar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerfilesTesis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar2;
        private System.Windows.Forms.Button btnBuscarPerfil;
        private System.Windows.Forms.TextBox txtBuscarPerfil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgPerfilesTesis;
        private System.Windows.Forms.Button btnEditarRevisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstado_Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFacultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha_Recepcion;
    }
}