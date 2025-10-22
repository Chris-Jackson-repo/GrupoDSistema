namespace GrupoD.Tutasa.CargarFactura

{
    partial class CargarFactura
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
            groupBox1 = new GroupBox();
            DireccionTextBox = new TextBox();
            DireccionLabel = new Label();
            RazonSocialTextBox = new TextBox();
            RazonSocialLabel = new Label();
            CuitEmpresaTextBox = new TextBox();
            CuitEmpresaLabel = new Label();
            BuscarButton = new Button();
            CuitTextBox = new TextBox();
            CuitLabel = new Label();
            ItemsFacturaListView = new ListView();
            Cantidad = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Precio = new ColumnHeader();
            PrecioConIVA = new ColumnHeader();
            txtTotalConIva = new TextBox();
            label11 = new Label();
            label7 = new Label();
            txtTotalFactura = new TextBox();
            btnCancelar = new Button();
            btnGrabarFactura = new Button();
            FechaVencimientoDtp = new DateTimePicker();
            label10 = new Label();
            FechaFacturaDtp = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            NumFacturaTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DireccionTextBox);
            groupBox1.Controls.Add(DireccionLabel);
            groupBox1.Controls.Add(RazonSocialTextBox);
            groupBox1.Controls.Add(RazonSocialLabel);
            groupBox1.Controls.Add(CuitEmpresaTextBox);
            groupBox1.Controls.Add(CuitEmpresaLabel);
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(CuitTextBox);
            groupBox1.Controls.Add(CuitLabel);
            groupBox1.Controls.Add(ItemsFacturaListView);
            groupBox1.Controls.Add(txtTotalConIva);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTotalFactura);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabarFactura);
            groupBox1.Controls.Add(FechaVencimientoDtp);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(FechaFacturaDtp);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(NumFacturaTextBox);
            groupBox1.Location = new Point(35, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1158, 868);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS FACTURA";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(879, 131);
            DireccionTextBox.Margin = new Padding(3, 4, 3, 4);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.ReadOnly = true;
            DireccionTextBox.Size = new Size(163, 27);
            DireccionTextBox.TabIndex = 36;
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Location = new Point(729, 135);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(133, 20);
            DireccionLabel.TabIndex = 35;
            DireccionLabel.Text = "Direccion Empresa";
            // 
            // RazonSocialTextBox
            // 
            RazonSocialTextBox.Location = new Point(525, 131);
            RazonSocialTextBox.Margin = new Padding(3, 4, 3, 4);
            RazonSocialTextBox.Name = "RazonSocialTextBox";
            RazonSocialTextBox.ReadOnly = true;
            RazonSocialTextBox.Size = new Size(170, 27);
            RazonSocialTextBox.TabIndex = 34;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(407, 131);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(94, 20);
            RazonSocialLabel.TabIndex = 33;
            RazonSocialLabel.Text = "Razon Social";
            // 
            // CuitEmpresaTextBox
            // 
            CuitEmpresaTextBox.Location = new Point(233, 131);
            CuitEmpresaTextBox.Margin = new Padding(3, 4, 3, 4);
            CuitEmpresaTextBox.Name = "CuitEmpresaTextBox";
            CuitEmpresaTextBox.ReadOnly = true;
            CuitEmpresaTextBox.Size = new Size(135, 27);
            CuitEmpresaTextBox.TabIndex = 32;
            // 
            // CuitEmpresaLabel
            // 
            CuitEmpresaLabel.AutoSize = true;
            CuitEmpresaLabel.Location = new Point(119, 131);
            CuitEmpresaLabel.Name = "CuitEmpresaLabel";
            CuitEmpresaLabel.Size = new Size(96, 20);
            CuitEmpresaLabel.TabIndex = 31;
            CuitEmpresaLabel.Text = "Cuit Empresa";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(712, 44);
            BuscarButton.Margin = new Padding(3, 4, 3, 4);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(159, 31);
            BuscarButton.TabIndex = 30;
            BuscarButton.Text = "Buscar Empresa";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButtonClick;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(470, 46);
            CuitTextBox.Margin = new Padding(3, 4, 3, 4);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(166, 27);
            CuitTextBox.TabIndex = 29;
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(391, 46);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(35, 20);
            CuitLabel.TabIndex = 28;
            CuitLabel.Text = "Cuit";
            // 
            // ItemsFacturaListView
            // 
            ItemsFacturaListView.Columns.AddRange(new ColumnHeader[] { Cantidad, Descripcion, Precio, PrecioConIVA });
            ItemsFacturaListView.GridLines = true;
            ItemsFacturaListView.Location = new Point(166, 345);
            ItemsFacturaListView.Margin = new Padding(3, 4, 3, 4);
            ItemsFacturaListView.Name = "ItemsFacturaListView";
            ItemsFacturaListView.Size = new Size(893, 192);
            ItemsFacturaListView.TabIndex = 27;
            ItemsFacturaListView.UseCompatibleStateImageBehavior = false;
            ItemsFacturaListView.View = View.Details;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            // 
            // PrecioConIVA
            // 
            PrecioConIVA.Text = "Precio Con IVA";
            // 
            // txtTotalConIva
            // 
            txtTotalConIva.Location = new Point(664, 628);
            txtTotalConIva.Margin = new Padding(3, 4, 3, 4);
            txtTotalConIva.Name = "txtTotalConIva";
            txtTotalConIva.ReadOnly = true;
            txtTotalConIva.Size = new Size(124, 27);
            txtTotalConIva.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(655, 584);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 25;
            label11.Text = "Total Factura con IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 584);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 24;
            label7.Text = "Total Factura";
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(431, 628);
            txtTotalFactura.Margin = new Padding(3, 4, 3, 4);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.ReadOnly = true;
            txtTotalFactura.Size = new Size(124, 27);
            txtTotalFactura.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(921, 779);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(209, 68);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabarFactura
            // 
            btnGrabarFactura.Location = new Point(505, 735);
            btnGrabarFactura.Margin = new Padding(3, 4, 3, 4);
            btnGrabarFactura.Name = "btnGrabarFactura";
            btnGrabarFactura.Size = new Size(202, 68);
            btnGrabarFactura.TabIndex = 21;
            btnGrabarFactura.Text = "GRABAR FACTURA";
            btnGrabarFactura.UseVisualStyleBackColor = true;
            btnGrabarFactura.Click += btnGrabarFactura_Click;
            // 
            // FechaVencimientoDtp
            // 
            FechaVencimientoDtp.Location = new Point(769, 274);
            FechaVencimientoDtp.Margin = new Padding(3, 4, 3, 4);
            FechaVencimientoDtp.Name = "FechaVencimientoDtp";
            FechaVencimientoDtp.Size = new Size(228, 27);
            FechaVencimientoDtp.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(785, 215);
            label10.Name = "label10";
            label10.Size = new Size(205, 20);
            label10.TabIndex = 14;
            label10.Text = "Fecha de Vencimiento Factura";
            // 
            // FechaFacturaDtp
            // 
            FechaFacturaDtp.Location = new Point(407, 274);
            FechaFacturaDtp.Margin = new Padding(3, 4, 3, 4);
            FechaFacturaDtp.Name = "FechaFacturaDtp";
            FechaFacturaDtp.Size = new Size(228, 27);
            FechaFacturaDtp.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 215);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 12;
            label9.Text = "Fecha de Factura";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 215);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 10;
            label8.Text = "Numero de Factura";
            // 
            // NumFacturaTextBox
            // 
            NumFacturaTextBox.Location = new Point(178, 274);
            NumFacturaTextBox.Margin = new Padding(3, 4, 3, 4);
            NumFacturaTextBox.Name = "NumFacturaTextBox";
            NumFacturaTextBox.ReadOnly = true;
            NumFacturaTextBox.Size = new Size(124, 27);
            NumFacturaTextBox.TabIndex = 9;
            // 
            // CargarFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 947);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CargarFactura";
            Text = "Alta de Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker FechaVencimientoDtp;
        private Label label10;
        private DateTimePicker FechaFacturaDtp;
        private Label label9;
        private Label label8;
        private TextBox NumFacturaTextBox;
        private Button btnCancelar;
        private Button btnGrabarFactura;
        private Label label7;
        private TextBox txtTotalFactura;
        private TextBox txtTotalConIva;
        private Label label11;
        private ListView ItemsFacturaListView;
        private ColumnHeader Cantidad;
        private ColumnHeader Descripcion;
        private ColumnHeader Precio;
        private ColumnHeader PrecioConIVA;
        private TextBox DireccionTextBox;
        private Label DireccionLabel;
        private TextBox RazonSocialTextBox;
        private Label RazonSocialLabel;
        private TextBox CuitEmpresaTextBox;
        private Label CuitEmpresaLabel;
        private Button BuscarButton;
        private TextBox CuitTextBox;
        private Label CuitLabel;
    }
}