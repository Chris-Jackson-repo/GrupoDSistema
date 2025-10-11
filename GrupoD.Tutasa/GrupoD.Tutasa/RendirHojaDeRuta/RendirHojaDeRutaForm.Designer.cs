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
            GuiasDespachogroupBox = new GroupBox();
            GuiasARealizarListView = new ListView();
            GuiacolumnHeader2 = new ColumnHeader();
            EstadocolumnHeader2 = new ColumnHeader();
            TipoPaquetecolumnHeader2 = new ColumnHeader();
            DireccionDestinocolumnHeader2 = new ColumnHeader();
            DNIAutorizadocolumnHeader2 = new ColumnHeader();
            CUITcolumnHeader2 = new ColumnHeader();
            ListaGuiasDespacholabel = new Label();
            Confirmarbutton = new Button();
            DNI_Fleterolabel = new Label();
            DNIFleteroTextBox = new TextBox();
            GuiasPendientesRendicionLabel = new Label();
            GuiasPendientesRendiciongroupBox = new GroupBox();
            GuiasARendirListView = new ListView();
            GuiacolumnHeader1 = new ColumnHeader();
            DireccionDestinocolumnHeader1 = new ColumnHeader();
            DNIAutorizadocolumnHeader1 = new ColumnHeader();
            CUITcolumnHeader = new ColumnHeader();
            TipoPaquetecolumnHeader = new ColumnHeader();
            Buscarbutton = new Button();
            EstadocolumnHeader1 = new ColumnHeader();
            GuiasDespachogroupBox.SuspendLayout();
            GuiasPendientesRendiciongroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EstadocolumnHeader1
            // 
            EstadocolumnHeader1.Text = "Estado";
            EstadocolumnHeader1.Width = 200;
            // 
            // GuiasDespachogroupBox
            // 
            GuiasDespachogroupBox.Controls.Add(GuiasARealizarListView);
            GuiasDespachogroupBox.Controls.Add(ListaGuiasDespacholabel);
            GuiasDespachogroupBox.Location = new Point(13, 467);
            GuiasDespachogroupBox.Name = "GuiasDespachogroupBox";
            GuiasDespachogroupBox.Size = new Size(977, 395);
            GuiasDespachogroupBox.TabIndex = 1;
            GuiasDespachogroupBox.TabStop = false;
            GuiasDespachogroupBox.Text = "Guías a despachar para fletero";
            // 
            // GuiasARealizarListView
            // 
            GuiasARealizarListView.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader2, EstadocolumnHeader2, TipoPaquetecolumnHeader2, DireccionDestinocolumnHeader2, DNIAutorizadocolumnHeader2, CUITcolumnHeader2 });
            GuiasARealizarListView.Location = new Point(8, 87);
            GuiasARealizarListView.Name = "GuiasARealizarListView";
            GuiasARealizarListView.Size = new Size(957, 290);
            GuiasARealizarListView.TabIndex = 7;
            GuiasARealizarListView.UseCompatibleStateImageBehavior = false;
            GuiasARealizarListView.View = View.Details;
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
            TipoPaquetecolumnHeader2.Text = "Tipo de paquete";
            TipoPaquetecolumnHeader2.Width = 100;
            // 
            // DireccionDestinocolumnHeader2
            // 
            DireccionDestinocolumnHeader2.DisplayIndex = 4;
            DireccionDestinocolumnHeader2.Text = "Dirección de destino";
            DireccionDestinocolumnHeader2.Width = 180;
            // 
            // DNIAutorizadocolumnHeader2
            // 
            DNIAutorizadocolumnHeader2.DisplayIndex = 5;
            DNIAutorizadocolumnHeader2.Text = "DNI del autorizado";
            DNIAutorizadocolumnHeader2.Width = 150;
            // 
            // CUITcolumnHeader2
            // 
            CUITcolumnHeader2.DisplayIndex = 3;
            CUITcolumnHeader2.Text = "CUIT";
            CUITcolumnHeader2.Width = 160;
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
            // Confirmarbutton
            // 
            Confirmarbutton.Location = new Point(874, 874);
            Confirmarbutton.Name = "Confirmarbutton";
            Confirmarbutton.Size = new Size(116, 47);
            Confirmarbutton.TabIndex = 4;
            Confirmarbutton.Text = "Confirmar ";
            Confirmarbutton.UseVisualStyleBackColor = true;
            Confirmarbutton.Click += Confirmarbutton_Click;
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
            // DNIFleteroTextBox
            // 
            DNIFleteroTextBox.Location = new Point(140, 32);
            DNIFleteroTextBox.Name = "DNIFleteroTextBox";
            DNIFleteroTextBox.Size = new Size(223, 23);
            DNIFleteroTextBox.TabIndex = 1;
            // 
            // GuiasPendientesRendicionLabel
            // 
            GuiasPendientesRendicionLabel.Font = new Font("Segoe UI", 14F);
            GuiasPendientesRendicionLabel.Location = new Point(6, 33);
            GuiasPendientesRendicionLabel.Name = "GuiasPendientesRendicionLabel";
            GuiasPendientesRendicionLabel.Size = new Size(316, 33);
            GuiasPendientesRendicionLabel.TabIndex = 6;
            GuiasPendientesRendicionLabel.Text = "Guías pendientes de rendición";
            // 
            // GuiasPendientesRendiciongroupBox
            // 
            GuiasPendientesRendiciongroupBox.Controls.Add(GuiasARendirListView);
            GuiasPendientesRendiciongroupBox.Controls.Add(GuiasPendientesRendicionLabel);
            GuiasPendientesRendiciongroupBox.Location = new Point(13, 73);
            GuiasPendientesRendiciongroupBox.Name = "GuiasPendientesRendiciongroupBox";
            GuiasPendientesRendiciongroupBox.Size = new Size(977, 375);
            GuiasPendientesRendiciongroupBox.TabIndex = 7;
            GuiasPendientesRendiciongroupBox.TabStop = false;
            GuiasPendientesRendiciongroupBox.Text = "Información de guías pendientes de rendición";
            // 
            // GuiasARendirListView
            // 
            GuiasARendirListView.CheckBoxes = true;
            GuiasARendirListView.Columns.AddRange(new ColumnHeader[] { GuiacolumnHeader1, EstadocolumnHeader1, DireccionDestinocolumnHeader1, DNIAutorizadocolumnHeader1, CUITcolumnHeader, TipoPaquetecolumnHeader });
            GuiasARendirListView.FullRowSelect = true;
            GuiasARendirListView.Location = new Point(8, 69);
            GuiasARendirListView.Name = "GuiasARendirListView";
            GuiasARendirListView.Size = new Size(957, 290);
            GuiasARendirListView.TabIndex = 7;
            GuiasARendirListView.UseCompatibleStateImageBehavior = false;
            GuiasARendirListView.View = View.Details;
            // 
            // GuiacolumnHeader1
            // 
            GuiacolumnHeader1.Text = "Guía";
            GuiacolumnHeader1.Width = 160;
            // 
            // DireccionDestinocolumnHeader1
            // 
            DireccionDestinocolumnHeader1.DisplayIndex = 4;
            DireccionDestinocolumnHeader1.Text = "Dirección de destino";
            DireccionDestinocolumnHeader1.Width = 220;
            // 
            // DNIAutorizadocolumnHeader1
            // 
            DNIAutorizadocolumnHeader1.DisplayIndex = 5;
            DNIAutorizadocolumnHeader1.Text = "DNI del autorizado";
            DNIAutorizadocolumnHeader1.Width = 150;
            // 
            // CUITcolumnHeader
            // 
            CUITcolumnHeader.DisplayIndex = 3;
            CUITcolumnHeader.Text = "CUIT";
            CUITcolumnHeader.Width = 160;
            // 
            // TipoPaquetecolumnHeader
            // 
            TipoPaquetecolumnHeader.DisplayIndex = 2;
            TipoPaquetecolumnHeader.Text = "Tipo de paquete";
            TipoPaquetecolumnHeader.Width = 100;
            // 
            // Buscarbutton
            // 
            Buscarbutton.Location = new Point(402, 32);
            Buscarbutton.Name = "Buscarbutton";
            Buscarbutton.Size = new Size(168, 23);
            Buscarbutton.TabIndex = 8;
            Buscarbutton.Text = "Buscar";
            Buscarbutton.UseVisualStyleBackColor = true;
            Buscarbutton.Click += Buscarbutton_Click;
            // 
            // RendirHojaDeRutaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 933);
            Controls.Add(Buscarbutton);
            Controls.Add(GuiasDespachogroupBox);
            Controls.Add(Confirmarbutton);
            Controls.Add(DNIFleteroTextBox);
            Controls.Add(DNI_Fleterolabel);
            Controls.Add(GuiasPendientesRendiciongroupBox);
            Name = "RendirHojaDeRutaForm";
            Text = "Rendición de hojas de ruta";
            GuiasDespachogroupBox.ResumeLayout(false);
            GuiasDespachogroupBox.PerformLayout();
            GuiasPendientesRendiciongroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox GuiasDespachogroupBox;
        private Button Confirmarbutton;
        private Label DNI_Fleterolabel;
        private TextBox DNIFleteroTextBox;
        private Label GuiasPendientesRendicionLabel;
        private GroupBox GuiasPendientesRendiciongroupBox;
        private Button Buscarbutton;
        private DataGridView dataGridView1;
        private Label ListaGuiasDespacholabel;
        private DataGridViewCheckBoxColumn CargarCheckBox;
        private DataGridViewTextBoxColumn GuíaColumn1;
        private DataGridViewTextBoxColumn EstadoColumn1;
        private DataGridViewTextBoxColumn DestinoColumn1;
        private DataGridViewTextBoxColumn DestinatarioColumn1;
        private DataGridViewCheckBoxColumn DevueltoHR;
        private ListView GuiasARendirListView;
        private ColumnHeader GuiacolumnHeader1;
        private ColumnHeader DireccionDestinocolumnHeader1;
        private ColumnHeader DNIAutorizadocolumnHeader1;
        private ListView GuiasARealizarListView;
        private ColumnHeader GuiacolumnHeader2;
        private ColumnHeader EstadocolumnHeader2;
        private ColumnHeader TipoPaquetecolumnHeader2;
        private ColumnHeader DireccionDestinocolumnHeader2;
        private ColumnHeader DNIAutorizadocolumnHeader2;
        private ColumnHeader CUITcolumnHeader2;
        private ColumnHeader CUITcolumnHeader;
        private ColumnHeader TipoPaquetecolumnHeader;
    }
}