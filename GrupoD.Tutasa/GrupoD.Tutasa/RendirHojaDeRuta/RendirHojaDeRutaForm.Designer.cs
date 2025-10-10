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
            ColumnHeader EstadocolumnHeader1;
            ListViewItem listViewItem1 = new ListViewItem("");
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            GuiacolumnHeader2 = new ColumnHeader();
            EstadocolumnHeader2 = new ColumnHeader();
            TipoPaquetecolumnHeader2 = new ColumnHeader();
            DireccionDestinocolumnHeader2 = new ColumnHeader();
            DNIAutorizadocolumnHeader2 = new ColumnHeader();
            ListaGuiasDespacholabel = new Label();
            button2 = new Button();
            DNI_Fleterolabel = new Label();
            textBox1 = new TextBox();
            DatagridRendicion = new Label();
            groupBox = new GroupBox();
            GuiasPendientesRendicionlistView1 = new ListView();
            GuiacolumnHeader1 = new ColumnHeader();
            DireccionDestinocolumnHeader1 = new ColumnHeader();
            DNIAutorizadocolumnHeader1 = new ColumnHeader();
            Buscarbutton = new Button();
            EstadocolumnHeader1 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EstadocolumnHeader1
            // 
            EstadocolumnHeader1.Text = "Estado";
            EstadocolumnHeader1.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(ListaGuiasDespacholabel);
            groupBox2.Location = new Point(13, 444);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(820, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Guías a despachar para fletero";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader2, EstadocolumnHeader2, TipoPaquetecolumnHeader2, DireccionDestinocolumnHeader2, DNIAutorizadocolumnHeader2 });
            listView1.Location = new Point(8, 86);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 242);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // GuiacolumnHeader2
            // 
            GuiacolumnHeader2.Text = "Guía";
            GuiacolumnHeader2.Width = 160;
            // 
            // EstadocolumnHeader2
            // 
            EstadocolumnHeader2.Text = "Estado";
            EstadocolumnHeader2.Width = 200;
            // 
            // TipoPaquetecolumnHeader2
            // 
            TipoPaquetecolumnHeader2.Text = "Tipo";
            TipoPaquetecolumnHeader2.Width = 100;
            // 
            // DireccionDestinocolumnHeader2
            // 
            DireccionDestinocolumnHeader2.Text = "Dirección de destino";
            DireccionDestinocolumnHeader2.Width = 180;
            // 
            // DNIAutorizadocolumnHeader2
            // 
            DNIAutorizadocolumnHeader2.Text = "DNI del autorizado";
            DNIAutorizadocolumnHeader2.Width = 150;
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
            DatagridRendicion.Location = new Point(6, 33);
            DatagridRendicion.Name = "DatagridRendicion";
            DatagridRendicion.Size = new Size(316, 33);
            DatagridRendicion.TabIndex = 6;
            DatagridRendicion.Text = "Guías pendientes de rendición";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(GuiasPendientesRendicionlistView1);
            groupBox.Controls.Add(DatagridRendicion);
            groupBox.Location = new Point(13, 73);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(820, 365);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Información de guías pendientes de rendición";
            // 
            // GuiasPendientesRendicionlistView1
            // 
            GuiasPendientesRendicionlistView1.CheckBoxes = true;
            GuiasPendientesRendicionlistView1.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader1, EstadocolumnHeader1, DireccionDestinocolumnHeader1, DNIAutorizadocolumnHeader1 });
            listViewItem1.StateImageIndex = 0;
            GuiasPendientesRendicionlistView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            GuiasPendientesRendicionlistView1.Location = new Point(8, 69);
            GuiasPendientesRendicionlistView1.Name = "GuiasPendientesRendicionlistView1";
            GuiasPendientesRendicionlistView1.Size = new Size(794, 290);
            GuiasPendientesRendicionlistView1.TabIndex = 7;
            GuiasPendientesRendicionlistView1.UseCompatibleStateImageBehavior = false;
            GuiasPendientesRendicionlistView1.View = View.Details;
            // 
            // GuiacolumnHeader1
            // 
            GuiacolumnHeader1.Text = "Guía";
            GuiacolumnHeader1.Width = 170;
            // 
            // DireccionDestinocolumnHeader1
            // 
            DireccionDestinocolumnHeader1.Text = "Dirección de destino";
            DireccionDestinocolumnHeader1.Width = 220;
            // 
            // DNIAutorizadocolumnHeader1
            // 
            DNIAutorizadocolumnHeader1.Text = "DNI del autorizado";
            DNIAutorizadocolumnHeader1.Width = 200;
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
        private ListView GuiasPendientesRendicionlistView1;
        private ColumnHeader GuiacolumnHeader1;
        private ColumnHeader DireccionDestinocolumnHeader1;
        private ColumnHeader DNIAutorizadocolumnHeader1;
        private ListView listView1;
        private ColumnHeader GuiacolumnHeader2;
        private ColumnHeader EstadocolumnHeader2;
        private ColumnHeader TipoPaquetecolumnHeader2;
        private ColumnHeader DireccionDestinocolumnHeader2;
        private ColumnHeader DNIAutorizadocolumnHeader2;
    }
}