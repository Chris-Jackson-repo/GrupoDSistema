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
            SeleccioneNúmeroCuit = new ComboBox();
            PeríodoDesde = new Label();
            dateTimePicker1 = new DateTimePicker();
            PeríodoHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            GenerarReporte = new Button();
            ExportarAExcel = new Button();
            textBox8 = new TextBox();
            textBox11 = new TextBox();
            textBox14 = new TextBox();
            EmpresaTransporte = new Label();
            Cancelar = new Button();
            dataGridView1 = new DataGridView();
            Resultados = new Label();
            Período = new Label();
            TotalVentas = new Label();
            TotalCostos = new Label();
            ResultadoNeto = new Label();
            Ingresos = new Label();
            Egresos = new Label();
            Monto = new Label();
            Mensual = new Label();
            PorRubro = new Label();
            TipoDeServicio = new Label();
            LargaDistancia = new RadioButton();
            MediaDistancia = new RadioButton();
            Ambos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FiltrosDelReporte
            // 
            FiltrosDelReporte.AutoSize = true;
            FiltrosDelReporte.Location = new Point(27, 26);
            FiltrosDelReporte.Name = "FiltrosDelReporte";
            FiltrosDelReporte.Size = new Size(133, 20);
            FiltrosDelReporte.TabIndex = 0;
            FiltrosDelReporte.Text = "Filtros Del Reporte";
            // 
            // SeleccioneNúmeroCuit
            // 
            SeleccioneNúmeroCuit.FormattingEnabled = true;
            SeleccioneNúmeroCuit.Location = new Point(211, 77);
            SeleccioneNúmeroCuit.Name = "SeleccioneNúmeroCuit";
            SeleccioneNúmeroCuit.Size = new Size(190, 28);
            SeleccioneNúmeroCuit.TabIndex = 2;
            SeleccioneNúmeroCuit.Text = "Seleccione Número  Cuit";
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
            GenerarReporte.Location = new Point(137, 235);
            GenerarReporte.Name = "GenerarReporte";
            GenerarReporte.Size = new Size(161, 29);
            GenerarReporte.TabIndex = 8;
            GenerarReporte.Text = "Generar Reporte";
            GenerarReporte.UseVisualStyleBackColor = true;
            // 
            // ExportarAExcel
            // 
            ExportarAExcel.Location = new Point(336, 235);
            ExportarAExcel.Name = "ExportarAExcel";
            ExportarAExcel.Size = new Size(140, 29);
            ExportarAExcel.TabIndex = 9;
            ExportarAExcel.Text = "Exportar a Excel";
            ExportarAExcel.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(601, 350);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(8, 27);
            textBox8.TabIndex = 19;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(634, 361);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(8, 27);
            textBox11.TabIndex = 22;
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
            EmpresaTransporte.Location = new Point(27, 80);
            EmpresaTransporte.Name = "EmpresaTransporte";
            EmpresaTransporte.Size = new Size(163, 20);
            EmpresaTransporte.TabIndex = 26;
            EmpresaTransporte.Text = "Empresa De Transporte";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(530, 235);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 29);
            Cancelar.TabIndex = 27;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(322, 128);
            dataGridView1.TabIndex = 28;
            // 
            // Resultados
            // 
            Resultados.AutoSize = true;
            Resultados.Location = new Point(50, 286);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(81, 20);
            Resultados.TabIndex = 29;
            Resultados.Text = "Resultados";
            // 
            // Período
            // 
            Período.AutoSize = true;
            Período.Location = new Point(50, 325);
            Período.Name = "Período";
            Período.Size = new Size(60, 20);
            Período.TabIndex = 30;
            Período.Text = "Período";
            // 
            // TotalVentas
            // 
            TotalVentas.AutoSize = true;
            TotalVentas.Location = new Point(116, 325);
            TotalVentas.Name = "TotalVentas";
            TotalVentas.Size = new Size(89, 20);
            TotalVentas.TabIndex = 31;
            TotalVentas.Text = "Total Ventas";
            // 
            // TotalCostos
            // 
            TotalCostos.AutoSize = true;
            TotalCostos.Location = new Point(211, 325);
            TotalCostos.Name = "TotalCostos";
            TotalCostos.Size = new Size(90, 20);
            TotalCostos.TabIndex = 32;
            TotalCostos.Text = "Total Costos";
            // 
            // ResultadoNeto
            // 
            ResultadoNeto.AutoSize = true;
            ResultadoNeto.Location = new Point(307, 325);
            ResultadoNeto.Name = "ResultadoNeto";
            ResultadoNeto.Size = new Size(112, 20);
            ResultadoNeto.TabIndex = 33;
            ResultadoNeto.Text = "Resultado Neto";
            // 
            // Ingresos
            // 
            Ingresos.AutoSize = true;
            Ingresos.Location = new Point(116, 379);
            Ingresos.Name = "Ingresos";
            Ingresos.Size = new Size(64, 20);
            Ingresos.TabIndex = 35;
            Ingresos.Text = "Ingresos";
            // 
            // Egresos
            // 
            Egresos.AutoSize = true;
            Egresos.Location = new Point(211, 379);
            Egresos.Name = "Egresos";
            Egresos.Size = new Size(60, 20);
            Egresos.TabIndex = 36;
            Egresos.Text = "Egresos";
            // 
            // Monto
            // 
            Monto.AutoSize = true;
            Monto.Location = new Point(318, 379);
            Monto.Name = "Monto";
            Monto.Size = new Size(53, 20);
            Monto.TabIndex = 37;
            Monto.Text = "Monto";
            // 
            // Mensual
            // 
            Mensual.AutoSize = true;
            Mensual.Location = new Point(46, 379);
            Mensual.Name = "Mensual";
            Mensual.Size = new Size(64, 20);
            Mensual.TabIndex = 38;
            Mensual.Text = "Mensual";
            // 
            // PorRubro
            // 
            PorRubro.AutoSize = true;
            PorRubro.Location = new Point(46, 403);
            PorRubro.Name = "PorRubro";
            PorRubro.Size = new Size(74, 20);
            PorRubro.TabIndex = 39;
            PorRubro.Text = "Por Rubro";
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.AutoSize = true;
            TipoDeServicio.Location = new Point(458, 77);
            TipoDeServicio.Name = "TipoDeServicio";
            TipoDeServicio.Size = new Size(118, 20);
            TipoDeServicio.TabIndex = 40;
            TipoDeServicio.Text = "Tipo De Servicio";
            // 
            // LargaDistancia
            // 
            LargaDistancia.AutoSize = true;
            LargaDistancia.Location = new Point(601, 57);
            LargaDistancia.Name = "LargaDistancia";
            LargaDistancia.Size = new Size(132, 24);
            LargaDistancia.TabIndex = 41;
            LargaDistancia.TabStop = true;
            LargaDistancia.Text = "Larga Distancia";
            LargaDistancia.UseVisualStyleBackColor = true;
            // 
            // MediaDistancia
            // 
            MediaDistancia.AutoSize = true;
            MediaDistancia.Location = new Point(601, 87);
            MediaDistancia.Name = "MediaDistancia";
            MediaDistancia.Size = new Size(137, 24);
            MediaDistancia.TabIndex = 42;
            MediaDistancia.TabStop = true;
            MediaDistancia.Text = "Media Distancia";
            MediaDistancia.UseVisualStyleBackColor = true;
            // 
            // Ambos
            // 
            Ambos.AutoSize = true;
            Ambos.Location = new Point(601, 117);
            Ambos.Name = "Ambos";
            Ambos.Size = new Size(77, 24);
            Ambos.TabIndex = 43;
            Ambos.TabStop = true;
            Ambos.Text = "Ambos";
            Ambos.UseVisualStyleBackColor = true;
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ambos);
            Controls.Add(MediaDistancia);
            Controls.Add(LargaDistancia);
            Controls.Add(TipoDeServicio);
            Controls.Add(PorRubro);
            Controls.Add(Mensual);
            Controls.Add(Monto);
            Controls.Add(Egresos);
            Controls.Add(Ingresos);
            Controls.Add(ResultadoNeto);
            Controls.Add(TotalCostos);
            Controls.Add(TotalVentas);
            Controls.Add(Período);
            Controls.Add(Resultados);
            Controls.Add(dataGridView1);
            Controls.Add(Cancelar);
            Controls.Add(EmpresaTransporte);
            Controls.Add(textBox14);
            Controls.Add(textBox11);
            Controls.Add(textBox8);
            Controls.Add(ExportarAExcel);
            Controls.Add(GenerarReporte);
            Controls.Add(dateTimePicker2);
            Controls.Add(PeríodoHasta);
            Controls.Add(dateTimePicker1);
            Controls.Add(PeríodoDesde);
            Controls.Add(SeleccioneNúmeroCuit);
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
        private ComboBox SeleccioneNúmeroCuit;
        private Label PeríodoDesde;
        private DateTimePicker dateTimePicker1;
        private Label PeríodoHasta;
        private DateTimePicker dateTimePicker2;
        private Button GenerarReporte;
        private Button ExportarAExcel;
        private TextBox textBox8;
        private TextBox textBox11;
        private TextBox textBox14;
        private Label EmpresaTransporte;
        private Button Cancelar;
        private DataGridView dataGridView1;
        private Label Resultados;
        private Label Período;
        private Label TotalVentas;
        private Label TotalCostos;
        private Label ResultadoNeto;
        private Label Ingresos;
        private Label Egresos;
        private Label Monto;
        private Label Mensual;
        private Label PorRubro;
        private Label TipoDeServicio;
        private RadioButton LargaDistancia;
        private RadioButton MediaDistancia;
        private RadioButton Ambos;
    }
}