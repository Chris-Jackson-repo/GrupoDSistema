namespace GrupoD.Tutasa.DespachanteOmnibus
{
    partial class DespachanteForm
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
            CargaYDescargagroupBox = new GroupBox();
            BuscarPatentebutton = new Button();
            GuiasACargarlabel = new Label();
            GuiasADescargarlabel = new Label();
            PatenteTextBox = new TextBox();
            IngresarPatentelabel = new Label();
            GuiasDescargaListView = new ListView();
            GuiaDescargarcolumnHeader = new ColumnHeader();
            CDOrigencolumnHeader = new ColumnHeader();
            DestinocolumnHeader = new ColumnHeader();
            TipoCajacolumnHeader = new ColumnHeader();
            EstadocolumnHeader = new ColumnHeader();
            GuiasCargaListView = new ListView();
            GuiasCargacolumnHeader1 = new ColumnHeader();
            CDDestinocolumnHeader = new ColumnHeader();
            TipoCajacolumnHeader2 = new ColumnHeader();
            EstadocolumnHeader2 = new ColumnHeader();
            DestinocolumnHeader2 = new ColumnHeader();
            Confirmarbutton = new Button();
            Cancelarbutton = new Button();
            CargaYDescargagroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CargaYDescargagroupBox
            // 
            CargaYDescargagroupBox.Controls.Add(BuscarPatentebutton);
            CargaYDescargagroupBox.Controls.Add(GuiasACargarlabel);
            CargaYDescargagroupBox.Controls.Add(GuiasADescargarlabel);
            CargaYDescargagroupBox.Controls.Add(PatenteTextBox);
            CargaYDescargagroupBox.Controls.Add(IngresarPatentelabel);
            CargaYDescargagroupBox.Controls.Add(GuiasDescargaListView);
            CargaYDescargagroupBox.Controls.Add(GuiasCargaListView);
            CargaYDescargagroupBox.Location = new Point(12, 7);
            CargaYDescargagroupBox.Name = "CargaYDescargagroupBox";
            CargaYDescargagroupBox.Size = new Size(759, 874);
            CargaYDescargagroupBox.TabIndex = 0;
            CargaYDescargagroupBox.TabStop = false;
            CargaYDescargagroupBox.Text = "Carga y descarga de cajas";
            // 
            // BuscarPatentebutton
            // 
            BuscarPatentebutton.Location = new Point(429, 47);
            BuscarPatentebutton.Name = "BuscarPatentebutton";
            BuscarPatentebutton.Size = new Size(101, 23);
            BuscarPatentebutton.TabIndex = 6;
            BuscarPatentebutton.Text = "BUSCAR";
            BuscarPatentebutton.UseVisualStyleBackColor = true;
            BuscarPatentebutton.Click += BuscarPatentebutton_Click;
            // 
            // GuiasACargarlabel
            // 
            GuiasACargarlabel.AutoSize = true;
            GuiasACargarlabel.Font = new Font("Segoe UI", 12F);
            GuiasACargarlabel.Location = new Point(17, 484);
            GuiasACargarlabel.Name = "GuiasACargarlabel";
            GuiasACargarlabel.Size = new Size(109, 21);
            GuiasACargarlabel.TabIndex = 5;
            GuiasACargarlabel.Text = "Guías a cargar";
            // 
            // GuiasADescargarlabel
            // 
            GuiasADescargarlabel.AutoSize = true;
            GuiasADescargarlabel.Font = new Font("Segoe UI", 12F);
            GuiasADescargarlabel.Location = new Point(17, 95);
            GuiasADescargarlabel.Name = "GuiasADescargarlabel";
            GuiasADescargarlabel.Size = new Size(133, 21);
            GuiasADescargarlabel.TabIndex = 4;
            GuiasADescargarlabel.Text = "Guías a descargar";
            // 
            // PatenteTextBox
            // 
            PatenteTextBox.Location = new Point(185, 47);
            PatenteTextBox.Name = "PatenteTextBox";
            PatenteTextBox.Size = new Size(200, 23);
            PatenteTextBox.TabIndex = 3;
            // 
            // IngresarPatentelabel
            // 
            IngresarPatentelabel.AutoSize = true;
            IngresarPatentelabel.Location = new Point(17, 50);
            IngresarPatentelabel.Name = "IngresarPatentelabel";
            IngresarPatentelabel.Size = new Size(116, 15);
            IngresarPatentelabel.TabIndex = 2;
            IngresarPatentelabel.Text = "Patente del ómnibus";
            // 
            // GuiasDescargaListView
            // 
            GuiasDescargaListView.CheckBoxes = true;
            GuiasDescargaListView.Columns.AddRange(new ColumnHeader[] { GuiaDescargarcolumnHeader, CDOrigencolumnHeader, DestinocolumnHeader, TipoCajacolumnHeader, EstadocolumnHeader });
            GuiasDescargaListView.Location = new Point(17, 119);
            GuiasDescargaListView.Name = "GuiasDescargaListView";
            GuiasDescargaListView.Size = new Size(712, 315);
            GuiasDescargaListView.TabIndex = 1;
            GuiasDescargaListView.UseCompatibleStateImageBehavior = false;
            GuiasDescargaListView.View = View.Details;
            // 
            // GuiaDescargarcolumnHeader
            // 
            GuiaDescargarcolumnHeader.Text = "Guía";
            GuiaDescargarcolumnHeader.Width = 150;
            // 
            // CDOrigencolumnHeader
            // 
            CDOrigencolumnHeader.Text = "CD Origen";
            CDOrigencolumnHeader.Width = 150;
            // 
            // DestinocolumnHeader
            // 
            DestinocolumnHeader.Text = "Destino final";
            DestinocolumnHeader.Width = 150;
            // 
            // TipoCajacolumnHeader
            // 
            TipoCajacolumnHeader.Text = "Tipo de caja";
            TipoCajacolumnHeader.Width = 100;
            // 
            // EstadocolumnHeader
            // 
            EstadocolumnHeader.Text = "Estado";
            EstadocolumnHeader.Width = 150;
            // 
            // GuiasCargaListView
            // 
            GuiasCargaListView.CheckBoxes = true;
            GuiasCargaListView.Columns.AddRange(new ColumnHeader[] { GuiasCargacolumnHeader1, CDDestinocolumnHeader, TipoCajacolumnHeader2, EstadocolumnHeader2, DestinocolumnHeader2 });
            GuiasCargaListView.Location = new Point(17, 508);
            GuiasCargaListView.Name = "GuiasCargaListView";
            GuiasCargaListView.Size = new Size(712, 340);
            GuiasCargaListView.TabIndex = 0;
            GuiasCargaListView.UseCompatibleStateImageBehavior = false;
            GuiasCargaListView.View = View.Details;
            // 
            // GuiasCargacolumnHeader1
            // 
            GuiasCargacolumnHeader1.Text = "Guías";
            GuiasCargacolumnHeader1.Width = 150;
            // 
            // CDDestinocolumnHeader
            // 
            CDDestinocolumnHeader.Text = "CD Destino";
            CDDestinocolumnHeader.Width = 150;
            // 
            // TipoCajacolumnHeader2
            // 
            TipoCajacolumnHeader2.DisplayIndex = 3;
            TipoCajacolumnHeader2.Text = "Tipo de caja";
            TipoCajacolumnHeader2.Width = 100;
            // 
            // EstadocolumnHeader2
            // 
            EstadocolumnHeader2.DisplayIndex = 4;
            EstadocolumnHeader2.Text = "Estado";
            EstadocolumnHeader2.Width = 150;
            // 
            // DestinocolumnHeader2
            // 
            DestinocolumnHeader2.DisplayIndex = 2;
            DestinocolumnHeader2.Text = "Destino final";
            DestinocolumnHeader2.Width = 150;
            // 
            // Confirmarbutton
            // 
            Confirmarbutton.Location = new Point(275, 925);
            Confirmarbutton.Name = "Confirmarbutton";
            Confirmarbutton.Size = new Size(183, 79);
            Confirmarbutton.TabIndex = 1;
            Confirmarbutton.Text = "Confirmar";
            Confirmarbutton.UseVisualStyleBackColor = true;
            Confirmarbutton.Click += Confirmarbutton_Click;
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Location = new Point(624, 1040);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(138, 50);
            Cancelarbutton.TabIndex = 2;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // DespachanteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 1102);
            Controls.Add(Cancelarbutton);
            Controls.Add(Confirmarbutton);
            Controls.Add(CargaYDescargagroupBox);
            Name = "DespachanteForm";
            Text = "DespachanteForm";
            CargaYDescargagroupBox.ResumeLayout(false);
            CargaYDescargagroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CargaYDescargagroupBox;
        private ListView GuiasDescargaListView;
        private ListView GuiasCargaListView;
        private Label IngresarPatentelabel;
        private TextBox PatenteTextBox;
        private ColumnHeader GuiaDescargarcolumnHeader;
        private ColumnHeader CDOrigencolumnHeader;
        private ColumnHeader DestinocolumnHeader;
        private ColumnHeader TipoCajacolumnHeader;
        private ColumnHeader EstadocolumnHeader;
        private ColumnHeader GuiasCargacolumnHeader1;
        private ColumnHeader CDDestinocolumnHeader;
        private ColumnHeader TipoCajacolumnHeader2;
        private ColumnHeader EstadocolumnHeader2;
        private ColumnHeader DestinocolumnHeader2;
        private Button Confirmarbutton;
        private Button Cancelarbutton;
        private Label GuiasACargarlabel;
        private Label GuiasADescargarlabel;
        private Button BuscarPatentebutton;
    }
}