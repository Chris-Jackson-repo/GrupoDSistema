namespace GrupoD.Tutasa.ImposicionCD
{
    partial class GenerarGuiaCDForm
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
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
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
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            groupBox2 = new GroupBox();
            BuscarButton = new Button();
            DirecRemitenteTextBox = new TextBox();
            ProvinciaTextBox = new TextBox();
            CPRemitenteTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            CiudadRemitenteTextBox = new TextBox();
            RazonTextBox = new TextBox();
            label14 = new Label();
            CuitTextBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox5 = new GroupBox();
            DniTextBox = new TextBox();
            ApellidoTextBox = new TextBox();
            label18 = new Label();
            NombreTextBox = new TextBox();
            label19 = new Label();
            label24 = new Label();
            groupBox7 = new GroupBox();
            ProvinciaComboBox = new ComboBox();
            DirecDestinatarioTextBox = new TextBox();
            CPDestinatarioTextBox = new TextBox();
            label35 = new Label();
            label36 = new Label();
            CiudadDestinatarioTextBox = new TextBox();
            label37 = new Label();
            label38 = new Label();
            VolverButton = new Button();
            GenerarButton = new Button();
            groupBox1 = new GroupBox();
            AgenciaComboBox = new ComboBox();
            label4 = new Label();
            CentroComboBox = new ComboBox();
            label3 = new Label();
            TipoEntregaComboBox = new ComboBox();
            label1 = new Label();
            TamañoComboBox = new ComboBox();
            label2 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox3.Location = new Point(26, 1057);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1187, 530);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Encomienda";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1053, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(95, 31);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(886, 52);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 34;
            label8.Text = "Profundidad (cm)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(749, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 31);
            textBox2.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(646, 52);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 32;
            label7.Text = "Ancho(cm)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 31);
            textBox1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 52);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 30;
            label6.Text = "Largo (cm)";
            label6.Click += label6_Click_1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(297, 48);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(95, 31);
            textBox9.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(207, 52);
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
            comboBox2.Location = new Point(401, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 33);
            comboBox2.TabIndex = 26;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Tipo, columnHeader1 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            listView1.Location = new Point(40, 170);
            listView1.Name = "listView1";
            listView1.Size = new Size(1110, 156);
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
            button2.Location = new Point(601, 465);
            button2.Name = "button2";
            button2.Size = new Size(111, 43);
            button2.TabIndex = 24;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(459, 465);
            button1.Name = "button1";
            button1.Size = new Size(111, 43);
            button1.TabIndex = 23;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "S", "M", "L", "XL" });
            comboBox4.Location = new Point(91, 108);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(147, 33);
            comboBox4.TabIndex = 20;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(26, 108);
            label20.Name = "label20";
            label20.Size = new Size(47, 25);
            label20.TabIndex = 19;
            label20.Text = "Tipo";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(114, 48);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(63, 31);
            textBox18.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(17, 52);
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
            // button3
            // 
            button3.Location = new Point(1101, 1593);
            button3.Name = "button3";
            button3.Size = new Size(111, 42);
            button3.TabIndex = 27;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(921, 1593);
            button4.Name = "button4";
            button4.Size = new Size(169, 42);
            button4.TabIndex = 26;
            button4.Text = "Generar Guías";
            button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(531, 1593);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 23;
            label9.Text = "TOTAL TARIFA $00.00";
            label9.Click += label9_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BuscarButton);
            groupBox2.Controls.Add(DirecRemitenteTextBox);
            groupBox2.Controls.Add(ProvinciaTextBox);
            groupBox2.Controls.Add(CPRemitenteTextBox);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(CiudadRemitenteTextBox);
            groupBox2.Controls.Add(RazonTextBox);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(CuitTextBox);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Location = new Point(41, 32);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1042, 267);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Remitente";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(412, 44);
            BuscarButton.Margin = new Padding(4, 3, 4, 3);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(87, 37);
            BuscarButton.TabIndex = 21;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += this.button6_Click;
            // 
            // DirecRemitenteTextBox
            // 
            DirecRemitenteTextBox.Location = new Point(102, 179);
            DirecRemitenteTextBox.Margin = new Padding(4, 3, 4, 3);
            DirecRemitenteTextBox.Name = "DirecRemitenteTextBox";
            DirecRemitenteTextBox.ReadOnly = true;
            DirecRemitenteTextBox.Size = new Size(288, 31);
            DirecRemitenteTextBox.TabIndex = 20;
            // 
            // ProvinciaTextBox
            // 
            ProvinciaTextBox.Location = new Point(102, 114);
            ProvinciaTextBox.Margin = new Padding(4, 3, 4, 3);
            ProvinciaTextBox.Name = "ProvinciaTextBox";
            ProvinciaTextBox.ReadOnly = true;
            ProvinciaTextBox.Size = new Size(288, 31);
            ProvinciaTextBox.TabIndex = 19;
            // 
            // CPRemitenteTextBox
            // 
            CPRemitenteTextBox.Location = new Point(694, 179);
            CPRemitenteTextBox.Margin = new Padding(4, 3, 4, 3);
            CPRemitenteTextBox.Name = "CPRemitenteTextBox";
            CPRemitenteTextBox.ReadOnly = true;
            CPRemitenteTextBox.Size = new Size(166, 31);
            CPRemitenteTextBox.TabIndex = 18;
            // 
            // label12
            // 
            label12.Location = new Point(6, 182);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 30);
            label12.TabIndex = 17;
            label12.Text = "Direccion";
            // 
            // label13
            // 
            label13.Location = new Point(565, 182);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(126, 30);
            label13.TabIndex = 16;
            label13.Text = "Codigo Postal";
            // 
            // CiudadRemitenteTextBox
            // 
            CiudadRemitenteTextBox.Location = new Point(694, 111);
            CiudadRemitenteTextBox.Margin = new Padding(4, 3, 4, 3);
            CiudadRemitenteTextBox.Name = "CiudadRemitenteTextBox";
            CiudadRemitenteTextBox.ReadOnly = true;
            CiudadRemitenteTextBox.Size = new Size(288, 31);
            CiudadRemitenteTextBox.TabIndex = 15;
            // 
            // RazonTextBox
            // 
            RazonTextBox.Location = new Point(695, 47);
            RazonTextBox.Margin = new Padding(4, 3, 4, 3);
            RazonTextBox.Name = "RazonTextBox";
            RazonTextBox.ReadOnly = true;
            RazonTextBox.Size = new Size(288, 31);
            RazonTextBox.TabIndex = 11;
            // 
            // label14
            // 
            label14.Location = new Point(565, 114);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(130, 30);
            label14.TabIndex = 14;
            label14.Text = "Ciudad";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(103, 47);
            CuitTextBox.Margin = new Padding(4, 3, 4, 3);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(287, 31);
            CuitTextBox.TabIndex = 9;
            CuitTextBox.TextChanged += this.textBox11_TextChanged;
            // 
            // label15
            // 
            label15.Location = new Point(6, 117);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(87, 30);
            label15.TabIndex = 12;
            label15.Text = "Provincia";
            // 
            // label16
            // 
            label16.Location = new Point(566, 52);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(130, 30);
            label16.TabIndex = 10;
            label16.Text = "Razon Social";
            label16.Click += this.label16_Click;
            // 
            // label17
            // 
            label17.Location = new Point(7, 52);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 30);
            label17.TabIndex = 8;
            label17.Text = "CUIT";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DniTextBox);
            groupBox5.Controls.Add(ApellidoTextBox);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(NombreTextBox);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label24);
            groupBox5.Location = new Point(41, 586);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(1042, 145);
            groupBox5.TabIndex = 37;
            groupBox5.TabStop = false;
            groupBox5.Text = "Autorizado de recepcion";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(54, 52);
            DniTextBox.Margin = new Padding(4, 3, 4, 3);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(208, 31);
            DniTextBox.TabIndex = 14;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(752, 51);
            ApellidoTextBox.Margin = new Padding(4, 3, 4, 3);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(230, 31);
            ApellidoTextBox.TabIndex = 13;
            // 
            // label18
            // 
            label18.Location = new Point(651, 53);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(93, 30);
            label18.TabIndex = 12;
            label18.Text = "Apellido";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(401, 49);
            NombreTextBox.Margin = new Padding(4, 3, 4, 3);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(208, 31);
            NombreTextBox.TabIndex = 11;
            // 
            // label19
            // 
            label19.Location = new Point(315, 52);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(97, 30);
            label19.TabIndex = 10;
            label19.Text = "Nombre";
            // 
            // label24
            // 
            label24.Location = new Point(7, 52);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(64, 30);
            label24.TabIndex = 8;
            label24.Text = "DNI";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(ProvinciaComboBox);
            groupBox7.Controls.Add(DirecDestinatarioTextBox);
            groupBox7.Controls.Add(CPDestinatarioTextBox);
            groupBox7.Controls.Add(label35);
            groupBox7.Controls.Add(label36);
            groupBox7.Controls.Add(CiudadDestinatarioTextBox);
            groupBox7.Controls.Add(label37);
            groupBox7.Controls.Add(label38);
            groupBox7.Location = new Point(41, 341);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(1042, 199);
            groupBox7.TabIndex = 36;
            groupBox7.TabStop = false;
            groupBox7.Text = "Destinatario";
            // 
            // ProvinciaComboBox
            // 
            ProvinciaComboBox.FormattingEnabled = true;
            ProvinciaComboBox.Location = new Point(103, 50);
            ProvinciaComboBox.Name = "ProvinciaComboBox";
            ProvinciaComboBox.Size = new Size(288, 33);
            ProvinciaComboBox.TabIndex = 21;
            // 
            // DirecDestinatarioTextBox
            // 
            DirecDestinatarioTextBox.Location = new Point(103, 117);
            DirecDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            DirecDestinatarioTextBox.Name = "DirecDestinatarioTextBox";
            DirecDestinatarioTextBox.Size = new Size(288, 31);
            DirecDestinatarioTextBox.TabIndex = 20;
            // 
            // CPDestinatarioTextBox
            // 
            CPDestinatarioTextBox.Location = new Point(695, 117);
            CPDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            CPDestinatarioTextBox.Name = "CPDestinatarioTextBox";
            CPDestinatarioTextBox.Size = new Size(165, 31);
            CPDestinatarioTextBox.TabIndex = 18;
            // 
            // label35
            // 
            label35.Location = new Point(8, 120);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(100, 30);
            label35.TabIndex = 17;
            label35.Text = "Direccion";
            // 
            // label36
            // 
            label36.Location = new Point(561, 117);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(126, 30);
            label36.TabIndex = 16;
            label36.Text = "Codigo Postal";
            // 
            // CiudadDestinatarioTextBox
            // 
            CiudadDestinatarioTextBox.Location = new Point(694, 50);
            CiudadDestinatarioTextBox.Margin = new Padding(4, 3, 4, 3);
            CiudadDestinatarioTextBox.Name = "CiudadDestinatarioTextBox";
            CiudadDestinatarioTextBox.Size = new Size(288, 31);
            CiudadDestinatarioTextBox.TabIndex = 15;
            // 
            // label37
            // 
            label37.Location = new Point(561, 55);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(130, 30);
            label37.TabIndex = 14;
            label37.Text = "Ciudad";
            // 
            // label38
            // 
            label38.Location = new Point(7, 55);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(87, 30);
            label38.TabIndex = 12;
            label38.Text = "Provincia";
            label38.Click += label38_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(801, 983);
            VolverButton.Margin = new Padding(4);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(118, 36);
            VolverButton.TabIndex = 42;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(965, 983);
            GenerarButton.Margin = new Padding(4);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(118, 36);
            GenerarButton.TabIndex = 41;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AgenciaComboBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CentroComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TipoEntregaComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TamañoComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(41, 763);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1042, 178);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Servicio";
            // 
            // AgenciaComboBox
            // 
            AgenciaComboBox.FormattingEnabled = true;
            AgenciaComboBox.Location = new Point(742, 105);
            AgenciaComboBox.Margin = new Padding(4);
            AgenciaComboBox.Name = "AgenciaComboBox";
            AgenciaComboBox.Size = new Size(240, 33);
            AgenciaComboBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.Location = new Point(586, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 30);
            label4.TabIndex = 27;
            label4.Text = "Agencia";
            // 
            // CentroComboBox
            // 
            CentroComboBox.FormattingEnabled = true;
            CentroComboBox.Location = new Point(200, 102);
            CentroComboBox.Margin = new Padding(4);
            CentroComboBox.Name = "CentroComboBox";
            CentroComboBox.Size = new Size(240, 33);
            CentroComboBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.Location = new Point(11, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 25;
            label3.Text = "Centro Distribución";
            label3.Click += label3_Click_1;
            // 
            // TipoEntregaComboBox
            // 
            TipoEntregaComboBox.FormattingEnabled = true;
            TipoEntregaComboBox.Location = new Point(742, 42);
            TipoEntregaComboBox.Margin = new Padding(4);
            TipoEntregaComboBox.Name = "TipoEntregaComboBox";
            TipoEntregaComboBox.Size = new Size(240, 33);
            TipoEntregaComboBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.Location = new Point(586, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 23;
            label1.Text = "Tipo de entrega";
            // 
            // TamañoComboBox
            // 
            TamañoComboBox.FormattingEnabled = true;
            TamañoComboBox.Location = new Point(200, 42);
            TamañoComboBox.Margin = new Padding(4);
            TamañoComboBox.Name = "TamañoComboBox";
            TamañoComboBox.Size = new Size(240, 33);
            TamañoComboBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.Location = new Point(8, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 21;
            label2.Text = "Tamaño Encomienda";
            // 
            // GenerarGuiaCDForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1050);
            Controls.Add(VolverButton);
            Controls.Add(GenerarButton);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox7);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Name = "GenerarGuiaCDForm";
            Text = "Generar Guía - Centro de Distribución";
            Load += ImposicionForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private ComboBox comboBox4;
        private Label label20;
        private TextBox textBox18;
        private Label label22;
        private Label label27;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Tipo;
        private ColumnHeader columnHeader1;
        private Button button3;
        private Button button4;
        private Label label10;
        private ComboBox comboBox2;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private Button BuscarButton;
        private TextBox DirecRemitenteTextBox;
        private TextBox ProvinciaTextBox;
        private TextBox CPRemitenteTextBox;
        private Label label12;
        private Label label13;
        private TextBox CiudadRemitenteTextBox;
        private TextBox RazonTextBox;
        private Label label14;
        private TextBox CuitTextBox;
        private Label label15;
        private Label label16;
        private Label label17;
        private GroupBox groupBox5;
        private TextBox DniTextBox;
        private TextBox ApellidoTextBox;
        private Label label18;
        private TextBox NombreTextBox;
        private Label label19;
        private Label label24;
        private GroupBox groupBox7;
        private TextBox DirecDestinatarioTextBox;
        private TextBox CPDestinatarioTextBox;
        private Label label35;
        private Label label36;
        private TextBox CiudadDestinatarioTextBox;
        private Label label37;
        private Label label38;
        private ComboBox ProvinciaComboBox;
        private Button VolverButton;
        private Button GenerarButton;
        private GroupBox groupBox1;
        private ComboBox AgenciaComboBox;
        private Label label4;
        private ComboBox CentroComboBox;
        private Label label3;
        private ComboBox TipoEntregaComboBox;
        private Label label1;
        private ComboBox TamañoComboBox;
        private Label label2;
    }
}
