namespace GrupoD.Tutasa.RegEntregaAgencia
{
    partial class RegEntregaAgenciaForm
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
            DatosRetiranteLabel = new Label();
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
            EstadoActualLabel = new Label();
            EstEnCaminoLabel = new Label();
            EstEnAgenciaLabel = new Label();
            EstEntregadoLabel = new Label();
            DniLabel = new Label();
            DniTextBox = new TextBox();
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
            DatosEncomiendaLabel.Location = new Point(25, 195);
            DatosEncomiendaLabel.Name = "DatosEncomiendaLabel";
            DatosEncomiendaLabel.Size = new Size(222, 28);
            DatosEncomiendaLabel.TabIndex = 2;
            DatosEncomiendaLabel.Text = "Datos de la encomienda";
            // 
            // FechaLlegadaAgenciaLabel
            // 
            FechaLlegadaAgenciaLabel.AutoSize = true;
            FechaLlegadaAgenciaLabel.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaLabel.Location = new Point(33, 240);
            FechaLlegadaAgenciaLabel.Name = "FechaLlegadaAgenciaLabel";
            FechaLlegadaAgenciaLabel.Size = new Size(171, 19);
            FechaLlegadaAgenciaLabel.TabIndex = 3;
            FechaLlegadaAgenciaLabel.Text = "Fecha de llegada a agencia";
            // 
            // FechaLlegadaAgenciaDateTimePicker
            // 
            FechaLlegadaAgenciaDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaDateTimePicker.Location = new Point(219, 240);
            FechaLlegadaAgenciaDateTimePicker.Name = "FechaLlegadaAgenciaDateTimePicker";
            FechaLlegadaAgenciaDateTimePicker.Size = new Size(292, 25);
            FechaLlegadaAgenciaDateTimePicker.TabIndex = 4;
            // 
            // DatosRetiranteLabel
            // 
            DatosRetiranteLabel.AutoSize = true;
            DatosRetiranteLabel.Font = new Font("Segoe UI", 12F);
            DatosRetiranteLabel.Location = new Point(25, 332);
            DatosRetiranteLabel.Name = "DatosRetiranteLabel";
            DatosRetiranteLabel.Size = new Size(174, 28);
            DatosRetiranteLabel.TabIndex = 7;
            DatosRetiranteLabel.Text = "Datos del retirante";
            // 
            // NomApRetiranteLabel
            // 
            NomApRetiranteLabel.AutoSize = true;
            NomApRetiranteLabel.Font = new Font("Segoe UI", 8F);
            NomApRetiranteLabel.Location = new Point(33, 417);
            NomApRetiranteLabel.Name = "NomApRetiranteLabel";
            NomApRetiranteLabel.Size = new Size(123, 19);
            NomApRetiranteLabel.TabIndex = 10;
            NomApRetiranteLabel.Text = "Nombre y Apellido";
            // 
            // TelefonoRetiranteLabel
            // 
            TelefonoRetiranteLabel.AutoSize = true;
            TelefonoRetiranteLabel.Font = new Font("Segoe UI", 8F);
            TelefonoRetiranteLabel.Location = new Point(33, 455);
            TelefonoRetiranteLabel.Name = "TelefonoRetiranteLabel";
            TelefonoRetiranteLabel.Size = new Size(60, 19);
            TelefonoRetiranteLabel.TabIndex = 11;
            TelefonoRetiranteLabel.Text = "Teléfono";
            // 
            // MailRetiranteLabel
            // 
            MailRetiranteLabel.AutoSize = true;
            MailRetiranteLabel.Font = new Font("Segoe UI", 8F);
            MailRetiranteLabel.Location = new Point(33, 495);
            MailRetiranteLabel.Name = "MailRetiranteLabel";
            MailRetiranteLabel.Size = new Size(35, 19);
            MailRetiranteLabel.TabIndex = 12;
            MailRetiranteLabel.Text = "Mail";
            MailRetiranteLabel.Click += MailRetiranteLabel_Click;
            // 
            // NomApRetiranteTextbox
            // 
            NomApRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            NomApRetiranteTextbox.Location = new Point(219, 417);
            NomApRetiranteTextbox.Name = "NomApRetiranteTextbox";
            NomApRetiranteTextbox.Size = new Size(292, 25);
            NomApRetiranteTextbox.TabIndex = 13;
            // 
            // TelefonoRetiranteTextbox
            // 
            TelefonoRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            TelefonoRetiranteTextbox.Location = new Point(219, 455);
            TelefonoRetiranteTextbox.Name = "TelefonoRetiranteTextbox";
            TelefonoRetiranteTextbox.Size = new Size(292, 25);
            TelefonoRetiranteTextbox.TabIndex = 14;
            // 
            // MailRetiranteTextbox
            // 
            MailRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            MailRetiranteTextbox.Location = new Point(219, 495);
            MailRetiranteTextbox.Name = "MailRetiranteTextbox";
            MailRetiranteTextbox.Size = new Size(292, 25);
            MailRetiranteTextbox.TabIndex = 15;
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(511, 556);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(134, 30);
            RegistarEntregaButton.TabIndex = 18;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(651, 556);
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
            FechaRetiroLabel.Location = new Point(33, 284);
            FechaRetiroLabel.Name = "FechaRetiroLabel";
            FechaRetiroLabel.Size = new Size(100, 19);
            FechaRetiroLabel.TabIndex = 20;
            FechaRetiroLabel.Text = "Fecha de retiro";
            FechaRetiroLabel.Click += label1_Click_1;
            // 
            // FechaRetiroDateTimePicker
            // 
            FechaRetiroDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaRetiroDateTimePicker.Location = new Point(219, 284);
            FechaRetiroDateTimePicker.Name = "FechaRetiroDateTimePicker";
            FechaRetiroDateTimePicker.Size = new Size(292, 25);
            FechaRetiroDateTimePicker.TabIndex = 21;
            // 
            // EstadoActualLabel
            // 
            EstadoActualLabel.AutoSize = true;
            EstadoActualLabel.Font = new Font("Segoe UI", 12F);
            EstadoActualLabel.Location = new Point(25, 113);
            EstadoActualLabel.Name = "EstadoActualLabel";
            EstadoActualLabel.Size = new Size(128, 28);
            EstadoActualLabel.TabIndex = 22;
            EstadoActualLabel.Text = "Estado actual";
            // 
            // EstEnCaminoLabel
            // 
            EstEnCaminoLabel.AutoSize = true;
            EstEnCaminoLabel.Font = new Font("Segoe UI", 8F);
            EstEnCaminoLabel.Location = new Point(33, 158);
            EstEnCaminoLabel.Name = "EstEnCaminoLabel";
            EstEnCaminoLabel.Size = new Size(147, 19);
            EstEnCaminoLabel.TabIndex = 23;
            EstEnCaminoLabel.Text = "En camino a la agencia";
            // 
            // EstEnAgenciaLabel
            // 
            EstEnAgenciaLabel.AutoSize = true;
            EstEnAgenciaLabel.Font = new Font("Segoe UI", 8F);
            EstEnAgenciaLabel.Location = new Point(219, 158);
            EstEnAgenciaLabel.Name = "EstEnAgenciaLabel";
            EstEnAgenciaLabel.Size = new Size(74, 19);
            EstEnAgenciaLabel.TabIndex = 24;
            EstEnAgenciaLabel.Text = "En agencia";
            // 
            // EstEntregadoLabel
            // 
            EstEntregadoLabel.AutoSize = true;
            EstEntregadoLabel.Font = new Font("Segoe UI", 8F);
            EstEntregadoLabel.Location = new Point(341, 158);
            EstEntregadoLabel.Name = "EstEntregadoLabel";
            EstEntregadoLabel.Size = new Size(72, 19);
            EstEntregadoLabel.TabIndex = 25;
            EstEntregadoLabel.Text = "Entregado";
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Font = new Font("Segoe UI", 8F);
            DniLabel.Location = new Point(33, 378);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(33, 19);
            DniLabel.TabIndex = 26;
            DniLabel.Text = "DNI";
            // 
            // DniTextBox
            // 
            DniTextBox.Font = new Font("Segoe UI", 8F);
            DniTextBox.Location = new Point(219, 378);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(292, 25);
            DniTextBox.TabIndex = 27;
            // 
            // RegEntregaAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 589);
            Controls.Add(DniTextBox);
            Controls.Add(DniLabel);
            Controls.Add(EstEntregadoLabel);
            Controls.Add(EstEnAgenciaLabel);
            Controls.Add(EstEnCaminoLabel);
            Controls.Add(EstadoActualLabel);
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
            Controls.Add(DatosRetiranteLabel);
            Controls.Add(FechaLlegadaAgenciaDateTimePicker);
            Controls.Add(FechaLlegadaAgenciaLabel);
            Controls.Add(DatosEncomiendaLabel);
            Controls.Add(NumeroGuiaTextbox);
            Controls.Add(NumeroGuiaLabel);
            Name = "RegEntregaAgenciaForm";
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
        private Label DatosRetiranteLabel;
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
        private Label EstadoActualLabel;
        private Label EstEnCaminoLabel;
        private Label EstEnAgenciaLabel;
        private Label EstEntregadoLabel;
        private Label DniLabel;
        private TextBox DniTextBox;
    }
}
