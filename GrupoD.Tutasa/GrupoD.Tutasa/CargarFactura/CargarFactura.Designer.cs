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
            textBox7 = new TextBox();
            label11 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            Cantidad = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1013, 651);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS FACTURA";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(581, 471);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(109, 23);
            textBox7.TabIndex = 26;
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
            // textBox6
            // 
            textBox6.Location = new Point(377, 471);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(109, 23);
            textBox6.TabIndex = 23;
            // 
            // button3
            // 
            button3.Location = new Point(847, 600);
            button3.Name = "button3";
            button3.Size = new Size(183, 51);
            button3.TabIndex = 22;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(442, 551);
            button2.Name = "button2";
            button2.Size = new Size(177, 51);
            button2.TabIndex = 21;
            button2.Text = "GRABAR FACTURA";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(674, 186);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 15;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(357, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
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
            // textBox1
            // 
            textBox1.Location = new Point(157, 186);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(442, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
            comboBox1.TabIndex = 6;
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Cantidad, columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(123, 250);
            listView1.Name = "listView1";
            listView1.Size = new Size(818, 164);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Descripcion";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Precio";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio con IVA";
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
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label8;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label11;
        private ListView listView1;
        private ColumnHeader Cantidad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}