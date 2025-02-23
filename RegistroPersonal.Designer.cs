namespace AutomatizacionPruebasElectricas
{
    partial class RegistroPersonal
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePersonal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoPersonal = new System.Windows.Forms.TextBox();
            this.cmbPuestoPersonal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenaPersonal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioPersonal = new System.Windows.Forms.TextBox();
            this.btnImagenPersonal = new System.Windows.Forms.Button();
            this.btnRegistrarPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnRegresar.Location = new System.Drawing.Point(17, 275);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 42);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseMnemonic = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.UseWaitCursor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombrePersonal
            // 
            this.txtNombrePersonal.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePersonal.ForeColor = System.Drawing.Color.Teal;
            this.txtNombrePersonal.Location = new System.Drawing.Point(131, 38);
            this.txtNombrePersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePersonal.Name = "txtNombrePersonal";
            this.txtNombrePersonal.Size = new System.Drawing.Size(257, 22);
            this.txtNombrePersonal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellidoPersonal
            // 
            this.txtApellidoPersonal.BackColor = System.Drawing.SystemColors.Info;
            this.txtApellidoPersonal.ForeColor = System.Drawing.Color.Teal;
            this.txtApellidoPersonal.Location = new System.Drawing.Point(131, 81);
            this.txtApellidoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoPersonal.Name = "txtApellidoPersonal";
            this.txtApellidoPersonal.Size = new System.Drawing.Size(257, 22);
            this.txtApellidoPersonal.TabIndex = 13;
            // 
            // cmbPuestoPersonal
            // 
            this.cmbPuestoPersonal.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPuestoPersonal.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbPuestoPersonal.FormattingEnabled = true;
            this.cmbPuestoPersonal.Location = new System.Drawing.Point(131, 126);
            this.cmbPuestoPersonal.Name = "cmbPuestoPersonal";
            this.cmbPuestoPersonal.Size = new System.Drawing.Size(257, 31);
            this.cmbPuestoPersonal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Puesto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contraseña";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContrasenaPersonal
            // 
            this.txtContrasenaPersonal.BackColor = System.Drawing.SystemColors.Info;
            this.txtContrasenaPersonal.ForeColor = System.Drawing.Color.Teal;
            this.txtContrasenaPersonal.Location = new System.Drawing.Point(131, 220);
            this.txtContrasenaPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaPersonal.Name = "txtContrasenaPersonal";
            this.txtContrasenaPersonal.Size = new System.Drawing.Size(257, 22);
            this.txtContrasenaPersonal.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsuarioPersonal
            // 
            this.txtUsuarioPersonal.BackColor = System.Drawing.SystemColors.Info;
            this.txtUsuarioPersonal.ForeColor = System.Drawing.Color.Teal;
            this.txtUsuarioPersonal.Location = new System.Drawing.Point(131, 177);
            this.txtUsuarioPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioPersonal.Name = "txtUsuarioPersonal";
            this.txtUsuarioPersonal.Size = new System.Drawing.Size(257, 22);
            this.txtUsuarioPersonal.TabIndex = 17;
            // 
            // btnImagenPersonal
            // 
            this.btnImagenPersonal.BackColor = System.Drawing.Color.Honeydew;
            this.btnImagenPersonal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnImagenPersonal.FlatAppearance.BorderSize = 2;
            this.btnImagenPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenPersonal.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnImagenPersonal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImagenPersonal.Location = new System.Drawing.Point(432, 35);
            this.btnImagenPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnImagenPersonal.Name = "btnImagenPersonal";
            this.btnImagenPersonal.Size = new System.Drawing.Size(169, 68);
            this.btnImagenPersonal.TabIndex = 21;
            this.btnImagenPersonal.Text = "Cargar Imagen";
            this.btnImagenPersonal.UseMnemonic = false;
            this.btnImagenPersonal.UseVisualStyleBackColor = false;
            this.btnImagenPersonal.UseWaitCursor = true;
            // 
            // btnRegistrarPersonal
            // 
            this.btnRegistrarPersonal.BackColor = System.Drawing.Color.Honeydew;
            this.btnRegistrarPersonal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegistrarPersonal.FlatAppearance.BorderSize = 2;
            this.btnRegistrarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarPersonal.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPersonal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarPersonal.Location = new System.Drawing.Point(432, 249);
            this.btnRegistrarPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarPersonal.Name = "btnRegistrarPersonal";
            this.btnRegistrarPersonal.Size = new System.Drawing.Size(169, 68);
            this.btnRegistrarPersonal.TabIndex = 22;
            this.btnRegistrarPersonal.Text = "Registrar Personal";
            this.btnRegistrarPersonal.UseMnemonic = false;
            this.btnRegistrarPersonal.UseVisualStyleBackColor = false;
            this.btnRegistrarPersonal.UseWaitCursor = true;
            // 
            // RegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(655, 345);
            this.Controls.Add(this.btnRegistrarPersonal);
            this.Controls.Add(this.btnImagenPersonal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContrasenaPersonal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsuarioPersonal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPuestoPersonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombrePersonal);
            this.Controls.Add(this.btnRegresar);
            this.Name = "RegistroPersonal";
            this.Text = "Registro de Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoPersonal;
        private System.Windows.Forms.ComboBox cmbPuestoPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasenaPersonal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuarioPersonal;
        private System.Windows.Forms.Button btnImagenPersonal;
        private System.Windows.Forms.Button btnRegistrarPersonal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarPersonal;
        private System.Windows.Forms.Button btnModificarPersonal;
    }
}