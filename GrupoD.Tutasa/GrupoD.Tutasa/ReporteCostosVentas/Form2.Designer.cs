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
            Buscar = new Button();
            EmpresaTransporte = new Label();
            Cancelar = new Button();
            Resultados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Resultados).BeginInit();
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
            SeleccioneNúmeroCuit.Location = new Point(181, 77);
            SeleccioneNúmeroCuit.Name = "SeleccioneNúmeroCuit";
            SeleccioneNúmeroCuit.Size = new Size(265, 28);
            SeleccioneNúmeroCuit.TabIndex = 2;
            SeleccioneNúmeroCuit.Text = "Seleccione Número  Cuit";
            // 
            // PeríodoDesde
            // 
            PeríodoDesde.AutoSize = true;
            PeríodoDesde.Location = new Point(54, 173);
            PeríodoDesde.Name = "PeríodoDesde";
            PeríodoDesde.Size = new Size(106, 20);
            PeríodoDesde.TabIndex = 4;
            PeríodoDesde.Text = "Período Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // PeríodoHasta
            // 
            PeríodoHasta.AutoSize = true;
            PeríodoHasta.Location = new Point(501, 170);
            PeríodoHasta.Name = "PeríodoHasta";
            PeríodoHasta.Size = new Size(102, 20);
            PeríodoHasta.TabIndex = 6;
            PeríodoHasta.Text = "Período Hasta";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(631, 165);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(463, 223);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(140, 29);
            Buscar.TabIndex = 8;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            // 
            // EmpresaTransporte
            // 
            EmpresaTransporte.AutoSize = true;
            EmpresaTransporte.Location = new Point(12, 80);
            EmpresaTransporte.Name = "EmpresaTransporte";
            EmpresaTransporte.Size = new Size(163, 20);
            EmpresaTransporte.TabIndex = 26;
            EmpresaTransporte.Text = "Empresa De Transporte";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(646, 223);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(123, 29);
            Cancelar.TabIndex = 27;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // Resultados
            // 
            Resultados.AllowUserToAddRows = false;
            Resultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Resultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Resultados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5 });
            Resultados.Location = new Point(59, 310);
            Resultados.Name = "Resultados";
            Resultados.RowHeadersWidth = 51;
            Resultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Resultados.Size = new Size(856, 253);
            Resultados.TabIndex = 28;
            Resultados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Empresa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Costos";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ventas";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Resultado";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 601);
            Controls.Add(Resultados);
            Controls.Add(Cancelar);
            Controls.Add(EmpresaTransporte);
            Controls.Add(Buscar);
            Controls.Add(dateTimePicker2);
            Controls.Add(PeríodoHasta);
            Controls.Add(dateTimePicker1);
            Controls.Add(PeríodoDesde);
            Controls.Add(SeleccioneNúmeroCuit);
            Controls.Add(FiltrosDelReporte);
            Name = "ReporteDeCostosvsVenta";
            Text = "Reporte de Costo VS Ventas";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)Resultados).EndInit();
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
        private Button Buscar;
        private Label EmpresaTransporte;
        private Button Cancelar;
        private DataGridView Resultados;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}