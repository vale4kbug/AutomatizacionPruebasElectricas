namespace AutomatizacionPruebasElectricas.Views
{
    partial class Linea
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
			this.btnRegresar.Location = new System.Drawing.Point(13, 395);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(66, 42);
			this.btnRegresar.TabIndex = 44;
			this.btnRegresar.Text = "<-";
			this.btnRegresar.UseMnemonic = false;
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.UseWaitCursor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// Linea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Linea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Linea";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
    }
}