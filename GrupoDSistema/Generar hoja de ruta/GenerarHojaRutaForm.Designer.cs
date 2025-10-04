namespace GrupoDSistema
{
    partial class GenerarHojaRutaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            SeleccionarC = new DataGridViewCheckBoxColumn();
            GuíaC = new DataGridViewTextBoxColumn();
            OrigenC = new DataGridViewTextBoxColumn();
            DestinoC = new DataGridViewTextBoxColumn();
            PesoC = new DataGridViewTextBoxColumn();
            BultosC = new DataGridViewTextBoxColumn();
            FechaAdC = new DataGridViewTextBoxColumn();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 701);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Programación del despacho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(26, 244);
            label4.Name = "label4";
            label4.Size = new Size(291, 25);
            label4.TabIndex = 8;
            label4.Text = "Asignar encomiendas pendientes";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SeleccionarC, GuíaC, OrigenC, DestinoC, PesoC, BultosC, FechaAdC });
            dataGridView1.Location = new Point(26, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 284);
            dataGridView1.TabIndex = 7;
            // 
            // SeleccionarC
            // 
            SeleccionarC.HeaderText = "Seleccionar";
            SeleccionarC.Name = "SeleccionarC";
            // 
            // GuíaC
            // 
            GuíaC.HeaderText = "Guía";
            GuíaC.Name = "GuíaC";
            // 
            // OrigenC
            // 
            OrigenC.HeaderText = "Origen";
            OrigenC.Name = "OrigenC";
            // 
            // DestinoC
            // 
            DestinoC.HeaderText = "Destino";
            DestinoC.Name = "DestinoC";
            // 
            // PesoC
            // 
            PesoC.HeaderText = "Peso (Kg)";
            PesoC.Name = "PesoC";
            // 
            // BultosC
            // 
            BultosC.HeaderText = "Bultos";
            BultosC.Name = "BultosC";
            // 
            // FechaAdC
            // 
            FechaAdC.HeaderText = "Fecha Admisión";
            FechaAdC.Name = "FechaAdC";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(161, 144);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(227, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(161, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 23);
            comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(208, 197);
            button1.Name = "button1";
            button1.Size = new Size(120, 25);
            button1.TabIndex = 4;
            button1.Text = "FILTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 152);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Transportista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Destino de ruta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 59);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo de ruta";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(108, 594);
            label5.Name = "label5";
            label5.Size = new Size(451, 63);
            label5.TabIndex = 9;
            label5.Text = "PESO TOTAL ASIGNADO (Kg) = XXXXX";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(612, 614);
            button2.Name = "button2";
            button2.Size = new Size(158, 65);
            button2.TabIndex = 10;
            button2.Text = "GENERAR MANIFIESTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // GenerarHojaRutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 724);
            Controls.Add(groupBox1);
            Name = "GenerarHojaRutaForm";
            Text = "Generación de hoja de ruta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn SeleccionarC;
        private DataGridViewTextBoxColumn GuíaC;
        private DataGridViewTextBoxColumn OrigenC;
        private DataGridViewTextBoxColumn DestinoC;
        private DataGridViewTextBoxColumn PesoC;
        private DataGridViewTextBoxColumn BultosC;
        private DataGridViewTextBoxColumn FechaAdC;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button button2;
    }
}
