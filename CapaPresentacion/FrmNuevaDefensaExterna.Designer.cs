namespace CapaPresentacion
{
    partial class FrmNuevaDefensaExterna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarNuevaD = new System.Windows.Forms.Button();
            this.btnGuardarNuevoP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDefensa = new System.Windows.Forms.DateTimePicker();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarNuevaD);
            this.panel1.Controls.Add(this.btnGuardarNuevoP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFechaDefensa);
            this.panel1.Controls.Add(this.dtHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 431);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancelarNuevaD
            // 
            this.btnCancelarNuevaD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelarNuevaD.FlatAppearance.BorderSize = 0;
            this.btnCancelarNuevaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevaD.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaD.Location = new System.Drawing.Point(271, 302);
            this.btnCancelarNuevaD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarNuevaD.Name = "btnCancelarNuevaD";
            this.btnCancelarNuevaD.Size = new System.Drawing.Size(82, 38);
            this.btnCancelarNuevaD.TabIndex = 35;
            this.btnCancelarNuevaD.Text = "Cancelar";
            this.btnCancelarNuevaD.UseVisualStyleBackColor = false;
            this.btnCancelarNuevaD.Click += new System.EventHandler(this.btnCancelarNuevaD_Click);
            // 
            // btnGuardarNuevoP
            // 
            this.btnGuardarNuevoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarNuevoP.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoP.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevoP.Location = new System.Drawing.Point(359, 302);
            this.btnGuardarNuevoP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarNuevoP.Name = "btnGuardarNuevoP";
            this.btnGuardarNuevoP.Size = new System.Drawing.Size(82, 38);
            this.btnGuardarNuevoP.TabIndex = 34;
            this.btnGuardarNuevoP.Text = "Guardar";
            this.btnGuardarNuevoP.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo Defensa";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "tesis",
            "examen de grado",
            "proyecto de grado"});
            this.cmbTipo.Location = new System.Drawing.Point(56, 135);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(92, 21);
            this.cmbTipo.TabIndex = 32;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Aula";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(55, 229);
            this.txtAula.Margin = new System.Windows.Forms.Padding(2);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(76, 20);
            this.txtAula.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Defensa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hora";
            // 
            // dtFechaDefensa
            // 
            this.dtFechaDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDefensa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDefensa.Location = new System.Drawing.Point(178, 224);
            this.dtFechaDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaDefensa.Name = "dtFechaDefensa";
            this.dtFechaDefensa.Size = new System.Drawing.Size(108, 24);
            this.dtFechaDefensa.TabIndex = 19;
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(319, 224);
            this.dtHora.Margin = new System.Windows.Forms.Padding(2);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(108, 24);
            this.dtHora.TabIndex = 18;
            // 
            // FrmNuevaDefensaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNuevaDefensaExterna";
            this.Text = "FrmNuevaDefensaExterna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFechaDefensa;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarNuevaD;
        private System.Windows.Forms.Button btnGuardarNuevoP;
    }
}