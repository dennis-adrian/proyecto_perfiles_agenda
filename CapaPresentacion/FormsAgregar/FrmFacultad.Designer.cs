namespace CapaPresentacion.FormsAgregar
{
    partial class FrmFacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacultad));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitu = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.txtNombreFacultad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarFacu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgFacultad = new System.Windows.Forms.DataGridView();
            this.idtxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrotxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscarFacultad = new System.Windows.Forms.TextBox();
            this.btnSelecFacu = new System.Windows.Forms.Button();
            this.btnEditarFacu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacultad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lbltitu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 45);
            this.panel2.TabIndex = 34;
            // 
            // lbltitu
            // 
            this.lbltitu.AutoSize = true;
            this.lbltitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitu.ForeColor = System.Drawing.Color.White;
            this.lbltitu.Location = new System.Drawing.Point(182, 14);
            this.lbltitu.Name = "lbltitu";
            this.lbltitu.Size = new System.Drawing.Size(184, 18);
            this.lbltitu.TabIndex = 29;
            this.lbltitu.Text = "Agregar nueva Facultad";
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(614, 27);
            this.pnlBarraTitulo.TabIndex = 33;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(579, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idlbl);
            this.groupBox2.Controls.Add(this.txtNombreFacultad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGuardarFacu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 98);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar y editar facultad";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(168, 32);
            this.idlbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(19, 20);
            this.idlbl.TabIndex = 53;
            this.idlbl.Text = "0";
            this.idlbl.Click += new System.EventHandler(this.idlbl_Click);
            // 
            // txtNombreFacultad
            // 
            this.txtNombreFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFacultad.Location = new System.Drawing.Point(18, 56);
            this.txtNombreFacultad.Name = "txtNombreFacultad";
            this.txtNombreFacultad.Size = new System.Drawing.Size(342, 26);
            this.txtNombreFacultad.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre de facultad";
            // 
            // btnGuardarFacu
            // 
            this.btnGuardarFacu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarFacu.FlatAppearance.BorderSize = 0;
            this.btnGuardarFacu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFacu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFacu.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFacu.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFacu.Image")));
            this.btnGuardarFacu.Location = new System.Drawing.Point(374, 55);
            this.btnGuardarFacu.Name = "btnGuardarFacu";
            this.btnGuardarFacu.Size = new System.Drawing.Size(108, 27);
            this.btnGuardarFacu.TabIndex = 40;
            this.btnGuardarFacu.Text = "Guardar";
            this.btnGuardarFacu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarFacu.UseVisualStyleBackColor = false;
            this.btnGuardarFacu.Click += new System.EventHandler(this.btnGuardarFacu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.dtgFacultad);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarFacultad);
            this.groupBox1.Controls.Add(this.btnSelecFacu);
            this.groupBox1.Controls.Add(this.btnEditarFacu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(593, 333);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar facultad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(484, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 29);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgFacultad
            // 
            this.dtgFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacultad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtxt,
            this.nrotxt,
            this.nombretxt});
            this.dtgFacultad.Location = new System.Drawing.Point(13, 83);
            this.dtgFacultad.Margin = new System.Windows.Forms.Padding(1);
            this.dtgFacultad.Name = "dtgFacultad";
            this.dtgFacultad.RowHeadersWidth = 92;
            this.dtgFacultad.RowTemplate.Height = 37;
            this.dtgFacultad.Size = new System.Drawing.Size(564, 190);
            this.dtgFacultad.TabIndex = 55;
            // 
            // idtxt
            // 
            this.idtxt.HeaderText = "Id";
            this.idtxt.MinimumWidth = 11;
            this.idtxt.Name = "idtxt";
            this.idtxt.Visible = false;
            this.idtxt.Width = 225;
            // 
            // nrotxt
            // 
            this.nrotxt.HeaderText = "Nro";
            this.nrotxt.MinimumWidth = 11;
            this.nrotxt.Name = "nrotxt";
            this.nrotxt.Width = 225;
            // 
            // nombretxt
            // 
            this.nombretxt.HeaderText = "Nombre";
            this.nombretxt.MinimumWidth = 11;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Width = 225;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.Location = new System.Drawing.Point(452, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarFacultad
            // 
            this.txtBuscarFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFacultad.Location = new System.Drawing.Point(85, 33);
            this.txtBuscarFacultad.Name = "txtBuscarFacultad";
            this.txtBuscarFacultad.Size = new System.Drawing.Size(352, 26);
            this.txtBuscarFacultad.TabIndex = 52;
            this.txtBuscarFacultad.TextChanged += new System.EventHandler(this.txtBuscarFacultad_TextChanged);
            // 
            // btnSelecFacu
            // 
            this.btnSelecFacu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSelecFacu.FlatAppearance.BorderSize = 0;
            this.btnSelecFacu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecFacu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecFacu.ForeColor = System.Drawing.Color.White;
            this.btnSelecFacu.Location = new System.Drawing.Point(264, 289);
            this.btnSelecFacu.Name = "btnSelecFacu";
            this.btnSelecFacu.Size = new System.Drawing.Size(115, 29);
            this.btnSelecFacu.TabIndex = 43;
            this.btnSelecFacu.Text = "Seleccionar";
            this.btnSelecFacu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecFacu.UseVisualStyleBackColor = false;
            this.btnSelecFacu.Click += new System.EventHandler(this.btnSelecFacu_Click);
            // 
            // btnEditarFacu
            // 
            this.btnEditarFacu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarFacu.FlatAppearance.BorderSize = 0;
            this.btnEditarFacu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFacu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFacu.ForeColor = System.Drawing.Color.White;
            this.btnEditarFacu.Location = new System.Drawing.Point(385, 289);
            this.btnEditarFacu.Name = "btnEditarFacu";
            this.btnEditarFacu.Size = new System.Drawing.Size(93, 29);
            this.btnEditarFacu.TabIndex = 43;
            this.btnEditarFacu.Text = "Editar";
            this.btnEditarFacu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarFacu.UseVisualStyleBackColor = false;
            this.btnEditarFacu.Click += new System.EventHandler(this.btnEditarFacu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(614, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(547, 537);
            this.Name = "FrmFacultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacultad";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacultad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbltitu;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreFacultad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarFacu;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarFacultad;
        private System.Windows.Forms.Button btnEditarFacu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgFacultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrotxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretxt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label idlbl;
        public System.Windows.Forms.Button btnSelecFacu;
    }
}