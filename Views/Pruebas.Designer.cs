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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.MedicionGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graficaVoltaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicionGrafica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaVoltaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIniciar.BackColor = System.Drawing.Color.Honeydew;
            this.BtnIniciar.Location = new System.Drawing.Point(399, 9);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(142, 40);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStop.Location = new System.Drawing.Point(552, 9);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(142, 40);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Detener";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.btnReporte);
            this.buttonPanel.Controls.Add(this.BtnStop);
            this.buttonPanel.Controls.Add(this.BtnIniciar);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 424);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(859, 52);
            this.buttonPanel.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.LightCyan;
            this.btnReporte.Enabled = false;
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReporte.Location = new System.Drawing.Point(709, 9);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(142, 40);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedicionGrafica
            // 
            this.MedicionGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicionGrafica.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.MedicionGrafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MedicionGrafica.Legends.Add(legend1);
            this.MedicionGrafica.Location = new System.Drawing.Point(482, 1);
            this.MedicionGrafica.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MedicionGrafica.Name = "MedicionGrafica";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = " ";
            this.MedicionGrafica.Series.Add(series1);
            this.MedicionGrafica.Size = new System.Drawing.Size(322, 91);
            this.MedicionGrafica.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(434, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
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
            this.cmbProducto.Location = new System.Drawing.Point(506, 25);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(137, 21);
            this.cmbProducto.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.graficaVoltaje);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.MedicionGrafica);
            this.groupBox1.Location = new System.Drawing.Point(-7, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(813, 377);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // graficaVoltaje
            // 
            this.graficaVoltaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graficaVoltaje.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.graficaVoltaje.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficaVoltaje.Legends.Add(legend2);
            this.graficaVoltaje.Location = new System.Drawing.Point(473, 281);
            this.graficaVoltaje.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.graficaVoltaje.Name = "graficaVoltaje";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = " ";
            this.graficaVoltaje.Series.Add(series2);
            this.graficaVoltaje.Size = new System.Drawing.Size(322, 84);
            this.graficaVoltaje.TabIndex = 6;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(20, 3);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 20);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lectura";
            // 
            // cmbEstacion
            // 
            this.cmbEstacion.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEstacion.DropDownHeight = 200;
            this.cmbEstacion.FormattingEnabled = true;
            this.cmbEstacion.IntegralHeight = false;
            this.cmbEstacion.Items.AddRange(new object[] {
            "asda",
            "eqw",
            "eqwe",
            "qe",
            "qw",
            "e",
            "q",
            "eq"});
            this.cmbEstacion.Location = new System.Drawing.Point(90, 23);
            this.cmbEstacion.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbEstacion.Name = "cmbEstacion";
            this.cmbEstacion.Size = new System.Drawing.Size(135, 21);
            this.cmbEstacion.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Estacion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbLinea
            // 
            this.cmbLinea.BackColor = System.Drawing.SystemColors.Info;
            this.cmbLinea.DropDownHeight = 200;
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.IntegralHeight = false;
            this.cmbLinea.Items.AddRange(new object[] {
            "asda",
            "eqw",
            "eqwe",
            "qe",
            "qw",
            "e",
            "q",
            "eq"});
            this.cmbLinea.Location = new System.Drawing.Point(286, 23);
            this.cmbLinea.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(137, 21);
            this.cmbLinea.TabIndex = 62;
            this.cmbLinea.SelectedIndexChanged += new System.EventHandler(this.cmbLinea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(237, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Linea";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 341);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(459, 250);
            this.dataGridView2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Pruebas";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicionGrafica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaVoltaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MedicionGrafica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox cmbEstacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaVoltaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}