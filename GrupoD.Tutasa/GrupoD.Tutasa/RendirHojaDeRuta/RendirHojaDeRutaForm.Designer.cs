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
            ListViewItem listViewItem2 = new ListViewItem("Cumplido");
            groupBox2 = new GroupBox();
            ListaGuiasDespacholabel = new Label();
            button2 = new Button();
            DNI_Fleterolabel = new Label();
            textBox1 = new TextBox();
            DatagridRendicion = new Label();
            groupBox = new GroupBox();
            Buscarbutton = new Button();
            listView1 = new ListView();
            this.EspacioVaciocolumnHeader1 = new ColumnHeader();
            GuiacolumnHeader1 = new ColumnHeader();
            DireccioncolumnHeader1 = new ColumnHeader();
            DNIDestinatariocolumnHeader1 = new ColumnHeader();
            TipoPaquetecolumnHeader1 = new ColumnHeader();
            listView2 = new ListView();
            GuiacolumnHeader2 = new ColumnHeader();
            EstadocolumnHeader2 = new ColumnHeader();
            TipoPaquetecolumnHeader2 = new ColumnHeader();
            DireccionDestinocolumnHeader2 = new ColumnHeader();
            DNIAutorizadocolumnHeader2 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(ListaGuiasDespacholabel);
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
            // button2
            // 
            button2.Location = new Point(699, 815);
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
            DatagridRendicion.Size = new Size(316, 33);
            DatagridRendicion.TabIndex = 6;
            DatagridRendicion.Text = "Guías pendientes de rendición";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(listView1);
            groupBox.Controls.Add(DatagridRendicion);
            groupBox.Location = new Point(13, 73);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(791, 356);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Guías a cargo del fletero";
            // 
            // Buscarbutton
            // 
            Buscarbutton.Location = new Point(402, 32);
            Buscarbutton.Name = "Buscarbutton";
            Buscarbutton.Size = new Size(168, 23);
            Buscarbutton.TabIndex = 8;
            Buscarbutton.Text = "Buscar";
            Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { this.EspacioVaciocolumnHeader1, GuiacolumnHeader1, DireccioncolumnHeader1, DNIDestinatariocolumnHeader1, TipoPaquetecolumnHeader1 });
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(8, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(766, 261);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // EspacioVaciocolumnHeader1
            // 
            this.EspacioVaciocolumnHeader1.Text = "";
            this.EspacioVaciocolumnHeader1.Width = 100;
            // 
            // GuiacolumnHeader1
            // 
            GuiacolumnHeader1.Text = "Guía";
            GuiacolumnHeader1.Width = 150;
            // 
            // DireccioncolumnHeader1
            // 
            DireccioncolumnHeader1.DisplayIndex = 3;
            DireccioncolumnHeader1.Text = "Dirección de destino";
            DireccioncolumnHeader1.Width = 250;
            // 
            // DNIDestinatariocolumnHeader1
            // 
            DNIDestinatariocolumnHeader1.DisplayIndex = 4;
            DNIDestinatariocolumnHeader1.Text = "DNI autorizado";
            DNIDestinatariocolumnHeader1.Width = 200;
            // 
            // TipoPaquetecolumnHeader1
            // 
            TipoPaquetecolumnHeader1.DisplayIndex = 2;
            TipoPaquetecolumnHeader1.Text = "Tipo";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader2, EstadocolumnHeader2, TipoPaquetecolumnHeader2, DireccionDestinocolumnHeader2, DNIAutorizadocolumnHeader2 });
            listView2.Location = new Point(6, 86);
            listView2.Name = "listView2";
            listView2.Size = new Size(796, 249);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // GuiacolumnHeader2
            // 
            GuiacolumnHeader2.Text = "Guía";
            GuiacolumnHeader2.Width = 150;
            // 
            // EstadocolumnHeader2
            // 
            EstadocolumnHeader2.Text = "Estado";
            EstadocolumnHeader2.Width = 180;
            // 
            // TipoPaquetecolumnHeader2
            // 
            TipoPaquetecolumnHeader2.Text = "Tipo";
            // 
            // DireccionDestinocolumnHeader2
            // 
            DireccionDestinocolumnHeader2.Text = "Dirección de destino";
            DireccionDestinocolumnHeader2.Width = 200;
            // 
            // DNIAutorizadocolumnHeader2
            // 
            DNIAutorizadocolumnHeader2.Text = "DNI autorizado";
            DNIAutorizadocolumnHeader2.Width = 200;
            // 
            // RendirHojaDeRutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 874);
            Controls.Add(Buscarbutton);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(DNI_Fleterolabel);
            Controls.Add(groupBox);
            Name = "RendirHojaDeRutaForm";
            Text = "Rendición de hojas de ruta";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox.ResumeLayout(false);
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
        private Button Buscarbutton;
        private DataGridView dataGridView1;
        private Label ListaGuiasDespacholabel;
        private DataGridViewCheckBoxColumn CargarCheckBox;
        private DataGridViewTextBoxColumn GuíaColumn1;
        private DataGridViewTextBoxColumn EstadoColumn1;
        private DataGridViewTextBoxColumn DestinoColumn1;
        private DataGridViewTextBoxColumn DestinatarioColumn1;
        private DataGridViewCheckBoxColumn DevueltoHR;
        private ListView listView1;
        private ColumnHeader GuiacolumnHeader1;
        private ColumnHeader GuiacolumnHeader1;
        private ColumnHeader DireccioncolumnHeader1;
        private ColumnHeader DNIDestinatariocolumnHeader1;
        private ColumnHeader TipoPaquetecolumnHeader1;
        private ListView listView2;
        private ColumnHeader GuiacolumnHeader2;
        private ColumnHeader EstadocolumnHeader2;
        private ColumnHeader TipoPaquetecolumnHeader2;
        private ColumnHeader DireccionDestinocolumnHeader2;
        private ColumnHeader DNIAutorizadocolumnHeader2;
    }
}