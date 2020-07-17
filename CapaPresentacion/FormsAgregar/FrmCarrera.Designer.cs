namespace CapaPresentacion.FormsAgregar
{
    partial class FrmCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrera));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreCarreraLic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaCarreraLicenciado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(350, 27);
            this.pnlBarraTitulo.TabIndex = 28;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(315, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(82, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nueva Carrera Externa";
            // 
            // txtNombreCarreraLic
            // 
            this.txtNombreCarreraLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCarreraLic.Location = new System.Drawing.Point(115, 94);
            this.txtNombreCarreraLic.Name = "txtNombreCarreraLic";
            this.txtNombreCarreraLic.Size = new System.Drawing.Size(208, 24);
            this.txtNombreCarreraLic.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre :";
            // 
            // btnNuevaCarreraLicenciado
            // 
            this.btnNuevaCarreraLicenciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnNuevaCarreraLicenciado.FlatAppearance.BorderSize = 0;
            this.btnNuevaCarreraLicenciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCarreraLicenciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCarreraLicenciado.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCarreraLicenciado.Location = new System.Drawing.Point(148, 146);
            this.btnNuevaCarreraLicenciado.Name = "btnNuevaCarreraLicenciado";
            this.btnNuevaCarreraLicenciado.Size = new System.Drawing.Size(124, 30);
            this.btnNuevaCarreraLicenciado.TabIndex = 31;
            this.btnNuevaCarreraLicenciado.Text = "Guardar";
            this.btnNuevaCarreraLicenciado.UseVisualStyleBackColor = false;
            this.btnNuevaCarreraLicenciado.Click += new System.EventHandler(this.btnNuevaCarreraLicenciado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 45);
            this.panel2.TabIndex = 32;
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(350, 208);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNuevaCarreraLicenciado);
            this.Controls.Add(this.txtNombreCarreraLic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarrera";
            this.Text = "FrmCarrera";
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreCarreraLic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaCarreraLicenciado;
        private System.Windows.Forms.Panel panel2;
    }
}