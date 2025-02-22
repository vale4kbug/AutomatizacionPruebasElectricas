namespace AutomatizacionPruebasElectricas
{
    partial class RegistroPersonal
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
            this.btnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebas
            // 
            this.btnPruebas.BackColor = System.Drawing.SystemColors.Info;
            this.btnPruebas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPruebas.FlatAppearance.BorderSize = 2;
            this.btnPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebas.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnPruebas.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnPruebas.Location = new System.Drawing.Point(13, 395);
            this.btnPruebas.Margin = new System.Windows.Forms.Padding(4);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(66, 42);
            this.btnPruebas.TabIndex = 10;
            this.btnPruebas.Text = "<-";
            this.btnPruebas.UseMnemonic = false;
            this.btnPruebas.UseVisualStyleBackColor = false;
            this.btnPruebas.UseWaitCursor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // RegistroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebas);
            this.Name = "RegistroPersonal";
            this.Text = "Registro de Personal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebas;
    }
}