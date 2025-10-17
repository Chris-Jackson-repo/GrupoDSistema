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
            CargaGuiaslistView = new ListView();
            DescargaGuiaslistView = new ListView();
            IngresarPatentelabel = new Label();
            PatentetextBox = new TextBox();
            GuiaDescargarcolumnHeader = new ColumnHeader();
            CDOrigencolumnHeader = new ColumnHeader();
            DestinocolumnHeader = new ColumnHeader();
            TipoCajacolumnHeader = new ColumnHeader();
            EstadocolumnHeader = new ColumnHeader();
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
            CargaYDescargagroupBox.Controls.Add(PatentetextBox);
            CargaYDescargagroupBox.Controls.Add(IngresarPatentelabel);
            CargaYDescargagroupBox.Controls.Add(DescargaGuiaslistView);
            CargaYDescargagroupBox.Controls.Add(CargaGuiaslistView);
            CargaYDescargagroupBox.Location = new Point(12, 7);
            CargaYDescargagroupBox.Name = "CargaYDescargagroupBox";
            CargaYDescargagroupBox.Size = new Size(759, 874);
            CargaYDescargagroupBox.TabIndex = 0;
            CargaYDescargagroupBox.TabStop = false;
            CargaYDescargagroupBox.Text = "Carga y descarga de cajas";
            // 
            // CargaGuiaslistView
            // 
            CargaGuiaslistView.CheckBoxes = true;
            CargaGuiaslistView.Columns.AddRange(new ColumnHeader[] { GuiasCargacolumnHeader1, CDDestinocolumnHeader, TipoCajacolumnHeader2, EstadocolumnHeader2, DestinocolumnHeader2 });
            CargaGuiaslistView.Location = new Point(17, 508);
            CargaGuiaslistView.Name = "CargaGuiaslistView";
            CargaGuiaslistView.Size = new Size(712, 340);
            CargaGuiaslistView.TabIndex = 0;
            CargaGuiaslistView.UseCompatibleStateImageBehavior = false;
            CargaGuiaslistView.View = View.Details;
            // 
            // DescargaGuiaslistView
            // 
            DescargaGuiaslistView.CheckBoxes = true;
            DescargaGuiaslistView.Columns.AddRange(new ColumnHeader[] { GuiaDescargarcolumnHeader, CDOrigencolumnHeader, DestinocolumnHeader, TipoCajacolumnHeader, EstadocolumnHeader });
            DescargaGuiaslistView.Location = new Point(17, 119);
            DescargaGuiaslistView.Name = "DescargaGuiaslistView";
            DescargaGuiaslistView.Size = new Size(712, 315);
            DescargaGuiaslistView.TabIndex = 1;
            DescargaGuiaslistView.UseCompatibleStateImageBehavior = false;
            DescargaGuiaslistView.View = View.Details;
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
            // PatentetextBox
            // 
            PatentetextBox.Location = new Point(185, 47);
            PatentetextBox.Name = "PatentetextBox";
            PatentetextBox.Size = new Size(200, 23);
            PatentetextBox.TabIndex = 3;
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
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Location = new Point(624, 1040);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(138, 50);
            Cancelarbutton.TabIndex = 2;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.UseVisualStyleBackColor = true;
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
        private ListView DescargaGuiaslistView;
        private ListView CargaGuiaslistView;
        private Label IngresarPatentelabel;
        private TextBox PatentetextBox;
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
    }
}