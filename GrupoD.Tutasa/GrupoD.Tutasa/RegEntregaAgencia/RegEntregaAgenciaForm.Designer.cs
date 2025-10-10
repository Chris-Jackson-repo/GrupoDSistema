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
            FechaLlegadaAgenciaLabel = new Label();
            FechaLlegadaAgenciaDateTimePicker = new DateTimePicker();
            NombreRetiranteLabel = new Label();
            ApellidoRetiranteLabel = new Label();
            NombreRetiranteTextbox = new TextBox();
            ApellidoRetiranteTextbox = new TextBox();
            RegistarEntregaButton = new Button();
            CancelarButton = new Button();
            FechaRetiroLabel = new Label();
            FechaRetiroDateTimePicker = new DateTimePicker();
            EstadoActualLabel = new Label();
            DniLabel = new Label();
            DniTextBox = new TextBox();
            DatosRetiranteGroupBox = new GroupBox();
            DatosEncomiendaGroupBox = new GroupBox();
            EstadoActualTextBox = new TextBox();
            DatosRetiranteGroupBox.SuspendLayout();
            DatosEncomiendaGroupBox.SuspendLayout();
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
            // FechaLlegadaAgenciaLabel
            // 
            FechaLlegadaAgenciaLabel.AutoSize = true;
            FechaLlegadaAgenciaLabel.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaLabel.Location = new Point(4, 46);
            FechaLlegadaAgenciaLabel.Name = "FechaLlegadaAgenciaLabel";
            FechaLlegadaAgenciaLabel.Size = new Size(171, 19);
            FechaLlegadaAgenciaLabel.TabIndex = 3;
            FechaLlegadaAgenciaLabel.Text = "Fecha de llegada a agencia";
            // 
            // FechaLlegadaAgenciaDateTimePicker
            // 
            FechaLlegadaAgenciaDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaLlegadaAgenciaDateTimePicker.Location = new Point(193, 46);
            FechaLlegadaAgenciaDateTimePicker.Name = "FechaLlegadaAgenciaDateTimePicker";
            FechaLlegadaAgenciaDateTimePicker.Size = new Size(292, 25);
            FechaLlegadaAgenciaDateTimePicker.TabIndex = 4;
            // 
            // NombreRetiranteLabel
            // 
            NombreRetiranteLabel.AutoSize = true;
            NombreRetiranteLabel.Font = new Font("Segoe UI", 8F);
            NombreRetiranteLabel.Location = new Point(10, 71);
            NombreRetiranteLabel.Name = "NombreRetiranteLabel";
            NombreRetiranteLabel.Size = new Size(59, 19);
            NombreRetiranteLabel.TabIndex = 10;
            NombreRetiranteLabel.Text = "Nombre";
            // 
            // ApellidoRetiranteLabel
            // 
            ApellidoRetiranteLabel.AutoSize = true;
            ApellidoRetiranteLabel.Font = new Font("Segoe UI", 8F);
            ApellidoRetiranteLabel.Location = new Point(10, 109);
            ApellidoRetiranteLabel.Name = "ApellidoRetiranteLabel";
            ApellidoRetiranteLabel.Size = new Size(58, 19);
            ApellidoRetiranteLabel.TabIndex = 11;
            ApellidoRetiranteLabel.Text = "Apellido";
            ApellidoRetiranteLabel.Click += TelefonoRetiranteLabel_Click;
            // 
            // NombreRetiranteTextbox
            // 
            NombreRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            NombreRetiranteTextbox.Location = new Point(196, 71);
            NombreRetiranteTextbox.Name = "NombreRetiranteTextbox";
            NombreRetiranteTextbox.Size = new Size(292, 25);
            NombreRetiranteTextbox.TabIndex = 13;
            // 
            // ApellidoRetiranteTextbox
            // 
            ApellidoRetiranteTextbox.Font = new Font("Segoe UI", 8F);
            ApellidoRetiranteTextbox.Location = new Point(196, 109);
            ApellidoRetiranteTextbox.Name = "ApellidoRetiranteTextbox";
            ApellidoRetiranteTextbox.Size = new Size(292, 25);
            ApellidoRetiranteTextbox.TabIndex = 14;
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
            FechaRetiroLabel.Location = new Point(6, 85);
            FechaRetiroLabel.Name = "FechaRetiroLabel";
            FechaRetiroLabel.Size = new Size(100, 19);
            FechaRetiroLabel.TabIndex = 20;
            FechaRetiroLabel.Text = "Fecha de retiro";
            FechaRetiroLabel.Click += label1_Click_1;
            // 
            // FechaRetiroDateTimePicker
            // 
            FechaRetiroDateTimePicker.Font = new Font("Segoe UI", 8F);
            FechaRetiroDateTimePicker.Location = new Point(193, 85);
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
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Font = new Font("Segoe UI", 8F);
            DniLabel.Location = new Point(10, 35);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(33, 19);
            DniLabel.TabIndex = 26;
            DniLabel.Text = "DNI";
            // 
            // DniTextBox
            // 
            DniTextBox.Font = new Font("Segoe UI", 8F);
            DniTextBox.Location = new Point(196, 35);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(292, 25);
            DniTextBox.TabIndex = 27;
            // 
            // DatosRetiranteGroupBox
            // 
            DatosRetiranteGroupBox.Controls.Add(DniTextBox);
            DatosRetiranteGroupBox.Controls.Add(DniLabel);
            DatosRetiranteGroupBox.Controls.Add(ApellidoRetiranteTextbox);
            DatosRetiranteGroupBox.Controls.Add(NombreRetiranteTextbox);
            DatosRetiranteGroupBox.Controls.Add(ApellidoRetiranteLabel);
            DatosRetiranteGroupBox.Controls.Add(NombreRetiranteLabel);
            DatosRetiranteGroupBox.Font = new Font("Segoe UI", 10F);
            DatosRetiranteGroupBox.Location = new Point(23, 349);
            DatosRetiranteGroupBox.Name = "DatosRetiranteGroupBox";
            DatosRetiranteGroupBox.Size = new Size(753, 154);
            DatosRetiranteGroupBox.TabIndex = 28;
            DatosRetiranteGroupBox.TabStop = false;
            DatosRetiranteGroupBox.Text = "Datos del retirante";
            // 
            // DatosEncomiendaGroupBox
            // 
            DatosEncomiendaGroupBox.Controls.Add(FechaRetiroDateTimePicker);
            DatosEncomiendaGroupBox.Controls.Add(FechaRetiroLabel);
            DatosEncomiendaGroupBox.Controls.Add(FechaLlegadaAgenciaDateTimePicker);
            DatosEncomiendaGroupBox.Controls.Add(FechaLlegadaAgenciaLabel);
            DatosEncomiendaGroupBox.Font = new Font("Segoe UI", 10F);
            DatosEncomiendaGroupBox.Location = new Point(21, 197);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Size = new Size(753, 135);
            DatosEncomiendaGroupBox.TabIndex = 29;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Datos de la encomienda";
            // 
            // EstadoActualTextBox
            // 
            EstadoActualTextBox.Font = new Font("Segoe UI", 8F);
            EstadoActualTextBox.Location = new Point(33, 153);
            EstadoActualTextBox.Name = "EstadoActualTextBox";
            EstadoActualTextBox.ReadOnly = true;
            EstadoActualTextBox.Size = new Size(309, 25);
            EstadoActualTextBox.TabIndex = 30;
            // 
            // RegEntregaAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 589);
            Controls.Add(EstadoActualTextBox);
            Controls.Add(DatosEncomiendaGroupBox);
            Controls.Add(DatosRetiranteGroupBox);
            Controls.Add(EstadoActualLabel);
            Controls.Add(CancelarButton);
            Controls.Add(RegistarEntregaButton);
            Controls.Add(NumeroGuiaTextbox);
            Controls.Add(NumeroGuiaLabel);
            Name = "RegEntregaAgenciaForm";
            Text = "Registrar entrega en agencia";
            DatosRetiranteGroupBox.ResumeLayout(false);
            DatosRetiranteGroupBox.PerformLayout();
            DatosEncomiendaGroupBox.ResumeLayout(false);
            DatosEncomiendaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumeroGuiaLabel;
        private TextBox NumeroGuiaTextbox;
        private Label FechaLlegadaAgenciaLabel;
        private DateTimePicker FechaLlegadaAgenciaDateTimePicker;
        private Label NombreRetiranteLabel;
        private Label ApellidoRetiranteLabel;
        private TextBox NombreRetiranteTextbox;
        private TextBox ApellidoRetiranteTextbox;
        private Button RegistarEntregaButton;
        private Button CancelarButton;
        private Label FechaRetiroLabel;
        private DateTimePicker FechaRetiroDateTimePicker;
        private Label EstadoActualLabel;
        private Label DniLabel;
        private TextBox DniTextBox;
        private GroupBox DatosRetiranteGroupBox;
        private GroupBox DatosEncomiendaGroupBox;
        private TextBox EstadoActualTextBox;
    }
}
