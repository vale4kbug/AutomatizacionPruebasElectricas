namespace AutomatizacionPruebasElectricas.Views
{
    partial class BuscarProcedimientos
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
            this.dgProcedimientos = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Haz doble click para seleccionar un procedimiento";
            // 
            // dgProcedimientos
            // 
            this.dgProcedimientos.AllowUserToAddRows = false;
            this.dgProcedimientos.AllowUserToDeleteRows = false;
            this.dgProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProcedimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcedimientos.Location = new System.Drawing.Point(12, 55);
            this.dgProcedimientos.Name = "dgProcedimientos";
            this.dgProcedimientos.ReadOnly = true;
            this.dgProcedimientos.RowHeadersVisible = false;
            this.dgProcedimientos.RowHeadersWidth = 51;
            this.dgProcedimientos.RowTemplate.Height = 24;
            this.dgProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProcedimientos.Size = new System.Drawing.Size(776, 355);
            this.dgProcedimientos.TabIndex = 6;
            this.dgProcedimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProcedimientos_CellDoubleClick);
            this.dgProcedimientos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProcedimientos_KeyDown);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(83, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(661, 22);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // BuscarProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgProcedimientos);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Name = "BuscarProcedimientos";
            this.Text = "Procedimientos";
            this.Load += new System.EventHandler(this.BuscarProcedimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcedimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProcedimientos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
    }
}