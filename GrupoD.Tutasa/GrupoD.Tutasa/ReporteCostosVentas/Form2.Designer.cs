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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
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
            Resultados.Location = new Point(73, 283);
            Resultados.Name = "Resultados";
            Resultados.RowHeadersWidth = 51;
            Resultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Resultados.Size = new Size(842, 224);
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
            // textBox1
            // 
            textBox1.Location = new Point(708, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(513, 338);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(310, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(73, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(708, 362);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 27);
            textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(708, 386);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(207, 27);
            textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(513, 362);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(199, 27);
            textBox7.TabIndex = 35;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(512, 386);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 27);
            textBox8.TabIndex = 36;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(708, 315);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(207, 27);
            textBox9.TabIndex = 37;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(513, 315);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(199, 27);
            textBox10.TabIndex = 38;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(310, 338);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(206, 27);
            textBox11.TabIndex = 39;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(310, 362);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(206, 27);
            textBox12.TabIndex = 40;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(311, 386);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(205, 27);
            textBox13.TabIndex = 41;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(73, 338);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(241, 27);
            textBox14.TabIndex = 42;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(73, 362);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(241, 27);
            textBox15.TabIndex = 43;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(73, 386);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(241, 27);
            textBox16.TabIndex = 44;
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 601);
            Controls.Add(textBox16);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
    }
}