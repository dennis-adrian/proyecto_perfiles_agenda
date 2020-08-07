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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfiles));
            this.pnlBuscar2 = new System.Windows.Forms.Panel();
            this.btnEditarRevisiones = new System.Windows.Forms.Button();
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
            this.pnlBuscar2.Controls.Add(this.btnEditarRevisiones);
            this.pnlBuscar2.Controls.Add(this.btnBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.txtBuscarPerfil);
            this.pnlBuscar2.Controls.Add(this.label14);
            this.pnlBuscar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscar2.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBuscar2.Name = "pnlBuscar2";
            this.pnlBuscar2.Size = new System.Drawing.Size(1620, 88);
            this.pnlBuscar2.TabIndex = 2;
            // 
            // btnEditarRevisiones
            // 
            this.btnEditarRevisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEditarRevisiones.FlatAppearance.BorderSize = 0;
            this.btnEditarRevisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEditarRevisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRevisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRevisiones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarRevisiones.Location = new System.Drawing.Point(22, 21);
            this.btnEditarRevisiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarRevisiones.Name = "btnEditarRevisiones";
            this.btnEditarRevisiones.Size = new System.Drawing.Size(360, 52);
            this.btnEditarRevisiones.TabIndex = 26;
            this.btnEditarRevisiones.Text = "Editar Revisiones";
            this.btnEditarRevisiones.UseVisualStyleBackColor = false;
            this.btnEditarRevisiones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBuscarPerfil.FlatAppearance.BorderSize = 0;
            this.btnBuscarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBuscarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarPerfil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarPerfil.Location = new System.Drawing.Point(1400, 20);
            this.btnBuscarPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Size = new System.Drawing.Size(144, 40);
            this.btnBuscarPerfil.TabIndex = 25;
            this.btnBuscarPerfil.Text = "Buscar";
            this.btnBuscarPerfil.UseVisualStyleBackColor = false;
            this.btnBuscarPerfil.Click += new System.EventHandler(this.btnBuscarPerfil_Click);
            // 
            // txtBuscarPerfil
            // 
            this.txtBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerfil.Location = new System.Drawing.Point(1000, 20);
            this.txtBuscarPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarPerfil.Name = "txtBuscarPerfil";
            this.txtBuscarPerfil.Size = new System.Drawing.Size(370, 38);
            this.txtBuscarPerfil.TabIndex = 24;
            this.txtBuscarPerfil.TextChanged += new System.EventHandler(this.txtBuscarPerfil_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(700, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(281, 33);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre Estudiante";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dtgPerfilesTesis
            // 
            this.dtgPerfilesTesis.AllowUserToAddRows = false;
            this.dtgPerfilesTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPerfilesTesis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPerfilesTesis.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgPerfilesTesis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPerfilesTesis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgPerfilesTesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPerfilesTesis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPerfilesTesis.ColumnHeadersHeight = 34;
            this.dtgPerfilesTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgPerfilesTesis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPerfilesTesis.EnableHeadersVisualStyles = false;
            this.dtgPerfilesTesis.GridColor = System.Drawing.Color.Silver;
            this.dtgPerfilesTesis.Location = new System.Drawing.Point(0, 88);
            this.dtgPerfilesTesis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgPerfilesTesis.Name = "dtgPerfilesTesis";
            this.dtgPerfilesTesis.ReadOnly = true;
            this.dtgPerfilesTesis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPerfilesTesis.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPerfilesTesis.RowHeadersVisible = false;
            this.dtgPerfilesTesis.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPerfilesTesis.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPerfilesTesis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPerfilesTesis.Size = new System.Drawing.Size(1620, 831);
            this.dtgPerfilesTesis.TabIndex = 3;
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 919);
            this.Controls.Add(this.dtgPerfilesTesis);
            this.Controls.Add(this.pnlBuscar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnEditarRevisiones;
    }
}