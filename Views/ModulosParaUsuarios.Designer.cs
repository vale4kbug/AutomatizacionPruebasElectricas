namespace AutomatizacionPruebasElectricas.Views
{
	partial class ModulosParaUsuarios
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BtnRegistrarPermisos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(462, 304);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Modulo";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Acceso";
			this.Column2.Items.AddRange(new object[] {
            "No",
            "Si"});
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column2.Width = 125;
			// 
			// BtnRegistrarPermisos
			// 
			this.BtnRegistrarPermisos.Location = new System.Drawing.Point(187, 327);
			this.BtnRegistrarPermisos.Name = "BtnRegistrarPermisos";
			this.BtnRegistrarPermisos.Size = new System.Drawing.Size(169, 32);
			this.BtnRegistrarPermisos.TabIndex = 1;
			this.BtnRegistrarPermisos.Text = "registrar permisos";
			this.BtnRegistrarPermisos.UseVisualStyleBackColor = true;
			this.BtnRegistrarPermisos.Click += new System.EventHandler(this.BtnRegistrarPermisos_Click);
			// 
			// ModulosParaUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 362);
			this.Controls.Add(this.BtnRegistrarPermisos);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ModulosParaUsuarios";
			this.Text = "ModulosParaUsuarios";
			this.Load += new System.EventHandler(this.ModulosParaUsuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
		private System.Windows.Forms.Button BtnRegistrarPermisos;
	}
}