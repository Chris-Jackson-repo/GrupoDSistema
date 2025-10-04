namespace GrupoDSistema.Rendir_hoja_de_ruta
{
    partial class RendirHojaDeRutaForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            GuíaHR = new DataGridViewTextBoxColumn();
            DestinoHR = new DataGridViewTextBoxColumn();
            EstadoHR = new DataGridViewTextBoxColumn();
            DevueltoHR = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            DatagridRendicion = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatagridRendicion);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 422);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificación de viaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "ID hoja de ruta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha de rendición";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { GuíaHR, DestinoHR, EstadoHR, DevueltoHR });
            dataGridView1.Location = new Point(100, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(443, 235);
            dataGridView1.TabIndex = 4;
            // 
            // GuíaHR
            // 
            GuíaHR.HeaderText = "Guía";
            GuíaHR.Name = "GuíaHR";
            GuíaHR.ReadOnly = true;
            // 
            // DestinoHR
            // 
            DestinoHR.HeaderText = "Destino";
            DestinoHR.Name = "DestinoHR";
            DestinoHR.ReadOnly = true;
            // 
            // EstadoHR
            // 
            EstadoHR.HeaderText = "Estado";
            EstadoHR.Name = "EstadoHR";
            EstadoHR.ReadOnly = true;
            // 
            // DevueltoHR
            // 
            DevueltoHR.HeaderText = "Devuelto ";
            DevueltoHR.Name = "DevueltoHR";
            DevueltoHR.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(403, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 64);
            button1.TabIndex = 5;
            button1.Text = "Cargar ruta";
            button1.UseVisualStyleBackColor = true;
            // 
            // DatagridRendicion
            // 
            DatagridRendicion.Font = new Font("Segoe UI", 14F);
            DatagridRendicion.Location = new Point(6, 133);
            DatagridRendicion.Name = "DatagridRendicion";
            DatagridRendicion.Size = new Size(186, 33);
            DatagridRendicion.TabIndex = 6;
            DatagridRendicion.Text = "Lista de guías";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 351);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cierre y liquidación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(9, 43);
            label3.Name = "label3";
            label3.Size = new Size(222, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Guías en ruta: XXXX";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(9, 90);
            label4.Name = "label4";
            label4.Size = new Size(265, 25);
            label4.TabIndex = 1;
            label4.Text = "Total guías entregadas: XXXXX";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(9, 138);
            label5.Name = "label5";
            label5.Size = new Size(224, 25);
            label5.TabIndex = 2;
            label5.Text = "Total excepciones: XXXXX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(9, 185);
            label6.Name = "label6";
            label6.Size = new Size(256, 25);
            label6.TabIndex = 3;
            label6.Text = "Pendientres a conciliar: XXXX";
            // 
            // button2
            // 
            button2.Location = new Point(195, 245);
            button2.Name = "button2";
            button2.Size = new Size(203, 78);
            button2.TabIndex = 4;
            button2.Text = "Cerrar rendición";
            button2.UseVisualStyleBackColor = true;
            // 
            // RendirHojaDeRutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 796);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RendirHojaDeRutaForm";
            Text = "Rendición de hojas de ruta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn GuíaHR;
        private DataGridViewTextBoxColumn DestinoHR;
        private DataGridViewTextBoxColumn EstadoHR;
        private DataGridViewCheckBoxColumn DevueltoHR;
        private Label DatagridRendicion;
        private GroupBox groupBox2;
        private Label label3;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}