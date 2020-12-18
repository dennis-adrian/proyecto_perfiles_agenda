namespace CapaPresentacion.FormsAgregar
{
    partial class FrmCarreraExterna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarreraExterna));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lbltitu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.txtNombreCarreraLic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarreraExt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscarCarreraExt = new System.Windows.Forms.TextBox();
            this.btnSelecCarreraExt = new System.Windows.Forms.Button();
            this.btnEditarCarreraExt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCarreraExterna = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBarraTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarreraExterna)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(612, 27);
            this.pnlBarraTitulo.TabIndex = 28;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
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
            this.btnCerrar.Location = new System.Drawing.Point(577, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbltitu
            // 
            this.lbltitu.AutoSize = true;
            this.lbltitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitu.ForeColor = System.Drawing.Color.White;
            this.lbltitu.Location = new System.Drawing.Point(201, 13);
            this.lbltitu.Name = "lbltitu";
            this.lbltitu.Size = new System.Drawing.Size(174, 18);
            this.lbltitu.TabIndex = 29;
            this.lbltitu.Text = "Nueva carrera externa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lbltitu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 45);
            this.panel2.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idlbl);
            this.groupBox2.Controls.Add(this.txtNombreCarreraLic);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCarreraExt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 115);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar y agregar carrera externa";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(220, 34);
            this.idlbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(19, 20);
            this.idlbl.TabIndex = 54;
            this.idlbl.Text = "0";
            this.idlbl.Visible = false;
            // 
            // txtNombreCarreraLic
            // 
            this.txtNombreCarreraLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCarreraLic.Location = new System.Drawing.Point(17, 55);
            this.txtNombreCarreraLic.Name = "txtNombreCarreraLic";
            this.txtNombreCarreraLic.Size = new System.Drawing.Size(352, 26);
            this.txtNombreCarreraLic.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre de carrera externa";
            // 
            // btnCarreraExt
            // 
            this.btnCarreraExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCarreraExt.FlatAppearance.BorderSize = 0;
            this.btnCarreraExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreraExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreraExt.ForeColor = System.Drawing.Color.White;
            this.btnCarreraExt.Location = new System.Drawing.Point(384, 54);
            this.btnCarreraExt.Name = "btnCarreraExt";
            this.btnCarreraExt.Size = new System.Drawing.Size(93, 29);
            this.btnCarreraExt.TabIndex = 40;
            this.btnCarreraExt.Text = "Guardar";
            this.btnCarreraExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarreraExt.UseVisualStyleBackColor = false;
            this.btnCarreraExt.Click += new System.EventHandler(this.btnCarreraExt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarCarreraExt);
            this.groupBox1.Controls.Add(this.btnSelecCarreraExt);
            this.groupBox1.Controls.Add(this.btnEditarCarreraExt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgCarreraExterna);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(589, 298);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar carrera";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(263, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 29);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(465, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 24);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCarreraExt
            // 
            this.txtBuscarCarreraExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCarreraExt.Location = new System.Drawing.Point(81, 33);
            this.txtBuscarCarreraExt.Name = "txtBuscarCarreraExt";
            this.txtBuscarCarreraExt.Size = new System.Drawing.Size(364, 26);
            this.txtBuscarCarreraExt.TabIndex = 52;
            // 
            // btnSelecCarreraExt
            // 
            this.btnSelecCarreraExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSelecCarreraExt.FlatAppearance.BorderSize = 0;
            this.btnSelecCarreraExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecCarreraExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecCarreraExt.ForeColor = System.Drawing.Color.White;
            this.btnSelecCarreraExt.Location = new System.Drawing.Point(362, 257);
            this.btnSelecCarreraExt.Name = "btnSelecCarreraExt";
            this.btnSelecCarreraExt.Size = new System.Drawing.Size(114, 29);
            this.btnSelecCarreraExt.TabIndex = 43;
            this.btnSelecCarreraExt.Text = "Seleccionar";
            this.btnSelecCarreraExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecCarreraExt.UseVisualStyleBackColor = false;
            this.btnSelecCarreraExt.Click += new System.EventHandler(this.btnSelecCarreraExt_Click);
            // 
            // btnEditarCarreraExt
            // 
            this.btnEditarCarreraExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarCarreraExt.FlatAppearance.BorderSize = 0;
            this.btnEditarCarreraExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCarreraExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCarreraExt.ForeColor = System.Drawing.Color.White;
            this.btnEditarCarreraExt.Location = new System.Drawing.Point(482, 257);
            this.btnEditarCarreraExt.Name = "btnEditarCarreraExt";
            this.btnEditarCarreraExt.Size = new System.Drawing.Size(93, 29);
            this.btnEditarCarreraExt.TabIndex = 43;
            this.btnEditarCarreraExt.Text = "Editar";
            this.btnEditarCarreraExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCarreraExt.UseVisualStyleBackColor = false;
            this.btnEditarCarreraExt.Click += new System.EventHandler(this.btnEditarCarreraExt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar :";
            // 
            // dtgCarreraExterna
            // 
            this.dtgCarreraExterna.AllowUserToDeleteRows = false;
            this.dtgCarreraExterna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCarreraExterna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCarreraExterna.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgCarreraExterna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCarreraExterna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCarreraExterna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCarreraExterna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCarreraExterna.ColumnHeadersHeight = 24;
            this.dtgCarreraExterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCarreraExterna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtid,
            this.txtnro,
            this.txtnombre});
            this.dtgCarreraExterna.EnableHeadersVisualStyles = false;
            this.dtgCarreraExterna.GridColor = System.Drawing.Color.White;
            this.dtgCarreraExterna.Location = new System.Drawing.Point(15, 73);
            this.dtgCarreraExterna.Name = "dtgCarreraExterna";
            this.dtgCarreraExterna.ReadOnly = true;
            this.dtgCarreraExterna.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCarreraExterna.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCarreraExterna.RowHeadersVisible = false;
            this.dtgCarreraExterna.RowHeadersWidth = 52;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCarreraExterna.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCarreraExterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCarreraExterna.Size = new System.Drawing.Size(560, 164);
            this.dtgCarreraExterna.TabIndex = 49;
            // 
            // txtid
            // 
            this.txtid.HeaderText = "Id";
            this.txtid.MinimumWidth = 11;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Visible = false;
            // 
            // txtnro
            // 
            this.txtnro.FillWeight = 30.45685F;
            this.txtnro.HeaderText = "Nro.";
            this.txtnro.MinimumWidth = 11;
            this.txtnro.Name = "txtnro";
            this.txtnro.ReadOnly = true;
            // 
            // txtnombre
            // 
            this.txtnombre.FillWeight = 169.5432F;
            this.txtnombre.HeaderText = "Nombre";
            this.txtnombre.MinimumWidth = 11;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            // 
            // FrmCarreraExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(612, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(546, 550);
            this.Name = "FrmCarreraExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarrera";
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarreraExterna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbltitu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreCarreraLic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarreraExt;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCarreraExt;
        private System.Windows.Forms.Button btnEditarCarreraExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgCarreraExterna;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnombre;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnSelecCarreraExt;
    }
}