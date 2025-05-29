namespace AutomatizacionPruebasElectricas.Views
{
    partial class Ventas
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
			this.dataGridVentas = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnModificarVentas = new System.Windows.Forms.Button();
			this.btnEliminarVentas = new System.Windows.Forms.Button();
			this.btnRegistrarVentas = new System.Windows.Forms.Button();
			this.richDescripcion = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNoSerie = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridVentas
			// 
			this.dataGridVentas.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridVentas.Location = new System.Drawing.Point(15, 374);
			this.dataGridVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridVentas.Name = "dataGridVentas";
			this.dataGridVentas.RowHeadersWidth = 51;
			this.dataGridVentas.RowTemplate.Height = 24;
			this.dataGridVentas.Size = new System.Drawing.Size(527, 244);
			this.dataGridVentas.TabIndex = 55;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
			this.btnRegresar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnRegresar.FlatAppearance.BorderSize = 2;
			this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnRegresar.ForeColor = System.Drawing.Color.DarkKhaki;
			this.btnRegresar.Location = new System.Drawing.Point(791, 575);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(67, 42);
			this.btnRegresar.TabIndex = 54;
			this.btnRegresar.Text = "<-";
			this.btnRegresar.UseMnemonic = false;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.UseWaitCursor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnModificarVentas
			// 
			this.btnModificarVentas.BackColor = System.Drawing.Color.LightCyan;
			this.btnModificarVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnModificarVentas.FlatAppearance.BorderSize = 2;
			this.btnModificarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModificarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnModificarVentas.ForeColor = System.Drawing.Color.DarkCyan;
			this.btnModificarVentas.Location = new System.Drawing.Point(372, 314);
			this.btnModificarVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnModificarVentas.Name = "btnModificarVentas";
			this.btnModificarVentas.Size = new System.Drawing.Size(169, 54);
			this.btnModificarVentas.TabIndex = 53;
			this.btnModificarVentas.Text = "Modificar Venta";
			this.btnModificarVentas.UseMnemonic = false;
			this.btnModificarVentas.UseVisualStyleBackColor = false;
			this.btnModificarVentas.UseWaitCursor = true;
			this.btnModificarVentas.Click += new System.EventHandler(this.btnModificarVentas_Click);
			// 
			// btnEliminarVentas
			// 
			this.btnEliminarVentas.BackColor = System.Drawing.Color.MistyRose;
			this.btnEliminarVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnEliminarVentas.FlatAppearance.BorderSize = 2;
			this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnEliminarVentas.ForeColor = System.Drawing.Color.SaddleBrown;
			this.btnEliminarVentas.Location = new System.Drawing.Point(196, 314);
			this.btnEliminarVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminarVentas.Name = "btnEliminarVentas";
			this.btnEliminarVentas.Size = new System.Drawing.Size(169, 54);
			this.btnEliminarVentas.TabIndex = 52;
			this.btnEliminarVentas.Text = "Eliminar Venta";
			this.btnEliminarVentas.UseMnemonic = false;
			this.btnEliminarVentas.UseVisualStyleBackColor = false;
			this.btnEliminarVentas.UseWaitCursor = true;
			this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
			// 
			// btnRegistrarVentas
			// 
			this.btnRegistrarVentas.BackColor = System.Drawing.Color.Honeydew;
			this.btnRegistrarVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.btnRegistrarVentas.FlatAppearance.BorderSize = 2;
			this.btnRegistrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnRegistrarVentas.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btnRegistrarVentas.Location = new System.Drawing.Point(19, 314);
			this.btnRegistrarVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegistrarVentas.Name = "btnRegistrarVentas";
			this.btnRegistrarVentas.Size = new System.Drawing.Size(169, 54);
			this.btnRegistrarVentas.TabIndex = 51;
			this.btnRegistrarVentas.Text = "Registrar Venta";
			this.btnRegistrarVentas.UseMnemonic = false;
			this.btnRegistrarVentas.UseVisualStyleBackColor = false;
			this.btnRegistrarVentas.UseWaitCursor = true;
			this.btnRegistrarVentas.Click += new System.EventHandler(this.btnRegistrarVentas_Click);
			// 
			// richDescripcion
			// 
			this.richDescripcion.BackColor = System.Drawing.SystemColors.Info;
			this.richDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.richDescripcion.Location = new System.Drawing.Point(191, 210);
			this.richDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richDescripcion.Name = "richDescripcion";
			this.richDescripcion.Size = new System.Drawing.Size(257, 96);
			this.richDescripcion.TabIndex = 50;
			this.richDescripcion.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(52, 210);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 49;
			this.label3.Text = "Descripcion";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(64, 156);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Modelo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtModelo
			// 
			this.txtModelo.BackColor = System.Drawing.SystemColors.Info;
			this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.txtModelo.ForeColor = System.Drawing.Color.Teal;
			this.txtModelo.Location = new System.Drawing.Point(191, 154);
			this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(257, 27);
			this.txtModelo.TabIndex = 47;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(52, 110);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 46;
			this.label1.Text = "No. de Serie";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtNoSerie
			// 
			this.txtNoSerie.BackColor = System.Drawing.SystemColors.Info;
			this.txtNoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.txtNoSerie.ForeColor = System.Drawing.Color.Teal;
			this.txtNoSerie.Location = new System.Drawing.Point(191, 106);
			this.txtNoSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNoSerie.Name = "txtNoSerie";
			this.txtNoSerie.Size = new System.Drawing.Size(257, 27);
			this.txtNoSerie.TabIndex = 45;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(52, 18);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 20);
			this.label4.TabIndex = 57;
			this.label4.Text = "No. de Venta";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Info;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBox1.ForeColor = System.Drawing.Color.Teal;
			this.textBox1.Location = new System.Drawing.Point(191, 15);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(257, 27);
			this.textBox1.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(52, 74);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 59;
			this.label5.Text = "Cantidad";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Info;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.textBox2.ForeColor = System.Drawing.Color.Teal;
			this.textBox2.Location = new System.Drawing.Point(191, 70);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(257, 27);
			this.textBox2.TabIndex = 58;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(460, 43);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 20);
			this.label6.TabIndex = 61;
			this.label6.Text = "Comprador";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(585, 43);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(185, 24);
			this.comboBox1.TabIndex = 62;
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 631);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridVentas);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnModificarVentas);
			this.Controls.Add(this.btnEliminarVentas);
			this.Controls.Add(this.btnRegistrarVentas);
			this.Controls.Add(this.richDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNoSerie);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Ventas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ventas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificarVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnRegistrarVentas;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}