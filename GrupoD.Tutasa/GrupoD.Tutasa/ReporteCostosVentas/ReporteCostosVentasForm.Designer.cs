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
            SeleccioneNumeroCuitComboBox = new ComboBox();
            PeríodoDesde = new Label();
            DesdedateTimePicker = new DateTimePicker();
            PeríodoHasta = new Label();
            HastadateTimePicker = new DateTimePicker();
            BuscarButton = new Button();
            EmpresaTransporte = new Label();
            button1 = new Button();
            ReporteCostosVentaslistView = new ListView();
            EmpresacolumnHeader = new ColumnHeader();
            ImporteCostocolumnHeader = new ColumnHeader();
            ImporteVentacolumnHeader = new ColumnHeader();
            ResultadocolumnHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // SeleccioneNumeroCuitComboBox
            // 
            SeleccioneNumeroCuitComboBox.FormattingEnabled = true;
            SeleccioneNumeroCuitComboBox.Location = new Point(561, 47);
            SeleccioneNumeroCuitComboBox.Name = "SeleccioneNumeroCuitComboBox";
            SeleccioneNumeroCuitComboBox.Size = new Size(265, 28);
            SeleccioneNumeroCuitComboBox.TabIndex = 2;
            SeleccioneNumeroCuitComboBox.Text = "Seleccione Número  Cuit";
            SeleccioneNumeroCuitComboBox.SelectedIndexChanged += SeleccioneNúmeroCuitComboBox_SelectedIndexChanged;
            // 
            // PeríodoDesde
            // 
            PeríodoDesde.AutoSize = true;
            PeríodoDesde.Location = new Point(143, 127);
            PeríodoDesde.Name = "PeríodoDesde";
            PeríodoDesde.Size = new Size(106, 20);
            PeríodoDesde.TabIndex = 4;
            PeríodoDesde.Text = "Período Desde";
            // 
            // DesdedateTimePicker
            // 
            DesdedateTimePicker.Location = new Point(270, 121);
            DesdedateTimePicker.Name = "DesdedateTimePicker";
            DesdedateTimePicker.Size = new Size(266, 27);
            DesdedateTimePicker.TabIndex = 5;
            // 
            // PeríodoHasta
            // 
            PeríodoHasta.AutoSize = true;
            PeríodoHasta.Location = new Point(590, 124);
            PeríodoHasta.Name = "PeríodoHasta";
            PeríodoHasta.Size = new Size(102, 20);
            PeríodoHasta.TabIndex = 6;
            PeríodoHasta.Text = "Período Hasta";
            // 
            // HastadateTimePicker
            // 
            HastadateTimePicker.Location = new Point(720, 119);
            HastadateTimePicker.Name = "HastadateTimePicker";
            HastadateTimePicker.Size = new Size(284, 27);
            HastadateTimePicker.TabIndex = 7;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(515, 199);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(162, 29);
            BuscarButton.TabIndex = 8;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // EmpresaTransporte
            // 
            EmpresaTransporte.AutoSize = true;
            EmpresaTransporte.Location = new Point(376, 51);
            EmpresaTransporte.Name = "EmpresaTransporte";
            EmpresaTransporte.Size = new Size(163, 20);
            EmpresaTransporte.TabIndex = 26;
            EmpresaTransporte.Text = "Empresa De Transporte";
            EmpresaTransporte.Click += EmpresaTransporte_Click;
            // 
            // button1
            // 
            button1.Location = new Point(788, 199);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 77;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // ReporteCostosVentaslistView
            // 
            ReporteCostosVentaslistView.Columns.AddRange(new ColumnHeader[] { EmpresacolumnHeader, ImporteCostocolumnHeader, ImporteVentacolumnHeader, ResultadocolumnHeader });
            ReporteCostosVentaslistView.Location = new Point(133, 276);
            ReporteCostosVentaslistView.Margin = new Padding(3, 4, 3, 4);
            ReporteCostosVentaslistView.Name = "ReporteCostosVentaslistView";
            ReporteCostosVentaslistView.Size = new Size(905, 404);
            ReporteCostosVentaslistView.TabIndex = 78;
            ReporteCostosVentaslistView.UseCompatibleStateImageBehavior = false;
            ReporteCostosVentaslistView.View = View.Details;
            // 
            // EmpresacolumnHeader
            // 
            EmpresacolumnHeader.Text = "Empresa";
            EmpresacolumnHeader.Width = 150;
            // 
            // ImporteCostocolumnHeader
            // 
            ImporteCostocolumnHeader.Text = "Costo";
            ImporteCostocolumnHeader.Width = 150;
            // 
            // ImporteVentacolumnHeader
            // 
            ImporteVentacolumnHeader.Text = "Venta";
            ImporteVentacolumnHeader.Width = 150;
            // 
            // ResultadocolumnHeader
            // 
            ResultadocolumnHeader.Text = "Resultado";
            ResultadocolumnHeader.Width = 150;
            // 
            // ReporteDeCostosvsVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 821);
            Controls.Add(ReporteCostosVentaslistView);
            Controls.Add(button1);
            Controls.Add(EmpresaTransporte);
            Controls.Add(BuscarButton);
            Controls.Add(HastadateTimePicker);
            Controls.Add(PeríodoHasta);
            Controls.Add(DesdedateTimePicker);
            Controls.Add(PeríodoDesde);
            Controls.Add(SeleccioneNumeroCuitComboBox);
            Name = "ReporteDeCostosvsVenta";
            Text = "Reporte de Costo VS Ventas";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox SeleccioneNumeroCuitComboBox;
        private Label PeríodoDesde;
        private DateTimePicker DesdedateTimePicker;
        private Label PeríodoHasta;
        private DateTimePicker HastadateTimePicker;
        private Button BuscarButton;
        private Label EmpresaTransporte;
        private Button button1;
        private ListView ReporteCostosVentaslistView;
        private ColumnHeader EmpresacolumnHeader;
        private ColumnHeader ImporteCostocolumnHeader;
        private ColumnHeader ImporteVentacolumnHeader;
        private ColumnHeader ResultadocolumnHeader;
    }
}