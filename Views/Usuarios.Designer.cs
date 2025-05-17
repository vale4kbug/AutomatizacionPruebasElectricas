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
			this.picFoto = new System.Windows.Forms.PictureBox();
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
			this.BtnAddModify = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnModulos = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.BtnCredencial = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(162, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(117, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(117, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de contratacion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Nirmala Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(288, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 41);
			this.label5.TabIndex = 4;
			this.label5.Text = "Usuarios";
			// 
			// picFoto
			// 
			this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
			this.picFoto.Location = new System.Drawing.Point(434, 66);
			this.picFoto.Name = "picFoto";
			this.picFoto.Size = new System.Drawing.Size(263, 230);
			this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFoto.TabIndex = 5;
			this.picFoto.TabStop = false;
			// 
			// BtnRuta
			// 
			this.BtnRuta.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRuta.Location = new System.Drawing.Point(434, 305);
			this.BtnRuta.Name = "BtnRuta";
			this.BtnRuta.Size = new System.Drawing.Size(186, 35);
			this.BtnRuta.TabIndex = 6;
			this.BtnRuta.Text = "Seleccionar foto";
			this.BtnRuta.UseVisualStyleBackColor = true;
			this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
			// 
			// txtUserID
			// 
			this.txtUserID.BackColor = System.Drawing.SystemColors.Info;
			this.txtUserID.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.Location = new System.Drawing.Point(196, 66);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(129, 39);
			this.txtUserID.TabIndex = 7;
			this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
			this.txtNombre.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(196, 112);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(225, 39);
			this.txtNombre.TabIndex = 8;
			// 
			// txtApellido
			// 
			this.txtApellido.BackColor = System.Drawing.SystemColors.Info;
			this.txtApellido.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(196, 156);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(225, 39);
			this.txtApellido.TabIndex = 9;
			// 
			// dtFecha
			// 
			this.dtFecha.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(196, 200);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(134, 39);
			this.dtFecha.TabIndex = 10;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
			this.txtPassword.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(196, 291);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(225, 39);
			this.txtPassword.TabIndex = 14;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.SystemColors.Info;
			this.txtUsername.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(196, 243);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(225, 39);
			this.txtUsername.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(93, 294);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Contraseña";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(103, 246);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Username";
			// 
			// chkShowPassword
			// 
			this.chkShowPassword.AutoSize = true;
			this.chkShowPassword.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowPassword.Location = new System.Drawing.Point(223, 340);
			this.chkShowPassword.Name = "chkShowPassword";
			this.chkShowPassword.Size = new System.Drawing.Size(180, 27);
			this.chkShowPassword.TabIndex = 15;
			this.chkShowPassword.Text = "Mostrar contraseña";
			this.chkShowPassword.UseVisualStyleBackColor = true;
			this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
			// 
			// OpenImage
			// 
			this.OpenImage.FileName = "openFileDialog1";
			// 
			// BtnAddModify
			// 
			this.BtnAddModify.BackColor = System.Drawing.Color.Honeydew;
			this.BtnAddModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnAddModify.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
			this.BtnAddModify.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.BtnAddModify.Location = new System.Drawing.Point(206, 383);
			this.BtnAddModify.Name = "BtnAddModify";
			this.BtnAddModify.Size = new System.Drawing.Size(197, 65);
			this.BtnAddModify.TabIndex = 16;
			this.BtnAddModify.Text = "Agregar/Modificar";
			this.BtnAddModify.UseVisualStyleBackColor = false;
			this.BtnAddModify.Click += new System.EventHandler(this.BtnAddModify_Click);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.BackColor = System.Drawing.Color.MistyRose;
			this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnEliminar.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
			this.BtnEliminar.ForeColor = System.Drawing.Color.SaddleBrown;
			this.BtnEliminar.Location = new System.Drawing.Point(556, 383);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(142, 65);
			this.BtnEliminar.TabIndex = 17;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = false;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// BtnModulos
			// 
			this.BtnModulos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnModulos.Location = new System.Drawing.Point(331, 68);
			this.BtnModulos.Name = "BtnModulos";
			this.BtnModulos.Size = new System.Drawing.Size(90, 33);
			this.BtnModulos.TabIndex = 18;
			this.BtnModulos.Text = "Modulos";
			this.BtnModulos.UseVisualStyleBackColor = true;
			this.BtnModulos.Click += new System.EventHandler(this.BtnModulos_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.BackColor = System.Drawing.Color.Honeydew;
			this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnClear.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
			this.BtnClear.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.BtnClear.Location = new System.Drawing.Point(58, 383);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(142, 65);
			this.BtnClear.TabIndex = 19;
			this.BtnClear.Text = "Limpiar campos";
			this.BtnClear.UseVisualStyleBackColor = false;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnSearch
			// 
			this.BtnSearch.BackColor = System.Drawing.Color.LightCyan;
			this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnSearch.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
			this.BtnSearch.ForeColor = System.Drawing.Color.DarkCyan;
			this.BtnSearch.Location = new System.Drawing.Point(408, 383);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(142, 65);
			this.BtnSearch.TabIndex = 20;
			this.BtnSearch.Text = "Buscar";
			this.BtnSearch.UseVisualStyleBackColor = false;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// BtnCredencial
			// 
			this.BtnCredencial.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCredencial.Location = new System.Drawing.Point(626, 305);
			this.BtnCredencial.Name = "BtnCredencial";
			this.BtnCredencial.Size = new System.Drawing.Size(71, 35);
			this.BtnCredencial.TabIndex = 21;
			this.BtnCredencial.Text = "PDF";
			this.BtnCredencial.UseVisualStyleBackColor = true;
			this.BtnCredencial.Click += new System.EventHandler(this.BtnCredencial_Click);
			// 
			// Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(719, 470);
			this.Controls.Add(this.BtnCredencial);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnModulos);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.BtnAddModify);
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
			this.Controls.Add(this.picFoto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Usuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.Usuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picFoto;
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
		private System.Windows.Forms.Button BtnAddModify;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button BtnModulos;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.Button BtnCredencial;
	}
}