namespace AutomatizacionPruebasElectricas.Views
{
	partial class Usuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnRuta = new System.Windows.Forms.Button();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.chkShowPassword = new System.Windows.Forms.CheckBox();
			this.OpenImage = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(131, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de contratacion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(246, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Usuarios";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(401, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// BtnRuta
			// 
			this.BtnRuta.Location = new System.Drawing.Point(401, 255);
			this.BtnRuta.Name = "BtnRuta";
			this.BtnRuta.Size = new System.Drawing.Size(186, 23);
			this.BtnRuta.TabIndex = 6;
			this.BtnRuta.Text = "Seleccionar foto";
			this.BtnRuta.UseVisualStyleBackColor = true;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(157, 83);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(129, 22);
			this.txtUserID.TabIndex = 7;
			this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(157, 111);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(225, 22);
			this.txtNombre.TabIndex = 8;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(157, 142);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(225, 22);
			this.txtApellido.TabIndex = 9;
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(157, 170);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(134, 22);
			this.dtFecha.TabIndex = 10;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(157, 229);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(225, 22);
			this.txtPassword.TabIndex = 14;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(157, 198);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(225, 22);
			this.txtUsername.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(76, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Contraseña";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Username";
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Location = new System.Drawing.Point(238, 257);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(144, 20);
			this.chkShowPassword.TabIndex = 15;
			this.chkShowPassword.Text = "Mostrar contraseña";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
			// 
			// OpenImage
			// 
			this.OpenImage.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 29);
			this.button1.TabIndex = 16;
			this.button1.Text = "Agregar/Modificar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(196, 298);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 29);
			this.button2.TabIndex = 17;
			this.button2.Text = "Eliminar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(292, 83);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 22);
			this.button3.TabIndex = 18;
			this.button3.Text = "Modulos";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 427);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chkShowPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtFecha);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.BtnRuta);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Usuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.Usuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnRuta;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkShowPassword;
		private System.Windows.Forms.OpenFileDialog OpenImage;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}