namespace AutomatizacionPruebasElectricas.Views
{
    partial class Productos
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnRegistrarProductos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregasEspecificacion = new System.Windows.Forms.Button();
            this.btnEliminarEspecificaciones = new System.Windows.Forms.Button();
            this.btnEliminarProcedimientos = new System.Windows.Forms.Button();
            this.btnAgregarProcedimientos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxProcedimientos = new System.Windows.Forms.ListBox();
            this.dataEspecificaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Modelo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.Info;
            this.txtModelo.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtModelo.ForeColor = System.Drawing.Color.Teal;
            this.txtModelo.Location = new System.Drawing.Point(185, 77);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(257, 39);
            this.txtModelo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "No. de Serie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNoSerie
            // 
            this.txtNoSerie.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoSerie.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNoSerie.ForeColor = System.Drawing.Color.Teal;
            this.txtNoSerie.Location = new System.Drawing.Point(185, 30);
            this.txtNoSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoSerie.Name = "txtNoSerie";
            this.txtNoSerie.Size = new System.Drawing.Size(257, 39);
            this.txtNoSerie.TabIndex = 28;
            this.txtNoSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoSerie_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Descripcion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richDescripcion
            // 
            this.richDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.richDescripcion.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.richDescripcion.Location = new System.Drawing.Point(185, 134);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(257, 96);
            this.richDescripcion.TabIndex = 34;
            this.richDescripcion.Text = "";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarProductos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBuscarProductos.FlatAppearance.BorderSize = 2;
            this.btnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProductos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProductos.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarProductos.Location = new System.Drawing.Point(550, 132);
            this.btnBuscarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(193, 54);
            this.btnBuscarProductos.TabIndex = 42;
            this.btnBuscarProductos.Text = "Buscar";
            this.btnBuscarProductos.UseMnemonic = false;
            this.btnBuscarProductos.UseVisualStyleBackColor = false;
            this.btnBuscarProductos.UseWaitCursor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminarProductos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEliminarProductos.FlatAppearance.BorderSize = 2;
            this.btnEliminarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProductos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProductos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminarProductos.Location = new System.Drawing.Point(550, 73);
            this.btnEliminarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(193, 54);
            this.btnEliminarProductos.TabIndex = 41;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseMnemonic = false;
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            this.btnEliminarProductos.UseWaitCursor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.BackColor = System.Drawing.Color.Honeydew;
            this.btnRegistrarProductos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegistrarProductos.FlatAppearance.BorderSize = 2;
            this.btnRegistrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarProductos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarProductos.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrarProductos.Location = new System.Drawing.Point(550, 13);
            this.btnRegistrarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(193, 54);
            this.btnRegistrarProductos.TabIndex = 40;
            this.btnRegistrarProductos.Text = "Registrar/Modificar";
            this.btnRegistrarProductos.UseMnemonic = false;
            this.btnRegistrarProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarProductos.UseWaitCursor = true;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnRegresar.Location = new System.Drawing.Point(655, 306);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 42);
            this.btnRegresar.TabIndex = 43;
            this.btnRegresar.Text = "<-";
            this.btnRegresar.UseMnemonic = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.UseWaitCursor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Azure;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnLimpiar.Location = new System.Drawing.Point(550, 194);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(193, 54);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseMnemonic = false;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.UseWaitCursor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Especificaciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregasEspecificacion
            // 
            this.btnAgregasEspecificacion.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregasEspecificacion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAgregasEspecificacion.FlatAppearance.BorderSize = 2;
            this.btnAgregasEspecificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregasEspecificacion.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregasEspecificacion.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregasEspecificacion.Location = new System.Drawing.Point(326, 282);
            this.btnAgregasEspecificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregasEspecificacion.Name = "btnAgregasEspecificacion";
            this.btnAgregasEspecificacion.Size = new System.Drawing.Size(45, 39);
            this.btnAgregasEspecificacion.TabIndex = 49;
            this.btnAgregasEspecificacion.Text = "+";
            this.btnAgregasEspecificacion.UseMnemonic = false;
            this.btnAgregasEspecificacion.UseVisualStyleBackColor = false;
            this.btnAgregasEspecificacion.UseWaitCursor = true;
            this.btnAgregasEspecificacion.Click += new System.EventHandler(this.btnAgregasEspecificacion_Click);
            // 
            // btnEliminarEspecificaciones
            // 
            this.btnEliminarEspecificaciones.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminarEspecificaciones.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEliminarEspecificaciones.FlatAppearance.BorderSize = 2;
            this.btnEliminarEspecificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEspecificaciones.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEspecificaciones.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminarEspecificaciones.Location = new System.Drawing.Point(326, 327);
            this.btnEliminarEspecificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEspecificaciones.Name = "btnEliminarEspecificaciones";
            this.btnEliminarEspecificaciones.Size = new System.Drawing.Size(45, 39);
            this.btnEliminarEspecificaciones.TabIndex = 50;
            this.btnEliminarEspecificaciones.Text = "-";
            this.btnEliminarEspecificaciones.UseMnemonic = false;
            this.btnEliminarEspecificaciones.UseVisualStyleBackColor = false;
            this.btnEliminarEspecificaciones.UseWaitCursor = true;
            this.btnEliminarEspecificaciones.Click += new System.EventHandler(this.btnEliminarEspecificaciones_Click);
            // 
            // btnEliminarProcedimientos
            // 
            this.btnEliminarProcedimientos.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminarProcedimientos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEliminarProcedimientos.FlatAppearance.BorderSize = 2;
            this.btnEliminarProcedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProcedimientos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProcedimientos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEliminarProcedimientos.Location = new System.Drawing.Point(602, 327);
            this.btnEliminarProcedimientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProcedimientos.Name = "btnEliminarProcedimientos";
            this.btnEliminarProcedimientos.Size = new System.Drawing.Size(45, 39);
            this.btnEliminarProcedimientos.TabIndex = 54;
            this.btnEliminarProcedimientos.Text = "-";
            this.btnEliminarProcedimientos.UseMnemonic = false;
            this.btnEliminarProcedimientos.UseVisualStyleBackColor = false;
            this.btnEliminarProcedimientos.UseWaitCursor = true;
            this.btnEliminarProcedimientos.Click += new System.EventHandler(this.btnEliminarProcedimientos_Click);
            // 
            // btnAgregarProcedimientos
            // 
            this.btnAgregarProcedimientos.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregarProcedimientos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAgregarProcedimientos.FlatAppearance.BorderSize = 2;
            this.btnAgregarProcedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProcedimientos.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarProcedimientos.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarProcedimientos.Location = new System.Drawing.Point(602, 282);
            this.btnAgregarProcedimientos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProcedimientos.Name = "btnAgregarProcedimientos";
            this.btnAgregarProcedimientos.Size = new System.Drawing.Size(45, 39);
            this.btnAgregarProcedimientos.TabIndex = 53;
            this.btnAgregarProcedimientos.Text = "+";
            this.btnAgregarProcedimientos.UseMnemonic = false;
            this.btnAgregarProcedimientos.UseVisualStyleBackColor = false;
            this.btnAgregarProcedimientos.UseWaitCursor = true;
            this.btnAgregarProcedimientos.Click += new System.EventHandler(this.btnAgregarProcedimientos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(391, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Procedimientos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxProcedimientos
            // 
            this.listBoxProcedimientos.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxProcedimientos.FormattingEnabled = true;
            this.listBoxProcedimientos.ItemHeight = 16;
            this.listBoxProcedimientos.Location = new System.Drawing.Point(390, 282);
            this.listBoxProcedimientos.Name = "listBoxProcedimientos";
            this.listBoxProcedimientos.Size = new System.Drawing.Size(205, 84);
            this.listBoxProcedimientos.TabIndex = 51;
            this.listBoxProcedimientos.DoubleClick += new System.EventHandler(this.listBoxProcedimientos_DoubleClick);
            // 
            // dataEspecificaciones
            // 
            this.dataEspecificaciones.AllowUserToAddRows = false;
            this.dataEspecificaciones.AllowUserToDeleteRows = false;
            this.dataEspecificaciones.AllowUserToResizeRows = false;
            this.dataEspecificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataEspecificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEspecificaciones.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEspecificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataEspecificaciones.Location = new System.Drawing.Point(12, 283);
            this.dataEspecificaciones.MultiSelect = false;
            this.dataEspecificaciones.Name = "dataEspecificaciones";
            this.dataEspecificaciones.RowHeadersVisible = false;
            this.dataEspecificaciones.RowHeadersWidth = 51;
            this.dataEspecificaciones.RowTemplate.Height = 24;
            this.dataEspecificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEspecificaciones.Size = new System.Drawing.Size(307, 83);
            this.dataEspecificaciones.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Especificacion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 124;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 68;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(760, 378);
            this.Controls.Add(this.dataEspecificaciones);
            this.Controls.Add(this.btnEliminarProcedimientos);
            this.Controls.Add(this.btnAgregarProcedimientos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxProcedimientos);
            this.Controls.Add(this.btnEliminarEspecificaciones);
            this.Controls.Add(this.btnAgregasEspecificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.btnEliminarProductos);
            this.Controls.Add(this.btnRegistrarProductos);
            this.Controls.Add(this.richDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoSerie);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataEspecificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnRegistrarProductos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregasEspecificacion;
        private System.Windows.Forms.Button btnEliminarEspecificaciones;
        private System.Windows.Forms.Button btnEliminarProcedimientos;
        private System.Windows.Forms.Button btnAgregarProcedimientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxProcedimientos;
        private System.Windows.Forms.DataGridView dataEspecificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}