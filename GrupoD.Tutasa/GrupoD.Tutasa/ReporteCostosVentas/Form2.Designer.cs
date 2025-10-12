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
            SeleccioneNúmeroCuitComboBox = new ComboBox();
            PeríodoDesde = new Label();
            dateTimePicker1 = new DateTimePicker();
            PeríodoHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            BuscarButton = new Button();
            EmpresaTransporte = new Label();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // SeleccioneNúmeroCuitComboBox
            // 
            SeleccioneNúmeroCuitComboBox.FormattingEnabled = true;
            SeleccioneNúmeroCuitComboBox.Location = new Point(491, 35);
            SeleccioneNúmeroCuitComboBox.Margin = new Padding(3, 2, 3, 2);
            SeleccioneNúmeroCuitComboBox.Name = "SeleccioneNúmeroCuitComboBox";
            SeleccioneNúmeroCuitComboBox.Size = new Size(232, 23);
            SeleccioneNúmeroCuitComboBox.TabIndex = 2;
            SeleccioneNúmeroCuitComboBox.Text = "Seleccione Número  Cuit";
            // 
            // PeríodoDesde
            // 
            PeríodoDesde.AutoSize = true;
            PeríodoDesde.Location = new Point(125, 95);
            PeríodoDesde.Name = "PeríodoDesde";
            PeríodoDesde.Size = new Size(83, 15);
            PeríodoDesde.TabIndex = 4;
            PeríodoDesde.Text = "Período Desde";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 91);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // PeríodoHasta
            // 
            PeríodoHasta.AutoSize = true;
            PeríodoHasta.Location = new Point(516, 93);
            PeríodoHasta.Name = "PeríodoHasta";
            PeríodoHasta.Size = new Size(81, 15);
            PeríodoHasta.TabIndex = 6;
            PeríodoHasta.Text = "Período Hasta";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(630, 89);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(249, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(451, 149);
            BuscarButton.Margin = new Padding(3, 2, 3, 2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(122, 22);
            BuscarButton.TabIndex = 8;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaTransporte
            // 
            EmpresaTransporte.AutoSize = true;
            EmpresaTransporte.Location = new Point(329, 38);
            EmpresaTransporte.Name = "EmpresaTransporte";
            EmpresaTransporte.Size = new Size(127, 15);
            EmpresaTransporte.TabIndex = 26;
            EmpresaTransporte.Text = "Empresa De Transporte";
            EmpresaTransporte.Click += EmpresaTransporte_Click;
            // 
            // button1
            // 
            button1.Location = new Point(847, 550);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 77;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(116, 207);
            listView1.Name = "listView1";
            listView1.Size = new Size(792, 304);
            listView1.TabIndex = 78;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Empresa";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Costo";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Venta";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Resultado";
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 616);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(EmpresaTransporte);
            Controls.Add(BuscarButton);
            Controls.Add(dateTimePicker2);
            Controls.Add(PeríodoHasta);
            Controls.Add(dateTimePicker1);
            Controls.Add(PeríodoDesde);
            Controls.Add(SeleccioneNúmeroCuitComboBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteDeCostosvsVenta";
            Text = "Reporte de Costo VS Ventas";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox SeleccioneNúmeroCuitComboBox;
        private Label PeríodoDesde;
        private DateTimePicker dateTimePicker1;
        private Label PeríodoHasta;
        private DateTimePicker dateTimePicker2;
        private Button BuscarButton;
        private Label EmpresaTransporte;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}