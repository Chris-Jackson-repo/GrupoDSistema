namespace GrupoD.Tutasa.ReporteCostosVentas
{
    partial class ReporteDeCostosvsVenta
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
            FiltrosDelReporte = new Label();
            SeleccioneNúmeroDeEmpresa = new ComboBox();
            PeríodoDesde = new Label();
            dateTimePicker1 = new DateTimePicker();
            PeríodoHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            GenerarReporte = new Button();
            ExportarAExcel = new Button();
            dataGridView1 = new DataGridView();
            Resultados = new TextBox();
            Período = new TextBox();
            TotalVentas = new TextBox();
            TotalCostos = new TextBox();
            ResultadoNeto = new TextBox();
            TotalDelRango = new TextBox();
            Ingresos = new TextBox();
            Egresos = new TextBox();
            textBox8 = new TextBox();
            TotalNeto = new TextBox();
            Detalle = new TextBox();
            textBox11 = new TextBox();
            PorMes = new TextBox();
            textBox14 = new TextBox();
            EmpresaTransporte = new Label();
            Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FiltrosDelReporte
            // 
            FiltrosDelReporte.AutoSize = true;
            FiltrosDelReporte.Location = new Point(43, 25);
            FiltrosDelReporte.Name = "FiltrosDelReporte";
            FiltrosDelReporte.Size = new Size(133, 20);
            FiltrosDelReporte.TabIndex = 0;
            FiltrosDelReporte.Text = "Filtros Del Reporte";
            // 
            // SeleccioneNúmeroDeEmpresa
            // 
            SeleccioneNúmeroDeEmpresa.FormattingEnabled = true;
            SeleccioneNúmeroDeEmpresa.Location = new Point(362, 77);
            SeleccioneNúmeroDeEmpresa.Name = "SeleccioneNúmeroDeEmpresa";
            SeleccioneNúmeroDeEmpresa.Size = new Size(295, 28);
            SeleccioneNúmeroDeEmpresa.TabIndex = 2;
            SeleccioneNúmeroDeEmpresa.Text = "Seleccione Número Empresa";
            // 
            // PeríodoDesde
            // 
            PeríodoDesde.AutoSize = true;
            PeríodoDesde.Location = new Point(25, 170);
            PeríodoDesde.Name = "PeríodoDesde";
            PeríodoDesde.Size = new Size(106, 20);
            PeríodoDesde.TabIndex = 4;
            PeríodoDesde.Text = "Período Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // PeríodoHasta
            // 
            PeríodoHasta.AutoSize = true;
            PeríodoHasta.Location = new Point(413, 168);
            PeríodoHasta.Name = "PeríodoHasta";
            PeríodoHasta.Size = new Size(102, 20);
            PeríodoHasta.TabIndex = 6;
            PeríodoHasta.Text = "Período Hasta";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(538, 163);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // GenerarReporte
            // 
            GenerarReporte.Location = new Point(234, 235);
            GenerarReporte.Name = "GenerarReporte";
            GenerarReporte.Size = new Size(161, 29);
            GenerarReporte.TabIndex = 8;
            GenerarReporte.Text = "Generar Reporte";
            GenerarReporte.UseVisualStyleBackColor = true;
            // 
            // ExportarAExcel
            // 
            ExportarAExcel.Location = new Point(469, 235);
            ExportarAExcel.Name = "ExportarAExcel";
            ExportarAExcel.Size = new Size(140, 29);
            ExportarAExcel.TabIndex = 9;
            ExportarAExcel.Text = "Exportar a Excel";
            ExportarAExcel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(483, 98);
            dataGridView1.TabIndex = 10;
            // 
            // Resultados
            // 
            Resultados.Location = new Point(43, 279);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(483, 27);
            Resultados.TabIndex = 11;
            Resultados.Text = "Resultados";
            // 
            // Período
            // 
            Período.Location = new Point(43, 303);
            Período.Name = "Período";
            Período.Size = new Size(125, 27);
            Período.TabIndex = 12;
            Período.Text = "Período";
            // 
            // TotalVentas
            // 
            TotalVentas.Location = new Point(162, 303);
            TotalVentas.Name = "TotalVentas";
            TotalVentas.Size = new Size(125, 27);
            TotalVentas.TabIndex = 13;
            TotalVentas.Text = "Total Ventas";
            // 
            // TotalCostos
            // 
            TotalCostos.Location = new Point(283, 303);
            TotalCostos.Name = "TotalCostos";
            TotalCostos.Size = new Size(125, 27);
            TotalCostos.TabIndex = 14;
            TotalCostos.Text = "Total Costos";
            // 
            // ResultadoNeto
            // 
            ResultadoNeto.Location = new Point(401, 303);
            ResultadoNeto.Name = "ResultadoNeto";
            ResultadoNeto.Size = new Size(125, 27);
            ResultadoNeto.TabIndex = 15;
            ResultadoNeto.Text = "Resultado Neto";
            // 
            // TotalDelRango
            // 
            TotalDelRango.Location = new Point(43, 325);
            TotalDelRango.Name = "TotalDelRango";
            TotalDelRango.Size = new Size(125, 27);
            TotalDelRango.TabIndex = 16;
            TotalDelRango.Text = "Total Del Rango";
            // 
            // Ingresos
            // 
            Ingresos.Location = new Point(162, 325);
            Ingresos.Name = "Ingresos";
            Ingresos.Size = new Size(125, 27);
            Ingresos.TabIndex = 17;
            Ingresos.Text = "Ingresos";
            // 
            // Egresos
            // 
            Egresos.Location = new Point(283, 325);
            Egresos.Name = "Egresos";
            Egresos.Size = new Size(125, 27);
            Egresos.TabIndex = 18;
            Egresos.Text = "Egresos";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(601, 350);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(8, 27);
            textBox8.TabIndex = 19;
            // 
            // TotalNeto
            // 
            TotalNeto.Location = new Point(401, 325);
            TotalNeto.Name = "TotalNeto";
            TotalNeto.Size = new Size(125, 27);
            TotalNeto.TabIndex = 20;
            TotalNeto.Text = "Total Neto";
            // 
            // Detalle
            // 
            Detalle.Location = new Point(43, 350);
            Detalle.Name = "Detalle";
            Detalle.Size = new Size(125, 27);
            Detalle.TabIndex = 21;
            Detalle.Text = "Detalle ";
            Detalle.TextChanged += DetalleOpcional_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(634, 361);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(8, 27);
            textBox11.TabIndex = 22;
            // 
            // PorMes
            // 
            PorMes.Location = new Point(162, 350);
            PorMes.Name = "PorMes";
            PorMes.Size = new Size(364, 27);
            PorMes.TabIndex = 23;
            PorMes.Text = "Por Mes / rubro";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(616, 342);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(8, 27);
            textBox14.TabIndex = 25;
            // 
            // EmpresaTransporte
            // 
            EmpresaTransporte.AutoSize = true;
            EmpresaTransporte.Location = new Point(162, 80);
            EmpresaTransporte.Name = "EmpresaTransporte";
            EmpresaTransporte.Size = new Size(163, 20);
            EmpresaTransporte.TabIndex = 26;
            EmpresaTransporte.Text = "Empresa De Transporte";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(673, 235);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 27;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelar);
            Controls.Add(EmpresaTransporte);
            Controls.Add(textBox14);
            Controls.Add(PorMes);
            Controls.Add(textBox11);
            Controls.Add(Detalle);
            Controls.Add(TotalNeto);
            Controls.Add(textBox8);
            Controls.Add(Egresos);
            Controls.Add(Ingresos);
            Controls.Add(TotalDelRango);
            Controls.Add(ResultadoNeto);
            Controls.Add(TotalCostos);
            Controls.Add(TotalVentas);
            Controls.Add(Período);
            Controls.Add(Resultados);
            Controls.Add(dataGridView1);
            Controls.Add(ExportarAExcel);
            Controls.Add(GenerarReporte);
            Controls.Add(dateTimePicker2);
            Controls.Add(PeríodoHasta);
            Controls.Add(dateTimePicker1);
            Controls.Add(PeríodoDesde);
            Controls.Add(SeleccioneNúmeroDeEmpresa);
            Controls.Add(FiltrosDelReporte);
            Name = "ReporteDeCostosvsVenta";
            Text = "Reporte de Costo VS Ventas";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FiltrosDelReporte;
        private ComboBox SeleccioneNúmeroDeEmpresa;
        private Label PeríodoDesde;
        private DateTimePicker dateTimePicker1;
        private Label PeríodoHasta;
        private DateTimePicker dateTimePicker2;
        private Button GenerarReporte;
        private Button ExportarAExcel;
        private DataGridView dataGridView1;
        private TextBox Resultados;
        private TextBox Período;
        private TextBox TotalVentas;
        private TextBox TotalCostos;
        private TextBox ResultadoNeto;
        private TextBox TotalDelRango;
        private TextBox Ingresos;
        private TextBox Egresos;
        private TextBox textBox8;
        private TextBox TotalNeto;
        private TextBox Detalle;
        private TextBox textBox11;
        private TextBox PorMes;
        private TextBox textBox14;
        private Label EmpresaTransporte;
        private Button Cancelar;
    }
}