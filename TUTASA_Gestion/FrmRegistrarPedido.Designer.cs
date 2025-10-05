namespace TUTASA_Gestion
{
    partial class FrmRegistrarPedido
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
            labelTitulo = new Label();
            gbRemitente = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox16 = new TextBox();
            textBox9 = new TextBox();
            label20 = new Label();
            textBox8 = new TextBox();
            textBox11 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox10 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label10 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            label21 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label22 = new Label();
            textBox17 = new TextBox();
            groupBox3 = new GroupBox();
            textBox18 = new TextBox();
            label23 = new Label();
            label24 = new Label();
            comboBox1 = new ComboBox();
            gbRemitente.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(454, 30);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Registración de pedidos con retiro a domicilio";
            // 
            // gbRemitente
            // 
            gbRemitente.Controls.Add(textBox1);
            gbRemitente.Controls.Add(textBox2);
            gbRemitente.Controls.Add(textBox3);
            gbRemitente.Controls.Add(textBox4);
            gbRemitente.Controls.Add(button1);
            gbRemitente.Controls.Add(checkBox1);
            gbRemitente.Controls.Add(label5);
            gbRemitente.Controls.Add(label4);
            gbRemitente.Controls.Add(label1);
            gbRemitente.Controls.Add(label3);
            gbRemitente.Controls.Add(label2);
            gbRemitente.Location = new Point(21, 70);
            gbRemitente.Name = "gbRemitente";
            gbRemitente.Size = new Size(840, 110);
            gbRemitente.TabIndex = 1;
            gbRemitente.TabStop = false;
            gbRemitente.Text = "Datos de Remitente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(416, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 23);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(131, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 85);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Cliente registrado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 58);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 48);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono :";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox16);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(21, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 97);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Retiro";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(416, 54);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(132, 23);
            textBox16.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(131, 19);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(132, 23);
            textBox9.TabIndex = 16;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(294, 57);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 3;
            label20.Text = "Codigo postal :";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(131, 57);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(132, 23);
            textBox8.TabIndex = 0;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(416, 19);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(132, 23);
            textBox11.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 22);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 3;
            label9.Text = "Fecha del pedido :";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 1;
            label7.Text = "Localidad :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 22);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 0;
            label6.Text = "Dirección de Retiro :\r\n";
            label6.Click += label6_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(131, 56);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(132, 23);
            textBox10.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(698, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(39, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(566, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(39, 23);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(421, 23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(39, 23);
            textBox5.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(378, 26);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 7;
            label11.Text = "Largo";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(461, 26);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 8;
            label12.Text = "cm";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(514, 26);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 9;
            label13.Text = "Ancho";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(611, 26);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 10;
            label14.Text = "cm";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(663, 26);
            label15.Name = "label15";
            label15.Size = new Size(29, 15);
            label15.TabIndex = 11;
            label15.Text = "Alto";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(743, 26);
            label16.Name = "label16";
            label16.Size = new Size(24, 15);
            label16.TabIndex = 12;
            label16.Text = "cm";
            label16.Click += label16_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(291, 26);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 4;
            label10.Text = "Dimensiones :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 59);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 2;
            label8.Text = "Peso (kg) :";
            label8.Click += label8_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox15);
            groupBox2.Controls.Add(textBox14);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Location = new Point(21, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(840, 126);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Destino ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(131, 31);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(132, 23);
            textBox15.TabIndex = 20;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(131, 64);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(132, 23);
            textBox14.TabIndex = 19;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(416, 31);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(402, 82);
            textBox13.TabIndex = 18;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(131, 97);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(132, 23);
            textBox12.TabIndex = 17;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 100);
            label21.Name = "label21";
            label21.Size = new Size(87, 15);
            label21.TabIndex = 4;
            label21.Text = "Codigo postal :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(291, 31);
            label19.Name = "label19";
            label19.Size = new Size(80, 15);
            label19.TabIndex = 2;
            label19.Text = "Aclaraciones :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 67);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 1;
            label18.Text = "Localidad :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 34);
            label17.Name = "label17";
            label17.Size = new Size(105, 15);
            label17.TabIndex = 0;
            label17.Text = "Dirección destino :";
            // 
            // button2
            // 
            button2.Location = new Point(535, 521);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 7;
            button2.Text = "Registrar Pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(652, 521);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 8;
            button3.Text = "Limpiar Campos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(764, 521);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(24, 555);
            label22.Name = "label22";
            label22.Size = new Size(107, 15);
            label22.TabIndex = 10;
            label22.Text = "Nº Guía Generada :";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(152, 552);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(132, 23);
            textBox17.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(textBox18);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(21, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(840, 82);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de Encomienda";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(131, 22);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(132, 23);
            textBox18.TabIndex = 17;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(18, 26);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 16;
            label23.Text = "Cantidad :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(294, 59);
            label24.Name = "label24";
            label24.Size = new Size(36, 15);
            label24.TabIndex = 12;
            label24.Text = "Tipo :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(65, 23);
            comboBox1.TabIndex = 6;
            // 
            // FrmRegistrarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 588);
            Controls.Add(groupBox3);
            Controls.Add(textBox17);
            Controls.Add(label22);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(gbRemitente);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmRegistrarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Registrar Pedido - Retiro a domicilio";
            gbRemitente.ResumeLayout(false);
            gbRemitente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private GroupBox gbRemitente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox8;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label20;
        private Label label21;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label22;
        private TextBox textBox17;
        private GroupBox groupBox3;
        private Label label23;
        private TextBox textBox18;
        private Label label24;
        private ComboBox comboBox1;
    }
}
