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
            this.btnBuscarDefensa = new System.Windows.Forms.Button();
            this.txtBuscarDefensa = new System.Windows.Forms.TextBox();
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
            this.pnlBuscar.Controls.Add(this.btnBuscarDefensa);
            this.pnlBuscar.Controls.Add(this.txtBuscarDefensa);
            this.pnlBuscar.Controls.Add(this.label14);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(810, 46);
            this.pnlBuscar.TabIndex = 1;
            // 
            // btnBuscarDefensa
            // 
            this.btnBuscarDefensa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarDefensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscarDefensa.FlatAppearance.BorderSize = 0;
            this.btnBuscarDefensa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarDefensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDefensa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarDefensa.Location = new System.Drawing.Point(694, 8);
            this.btnBuscarDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarDefensa.Name = "btnBuscarDefensa";
            this.btnBuscarDefensa.Size = new System.Drawing.Size(72, 27);
            this.btnBuscarDefensa.TabIndex = 25;
            this.btnBuscarDefensa.Text = "Buscar";
            this.btnBuscarDefensa.UseVisualStyleBackColor = false;
            this.btnBuscarDefensa.Click += new System.EventHandler(this.btnBuscarDefensa_Click);
            // 
            // txtBuscarDefensa
            // 
            this.txtBuscarDefensa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarDefensa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDefensa.Location = new System.Drawing.Point(520, 11);
            this.txtBuscarDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDefensa.Name = "txtBuscarDefensa";
            this.txtBuscarDefensa.Size = new System.Drawing.Size(155, 23);
            this.txtBuscarDefensa.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(356, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre Estudiante";
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.Silver;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDefensaExterna.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDefensaExterna.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgDefensaExterna.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDefensaExterna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDefensaExterna.Size = new System.Drawing.Size(810, 432);
            this.dtgDefensaExterna.TabIndex = 0;
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtBuscarDefensa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dtgDefensaExterna;
        private System.Windows.Forms.Button btnBuscarDefensa;
    }
}