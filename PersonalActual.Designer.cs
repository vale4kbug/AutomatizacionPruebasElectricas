namespace AutomatizacionPruebasElectricas
{
    partial class PersonalActual
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
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Location = new System.Drawing.Point(60, 110);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.RowHeadersWidth = 51;
            this.dataGridPersonal.RowTemplate.Height = 24;
            this.dataGridPersonal.Size = new System.Drawing.Size(594, 256);
            this.dataGridPersonal.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Location = new System.Drawing.Point(411, 65);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPersonal.TabIndex = 2;
            this.btnBuscarPersonal.Text = "Buscar";
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnRegresar.Location = new System.Drawing.Point(721, 395);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 42);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseMnemonic = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.UseWaitCursor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // PersonalActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscarPersonal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridPersonal);
            this.Name = "PersonalActual";
            this.Text = "Personal Actual";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Button btnRegresar;
    }
}