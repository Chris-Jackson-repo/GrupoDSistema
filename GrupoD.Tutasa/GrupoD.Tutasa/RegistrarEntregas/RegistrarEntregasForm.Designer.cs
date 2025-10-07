namespace GrupoD.Tutasa.RegistrarEntregas
{
    partial class EstadoActualLabel
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
            NumeroEncomiendaLabel = new Label();
            NroEncomiendaTextbox = new TextBox();
            DatosEncomiendaLabel = new Label();
            FechaLlegadaAgenciaLabel = new Label();
            FechaLlegadaAgenciaDateTimePicker = new DateTimePicker();
            EstadoActLabel = new Label();
            EstadoActualCombobox = new ComboBox();
            DatosClienteLabel = new Label();
            DniClienteLabel = new Label();
            DniClienteTextbox = new TextBox();
            NombreApellidoTextbox = new Label();
            TelefonoClienteLabel = new Label();
            MailClienteLabel = new Label();
            NomApClienteTextbox = new TextBox();
            TelefonoClienteTextbox = new TextBox();
            MailClienteTextbox = new TextBox();
            ObservacionesTextbox = new TextBox();
            ObservacionesLabel = new Label();
            RegistarEntregaButton = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // NumeroEncomiendaLabel
            // 
            NumeroEncomiendaLabel.AutoSize = true;
            NumeroEncomiendaLabel.Font = new Font("Segoe UI", 12F);
            NumeroEncomiendaLabel.Location = new Point(25, 33);
            NumeroEncomiendaLabel.Name = "NumeroEncomiendaLabel";
            NumeroEncomiendaLabel.Size = new Size(223, 28);
            NumeroEncomiendaLabel.TabIndex = 0;
            NumeroEncomiendaLabel.Text = "Número de encomienda";
            NumeroEncomiendaLabel.Click += label1_Click;
            // 
            // NroEncomiendaTextbox
            // 
            NroEncomiendaTextbox.Font = new Font("Segoe UI", 8F);
            NroEncomiendaTextbox.Location = new Point(25, 64);
            NroEncomiendaTextbox.Name = "NroEncomiendaTextbox";
            NroEncomiendaTextbox.Size = new Size(317, 25);
            NroEncomiendaTextbox.TabIndex = 1;
            // 
            // DatosEncomiendaLabel
            // 
            DatosEncomiendaLabel.AutoSize = true;
            DatosEncomiendaLabel.Font = new Font("Segoe UI", 12F);
            DatosEncomiendaLabel.Location = new Point(25, 131);
            DatosEncomiendaLabel.Name = "DatosEncomiendaLabel";
            DatosEncomiendaLabel.Size = new Size(222, 28);
            DatosEncomiendaLabel.TabIndex = 2;
            DatosEncomiendaLabel.Text = "Datos de la encomienda";
            // 
            // FechaLlegadaAgenciaLabel
            // 
            FechaLlegadaAgenciaLabel.AutoSize = true;
            FechaLlegadaAgenciaLabel.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaLabel.Location = new Point(25, 181);
            FechaLlegadaAgenciaLabel.Name = "FechaLlegadaAgenciaLabel";
            FechaLlegadaAgenciaLabel.Size = new Size(171, 19);
            FechaLlegadaAgenciaLabel.TabIndex = 3;
            FechaLlegadaAgenciaLabel.Text = "Fecha de llegada a agencia";
            // 
            // FechaLlegadaAgenciaDateTimePicker
            // 
            FechaLlegadaAgenciaDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaDateTimePicker.Location = new Point(219, 181);
            FechaLlegadaAgenciaDateTimePicker.Name = "FechaLlegadaAgenciaDateTimePicker";
            FechaLlegadaAgenciaDateTimePicker.Size = new Size(292, 25);
            FechaLlegadaAgenciaDateTimePicker.TabIndex = 4;
            // 
            // EstadoActLabel
            // 
            EstadoActLabel.AutoSize = true;
            EstadoActLabel.Font = new Font("Segoe UI", 8F);
            EstadoActLabel.Location = new Point(25, 224);
            EstadoActLabel.Name = "EstadoActLabel";
            EstadoActLabel.Size = new Size(90, 19);
            EstadoActLabel.TabIndex = 5;
            EstadoActLabel.Text = "Estado actual";
            // 
            // EstadoActualCombobox
            // 
            EstadoActualCombobox.Font = new Font("Segoe UI", 8F);
            EstadoActualCombobox.FormattingEnabled = true;
            EstadoActualCombobox.Items.AddRange(new object[] { "En camino a la agencia", "En agencia", "Entregado a cliente" });
            EstadoActualCombobox.Location = new Point(219, 224);
            EstadoActualCombobox.Name = "EstadoActualCombobox";
            EstadoActualCombobox.Size = new Size(292, 25);
            EstadoActualCombobox.TabIndex = 6;
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Font = new Font("Segoe UI", 12F);
            DatosClienteLabel.Location = new Point(25, 275);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(157, 28);
            DatosClienteLabel.TabIndex = 7;
            DatosClienteLabel.Text = "Datos del cliente";
            // 
            // DniClienteLabel
            // 
            DniClienteLabel.AutoSize = true;
            DniClienteLabel.Location = new Point(25, 321);
            DniClienteLabel.Name = "DniClienteLabel";
            DniClienteLabel.Size = new Size(35, 20);
            DniClienteLabel.TabIndex = 8;
            DniClienteLabel.Text = "DNI";
            // 
            // DniClienteTextbox
            // 
            DniClienteTextbox.Font = new Font("Segoe UI", 8F);
            DniClienteTextbox.Location = new Point(219, 320);
            DniClienteTextbox.Name = "DniClienteTextbox";
            DniClienteTextbox.Size = new Size(292, 25);
            DniClienteTextbox.TabIndex = 9;
            // 
            // NombreApellidoTextbox
            // 
            NombreApellidoTextbox.AutoSize = true;
            NombreApellidoTextbox.Font = new Font("Segoe UI", 8F);
            NombreApellidoTextbox.Location = new Point(25, 364);
            NombreApellidoTextbox.Name = "NombreApellidoTextbox";
            NombreApellidoTextbox.Size = new Size(123, 19);
            NombreApellidoTextbox.TabIndex = 10;
            NombreApellidoTextbox.Text = "Nombre y Apellido";
            // 
            // TelefonoClienteLabel
            // 
            TelefonoClienteLabel.AutoSize = true;
            TelefonoClienteLabel.Font = new Font("Segoe UI", 8F);
            TelefonoClienteLabel.Location = new Point(25, 407);
            TelefonoClienteLabel.Name = "TelefonoClienteLabel";
            TelefonoClienteLabel.Size = new Size(60, 19);
            TelefonoClienteLabel.TabIndex = 11;
            TelefonoClienteLabel.Text = "Teléfono";
            // 
            // MailClienteLabel
            // 
            MailClienteLabel.AutoSize = true;
            MailClienteLabel.Font = new Font("Segoe UI", 8F);
            MailClienteLabel.Location = new Point(25, 452);
            MailClienteLabel.Name = "MailClienteLabel";
            MailClienteLabel.Size = new Size(35, 19);
            MailClienteLabel.TabIndex = 12;
            MailClienteLabel.Text = "Mail";
            // 
            // NomApClienteTextbox
            // 
            NomApClienteTextbox.Font = new Font("Segoe UI", 8F);
            NomApClienteTextbox.Location = new Point(219, 361);
            NomApClienteTextbox.Name = "NomApClienteTextbox";
            NomApClienteTextbox.Size = new Size(292, 25);
            NomApClienteTextbox.TabIndex = 13;
            // 
            // TelefonoClienteTextbox
            // 
            TelefonoClienteTextbox.Font = new Font("Segoe UI", 8F);
            TelefonoClienteTextbox.Location = new Point(219, 407);
            TelefonoClienteTextbox.Name = "TelefonoClienteTextbox";
            TelefonoClienteTextbox.Size = new Size(292, 25);
            TelefonoClienteTextbox.TabIndex = 14;
            // 
            // MailClienteTextbox
            // 
            MailClienteTextbox.Font = new Font("Segoe UI", 8F);
            MailClienteTextbox.Location = new Point(219, 449);
            MailClienteTextbox.Name = "MailClienteTextbox";
            MailClienteTextbox.Size = new Size(292, 25);
            MailClienteTextbox.TabIndex = 15;
            // 
            // ObservacionesTextbox
            // 
            ObservacionesTextbox.Font = new Font("Segoe UI", 8F);
            ObservacionesTextbox.Location = new Point(25, 535);
            ObservacionesTextbox.Name = "ObservacionesTextbox";
            ObservacionesTextbox.Size = new Size(742, 25);
            ObservacionesTextbox.TabIndex = 16;
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Font = new Font("Segoe UI", 11F);
            ObservacionesLabel.Location = new Point(25, 496);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new Size(135, 25);
            ObservacionesLabel.TabIndex = 17;
            ObservacionesLabel.Text = "Observaciones";
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(530, 635);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(134, 30);
            RegistarEntregaButton.TabIndex = 18;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(670, 635);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(134, 30);
            CancelarButton.TabIndex = 19;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EstadoActualLabel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 671);
            Controls.Add(CancelarButton);
            Controls.Add(RegistarEntregaButton);
            Controls.Add(ObservacionesLabel);
            Controls.Add(ObservacionesTextbox);
            Controls.Add(MailClienteTextbox);
            Controls.Add(TelefonoClienteTextbox);
            Controls.Add(NomApClienteTextbox);
            Controls.Add(MailClienteLabel);
            Controls.Add(TelefonoClienteLabel);
            Controls.Add(NombreApellidoTextbox);
            Controls.Add(DniClienteTextbox);
            Controls.Add(DniClienteLabel);
            Controls.Add(DatosClienteLabel);
            Controls.Add(EstadoActualCombobox);
            Controls.Add(EstadoActLabel);
            Controls.Add(FechaLlegadaAgenciaDateTimePicker);
            Controls.Add(FechaLlegadaAgenciaLabel);
            Controls.Add(DatosEncomiendaLabel);
            Controls.Add(NroEncomiendaTextbox);
            Controls.Add(NumeroEncomiendaLabel);
            Name = "EstadoActualLabel";
            Text = "RegistrarEntregasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumeroEncomiendaLabel;
        private TextBox NroEncomiendaTextbox;
        private Label DatosEncomiendaLabel;
        private Label FechaLlegadaAgenciaLabel;
        private DateTimePicker FechaLlegadaAgenciaDateTimePicker;
        private Label EstadoActLabel;
        private ComboBox EstadoActualCombobox;
        private Label DatosClienteLabel;
        private Label DniClienteLabel;
        private TextBox DniClienteTextbox;
        private Label NombreApellidoTextbox;
        private Label TelefonoClienteLabel;
        private Label MailClienteLabel;
        private TextBox NomApClienteTextbox;
        private TextBox TelefonoClienteTextbox;
        private TextBox MailClienteTextbox;
        private TextBox ObservacionesTextbox;
        private Label ObservacionesLabel;
        private Button RegistarEntregaButton;
        private Button CancelarButton;
    }
}
