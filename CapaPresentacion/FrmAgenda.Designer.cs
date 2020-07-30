namespace CapaPresentacion
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnEditarAgenda = new System.Windows.Forms.Button();
            this.txtBuscarDefensa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dtgDefensaExterna = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnFiltro = new FontAwesome.Sharp.IconButton();
            this.pnlFiltroDefensa = new System.Windows.Forms.Panel();
            this.btnPorExecencia = new FontAwesome.Sharp.IconButton();
            this.btnTesis = new FontAwesome.Sharp.IconButton();
            this.btnExamenGrado = new FontAwesome.Sharp.IconButton();
            this.pnlBuscar.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDefensaExterna)).BeginInit();
            this.pnlFiltroDefensa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBuscar.Controls.Add(this.btnFiltro);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.btnEditarAgenda);
            this.pnlBuscar.Controls.Add(this.txtBuscarDefensa);
            this.pnlBuscar.Controls.Add(this.label14);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(810, 46);
            this.pnlBuscar.TabIndex = 1;
            // 
            // btnEditarAgenda
            // 
            this.btnEditarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarAgenda.FlatAppearance.BorderSize = 0;
            this.btnEditarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAgenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarAgenda.Location = new System.Drawing.Point(11, 11);
            this.btnEditarAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarAgenda.Name = "btnEditarAgenda";
            this.btnEditarAgenda.Size = new System.Drawing.Size(255, 25);
            this.btnEditarAgenda.TabIndex = 27;
            this.btnEditarAgenda.Text = "Editar Información de la Defensa";
            this.btnEditarAgenda.UseVisualStyleBackColor = false;
            this.btnEditarAgenda.Click += new System.EventHandler(this.btnEditarAgenda_Click);
            // 
            // txtBuscarDefensa
            // 
            this.txtBuscarDefensa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDefensa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDefensa.Location = new System.Drawing.Point(603, 14);
            this.txtBuscarDefensa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarDefensa.Name = "txtBuscarDefensa";
            this.txtBuscarDefensa.Size = new System.Drawing.Size(196, 24);
            this.txtBuscarDefensa.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(448, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre Estudiante";
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.Silver;
            this.pnlDataGrid.Controls.Add(this.pnlFiltroDefensa);
            this.pnlDataGrid.Controls.Add(this.dtgDefensaExterna);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 46);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(810, 432);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dtgDefensaExterna
            // 
            this.dtgDefensaExterna.AllowUserToAddRows = false;
            this.dtgDefensaExterna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDefensaExterna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDefensaExterna.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgDefensaExterna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDefensaExterna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDefensaExterna.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDefensaExterna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDefensaExterna.ColumnHeadersHeight = 34;
            this.dtgDefensaExterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDefensaExterna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDefensaExterna.EnableHeadersVisualStyles = false;
            this.dtgDefensaExterna.GridColor = System.Drawing.Color.Silver;
            this.dtgDefensaExterna.Location = new System.Drawing.Point(0, 0);
            this.dtgDefensaExterna.Name = "dtgDefensaExterna";
            this.dtgDefensaExterna.ReadOnly = true;
            this.dtgDefensaExterna.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDefensaExterna.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDefensaExterna.RowHeadersVisible = false;
            this.dtgDefensaExterna.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDefensaExterna.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDefensaExterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDefensaExterna.Size = new System.Drawing.Size(810, 432);
            this.dtgDefensaExterna.TabIndex = 0;
            this.dtgDefensaExterna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDefensaExterna_CellContentClick);
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
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.Location = new System.Drawing.Point(774, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(22, 21);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltro.IconColor = System.Drawing.Color.White;
            this.btnFiltro.IconSize = 16;
            this.btnFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltro.Location = new System.Drawing.Point(300, 11);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Rotation = 0D;
            this.btnFiltro.Size = new System.Drawing.Size(70, 25);
            this.btnFiltro.TabIndex = 56;
            this.btnFiltro.Text = " Filtro";
            this.btnFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // pnlFiltroDefensa
            // 
            this.pnlFiltroDefensa.BackColor = System.Drawing.Color.DarkGray;
            this.pnlFiltroDefensa.Controls.Add(this.btnPorExecencia);
            this.pnlFiltroDefensa.Controls.Add(this.btnTesis);
            this.pnlFiltroDefensa.Controls.Add(this.btnExamenGrado);
            this.pnlFiltroDefensa.Location = new System.Drawing.Point(369, 0);
            this.pnlFiltroDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFiltroDefensa.Name = "pnlFiltroDefensa";
            this.pnlFiltroDefensa.Size = new System.Drawing.Size(185, 97);
            this.pnlFiltroDefensa.TabIndex = 33;
            // 
            // btnPorExecencia
            // 
            this.btnPorExecencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnPorExecencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorExecencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorExecencia.FlatAppearance.BorderSize = 0;
            this.btnPorExecencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPorExecencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPorExecencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorExecencia.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPorExecencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorExecencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPorExecencia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPorExecencia.IconColor = System.Drawing.Color.White;
            this.btnPorExecencia.IconSize = 10;
            this.btnPorExecencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorExecencia.Location = new System.Drawing.Point(0, 62);
            this.btnPorExecencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorExecencia.Name = "btnPorExecencia";
            this.btnPorExecencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPorExecencia.Rotation = 0D;
            this.btnPorExecencia.Size = new System.Drawing.Size(185, 31);
            this.btnPorExecencia.TabIndex = 16;
            this.btnPorExecencia.Text = "Graduacion Por Exelencia";
            this.btnPorExecencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPorExecencia.UseVisualStyleBackColor = false;
            this.btnPorExecencia.Click += new System.EventHandler(this.btnPorExecencia_Click);
            // 
            // btnTesis
            // 
            this.btnTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTesis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTesis.FlatAppearance.BorderSize = 0;
            this.btnTesis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesis.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTesis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTesis.IconColor = System.Drawing.Color.White;
            this.btnTesis.IconSize = 10;
            this.btnTesis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesis.Location = new System.Drawing.Point(0, 31);
            this.btnTesis.Margin = new System.Windows.Forms.Padding(2);
            this.btnTesis.Name = "btnTesis";
            this.btnTesis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTesis.Rotation = 0D;
            this.btnTesis.Size = new System.Drawing.Size(185, 31);
            this.btnTesis.TabIndex = 18;
            this.btnTesis.Text = "Tesis";
            this.btnTesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTesis.UseVisualStyleBackColor = false;
            this.btnTesis.Click += new System.EventHandler(this.btnTesis_Click);
            // 
            // btnExamenGrado
            // 
            this.btnExamenGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExamenGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExamenGrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamenGrado.FlatAppearance.BorderSize = 0;
            this.btnExamenGrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnExamenGrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnExamenGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamenGrado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExamenGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenGrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExamenGrado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExamenGrado.IconColor = System.Drawing.Color.White;
            this.btnExamenGrado.IconSize = 10;
            this.btnExamenGrado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamenGrado.Location = new System.Drawing.Point(0, 0);
            this.btnExamenGrado.Margin = new System.Windows.Forms.Padding(2);
            this.btnExamenGrado.Name = "btnExamenGrado";
            this.btnExamenGrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExamenGrado.Rotation = 0D;
            this.btnExamenGrado.Size = new System.Drawing.Size(185, 31);
            this.btnExamenGrado.TabIndex = 17;
            this.btnExamenGrado.Text = "Examen de Grado";
            this.btnExamenGrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamenGrado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExamenGrado.UseVisualStyleBackColor = false;
            this.btnExamenGrado.Click += new System.EventHandler(this.btnExamenGrado_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDefensaExterna)).EndInit();
            this.pnlFiltroDefensa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtBuscarDefensa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dtgDefensaExterna;
        private System.Windows.Forms.Button btnEditarAgenda;
        private FontAwesome.Sharp.IconButton btnFiltro;
        private FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.Panel pnlFiltroDefensa;
        private FontAwesome.Sharp.IconButton btnPorExecencia;
        private FontAwesome.Sharp.IconButton btnTesis;
        private FontAwesome.Sharp.IconButton btnExamenGrado;
    }
}