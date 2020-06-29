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
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnBuscarAgenda = new System.Windows.Forms.Button();
            this.txtBuscarAgenda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dtgDefensaExterna = new System.Windows.Forms.DataGridView();
            this.pnlBuscar.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDefensaExterna)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBuscar.Controls.Add(this.btnBuscarAgenda);
            this.pnlBuscar.Controls.Add(this.txtBuscarAgenda);
            this.pnlBuscar.Controls.Add(this.label14);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(1141, 57);
            this.pnlBuscar.TabIndex = 1;
            // 
            // btnBuscarAgenda
            // 
            this.btnBuscarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscarAgenda.FlatAppearance.BorderSize = 0;
            this.btnBuscarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAgenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarAgenda.Location = new System.Drawing.Point(969, 10);
            this.btnBuscarAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAgenda.Name = "btnBuscarAgenda";
            this.btnBuscarAgenda.Size = new System.Drawing.Size(96, 33);
            this.btnBuscarAgenda.TabIndex = 25;
            this.btnBuscarAgenda.Text = "Buscar";
            this.btnBuscarAgenda.UseVisualStyleBackColor = false;
            // 
            // txtBuscarAgenda
            // 
            this.txtBuscarAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAgenda.Location = new System.Drawing.Point(747, 14);
            this.txtBuscarAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarAgenda.Name = "txtBuscarAgenda";
            this.txtBuscarAgenda.Size = new System.Drawing.Size(206, 27);
            this.txtBuscarAgenda.TabIndex = 24;
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
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.Controls.Add(this.dtgDefensaExterna);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 57);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(1141, 604);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dtgDefensaExterna
            // 
            this.dtgDefensaExterna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDefensaExterna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDefensaExterna.Location = new System.Drawing.Point(0, 0);
            this.dtgDefensaExterna.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDefensaExterna.Name = "dtgDefensaExterna";
            this.dtgDefensaExterna.RowHeadersWidth = 51;
            this.dtgDefensaExterna.Size = new System.Drawing.Size(1141, 604);
            this.dtgDefensaExterna.TabIndex = 0;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1141, 661);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDefensaExterna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox txtBuscarAgenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dtgDefensaExterna;
        private System.Windows.Forms.Button btnBuscarAgenda;
    }
}