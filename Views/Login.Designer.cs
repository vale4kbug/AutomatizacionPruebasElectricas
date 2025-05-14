namespace AutomatizacionPruebasElectricas
{
    partial class Login
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
			this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtUsuarioContrasena = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAbout = new System.Windows.Forms.Button();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUsuarioLogin
			// 
			this.txtUsuarioLogin.BackColor = System.Drawing.SystemColors.Info;
			this.txtUsuarioLogin.ForeColor = System.Drawing.Color.Teal;
			this.txtUsuarioLogin.Location = new System.Drawing.Point(273, 177);
			this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuarioLogin.Name = "txtUsuarioLogin";
			this.txtUsuarioLogin.Size = new System.Drawing.Size(257, 39);
			this.txtUsuarioLogin.TabIndex = 0;
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.MintCream;
			this.btnIngresar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnIngresar.FlatAppearance.BorderSize = 2;
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIngresar.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.btnIngresar.Location = new System.Drawing.Point(321, 358);
			this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(125, 55);
			this.btnIngresar.TabIndex = 2;
			this.btnIngresar.Text = "Iniciar Sesión";
			this.btnIngresar.UseMnemonic = false;
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.UseWaitCursor = true;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// txtUsuarioContrasena
			// 
			this.txtUsuarioContrasena.BackColor = System.Drawing.SystemColors.Info;
			this.txtUsuarioContrasena.ForeColor = System.Drawing.Color.Teal;
			this.txtUsuarioContrasena.Location = new System.Drawing.Point(273, 279);
			this.txtUsuarioContrasena.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuarioContrasena.Name = "txtUsuarioContrasena";
			this.txtUsuarioContrasena.Size = new System.Drawing.Size(257, 39);
			this.txtUsuarioContrasena.TabIndex = 1;
			this.txtUsuarioContrasena.UseSystemPasswordChar = true;
			this.txtUsuarioContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuarioContrasena_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(195, 180);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(166, 282);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contraseña";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Nirmala Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(136, 34);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(536, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Sistema de Automatizacion de Pruebas Electricas";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(293, 118);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ingresa tus credenciales";
			// 
			// btnAbout
			// 
			this.btnAbout.BackgroundImage = global::AutomatizacionPruebasElectricas.Properties.Resources.about_logo;
			this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAbout.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnAbout.FlatAppearance.BorderSize = 0;
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.btnAbout.Location = new System.Drawing.Point(13, 468);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(46, 41);
			this.btnAbout.TabIndex = 3;
			this.btnAbout.UseMnemonic = false;
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.UseWaitCursor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(157, 429);
			this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(108, 23);
			this.lblMensaje.TabIndex = 7;
			this.lblMensaje.Text = "Cargando ...";
			this.lblMensaje.Visible = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(769, 522);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuarioContrasena);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.txtUsuarioLogin);
			this.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log-In";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuarioContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
		private System.Windows.Forms.Label lblMensaje;
    }
}

