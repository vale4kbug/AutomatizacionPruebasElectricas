namespace AutomatizacionPruebasElectricas
{
    partial class Pruebas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.MedicionGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicionGrafica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(27, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Serie";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 68;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descripcion";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 108;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Voltaje";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Corriente";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 79;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIniciar.BackColor = System.Drawing.Color.Honeydew;
            this.BtnIniciar.Location = new System.Drawing.Point(532, 11);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(189, 50);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnStop.Enabled = false;
            this.BtnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStop.Location = new System.Drawing.Point(736, 11);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(189, 50);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Detener";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.button1);
            this.buttonPanel.Controls.Add(this.BtnStop);
            this.buttonPanel.Controls.Add(this.BtnIniciar);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 522);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1146, 64);
            this.buttonPanel.TabIndex = 3;
            // 
            // MedicionGrafica
            // 
            this.MedicionGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicionGrafica.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.MedicionGrafica.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.MedicionGrafica.Legends.Add(legend3);
            this.MedicionGrafica.Location = new System.Drawing.Point(644, 62);
            this.MedicionGrafica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MedicionGrafica.Name = "MedicionGrafica";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = " ";
            this.MedicionGrafica.Series.Add(series3);
            this.MedicionGrafica.Size = new System.Drawing.Size(413, 265);
            this.MedicionGrafica.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.SystemColors.Info;
            this.cmbProducto.DropDownHeight = 200;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IntegralHeight = false;
            this.cmbProducto.Items.AddRange(new object[] {
            "asda",
            "eqw",
            "eqwe",
            "qe",
            "qw",
            "e",
            "q",
            "eq"});
            this.cmbProducto.Location = new System.Drawing.Point(112, 18);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(179, 24);
            this.cmbProducto.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.MedicionGrafica);
            this.groupBox1.Location = new System.Drawing.Point(-10, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1084, 461);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lectura";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(41, 358);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 40);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "TEST";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(27, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(69, 25);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "TEST";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(945, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPanel);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicionGrafica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedicionGrafica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}