namespace CapaPresentacion
{
    partial class FrmRevisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRevisiones));
            this.pnlBarraNuevoLicenciado = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCuartaRev = new System.Windows.Forms.Panel();
            this.btnAddNewRev4 = new System.Windows.Forms.Button();
            this.pnlTerceraRev = new System.Windows.Forms.Panel();
            this.btnAddNewRev3 = new System.Windows.Forms.Button();
            this.pnlSegundaRev = new System.Windows.Forms.Panel();
            this.btnAddNewRev = new System.Windows.Forms.Button();
            this.pnlPrimeraRev = new System.Windows.Forms.Panel();
            this.btnCuartaRev = new System.Windows.Forms.Button();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.btnTerceraRev = new System.Windows.Forms.Button();
            this.btnSegundaRev = new System.Windows.Forms.Button();
            this.btnPrimeraRev = new System.Windows.Forms.Button();
            this.btnGeneralRev = new System.Windows.Forms.Button();
            this.pnlContenedorRev = new System.Windows.Forms.Panel();
            this.pnlBarraNuevoLicenciado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraNuevoLicenciado
            // 
            this.pnlBarraNuevoLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraNuevoLicenciado.Controls.Add(this.btnCerrar);
            this.pnlBarraNuevoLicenciado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraNuevoLicenciado.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraNuevoLicenciado.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBarraNuevoLicenciado.Name = "pnlBarraNuevoLicenciado";
            this.pnlBarraNuevoLicenciado.Size = new System.Drawing.Size(1600, 52);
            this.pnlBarraNuevoLicenciado.TabIndex = 1;
            this.pnlBarraNuevoLicenciado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraNuevoLicenciado_MouseDown);
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
            this.btnCerrar.Location = new System.Drawing.Point(1530, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(68, 56);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 104);
            this.panel2.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(492, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(650, 56);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Revisiones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCuartaRev);
            this.panel1.Controls.Add(this.btnAddNewRev4);
            this.panel1.Controls.Add(this.pnlTerceraRev);
            this.panel1.Controls.Add(this.btnAddNewRev3);
            this.panel1.Controls.Add(this.pnlSegundaRev);
            this.panel1.Controls.Add(this.btnAddNewRev);
            this.panel1.Controls.Add(this.pnlPrimeraRev);
            this.panel1.Controls.Add(this.btnCuartaRev);
            this.panel1.Controls.Add(this.pnlGeneral);
            this.panel1.Controls.Add(this.btnTerceraRev);
            this.panel1.Controls.Add(this.btnSegundaRev);
            this.panel1.Controls.Add(this.btnPrimeraRev);
            this.panel1.Controls.Add(this.btnGeneralRev);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 75);
            this.panel1.TabIndex = 18;
            // 
            // pnlCuartaRev
            // 
            this.pnlCuartaRev.BackColor = System.Drawing.Color.Crimson;
            this.pnlCuartaRev.Location = new System.Drawing.Point(1042, 63);
            this.pnlCuartaRev.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCuartaRev.Name = "pnlCuartaRev";
            this.pnlCuartaRev.Size = new System.Drawing.Size(280, 15);
            this.pnlCuartaRev.TabIndex = 24;
            // 
            // btnAddNewRev4
            // 
            this.btnAddNewRev4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewRev4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewRev4.FlatAppearance.BorderSize = 0;
            this.btnAddNewRev4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnAddNewRev4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewRev4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRev4.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewRev4.Image")));
            this.btnAddNewRev4.Location = new System.Drawing.Point(1494, 0);
            this.btnAddNewRev4.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewRev4.Name = "btnAddNewRev4";
            this.btnAddNewRev4.Size = new System.Drawing.Size(86, 75);
            this.btnAddNewRev4.TabIndex = 7;
            this.btnAddNewRev4.UseVisualStyleBackColor = false;
            this.btnAddNewRev4.Click += new System.EventHandler(this.btnAddNewRev4_Click);
            // 
            // pnlTerceraRev
            // 
            this.pnlTerceraRev.BackColor = System.Drawing.Color.Crimson;
            this.pnlTerceraRev.Location = new System.Drawing.Point(762, 63);
            this.pnlTerceraRev.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTerceraRev.Name = "pnlTerceraRev";
            this.pnlTerceraRev.Size = new System.Drawing.Size(280, 15);
            this.pnlTerceraRev.TabIndex = 23;
            // 
            // btnAddNewRev3
            // 
            this.btnAddNewRev3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewRev3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewRev3.FlatAppearance.BorderSize = 0;
            this.btnAddNewRev3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnAddNewRev3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewRev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRev3.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewRev3.Image")));
            this.btnAddNewRev3.Location = new System.Drawing.Point(1408, 0);
            this.btnAddNewRev3.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewRev3.Name = "btnAddNewRev3";
            this.btnAddNewRev3.Size = new System.Drawing.Size(86, 75);
            this.btnAddNewRev3.TabIndex = 6;
            this.btnAddNewRev3.UseVisualStyleBackColor = false;
            this.btnAddNewRev3.Click += new System.EventHandler(this.btnAddNewRev3_Click);
            // 
            // pnlSegundaRev
            // 
            this.pnlSegundaRev.BackColor = System.Drawing.Color.Crimson;
            this.pnlSegundaRev.Location = new System.Drawing.Point(462, 63);
            this.pnlSegundaRev.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSegundaRev.Name = "pnlSegundaRev";
            this.pnlSegundaRev.Size = new System.Drawing.Size(300, 15);
            this.pnlSegundaRev.TabIndex = 22;
            // 
            // btnAddNewRev
            // 
            this.btnAddNewRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNewRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewRev.FlatAppearance.BorderSize = 0;
            this.btnAddNewRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnAddNewRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRev.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewRev.Image")));
            this.btnAddNewRev.Location = new System.Drawing.Point(1322, 0);
            this.btnAddNewRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewRev.Name = "btnAddNewRev";
            this.btnAddNewRev.Size = new System.Drawing.Size(86, 75);
            this.btnAddNewRev.TabIndex = 5;
            this.btnAddNewRev.UseVisualStyleBackColor = false;
            this.btnAddNewRev.Click += new System.EventHandler(this.btnAddNewRev_Click);
            // 
            // pnlPrimeraRev
            // 
            this.pnlPrimeraRev.BackColor = System.Drawing.Color.Crimson;
            this.pnlPrimeraRev.Location = new System.Drawing.Point(184, 63);
            this.pnlPrimeraRev.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrimeraRev.Name = "pnlPrimeraRev";
            this.pnlPrimeraRev.Size = new System.Drawing.Size(280, 15);
            this.pnlPrimeraRev.TabIndex = 21;
            // 
            // btnCuartaRev
            // 
            this.btnCuartaRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuartaRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCuartaRev.FlatAppearance.BorderSize = 0;
            this.btnCuartaRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCuartaRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuartaRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuartaRev.ForeColor = System.Drawing.Color.White;
            this.btnCuartaRev.Location = new System.Drawing.Point(1042, 0);
            this.btnCuartaRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnCuartaRev.Name = "btnCuartaRev";
            this.btnCuartaRev.Size = new System.Drawing.Size(280, 75);
            this.btnCuartaRev.TabIndex = 4;
            this.btnCuartaRev.Text = "Cuarta Revision";
            this.btnCuartaRev.UseVisualStyleBackColor = false;
            this.btnCuartaRev.Click += new System.EventHandler(this.btnCuartaRev_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.Crimson;
            this.pnlGeneral.Location = new System.Drawing.Point(2, 63);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(182, 15);
            this.pnlGeneral.TabIndex = 20;
            // 
            // btnTerceraRev
            // 
            this.btnTerceraRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTerceraRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTerceraRev.FlatAppearance.BorderSize = 0;
            this.btnTerceraRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnTerceraRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerceraRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerceraRev.ForeColor = System.Drawing.Color.White;
            this.btnTerceraRev.Location = new System.Drawing.Point(762, 0);
            this.btnTerceraRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnTerceraRev.Name = "btnTerceraRev";
            this.btnTerceraRev.Size = new System.Drawing.Size(280, 75);
            this.btnTerceraRev.TabIndex = 3;
            this.btnTerceraRev.Text = "Tercera Revision";
            this.btnTerceraRev.UseVisualStyleBackColor = false;
            this.btnTerceraRev.Click += new System.EventHandler(this.btnTerceraRev_Click);
            // 
            // btnSegundaRev
            // 
            this.btnSegundaRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSegundaRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSegundaRev.FlatAppearance.BorderSize = 0;
            this.btnSegundaRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSegundaRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundaRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaRev.ForeColor = System.Drawing.Color.White;
            this.btnSegundaRev.Location = new System.Drawing.Point(462, 0);
            this.btnSegundaRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnSegundaRev.Name = "btnSegundaRev";
            this.btnSegundaRev.Size = new System.Drawing.Size(300, 75);
            this.btnSegundaRev.TabIndex = 2;
            this.btnSegundaRev.Text = "Segunda Revision";
            this.btnSegundaRev.UseVisualStyleBackColor = false;
            this.btnSegundaRev.Click += new System.EventHandler(this.btnSegundaRev_Click);
            // 
            // btnPrimeraRev
            // 
            this.btnPrimeraRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrimeraRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrimeraRev.FlatAppearance.BorderSize = 0;
            this.btnPrimeraRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnPrimeraRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeraRev.ForeColor = System.Drawing.Color.White;
            this.btnPrimeraRev.Location = new System.Drawing.Point(182, 0);
            this.btnPrimeraRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrimeraRev.Name = "btnPrimeraRev";
            this.btnPrimeraRev.Size = new System.Drawing.Size(280, 75);
            this.btnPrimeraRev.TabIndex = 1;
            this.btnPrimeraRev.Text = "Primera Revision";
            this.btnPrimeraRev.UseVisualStyleBackColor = false;
            this.btnPrimeraRev.Click += new System.EventHandler(this.btnPrimeraRev_Click);
            // 
            // btnGeneralRev
            // 
            this.btnGeneralRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeneralRev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGeneralRev.FlatAppearance.BorderSize = 0;
            this.btnGeneralRev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnGeneralRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralRev.ForeColor = System.Drawing.Color.White;
            this.btnGeneralRev.Location = new System.Drawing.Point(0, 0);
            this.btnGeneralRev.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneralRev.Name = "btnGeneralRev";
            this.btnGeneralRev.Size = new System.Drawing.Size(182, 75);
            this.btnGeneralRev.TabIndex = 0;
            this.btnGeneralRev.Text = "General";
            this.btnGeneralRev.UseVisualStyleBackColor = false;
            this.btnGeneralRev.Click += new System.EventHandler(this.btnGeneralRev_Click);
            // 
            // pnlContenedorRev
            // 
            this.pnlContenedorRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorRev.Location = new System.Drawing.Point(0, 231);
            this.pnlContenedorRev.Margin = new System.Windows.Forms.Padding(6);
            this.pnlContenedorRev.Name = "pnlContenedorRev";
            this.pnlContenedorRev.Size = new System.Drawing.Size(1600, 838);
            this.pnlContenedorRev.TabIndex = 19;
            // 
            // FrmRevisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 1069);
            this.Controls.Add(this.pnlContenedorRev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarraNuevoLicenciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmRevisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRevisiones2";
            this.Load += new System.EventHandler(this.FrmRevisiones2_Load);
            this.pnlBarraNuevoLicenciado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraNuevoLicenciado;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerceraRev;
        private System.Windows.Forms.Button btnSegundaRev;
        private System.Windows.Forms.Button btnPrimeraRev;
        private System.Windows.Forms.Button btnGeneralRev;
        private System.Windows.Forms.Button btnCuartaRev;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlPrimeraRev;
        private System.Windows.Forms.Panel pnlSegundaRev;
        private System.Windows.Forms.Panel pnlTerceraRev;
        private System.Windows.Forms.Panel pnlCuartaRev;
        private System.Windows.Forms.Button btnAddNewRev;
        private System.Windows.Forms.Button btnAddNewRev4;
        private System.Windows.Forms.Button btnAddNewRev3;
        private System.Windows.Forms.Panel pnlContenedorRev;
    }
}