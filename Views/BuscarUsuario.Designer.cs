namespace AutomatizacionPruebasElectricas.Views
{
	partial class BuscarUsuario
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.dgUsuarios = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(83, 20);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(661, 22);
			this.txtFiltro.TabIndex = 1;
			this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
			// 
			// dgUsuarios
			// 
			this.dgUsuarios.AllowUserToAddRows = false;
			this.dgUsuarios.AllowUserToDeleteRows = false;
			this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsuarios.Location = new System.Drawing.Point(12, 60);
			this.dgUsuarios.Name = "dgUsuarios";
			this.dgUsuarios.ReadOnly = true;
			this.dgUsuarios.RowHeadersVisible = false;
			this.dgUsuarios.RowHeadersWidth = 51;
			this.dgUsuarios.RowTemplate.Height = 24;
			this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgUsuarios.Size = new System.Drawing.Size(776, 355);
			this.dgUsuarios.TabIndex = 2;
			this.dgUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentDoubleClick);
			this.dgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellDoubleClick);
			this.dgUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgUsuarios_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(492, 425);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "*Haz doble click para seleccionar un usuario";
			// 
			// BuscarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgUsuarios);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.label1);
			this.Name = "BuscarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar usuario";
			this.Load += new System.EventHandler(this.BuscarUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.DataGridView dgUsuarios;
		private System.Windows.Forms.Label label2;
	}
}