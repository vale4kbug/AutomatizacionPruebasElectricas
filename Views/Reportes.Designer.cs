namespace AutomatizacionPruebasElectricas.Views
{
	partial class Reportes
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
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.BtnShowReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(342, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecciona los parametros y el reportes que desees ver";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(256, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "De";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(287, 74);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(146, 22);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(476, 74);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(146, 22);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(445, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "A";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(259, 165);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 24);
			this.comboBox1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(256, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Productos";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(455, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Reporte a ver";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Reporte de estadisticas promedio de resistencias de producto",
            "Reporte de estadisticas promedio de voltajes de producto"});
			this.comboBox2.Location = new System.Drawing.Point(458, 165);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(193, 24);
			this.comboBox2.TabIndex = 7;
			// 
			// BtnShowReport
			// 
			this.BtnShowReport.Location = new System.Drawing.Point(385, 237);
			this.BtnShowReport.Name = "BtnShowReport";
			this.BtnShowReport.Size = new System.Drawing.Size(131, 43);
			this.BtnShowReport.TabIndex = 9;
			this.BtnShowReport.Text = "Ver reporte";
			this.BtnShowReport.UseVisualStyleBackColor = true;
			this.BtnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
			// 
			// Reportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 378);
			this.Controls.Add(this.BtnShowReport);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Reportes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reportes";
			this.Load += new System.EventHandler(this.Reportes_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button BtnShowReport;
	}
}