namespace GrupoD.Tutasa.RegEntregaAgencia
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
            NumeroGuiaLabel = new Label();
            NumeroGuiaTextbox = new TextBox();
            DatosEncomiendaLabel = new Label();
            FechaLlegadaAgenciaLabel = new Label();
            FechaLlegadaAgenciaDateTimePicker = new DateTimePicker();
            EstadoActLabel = new Label();
            EstadoActualCombobox = new ComboBox();
            DatosRetiranteLabel = new Label();
            RazonSocialLabel = new Label();
            RazonSocialTextbox = new TextBox();
            NomApRetiranteLabel = new Label();
            TelefonoRetiranteLabel = new Label();
            MailRetiranteLabel = new Label();
            NomApRetiranteTextbox = new TextBox();
            TelefonoRetiranteTextbox = new TextBox();
            MailRetiranteTextbox = new TextBox();
            RegistarEntregaButton = new Button();
            CancelarButton = new Button();
            FechaRetiroLabel = new Label();
            FechaRetiroDateTimePicker = new DateTimePicker();
            DatosClienteLabel = new Label();
            MailClienteLabel = new Label();
            MailClienteTextBox = new TextBox();
            TelefonoClienteLabel = new Label();
            TelefonoClienteTextBox = new TextBox();
            SuspendLayout();
            // 
            // NumeroGuiaLabel
            // 
            NumeroGuiaLabel.AutoSize = true;
            NumeroGuiaLabel.Font = new Font("Segoe UI", 12F);
            NumeroGuiaLabel.Location = new Point(25, 33);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(154, 28);
            NumeroGuiaLabel.TabIndex = 0;
            NumeroGuiaLabel.Text = "Número de guía";
            NumeroGuiaLabel.Click += label1_Click;
            // 
            // NumeroGuiaTextbox
            // 
            NumeroGuiaTextbox.Font = new Font("Segoe UI", 8F);
            NumeroGuiaTextbox.Location = new Point(33, 64);
            NumeroGuiaTextbox.Name = "NumeroGuiaTextbox";
            NumeroGuiaTextbox.Size = new Size(309, 25);
            NumeroGuiaTextbox.TabIndex = 1;
            NumeroGuiaTextbox.TextChanged += NumeroGuiaTextbox_TextChanged;
            // 
            // DatosEncomiendaLabel
            // 
            DatosEncomiendaLabel.AutoSize = true;
            DatosEncomiendaLabel.Font = new Font("Segoe UI", 12F);
            DatosEncomiendaLabel.Location = new Point(25, 294);
            DatosEncomiendaLabel.Name = "DatosEncomiendaLabel";
            DatosEncomiendaLabel.Size = new Size(222, 28);
            DatosEncomiendaLabel.TabIndex = 2;
            DatosEncomiendaLabel.Text = "Datos de la encomienda";
            // 
            // FechaLlegadaAgenciaLabel
            // 
            FechaLlegadaAgenciaLabel.AutoSize = true;
            FechaLlegadaAgenciaLabel.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaLabel.Location = new Point(25, 341);
            FechaLlegadaAgenciaLabel.Name = "FechaLlegadaAgenciaLabel";
            FechaLlegadaAgenciaLabel.Size = new Size(171, 19);
            FechaLlegadaAgenciaLabel.TabIndex = 3;
            FechaLlegadaAgenciaLabel.Text = "Fecha de llegada a agencia";
            // 
            // FechaLlegadaAgenciaDateTimePicker
            // 
            FechaLlegadaAgenciaDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaDateTimePicker.Location = new Point(219, 341);
            FechaLlegadaAgenciaDateTimePicker.Name = "FechaLlegadaAgenciaDateTimePicker";
            FechaLlegadaAgenciaDateTimePicker.Size = new Size(292, 25);
            FechaLlegadaAgenciaDateTimePicker.TabIndex = 4;
            // 
            // EstadoActLabel
            // 
            EstadoActLabel.AutoSize = true;
            EstadoActLabel.Font = new Font("Segoe UI", 8F);
            EstadoActLabel.Location = new Point(506, 42);
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
            EstadoActualCombobox.Location = new Point(517, 64);
            EstadoActualCombobox.Name = "EstadoActualCombobox";
            EstadoActualCombobox.Size = new Size(262, 25);
            EstadoActualCombobox.TabIndex = 6;
            EstadoActualCombobox.SelectedIndexChanged += EstadoActualCombobox_SelectedIndexChanged;
            // 
            // DatosRetiranteLabel
            // 
            DatosRetiranteLabel.AutoSize = true;
            DatosRetiranteLabel.Font = new Font("Segoe UI", 12F);
            DatosRetiranteLabel.Location = new Point(25, 425);
            DatosRetiranteLabel.Name = "DatosRetiranteLabel";
            DatosRetiranteLabel.Size = new Size(174, 28);
            DatosRetiranteLabel.TabIndex = 7;
            DatosRetiranteLabel.Text = "Datos del retirante";
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Font = new Font("Segoe UI", 8F);
            RazonSocialLabel.Location = new Point(25, 165);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(83, 19);
            RazonSocialLabel.TabIndex = 8;
            RazonSocialLabel.Text = "Razón social";
            // 
            // RazonSocialTextbox
            // 
            RazonSocialTextbox.Font = new Font("Segoe UI", 8F);
            RazonSocialTextbox.Location = new Point(219, 165);
            RazonSocialTextbox.Name = "RazonSocialTextbox";
            RazonSocialTextbox.Size = new Size(292, 25);
            RazonSocialTextbox.TabIndex = 9;
            // 
            // NomApRetiranteLabel
            // 
            NomApRetiranteLabel.AutoSize = true;
            NomApRetiranteLabel.Font = new Font("Segoe UI", 8F);
            NomApRetiranteLabel.Location = new Point(25, 468);
            NomApRetiranteLabel.Name = "NomApRetiranteLabel";
            NomApRetiranteLabel.Size = new Size(123, 19);
            NomApRetiranteLabel.TabIndex = 10;
            NomApRetiranteLabel.Text = "Nombre y Apellido";
            // 
            // TelefonoRetiranteLabel
            // 
            TelefonoRetiranteLabel.AutoSize = true;
            TelefonoRetiranteLabel.Font = new Font("Segoe UI", 8F);
            TelefonoRetiranteLabel.Location = new Point(25, 510);
            TelefonoRetiranteLabel.Name = "TelefonoRetiranteLabel";
            TelefonoRetiranteLabel.Size = new Size(60, 19);
            TelefonoRetiranteLabel.TabIndex = 11;
            TelefonoRetiranteLabel.Text = "Teléfono";
            // 
            // MailRetiranteLabel
            // 
            MailRetiranteLabel.AutoSize = true;
            MailRetiranteLabel.Font = new Font("Segoe UI", 8F);
            MailRetiranteLabel.Location = new Point(25, 556);
            MailRetiranteLabel.Name = "MailRetiranteLabel";
            MailRetiranteLabel.Size = new Size(35, 19);
            MailRetiranteLabel.TabIndex = 12;
            MailRetiranteLabel.Text = "Mail";
            // 
            // NomApRetiranteTextbox
            // 
            NomApRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            NomApRetiranteTextbox.Location = new Point(219, 465);
            NomApRetiranteTextbox.Name = "NomApRetiranteTextbox";
            NomApRetiranteTextbox.Size = new Size(292, 25);
            NomApRetiranteTextbox.TabIndex = 13;
            // 
            // TelefonoRetiranteTextbox
            // 
            TelefonoRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            TelefonoRetiranteTextbox.Location = new Point(219, 510);
            TelefonoRetiranteTextbox.Name = "TelefonoRetiranteTextbox";
            TelefonoRetiranteTextbox.Size = new Size(292, 25);
            TelefonoRetiranteTextbox.TabIndex = 14;
            // 
            // MailRetiranteTextbox
            // 
            MailRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            MailRetiranteTextbox.Location = new Point(219, 556);
            MailRetiranteTextbox.Name = "MailRetiranteTextbox";
            MailRetiranteTextbox.Size = new Size(292, 25);
            MailRetiranteTextbox.TabIndex = 15;
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(517, 636);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(134, 30);
            RegistarEntregaButton.TabIndex = 18;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(657, 636);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(134, 30);
            CancelarButton.TabIndex = 19;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // FechaRetiroLabel
            // 
            FechaRetiroLabel.AutoSize = true;
            FechaRetiroLabel.Font = new Font("Segoe UI", 8F);
            FechaRetiroLabel.Location = new Point(25, 388);
            FechaRetiroLabel.Name = "FechaRetiroLabel";
            FechaRetiroLabel.Size = new Size(100, 19);
            FechaRetiroLabel.TabIndex = 20;
            FechaRetiroLabel.Text = "Fecha de retiro";
            FechaRetiroLabel.Click += label1_Click_1;
            // 
            // FechaRetiroDateTimePicker
            // 
            FechaRetiroDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaRetiroDateTimePicker.Location = new Point(219, 388);
            FechaRetiroDateTimePicker.Name = "FechaRetiroDateTimePicker";
            FechaRetiroDateTimePicker.Size = new Size(292, 25);
            FechaRetiroDateTimePicker.TabIndex = 21;
            // 
            // DatosClienteLabel
            // 
            DatosClienteLabel.AutoSize = true;
            DatosClienteLabel.Font = new Font("Segoe UI", 12F);
            DatosClienteLabel.Location = new Point(25, 114);
            DatosClienteLabel.Name = "DatosClienteLabel";
            DatosClienteLabel.Size = new Size(157, 28);
            DatosClienteLabel.TabIndex = 22;
            DatosClienteLabel.Text = "Datos del cliente";
            // 
            // MailClienteLabel
            // 
            MailClienteLabel.AutoSize = true;
            MailClienteLabel.Font = new Font("Segoe UI", 8F);
            MailClienteLabel.Location = new Point(25, 255);
            MailClienteLabel.Name = "MailClienteLabel";
            MailClienteLabel.Size = new Size(35, 19);
            MailClienteLabel.TabIndex = 23;
            MailClienteLabel.Text = "Mail";
            // 
            // MailClienteTextBox
            // 
            MailClienteTextBox.Font = new Font("Segoe UI", 8F);
            MailClienteTextBox.Location = new Point(219, 255);
            MailClienteTextBox.Name = "MailClienteTextBox";
            MailClienteTextBox.Size = new Size(292, 25);
            MailClienteTextBox.TabIndex = 24;
            // 
            // TelefonoClienteLabel
            // 
            TelefonoClienteLabel.AutoSize = true;
            TelefonoClienteLabel.Font = new Font("Segoe UI", 8F);
            TelefonoClienteLabel.Location = new Point(25, 208);
            TelefonoClienteLabel.Name = "TelefonoClienteLabel";
            TelefonoClienteLabel.Size = new Size(60, 19);
            TelefonoClienteLabel.TabIndex = 25;
            TelefonoClienteLabel.Text = "Teléfono";
            // 
            // TelefonoClienteTextBox
            // 
            TelefonoClienteTextBox.Font = new Font("Segoe UI", 8F);
            TelefonoClienteTextBox.Location = new Point(219, 208);
            TelefonoClienteTextBox.Name = "TelefonoClienteTextBox";
            TelefonoClienteTextBox.Size = new Size(292, 25);
            TelefonoClienteTextBox.TabIndex = 26;
            // 
            // EstadoActualLabel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 668);
            Controls.Add(TelefonoClienteTextBox);
            Controls.Add(TelefonoClienteLabel);
            Controls.Add(MailClienteTextBox);
            Controls.Add(MailClienteLabel);
            Controls.Add(DatosClienteLabel);
            Controls.Add(FechaRetiroDateTimePicker);
            Controls.Add(FechaRetiroLabel);
            Controls.Add(CancelarButton);
            Controls.Add(RegistarEntregaButton);
            Controls.Add(MailRetiranteTextbox);
            Controls.Add(TelefonoRetiranteTextbox);
            Controls.Add(NomApRetiranteTextbox);
            Controls.Add(MailRetiranteLabel);
            Controls.Add(TelefonoRetiranteLabel);
            Controls.Add(NomApRetiranteLabel);
            Controls.Add(RazonSocialTextbox);
            Controls.Add(RazonSocialLabel);
            Controls.Add(DatosRetiranteLabel);
            Controls.Add(EstadoActualCombobox);
            Controls.Add(EstadoActLabel);
            Controls.Add(FechaLlegadaAgenciaDateTimePicker);
            Controls.Add(FechaLlegadaAgenciaLabel);
            Controls.Add(DatosEncomiendaLabel);
            Controls.Add(NumeroGuiaTextbox);
            Controls.Add(NumeroGuiaLabel);
            Name = "EstadoActualLabel";
            Text = "Registrar entrega en agencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumeroGuiaLabel;
        private TextBox NumeroGuiaTextbox;
        private Label DatosEncomiendaLabel;
        private Label FechaLlegadaAgenciaLabel;
        private DateTimePicker FechaLlegadaAgenciaDateTimePicker;
        private Label EstadoActLabel;
        private ComboBox EstadoActualCombobox;
        private Label DatosRetiranteLabel;
        private Label RazonSocialLabel;
        private TextBox RazonSocialTextbox;
        private Label NomApRetiranteLabel;
        private Label TelefonoRetiranteLabel;
        private Label MailRetiranteLabel;
        private TextBox NomApRetiranteTextbox;
        private TextBox TelefonoRetiranteTextbox;
        private TextBox MailRetiranteTextbox;
        private Button RegistarEntregaButton;
        private Button CancelarButton;
        private Label FechaRetiroLabel;
        private DateTimePicker FechaRetiroDateTimePicker;
        private Label DatosClienteLabel;
        private Label MailClienteLabel;
        private TextBox MailClienteTextBox;
        private Label TelefonoClienteLabel;
        private TextBox TelefonoClienteTextBox;
    }
}
