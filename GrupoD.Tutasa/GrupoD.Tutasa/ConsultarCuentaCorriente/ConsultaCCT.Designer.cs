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
            button2 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
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
            // button2
            // 
            button2.Location = new Point(762, 518);
            button2.Name = "button2";
            button2.Size = new Size(172, 54);
            button2.TabIndex = 19;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(482, 444);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(119, 23);
            textBox5.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 452);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 17;
            label5.Text = "Saldo Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(749, 120);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 14;
            label4.Text = "Direccion Empresa";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(439, 120);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 120);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Razon Social";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 120);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 120);
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
            textBox1.Location = new Point(396, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 7;
            label1.Text = "Cuit";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(40, 196);
            listView1.Name = "listView1";
            listView1.Size = new Size(874, 209);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Comprobante";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Importe";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Saldo";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Total";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vencimiento";
            // 
            // ConsultaCCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 624);
            Controls.Add(groupBox1);
            Name = "ConsultaCCT";
            Text = "Consultar Estado Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}