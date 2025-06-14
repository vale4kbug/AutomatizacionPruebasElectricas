﻿namespace AutomatizacionPruebasElectricas
{
    partial class Estacion
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
			this.label3 = new System.Windows.Forms.Label();
			this.Productos = new System.Windows.Forms.Button();
			this.Pruebas = new System.Windows.Forms.Button();
			this.Usuarios = new System.Windows.Forms.Button();
			this.Ventas = new System.Windows.Forms.Button();
			this.Especificaciones = new System.Windows.Forms.Button();
			this.Procedimientos = new System.Windows.Forms.Button();
			this.Lineas = new System.Windows.Forms.Button();
			this.Estaciones = new System.Windows.Forms.Button();
			this.Manual = new System.Windows.Forms.Button();
			this.Reportes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(139, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(590, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sistema de Automatizacion de Pruebas Electricas";
			// 
			// Productos
			// 
			this.Productos.BackColor = System.Drawing.Color.MintCream;
			this.Productos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Productos.FlatAppearance.BorderSize = 2;
			this.Productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Productos.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.Productos.Location = new System.Drawing.Point(128, 68);
			this.Productos.Margin = new System.Windows.Forms.Padding(4);
			this.Productos.Name = "Productos";
			this.Productos.Size = new System.Drawing.Size(169, 68);
			this.Productos.TabIndex = 7;
			this.Productos.Text = "Productos";
			this.Productos.UseMnemonic = false;
			this.Productos.UseVisualStyleBackColor = false;
			this.Productos.UseWaitCursor = true;
			this.Productos.Visible = false;
			this.Productos.Click += new System.EventHandler(this.btnRegistroProducto_Click_1);
			// 
			// Pruebas
			// 
			this.Pruebas.BackColor = System.Drawing.Color.GhostWhite;
			this.Pruebas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Pruebas.FlatAppearance.BorderSize = 2;
			this.Pruebas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Pruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Pruebas.ForeColor = System.Drawing.Color.MediumSlateBlue;
			this.Pruebas.Location = new System.Drawing.Point(511, 68);
			this.Pruebas.Margin = new System.Windows.Forms.Padding(4);
			this.Pruebas.Name = "Pruebas";
			this.Pruebas.Size = new System.Drawing.Size(169, 68);
			this.Pruebas.TabIndex = 9;
			this.Pruebas.Text = "Pruebas";
			this.Pruebas.UseMnemonic = false;
			this.Pruebas.UseVisualStyleBackColor = false;
			this.Pruebas.UseWaitCursor = true;
			this.Pruebas.Visible = false;
			this.Pruebas.Click += new System.EventHandler(this.btnPruebas_Click);
			// 
			// Usuarios
			// 
			this.Usuarios.BackColor = System.Drawing.Color.LavenderBlush;
			this.Usuarios.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Usuarios.FlatAppearance.BorderSize = 2;
			this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Usuarios.ForeColor = System.Drawing.Color.Purple;
			this.Usuarios.Location = new System.Drawing.Point(325, 68);
			this.Usuarios.Margin = new System.Windows.Forms.Padding(4);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.Size = new System.Drawing.Size(169, 68);
			this.Usuarios.TabIndex = 10;
			this.Usuarios.Text = "Usuarios";
			this.Usuarios.UseMnemonic = false;
			this.Usuarios.UseVisualStyleBackColor = false;
			this.Usuarios.UseWaitCursor = true;
			this.Usuarios.Visible = false;
			this.Usuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
			// 
			// Ventas
			// 
			this.Ventas.BackColor = System.Drawing.Color.LightCyan;
			this.Ventas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Ventas.FlatAppearance.BorderSize = 2;
			this.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Ventas.ForeColor = System.Drawing.Color.RoyalBlue;
			this.Ventas.Location = new System.Drawing.Point(325, 144);
			this.Ventas.Margin = new System.Windows.Forms.Padding(4);
			this.Ventas.Name = "Ventas";
			this.Ventas.Size = new System.Drawing.Size(169, 68);
			this.Ventas.TabIndex = 11;
			this.Ventas.Text = "Ventas";
			this.Ventas.UseMnemonic = false;
			this.Ventas.UseVisualStyleBackColor = false;
			this.Ventas.UseWaitCursor = true;
			this.Ventas.Visible = false;
			this.Ventas.Click += new System.EventHandler(this.button1_Click);
			// 
			// Especificaciones
			// 
			this.Especificaciones.BackColor = System.Drawing.Color.PapayaWhip;
			this.Especificaciones.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Especificaciones.FlatAppearance.BorderSize = 2;
			this.Especificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Especificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Especificaciones.ForeColor = System.Drawing.Color.SaddleBrown;
			this.Especificaciones.Location = new System.Drawing.Point(128, 144);
			this.Especificaciones.Margin = new System.Windows.Forms.Padding(4);
			this.Especificaciones.Name = "Especificaciones";
			this.Especificaciones.Size = new System.Drawing.Size(169, 68);
			this.Especificaciones.TabIndex = 12;
			this.Especificaciones.Text = "Especificaciones";
			this.Especificaciones.UseMnemonic = false;
			this.Especificaciones.UseVisualStyleBackColor = false;
			this.Especificaciones.UseWaitCursor = true;
			this.Especificaciones.Visible = false;
			this.Especificaciones.Click += new System.EventHandler(this.btnEspecificaciones_Click);
			// 
			// Procedimientos
			// 
			this.Procedimientos.BackColor = System.Drawing.Color.MistyRose;
			this.Procedimientos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Procedimientos.FlatAppearance.BorderSize = 2;
			this.Procedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Procedimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Procedimientos.ForeColor = System.Drawing.Color.Coral;
			this.Procedimientos.Location = new System.Drawing.Point(511, 144);
			this.Procedimientos.Margin = new System.Windows.Forms.Padding(4);
			this.Procedimientos.Name = "Procedimientos";
			this.Procedimientos.Size = new System.Drawing.Size(169, 68);
			this.Procedimientos.TabIndex = 13;
			this.Procedimientos.Text = "Procedimientos";
			this.Procedimientos.UseMnemonic = false;
			this.Procedimientos.UseVisualStyleBackColor = false;
			this.Procedimientos.UseWaitCursor = true;
			this.Procedimientos.Visible = false;
			this.Procedimientos.Click += new System.EventHandler(this.btnProcedimientos_Click);
			// 
			// Lineas
			// 
			this.Lineas.BackColor = System.Drawing.Color.Honeydew;
			this.Lineas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Lineas.FlatAppearance.BorderSize = 2;
			this.Lineas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Lineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Lineas.ForeColor = System.Drawing.Color.ForestGreen;
			this.Lineas.Location = new System.Drawing.Point(128, 220);
			this.Lineas.Margin = new System.Windows.Forms.Padding(4);
			this.Lineas.Name = "Lineas";
			this.Lineas.Size = new System.Drawing.Size(169, 68);
			this.Lineas.TabIndex = 14;
			this.Lineas.Text = "Lineas de produccion";
			this.Lineas.UseMnemonic = false;
			this.Lineas.UseVisualStyleBackColor = false;
			this.Lineas.UseWaitCursor = true;
			this.Lineas.Visible = false;
			this.Lineas.Click += new System.EventHandler(this.btnLinea_Click);
			// 
			// Estaciones
			// 
			this.Estaciones.BackColor = System.Drawing.Color.AntiqueWhite;
			this.Estaciones.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Estaciones.FlatAppearance.BorderSize = 2;
			this.Estaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Estaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Estaciones.ForeColor = System.Drawing.Color.Peru;
			this.Estaciones.Location = new System.Drawing.Point(325, 220);
			this.Estaciones.Margin = new System.Windows.Forms.Padding(4);
			this.Estaciones.Name = "Estaciones";
			this.Estaciones.Size = new System.Drawing.Size(169, 68);
			this.Estaciones.TabIndex = 15;
			this.Estaciones.Text = "Estacion";
			this.Estaciones.UseMnemonic = false;
			this.Estaciones.UseVisualStyleBackColor = false;
			this.Estaciones.UseWaitCursor = true;
			this.Estaciones.Visible = false;
			this.Estaciones.Click += new System.EventHandler(this.btnEstacion_Click);
			// 
			// Manual
			// 
			this.Manual.BackColor = System.Drawing.Color.Honeydew;
			this.Manual.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Manual.FlatAppearance.BorderSize = 2;
			this.Manual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Manual.ForeColor = System.Drawing.Color.ForestGreen;
			this.Manual.Location = new System.Drawing.Point(511, 220);
			this.Manual.Margin = new System.Windows.Forms.Padding(4);
			this.Manual.Name = "Manual";
			this.Manual.Size = new System.Drawing.Size(169, 68);
			this.Manual.TabIndex = 16;
			this.Manual.Text = "Prueba Manual";
			this.Manual.UseMnemonic = false;
			this.Manual.UseVisualStyleBackColor = false;
			this.Manual.UseWaitCursor = true;
			this.Manual.Visible = false;
			this.Manual.Click += new System.EventHandler(this.Manual_Click);
			// 
			// Reportes
			// 
			this.Reportes.BackColor = System.Drawing.Color.Honeydew;
			this.Reportes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Reportes.FlatAppearance.BorderSize = 2;
			this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.Reportes.ForeColor = System.Drawing.Color.ForestGreen;
			this.Reportes.Location = new System.Drawing.Point(325, 296);
			this.Reportes.Margin = new System.Windows.Forms.Padding(4);
			this.Reportes.Name = "Reportes";
			this.Reportes.Size = new System.Drawing.Size(169, 68);
			this.Reportes.TabIndex = 17;
			this.Reportes.Text = "Reportes";
			this.Reportes.UseMnemonic = false;
			this.Reportes.UseVisualStyleBackColor = false;
			this.Reportes.UseWaitCursor = true;
			this.Reportes.Visible = false;
			this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
			// 
			// Estacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Reportes);
			this.Controls.Add(this.Manual);
			this.Controls.Add(this.Estaciones);
			this.Controls.Add(this.Lineas);
			this.Controls.Add(this.Procedimientos);
			this.Controls.Add(this.Especificaciones);
			this.Controls.Add(this.Ventas);
			this.Controls.Add(this.Usuarios);
			this.Controls.Add(this.Pruebas);
			this.Controls.Add(this.Productos);
			this.Controls.Add(this.label3);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Estacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
			this.Load += new System.EventHandler(this.Menu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Productos;
        private System.Windows.Forms.Button Pruebas;
		private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button Ventas;
        private System.Windows.Forms.Button Especificaciones;
        private System.Windows.Forms.Button Procedimientos;
        private System.Windows.Forms.Button Lineas;
        private System.Windows.Forms.Button Estaciones;
        private System.Windows.Forms.Button Manual;
		private System.Windows.Forms.Button Reportes;
	}
}