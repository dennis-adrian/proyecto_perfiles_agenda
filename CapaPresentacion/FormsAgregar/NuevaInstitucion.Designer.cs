namespace CapaPresentacion.FormsAgregar
{
    partial class NuevaInstitucion
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
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancelarNuevaInstitucion = new System.Windows.Forms.Button();
            this.btnAgregarInstitucion = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Location = new System.Drawing.Point(65, 188);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(198, 22);
            this.txtInstitucion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 74);
            this.panel2.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 36);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Institucion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(442, 33);
            this.pnlBarraTitulo.TabIndex = 18;
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
            this.btnCerrar.Location = new System.Drawing.Point(396, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(45, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(61, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "Registro";
            // 
            // btnCancelarNuevaInstitucion
            // 
            this.btnCancelarNuevaInstitucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelarNuevaInstitucion.FlatAppearance.BorderSize = 0;
            this.btnCancelarNuevaInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevaInstitucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevaInstitucion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaInstitucion.Location = new System.Drawing.Point(65, 250);
            this.btnCancelarNuevaInstitucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarNuevaInstitucion.Name = "btnCancelarNuevaInstitucion";
            this.btnCancelarNuevaInstitucion.Size = new System.Drawing.Size(101, 31);
            this.btnCancelarNuevaInstitucion.TabIndex = 24;
            this.btnCancelarNuevaInstitucion.Text = "Cancelar";
            this.btnCancelarNuevaInstitucion.UseVisualStyleBackColor = false;
            this.btnCancelarNuevaInstitucion.Click += new System.EventHandler(this.btnCancelarNuevaInstitucion_Click);
            // 
            // btnAgregarInstitucion
            // 
            this.btnAgregarInstitucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAgregarInstitucion.FlatAppearance.BorderSize = 0;
            this.btnAgregarInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInstitucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInstitucion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInstitucion.Location = new System.Drawing.Point(182, 250);
            this.btnAgregarInstitucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarInstitucion.Name = "btnAgregarInstitucion";
            this.btnAgregarInstitucion.Size = new System.Drawing.Size(91, 31);
            this.btnAgregarInstitucion.TabIndex = 23;
            this.btnAgregarInstitucion.Text = "Guardar";
            this.btnAgregarInstitucion.UseVisualStyleBackColor = false;
            this.btnAgregarInstitucion.Click += new System.EventHandler(this.btnAgregarInstitucion_Click);
            // 
            // NuevaInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(442, 408);
            this.Controls.Add(this.btnCancelarNuevaInstitucion);
            this.Controls.Add(this.btnAgregarInstitucion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInstitucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaInstitucion";
            this.Text = "NuevaInstitucion";
            this.panel2.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancelarNuevaInstitucion;
        private System.Windows.Forms.Button btnAgregarInstitucion;
    }
}