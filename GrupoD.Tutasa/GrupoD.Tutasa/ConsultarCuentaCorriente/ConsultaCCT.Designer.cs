namespace GrupoD.Tutasa.ConsultarCuentaCorriente
{
    partial class ConsultaCCT
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
            textBox6 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 690);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cuenta Corriente";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(396, 71);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 74);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 21;
            label6.Text = "Razon social";
            // 
            // button3
            // 
            button3.Location = new Point(482, 598);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 20;
            button3.Text = "EXPORTAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(316, 598);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 19;
            button2.Text = "CERRAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(482, 529);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(119, 23);
            textBox5.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 537);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 17;
            label5.Text = "Saldo Total";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(155, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 248);
            dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Comprobante";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Importe";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Saldo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Vencimiento";
            Column6.Name = "Column6";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(729, 183);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 186);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 14;
            label4.Text = "Direccion Empresa";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 183);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 183);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Razon Social";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 183);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 183);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 10;
            label2.Text = "Cuit Empresa";
            // 
            // button1
            // 
            button1.Location = new Point(608, 49);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 9;
            button1.Text = "Buscar Empresa";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 33);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 7;
            label1.Text = "Cuit";
            // 
            // ConsultaCCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 739);
            Controls.Add(groupBox1);
            Name = "ConsultaCCT";
            Text = "Consultar Estado Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button3;
        private Button button2;
        private Label label6;
        private TextBox textBox6;
    }
}