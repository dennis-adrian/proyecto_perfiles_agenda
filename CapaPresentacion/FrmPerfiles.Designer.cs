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
            this.pnlBuscar2 = new System.Windows.Forms.Panel();
            this.btnBuscarPerfil = new System.Windows.Forms.Button();
            this.txtBuscarPerfil = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgPerfilesTesis = new System.Windows.Forms.DataGridView();
            this.pnlBuscar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerfilesTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscar2
            // 
            this.pnlBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBuscar2.Controls.Add(this.btnBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.txtBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.label14);
            this.pnlBuscar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar2.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar2.Name = "pnlBuscar2";
            this.pnlBuscar2.Size = new System.Drawing.Size(1141, 57);
            this.pnlBuscar2.TabIndex = 2;
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscarPerfil.FlatAppearance.BorderSize = 0;
            this.btnBuscarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarPerfil.Location = new System.Drawing.Point(969, 10);
            this.btnBuscarPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Size = new System.Drawing.Size(96, 33);
            this.btnBuscarPerfil.TabIndex = 25;
            this.btnBuscarPerfil.Text = "Buscar";
            this.btnBuscarPerfil.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPerfil
            // 
            this.txtBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerfil.Location = new System.Drawing.Point(747, 14);
            this.txtBuscarPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPerfil.Name = "txtBuscarPerfil";
            this.txtBuscarPerfil.Size = new System.Drawing.Size(206, 27);
            this.txtBuscarPerfil.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(552, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre Estudiante";
            // 
            // dtgPerfilesTesis
            // 
            this.dtgPerfilesTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPerfilesTesis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPerfilesTesis.Location = new System.Drawing.Point(0, 57);
            this.dtgPerfilesTesis.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPerfilesTesis.Name = "dtgPerfilesTesis";
            this.dtgPerfilesTesis.RowHeadersWidth = 51;
            this.dtgPerfilesTesis.Size = new System.Drawing.Size(1141, 604);
            this.dtgPerfilesTesis.TabIndex = 3;
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 661);
            this.Controls.Add(this.dtgPerfilesTesis);
            this.Controls.Add(this.pnlBuscar2);
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
    }
}