namespace GrupoD.Tutasa.GenerarHojaDeRuta
{
    partial class RendirHojaDeRuta2Form
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
            DNIFLeterolabel = new Label();
            button1 = new Button();
            ListaGuiaslabel = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            ListaGuiasADespacharlabel = new Label();
            dataGridView1 = new DataGridView();
            CargarColumn1 = new DataGridViewCheckBoxColumn();
            GuiaColumn1 = new DataGridViewTextBoxColumn();
            DevueltoColumn1 = new DataGridViewCheckBoxColumn();
            dataGridView2 = new DataGridView();
            CargarColumn2 = new DataGridViewCheckBoxColumn();
            GuiaADespacharColumn = new DataGridViewCheckBoxColumn();
            TipoADespacharColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // DNIFLeterolabel
            // 
            DNIFLeterolabel.AutoSize = true;
            DNIFLeterolabel.Location = new Point(48, 52);
            DNIFLeterolabel.Name = "DNIFLeterolabel";
            DNIFLeterolabel.Size = new Size(64, 15);
            DNIFLeterolabel.TabIndex = 1;
            DNIFLeterolabel.Text = "DNI fletero";
            // 
            // button1
            // 
            button1.Location = new Point(432, 47);
            button1.Name = "button1";
            button1.Size = new Size(120, 25);
            button1.TabIndex = 4;
            button1.Text = "FILTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListaGuiaslabel
            // 
            ListaGuiaslabel.AutoSize = true;
            ListaGuiaslabel.Font = new Font("Segoe UI", 12F);
            ListaGuiaslabel.Location = new Point(29, 127);
            ListaGuiaslabel.Name = "ListaGuiaslabel";
            ListaGuiaslabel.Size = new Size(104, 21);
            ListaGuiaslabel.TabIndex = 8;
            ListaGuiaslabel.Text = "Lista de guías";
            ListaGuiaslabel.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 522);
            button2.Name = "button2";
            button2.Size = new Size(158, 65);
            button2.TabIndex = 10;
            button2.Text = "ACEPTAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 11;
            // 
            // ListaGuiasADespacharlabel
            // 
            ListaGuiasADespacharlabel.AutoSize = true;
            ListaGuiasADespacharlabel.Font = new Font("Segoe UI", 12F);
            ListaGuiasADespacharlabel.Location = new Point(481, 127);
            ListaGuiasADespacharlabel.Name = "ListaGuiasADespacharlabel";
            ListaGuiasADespacharlabel.Size = new Size(271, 21);
            ListaGuiasADespacharlabel.TabIndex = 15;
            ListaGuiasADespacharlabel.Text = "Lista de guías pendientes a despachar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CargarColumn1, GuiaColumn1, DevueltoColumn1 });
            dataGridView1.Location = new Point(30, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(309, 289);
            dataGridView1.TabIndex = 16;
            // 
            // CargarColumn1
            // 
            CargarColumn1.HeaderText = "Cargar";
            CargarColumn1.Name = "CargarColumn1";
            CargarColumn1.Width = 50;
            // 
            // GuiaColumn1
            // 
            GuiaColumn1.HeaderText = "Guía";
            GuiaColumn1.Name = "GuiaColumn1";
            GuiaColumn1.Resizable = DataGridViewTriState.True;
            GuiaColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            GuiaColumn1.Width = 150;
            // 
            // DevueltoColumn1
            // 
            DevueltoColumn1.HeaderText = "Devuelto";
            DevueltoColumn1.Name = "DevueltoColumn1";
            DevueltoColumn1.Width = 65;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { CargarColumn2, GuiaADespacharColumn, TipoADespacharColumn });
            dataGridView2.Location = new Point(441, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(331, 289);
            dataGridView2.TabIndex = 17;
            // 
            // CargarColumn2
            // 
            CargarColumn2.HeaderText = "Cargar";
            CargarColumn2.Name = "CargarColumn2";
            // 
            // GuiaADespacharColumn
            // 
            GuiaADespacharColumn.HeaderText = "Guía";
            GuiaADespacharColumn.Name = "GuiaADespacharColumn";
            // 
            // TipoADespacharColumn
            // 
            TipoADespacharColumn.HeaderText = "Tipo";
            TipoADespacharColumn.Name = "TipoADespacharColumn";
            // 
            // RendirHojaDeRuta2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 598);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(ListaGuiasADespacharlabel);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(DNIFLeterolabel);
            Controls.Add(ListaGuiaslabel);
            Controls.Add(button1);
            Name = "RendirHojaDeRuta2Form";
            Text = "Rendición hojas de ruta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DNIFLeterolabel;
        private Button button1;
        private Label ListaGuiaslabel;
        private Button button2;
        private TextBox textBox1;
        private Label ListaGuiasADespacharlabel;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn CargarColumn1;
        private DataGridViewTextBoxColumn GuiaColumn1;
        private DataGridViewCheckBoxColumn DevueltoColumn1;
        private DataGridView dataGridView2;
        private DataGridViewCheckBoxColumn CargarColumn2;
        private DataGridViewCheckBoxColumn GuiaADespacharColumn;
        private DataGridViewTextBoxColumn TipoADespacharColumn;
    }
}
