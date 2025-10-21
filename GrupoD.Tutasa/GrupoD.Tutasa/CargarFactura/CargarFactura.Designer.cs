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
            txtTotalConIva = new TextBox();
            label11 = new Label();
            label7 = new Label();
            txtTotalFactura = new TextBox();
            btnCancelar = new Button();
            btnGrabarFactura = new Button();
            dtpFechaVencimiento = new DateTimePicker();
            label10 = new Label();
            dtpFechaFactura = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txtNumeroFactura = new TextBox();
            cmbEmpresa = new ComboBox();
            label1 = new Label();
            lsvItemsFactura = new ListView();
            Cantidad = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Precio = new ColumnHeader();
            PrecioConIVA = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvItemsFactura);
            groupBox1.Controls.Add(txtTotalConIva);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTotalFactura);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGrabarFactura);
            groupBox1.Controls.Add(dtpFechaVencimiento);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpFechaFactura);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNumeroFactura);
            groupBox1.Controls.Add(cmbEmpresa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1013, 651);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS FACTURA";
            // 
            // txtTotalConIva
            // 
            txtTotalConIva.Location = new Point(581, 471);
            txtTotalConIva.Name = "txtTotalConIva";
            txtTotalConIva.ReadOnly = true;
            txtTotalConIva.Size = new Size(109, 23);
            txtTotalConIva.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(573, 438);
            label11.Name = "label11";
            label11.Size = new Size(117, 15);
            label11.TabIndex = 25;
            label11.Text = "Total Factura con IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(389, 438);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 24;
            label7.Text = "Total Factura";
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(377, 471);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.ReadOnly = true;
            txtTotalFactura.Size = new Size(109, 23);
            txtTotalFactura.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(806, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 51);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabarFactura
            // 
            btnGrabarFactura.Location = new Point(442, 551);
            btnGrabarFactura.Name = "btnGrabarFactura";
            btnGrabarFactura.Size = new Size(177, 51);
            btnGrabarFactura.TabIndex = 21;
            btnGrabarFactura.Text = "GRABAR FACTURA";
            btnGrabarFactura.UseVisualStyleBackColor = true;
            btnGrabarFactura.Click += btnGrabarFactura_Click;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(674, 186);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(200, 23);
            dtpFechaVencimiento.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(688, 142);
            label10.Name = "label10";
            label10.Size = new Size(165, 15);
            label10.TabIndex = 14;
            label10.Text = "Fecha de Vencimiento Factura";
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Location = new Point(357, 186);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(200, 23);
            dtpFechaFactura.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(412, 142);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 12;
            label9.Text = "Fecha de Factura";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 142);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 10;
            label8.Text = "Numero de Factura";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(157, 186);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.ReadOnly = true;
            txtNumeroFactura.Size = new Size(109, 23);
            txtNumeroFactura.TabIndex = 9;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(442, 55);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(266, 23);
            cmbEmpresa.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Empresa";
            // 
            // lsvItemsFactura
            // 
            lsvItemsFactura.Columns.AddRange(new ColumnHeader[] { Cantidad, Descripcion, Precio, PrecioConIVA });
            lsvItemsFactura.GridLines = true;
            lsvItemsFactura.Location = new Point(145, 259);
            lsvItemsFactura.Name = "lsvItemsFactura";
            lsvItemsFactura.Size = new Size(782, 145);
            lsvItemsFactura.TabIndex = 27;
            lsvItemsFactura.UseCompatibleStateImageBehavior = false;
            lsvItemsFactura.View = View.Details;
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
            // CargarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 710);
            Controls.Add(groupBox1);
            Name = "CargarFactura";
            Text = "Alta de Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbEmpresa;
        private DateTimePicker dtpFechaVencimiento;
        private Label label10;
        private DateTimePicker dtpFechaFactura;
        private Label label9;
        private Label label8;
        private TextBox txtNumeroFactura;
        private Button btnCancelar;
        private Button btnGrabarFactura;
        private Label label7;
        private TextBox txtTotalFactura;
        private TextBox txtTotalConIva;
        private Label label11;
        private ListView lsvItemsFactura;
        private ColumnHeader Cantidad;
        private ColumnHeader Descripcion;
        private ColumnHeader Precio;
        private ColumnHeader PrecioConIVA;
    }
}