namespace GrupoD.Tutasa.ConsultarCuentaCorriente
{
    partial class ConsultarCuentaCorrienteForm
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
            ItemsCompListView = new ListView();
            FechaColumn = new ColumnHeader();
            ComprobanteColumn = new ColumnHeader();
            ImporteColumn = new ColumnHeader();
            VencimientoColumn = new ColumnHeader();
            CancelarButton = new Button();
            SaldoTextBox = new TextBox();
            SaldoLabel = new Label();
            DireccionTextBox = new TextBox();
            DireccionLabel = new Label();
            RazonSocialTextBox = new TextBox();
            RazonSocialLabel = new Label();
            CuitEmpresaTextBox = new TextBox();
            CuitEmpresaLabel = new Label();
            BuscarButton = new Button();
            CuitTextBox = new TextBox();
            CuitLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemsCompListView);
            groupBox1.Controls.Add(CancelarButton);
            groupBox1.Controls.Add(SaldoTextBox);
            groupBox1.Controls.Add(SaldoLabel);
            groupBox1.Controls.Add(DireccionTextBox);
            groupBox1.Controls.Add(DireccionLabel);
            groupBox1.Controls.Add(RazonSocialTextBox);
            groupBox1.Controls.Add(RazonSocialLabel);
            groupBox1.Controls.Add(CuitEmpresaTextBox);
            groupBox1.Controls.Add(CuitEmpresaLabel);
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(CuitTextBox);
            groupBox1.Controls.Add(CuitLabel);
            groupBox1.Location = new Point(26, 33);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1109, 920);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cuenta Corriente";
            // 
            // ItemsCompListView
            // 
            ItemsCompListView.Columns.AddRange(new ColumnHeader[] { FechaColumn, ComprobanteColumn, ImporteColumn, VencimientoColumn });
            ItemsCompListView.Location = new Point(46, 261);
            ItemsCompListView.Margin = new Padding(3, 4, 3, 4);
            ItemsCompListView.Name = "ItemsCompListView";
            ItemsCompListView.Size = new Size(998, 277);
            ItemsCompListView.TabIndex = 21;
            ItemsCompListView.UseCompatibleStateImageBehavior = false;
            ItemsCompListView.View = View.Details;
            ItemsCompListView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // FechaColumn
            // 
            FechaColumn.Text = "Fecha";
            FechaColumn.Width = 150;
            // 
            // ComprobanteColumn
            // 
            ComprobanteColumn.Text = "Comprobante";
            ComprobanteColumn.Width = 150;
            // 
            // ImporteColumn
            // 
            ImporteColumn.Text = "Importe";
            ImporteColumn.Width = 150;
            // 
            // VencimientoColumn
            // 
            VencimientoColumn.Text = "Vencimiento";
            VencimientoColumn.Width = 150;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(871, 691);
            CancelarButton.Margin = new Padding(3, 4, 3, 4);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(197, 72);
            CancelarButton.TabIndex = 19;
            CancelarButton.Text = "CANCELAR";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButtonClick;
            // 
            // SaldoTextBox
            // 
            SaldoTextBox.Location = new Point(543, 600);
            SaldoTextBox.Margin = new Padding(3, 4, 3, 4);
            SaldoTextBox.Name = "SaldoTextBox";
            SaldoTextBox.ReadOnly = true;
            SaldoTextBox.Size = new Size(135, 27);
            SaldoTextBox.TabIndex = 18;
            // 
            // SaldoLabel
            // 
            SaldoLabel.AutoSize = true;
            SaldoLabel.Location = new Point(453, 603);
            SaldoLabel.Name = "SaldoLabel";
            SaldoLabel.Size = new Size(84, 20);
            SaldoLabel.TabIndex = 17;
            SaldoLabel.Text = "Saldo Total";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(856, 160);
            DireccionTextBox.Margin = new Padding(3, 4, 3, 4);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.ReadOnly = true;
            DireccionTextBox.Size = new Size(163, 27);
            DireccionTextBox.TabIndex = 15;
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Location = new Point(706, 164);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(133, 20);
            DireccionLabel.TabIndex = 14;
            DireccionLabel.Text = "Direccion Empresa";
            DireccionLabel.Click += label4_Click;
            // 
            // RazonSocialTextBox
            // 
            RazonSocialTextBox.Location = new Point(502, 160);
            RazonSocialTextBox.Margin = new Padding(3, 4, 3, 4);
            RazonSocialTextBox.Name = "RazonSocialTextBox";
            RazonSocialTextBox.ReadOnly = true;
            RazonSocialTextBox.Size = new Size(170, 27);
            RazonSocialTextBox.TabIndex = 13;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(384, 160);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(94, 20);
            RazonSocialLabel.TabIndex = 12;
            RazonSocialLabel.Text = "Razon Social";
            // 
            // CuitEmpresaTextBox
            // 
            CuitEmpresaTextBox.Location = new Point(210, 160);
            CuitEmpresaTextBox.Margin = new Padding(3, 4, 3, 4);
            CuitEmpresaTextBox.Name = "CuitEmpresaTextBox";
            CuitEmpresaTextBox.ReadOnly = true;
            CuitEmpresaTextBox.Size = new Size(135, 27);
            CuitEmpresaTextBox.TabIndex = 11;
            // 
            // CuitEmpresaLabel
            // 
            CuitEmpresaLabel.AutoSize = true;
            CuitEmpresaLabel.Location = new Point(96, 160);
            CuitEmpresaLabel.Name = "CuitEmpresaLabel";
            CuitEmpresaLabel.Size = new Size(96, 20);
            CuitEmpresaLabel.TabIndex = 10;
            CuitEmpresaLabel.Text = "Cuit Empresa";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(695, 65);
            BuscarButton.Margin = new Padding(3, 4, 3, 4);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(159, 31);
            BuscarButton.TabIndex = 9;
            BuscarButton.Text = "Buscar Empresa";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButtonClick;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(453, 67);
            CuitTextBox.Margin = new Padding(3, 4, 3, 4);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(166, 27);
            CuitTextBox.TabIndex = 8;
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(374, 67);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(35, 20);
            CuitLabel.TabIndex = 7;
            CuitLabel.Text = "Cuit";
            // 
            // ConsultaCCT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 832);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultaCCT";
            Text = "Consultar Estado Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label CuitLabel;
        private TextBox DireccionTextBox;
        private Label DireccionLabel;
        private TextBox RazonSocialTextBox;
        private Label RazonSocialLabel;
        private TextBox CuitEmpresaTextBox;
        private Label CuitEmpresaLabel;
        private Button BuscarButton;
        private TextBox CuitTextBox;
        private TextBox SaldoTextBox;
        private Label SaldoLabel;
        private Button CancelarButton;
        private ListView ItemsCompListView;
        private ColumnHeader FechaColumn;
        private ColumnHeader ComprobanteColumn;
        private ColumnHeader ImporteColumn;
        private ColumnHeader VencimientoColumn;
    }
}