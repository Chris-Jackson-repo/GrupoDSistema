namespace GrupoD.Tutasa.RendirHojaDeRuta
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
            groupBox2 = new GroupBox();
            ListaGuiasDespacholabel = new Label();
            dataGridView2 = new DataGridView();
            GuíaColumn2 = new DataGridViewTextBoxColumn();
            EstadoColumn2 = new DataGridViewTextBoxColumn();
            TipoPaqueteColumn = new DataGridViewTextBoxColumn();
            DestinoColumn2 = new DataGridViewTextBoxColumn();
            DestinatarioColumn2 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            DNI_Fleterolabel = new Label();
            textBox1 = new TextBox();
            DatagridRendicion = new Label();
            groupBox = new GroupBox();
            dataGridView1 = new DataGridView();
            CargarGuiasbutton = new Button();
            CargarCheckBox = new DataGridViewCheckBoxColumn();
            GuíaColumn1 = new DataGridViewTextBoxColumn();
            EstadoColumn1 = new DataGridViewTextBoxColumn();
            DestinoColumn1 = new DataGridViewTextBoxColumn();
            DestinatarioColumn1 = new DataGridViewTextBoxColumn();
            DevueltoHR = new DataGridViewCheckBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListaGuiasDespacholabel);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(13, 444);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías a despachar para fletero";
            // 
            // ListaGuiasDespacholabel
            // 
            ListaGuiasDespacholabel.AutoSize = true;
            ListaGuiasDespacholabel.Font = new Font("Segoe UI", 14F);
            ListaGuiasDespacholabel.Location = new Point(6, 40);
            ListaGuiasDespacholabel.Name = "ListaGuiasDespacholabel";
            ListaGuiasDespacholabel.Size = new Size(209, 25);
            ListaGuiasDespacholabel.TabIndex = 6;
            ListaGuiasDespacholabel.Text = "Lista de guías a realizar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { GuíaColumn2, EstadoColumn2, TipoPaqueteColumn, DestinoColumn2, DestinatarioColumn2 });
            dataGridView2.Location = new Point(6, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(796, 235);
            dataGridView2.TabIndex = 5;
            // 
            // GuíaColumn2
            // 
            GuíaColumn2.HeaderText = "Guía";
            GuíaColumn2.Name = "GuíaColumn2";
            // 
            // EstadoColumn2
            // 
            EstadoColumn2.HeaderText = "Estado";
            EstadoColumn2.Name = "EstadoColumn2";
            EstadoColumn2.Width = 190;
            // 
            // TipoPaqueteColumn
            // 
            TipoPaqueteColumn.HeaderText = "Tipo";
            TipoPaqueteColumn.Name = "TipoPaqueteColumn";
            TipoPaqueteColumn.Width = 97;
            // 
            // DestinoColumn2
            // 
            DestinoColumn2.HeaderText = "Dirección de destino";
            DestinoColumn2.Name = "DestinoColumn2";
            DestinoColumn2.Width = 170;
            // 
            // DestinatarioColumn2
            // 
            DestinatarioColumn2.HeaderText = "Destinatario";
            DestinatarioColumn2.Name = "DestinatarioColumn2";
            DestinatarioColumn2.Width = 170;
            // 
            // button2
            // 
            button2.Location = new Point(726, 815);
            button2.Name = "button2";
            button2.Size = new Size(116, 47);
            button2.TabIndex = 4;
            button2.Text = "Confirmar ";
            button2.UseVisualStyleBackColor = true;
            // 
            // DNI_Fleterolabel
            // 
            DNI_Fleterolabel.AutoSize = true;
            DNI_Fleterolabel.Location = new Point(21, 36);
            DNI_Fleterolabel.Name = "DNI_Fleterolabel";
            DNI_Fleterolabel.Size = new Size(83, 15);
            DNI_Fleterolabel.TabIndex = 0;
            DNI_Fleterolabel.Text = "DNI del fletero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 1;
            // 
            // DatagridRendicion
            // 
            DatagridRendicion.Font = new Font("Segoe UI", 14F);
            DatagridRendicion.Location = new Point(8, 38);
            DatagridRendicion.Name = "DatagridRendicion";
            DatagridRendicion.Size = new Size(259, 33);
            DatagridRendicion.TabIndex = 6;
            DatagridRendicion.Text = "Lista de guías asociadas";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(DatagridRendicion);
            groupBox.Controls.Add(dataGridView1);
            groupBox.Location = new Point(13, 73);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(820, 356);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Guías a cargo del fletero";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CargarCheckBox, GuíaColumn1, EstadoColumn1, DestinoColumn1, DestinatarioColumn1, DevueltoHR });
            dataGridView1.Location = new Point(8, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(794, 235);
            dataGridView1.TabIndex = 4;
            // 
            // CargarGuiasbutton
            // 
            CargarGuiasbutton.Location = new Point(402, 32);
            CargarGuiasbutton.Name = "CargarGuiasbutton";
            CargarGuiasbutton.Size = new Size(168, 23);
            CargarGuiasbutton.TabIndex = 8;
            CargarGuiasbutton.Text = "Cargar guías asignadas";
            CargarGuiasbutton.UseVisualStyleBackColor = true;
            // 
            // CargarCheckBox
            // 
            CargarCheckBox.HeaderText = "Cargar";
            CargarCheckBox.Name = "CargarCheckBox";
            CargarCheckBox.ReadOnly = true;
            CargarCheckBox.Width = 50;
            // 
            // GuíaColumn1
            // 
            GuíaColumn1.FillWeight = 150F;
            GuíaColumn1.HeaderText = "Guía";
            GuíaColumn1.Name = "GuíaColumn1";
            GuíaColumn1.ReadOnly = true;
            GuíaColumn1.Width = 150;
            // 
            // EstadoColumn1
            // 
            EstadoColumn1.HeaderText = "Estado";
            EstadoColumn1.Name = "EstadoColumn1";
            EstadoColumn1.ReadOnly = true;
            EstadoColumn1.Width = 200;
            // 
            // DestinoColumn1
            // 
            DestinoColumn1.HeaderText = "Dirección de destino";
            DestinoColumn1.Name = "DestinoColumn1";
            DestinoColumn1.ReadOnly = true;
            DestinoColumn1.Width = 150;
            // 
            // DestinatarioColumn1
            // 
            DestinatarioColumn1.HeaderText = "DNI destinatario";
            DestinatarioColumn1.Name = "DestinatarioColumn1";
            DestinatarioColumn1.ReadOnly = true;
            // 
            // DevueltoHR
            // 
            DevueltoHR.HeaderText = "Devuelto ";
            DevueltoHR.Name = "DevueltoHR";
            DevueltoHR.ReadOnly = true;
            // 
            // RendirHojaDeRutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 874);
            Controls.Add(CargarGuiasbutton);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(DNI_Fleterolabel);
            Controls.Add(groupBox);
            Name = "RendirHojaDeRutaForm";
            Text = "Rendición de hojas de ruta";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button button2;
        private Label DNI_Fleterolabel;
        private TextBox textBox1;
        private Label DatagridRendicion;
        private GroupBox groupBox;
        private Button CargarGuiasbutton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label ListaGuiasDespacholabel;
        private DataGridViewTextBoxColumn GuíaColumn2;
        private DataGridViewTextBoxColumn EstadoColumn2;
        private DataGridViewTextBoxColumn TipoPaqueteColumn;
        private DataGridViewTextBoxColumn DestinoColumn2;
        private DataGridViewTextBoxColumn DestinatarioColumn2;
        private DataGridViewCheckBoxColumn CargarCheckBox;
        private DataGridViewTextBoxColumn GuíaColumn1;
        private DataGridViewTextBoxColumn EstadoColumn1;
        private DataGridViewTextBoxColumn DestinoColumn1;
        private DataGridViewTextBoxColumn DestinatarioColumn1;
        private DataGridViewCheckBoxColumn DevueltoHR;
    }
}