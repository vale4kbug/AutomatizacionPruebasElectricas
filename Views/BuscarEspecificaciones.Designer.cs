namespace AutomatizacionPruebasElectricas.Views
{
    partial class BuscarEspecificaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgEspecificaciones = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "*Haz doble click para seleccionar una especificacion";
            // 
            // dgEspecificaciones
            // 
            this.dgEspecificaciones.AllowUserToAddRows = false;
            this.dgEspecificaciones.AllowUserToDeleteRows = false;
            this.dgEspecificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEspecificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecificaciones.Location = new System.Drawing.Point(12, 58);
            this.dgEspecificaciones.Name = "dgEspecificaciones";
            this.dgEspecificaciones.ReadOnly = true;
            this.dgEspecificaciones.RowHeadersVisible = false;
            this.dgEspecificaciones.RowHeadersWidth = 51;
            this.dgEspecificaciones.RowTemplate.Height = 24;
            this.dgEspecificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEspecificaciones.Size = new System.Drawing.Size(776, 355);
            this.dgEspecificaciones.TabIndex = 10;
            this.dgEspecificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEspecificaciones_CellContentClick);
            this.dgEspecificaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEspecificaciones_CellContentDoubleClick);
            this.dgEspecificaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgEspecificaciones_KeyDown);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(83, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(661, 22);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar";
            // 
            // BuscarEspecificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEspecificaciones);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Name = "BuscarEspecificaciones";
            this.Text = "Especificaciones";
            this.Load += new System.EventHandler(this.BuscarEspecificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEspecificaciones;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
    }
}