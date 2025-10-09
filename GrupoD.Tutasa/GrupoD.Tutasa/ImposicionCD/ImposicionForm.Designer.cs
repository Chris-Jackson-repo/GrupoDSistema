namespace GrupoD.Tutasa.ImposicionCD
{
    partial class ImposicionForm
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
            ListViewItem listViewItem10 = new ListViewItem("Fecha");
            ListViewItem listViewItem11 = new ListViewItem("Cantidad");
            ListViewItem listViewItem12 = new ListViewItem("Tipo");
            ListViewItem listViewItem13 = new ListViewItem("Peso");
            ListViewItem listViewItem14 = new ListViewItem("Largo");
            ListViewItem listViewItem15 = new ListViewItem("Ancho");
            ListViewItem listViewItem16 = new ListViewItem("Profundidad");
            ListViewItem listViewItem17 = new ListViewItem("Entrega en");
            ListViewItem listViewItem18 = new ListViewItem("Num Tracking");
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            textBox9 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            Tipo = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label20 = new Label();
            textBox18 = new TextBox();
            label22 = new Label();
            label27 = new Label();
            groupBox4 = new GroupBox();
            comboBox6 = new ComboBox();
            label21 = new Label();
            textBox17 = new TextBox();
            label23 = new Label();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            label25 = new Label();
            textBox21 = new TextBox();
            label26 = new Label();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            textBox24 = new TextBox();
            textBox25 = new TextBox();
            label28 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1187, 109);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Remitente Autorizado";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 31);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 147);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(775, 50);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(listView1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(textBox18);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label27);
            groupBox3.Location = new Point(26, 453);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1187, 401);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(297, 48);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(96, 31);
            textBox9.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(207, 51);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 28;
            label11.Text = "Peso (kg)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 110);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 27;
            label10.Text = "Entrega en";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Domicilio", "Agencia", "CD" });
            comboBox2.Location = new Point(401, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(186, 33);
            comboBox2.TabIndex = 26;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Tipo, columnHeader1 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            listView1.Location = new Point(40, 170);
            listView1.Name = "listView1";
            listView1.Size = new Size(1109, 156);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Tipo
            // 
            Tipo.Text = "Tipo";
            // 
            // button2
            // 
            button2.Location = new Point(599, 351);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 24;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(475, 351);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 23;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            comboBox4.Location = new Point(94, 103);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(147, 33);
            comboBox4.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(26, 109);
            label20.Name = "label20";
            label20.Size = new Size(47, 25);
            label20.TabIndex = 19;
            label20.Text = "Tipo";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(115, 48);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(63, 31);
            textBox18.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 51);
            label22.Name = "label22";
            label22.Size = new Size(83, 25);
            label22.TabIndex = 12;
            label22.Text = "Cantidad";
            label22.Click += label22_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(303, 97);
            label27.Name = "label27";
            label27.Size = new Size(0, 25);
            label27.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox6);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(textBox17);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(textBox19);
            groupBox4.Controls.Add(textBox20);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(textBox21);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(textBox22);
            groupBox4.Controls.Add(textBox23);
            groupBox4.Controls.Add(textBox24);
            groupBox4.Controls.Add(textBox25);
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(label30);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(label33);
            groupBox4.Location = new Point(26, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1187, 213);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Destinatario";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Bs. As.", "La Pampa", "Entre Ríos" });
            comboBox6.Location = new Point(687, 145);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(230, 33);
            comboBox6.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(589, 145);
            label21.Name = "label21";
            label21.Size = new Size(83, 25);
            label21.TabIndex = 21;
            label21.Text = "Provincia";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(458, 94);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(253, 31);
            textBox17.TabIndex = 18;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(373, 94);
            label23.Name = "label23";
            label23.Size = new Size(54, 25);
            label23.TabIndex = 17;
            label23.Text = "Email";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(982, 145);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(96, 31);
            textBox19.TabIndex = 14;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(457, 41);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(254, 31);
            textBox20.TabIndex = 13;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(943, 148);
            label25.Name = "label25";
            label25.Size = new Size(33, 25);
            label25.TabIndex = 12;
            label25.Text = "CP";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(457, 145);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(96, 31);
            textBox21.TabIndex = 11;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(373, 148);
            label26.Name = "label26";
            label26.Size = new Size(77, 25);
            label26.TabIndex = 10;
            label26.Text = "Número";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(833, 41);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(230, 31);
            textBox22.TabIndex = 9;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(115, 145);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(230, 31);
            textBox23.TabIndex = 8;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(115, 91);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(230, 31);
            textBox24.TabIndex = 7;
            // 
            // textBox25
            // 
            textBox25.Location = new Point(115, 41);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(230, 31);
            textBox25.TabIndex = 5;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(749, 41);
            label28.Name = "label28";
            label28.Size = new Size(79, 25);
            label28.TabIndex = 4;
            label28.Text = "Teléfono";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(17, 148);
            label30.Name = "label30";
            label30.Size = new Size(49, 25);
            label30.TabIndex = 3;
            label30.Text = "Calle";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(373, 41);
            label31.Name = "label31";
            label31.Size = new Size(78, 25);
            label31.TabIndex = 2;
            label31.Text = "Apellido";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(17, 94);
            label32.Name = "label32";
            label32.Size = new Size(92, 25);
            label32.TabIndex = 1;
            label32.Text = "CUIL/CUIT";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(17, 41);
            label33.Name = "label33";
            label33.Size = new Size(78, 25);
            label33.TabIndex = 0;
            label33.Text = "Nombre";
            // 
            // button3
            // 
            button3.Location = new Point(1101, 889);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 27;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(921, 889);
            button4.Name = "button4";
            button4.Size = new Size(168, 34);
            button4.TabIndex = 26;
            button4.Text = "Generar Guías";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(373, 48);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 8;
            button5.Text = "Validar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(943, 48);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 9;
            label5.Text = "Empresa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 31);
            textBox1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 51);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 30;
            label6.Text = "Largo (cm)";
            label6.Click += label6_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(749, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(96, 31);
            textBox2.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 51);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 32;
            label7.Text = "Ancho(cm)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1053, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(96, 31);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(886, 51);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 34;
            label8.Text = "Profundidad (cm)";
            // 
            // ImposicionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 942);
            Controls.Add(button3);
            Controls.Add(groupBox4);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ImposicionForm";
            Text = "Imposición de Encomiendas";
            Load += ImposicionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private ComboBox comboBox4;
        private Label label20;
        private TextBox textBox18;
        private Label label22;
        private Label label27;
        private Button button2;
        private Button button1;
        private GroupBox groupBox4;
        private ComboBox comboBox6;
        private Label label21;
        private TextBox textBox17;
        private Label label23;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label25;
        private TextBox textBox21;
        private Label label26;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private Label label28;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private ListView listView1;
        private ColumnHeader Tipo;
        private ColumnHeader columnHeader1;
        private Button button3;
        private Button button4;
        private Label label10;
        private ComboBox comboBox2;
        private TextBox textBox9;
        private Label label11;
        private Button button5;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label8;
    }
}
