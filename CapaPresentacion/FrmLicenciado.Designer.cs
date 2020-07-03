namespace CapaPresentacion
{
    partial class FrmLicenciado
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
            this.pnlBodyLicenciado = new System.Windows.Forms.Panel();
            this.dtgLicenciados = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeleccionarLicenciado = new System.Windows.Forms.Button();
            this.btnAgregarLicenciado = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlbarralicenciado = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pnlBodyLicenciado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLicenciados)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlbarralicenciado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBodyLicenciado
            // 
            this.pnlBodyLicenciado.BackColor = System.Drawing.Color.LightGray;
            this.pnlBodyLicenciado.Controls.Add(this.dtgLicenciados);
            this.pnlBodyLicenciado.Controls.Add(this.panel2);
            this.pnlBodyLicenciado.Controls.Add(this.pnlbarralicenciado);
            this.pnlBodyLicenciado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyLicenciado.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyLicenciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBodyLicenciado.Name = "pnlBodyLicenciado";
            this.pnlBodyLicenciado.Size = new System.Drawing.Size(638, 488);
            this.pnlBodyLicenciado.TabIndex = 0;
            // 
            // dtgLicenciados
            // 
            this.dtgLicenciados.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgLicenciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLicenciados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLicenciados.Location = new System.Drawing.Point(0, 87);
            this.dtgLicenciados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgLicenciados.Name = "dtgLicenciados";
            this.dtgLicenciados.RowHeadersWidth = 51;
            this.dtgLicenciados.RowTemplate.Height = 24;
            this.dtgLicenciados.Size = new System.Drawing.Size(638, 401);
            this.dtgLicenciados.TabIndex = 17;
            this.dtgLicenciados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLicenciados_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnSeleccionarLicenciado);
            this.panel2.Controls.Add(this.btnAgregarLicenciado);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 60);
            this.panel2.TabIndex = 16;
            // 
            // btnSeleccionarLicenciado
            // 
            this.btnSeleccionarLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSeleccionarLicenciado.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLicenciado.Location = new System.Drawing.Point(343, 17);
            this.btnSeleccionarLicenciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionarLicenciado.Name = "btnSeleccionarLicenciado";
            this.btnSeleccionarLicenciado.Size = new System.Drawing.Size(100, 29);
            this.btnSeleccionarLicenciado.TabIndex = 26;
            this.btnSeleccionarLicenciado.Text = "Seleccionar";
            this.btnSeleccionarLicenciado.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLicenciado
            // 
            this.btnAgregarLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAgregarLicenciado.FlatAppearance.BorderSize = 0;
            this.btnAgregarLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLicenciado.Location = new System.Drawing.Point(469, 17);
            this.btnAgregarLicenciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarLicenciado.Name = "btnAgregarLicenciado";
            this.btnAgregarLicenciado.Size = new System.Drawing.Size(88, 29);
            this.btnAgregarLicenciado.TabIndex = 25;
            this.btnAgregarLicenciado.Text = "Agregar";
            this.btnAgregarLicenciado.UseVisualStyleBackColor = false;
            this.btnAgregarLicenciado.Click += new System.EventHandler(this.btnAgregarLicenciado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(14, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 29);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Licenciados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pnlbarralicenciado
            // 
            this.pnlbarralicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlbarralicenciado.Controls.Add(this.btnCerrar);
            this.pnlbarralicenciado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbarralicenciado.Location = new System.Drawing.Point(0, 0);
            this.pnlbarralicenciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlbarralicenciado.Name = "pnlbarralicenciado";
            this.pnlbarralicenciado.Size = new System.Drawing.Size(638, 27);
            this.pnlbarralicenciado.TabIndex = 1;
            this.pnlbarralicenciado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlbarralicenciado_MouseDown);
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
            this.btnCerrar.Location = new System.Drawing.Point(603, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmLicenciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(638, 488);
            this.Controls.Add(this.pnlBodyLicenciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLicenciado";
            this.Text = "FrmLicenciado";
            this.pnlBodyLicenciado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLicenciados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlbarralicenciado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBodyLicenciado;
        private System.Windows.Forms.Panel pnlbarralicenciado;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.DataGridView dtgLicenciados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionarLicenciado;
        private System.Windows.Forms.Button btnAgregarLicenciado;
    }
}