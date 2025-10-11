namespace GrupoD.Tutasa.RegEntregaCD
{
    partial class RegEntregaCDForm
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
            CancelarButton = new Button();
            RegistarEntregaButton = new Button();
            NumeroGuiaTextbox = new TextBox();
            NumeroGuiaLabel = new Label();
            DniLabel = new Label();
            DniTextBox = new TextBox();
            DatosRetiranteGroupBox = new GroupBox();
            EstadoActualLabel = new Label();
            EstadoActualTextBox = new TextBox();
            DatosRetiranteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(218, 290);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(134, 30);
            CancelarButton.TabIndex = 39;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(78, 290);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(134, 30);
            RegistarEntregaButton.TabIndex = 38;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // NumeroGuiaTextbox
            // 
            NumeroGuiaTextbox.Font = new Font("Segoe UI", 8F);
            NumeroGuiaTextbox.Location = new Point(26, 50);
            NumeroGuiaTextbox.Name = "NumeroGuiaTextbox";
            NumeroGuiaTextbox.Size = new Size(309, 25);
            NumeroGuiaTextbox.TabIndex = 27;
            // 
            // NumeroGuiaLabel
            // 
            NumeroGuiaLabel.AutoSize = true;
            NumeroGuiaLabel.Font = new Font("Segoe UI", 12F);
            NumeroGuiaLabel.Location = new Point(26, 19);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(154, 28);
            NumeroGuiaLabel.TabIndex = 26;
            NumeroGuiaLabel.Text = "Número de guía";
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Font = new Font("Segoe UI", 8F);
            DniLabel.Location = new Point(8, 32);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(33, 19);
            DniLabel.TabIndex = 46;
            DniLabel.Text = "DNI";
            // 
            // DniTextBox
            // 
            DniTextBox.Font = new Font("Segoe UI", 8F);
            DniTextBox.Location = new Point(114, 32);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.ReadOnly = true;
            DniTextBox.Size = new Size(197, 25);
            DniTextBox.TabIndex = 47;
            // 
            // DatosRetiranteGroupBox
            // 
            DatosRetiranteGroupBox.Controls.Add(DniTextBox);
            DatosRetiranteGroupBox.Controls.Add(DniLabel);
            DatosRetiranteGroupBox.Font = new Font("Segoe UI", 10F);
            DatosRetiranteGroupBox.Location = new Point(26, 183);
            DatosRetiranteGroupBox.Name = "DatosRetiranteGroupBox";
            DatosRetiranteGroupBox.Size = new Size(326, 65);
            DatosRetiranteGroupBox.TabIndex = 49;
            DatosRetiranteGroupBox.TabStop = false;
            DatosRetiranteGroupBox.Text = "Datos del retirante";
            // 
            // EstadoActualLabel
            // 
            EstadoActualLabel.AutoSize = true;
            EstadoActualLabel.Font = new Font("Segoe UI", 12F);
            EstadoActualLabel.Location = new Point(26, 98);
            EstadoActualLabel.Name = "EstadoActualLabel";
            EstadoActualLabel.Size = new Size(128, 28);
            EstadoActualLabel.TabIndex = 42;
            EstadoActualLabel.Text = "Estado actual";
            // 
            // EstadoActualTextBox
            // 
            EstadoActualTextBox.Font = new Font("Segoe UI", 8F);
            EstadoActualTextBox.Location = new Point(26, 129);
            EstadoActualTextBox.Name = "EstadoActualTextBox";
            EstadoActualTextBox.ReadOnly = true;
            EstadoActualTextBox.Size = new Size(309, 25);
            EstadoActualTextBox.TabIndex = 50;
            // 
            // RegEntregaCDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 322);
            Controls.Add(EstadoActualTextBox);
            Controls.Add(DatosRetiranteGroupBox);
            Controls.Add(EstadoActualLabel);
            Controls.Add(CancelarButton);
            Controls.Add(RegistarEntregaButton);
            Controls.Add(NumeroGuiaTextbox);
            Controls.Add(NumeroGuiaLabel);
            Name = "RegEntregaCDForm";
            Text = "Registrar entrega en CD";
            Load += RegEntregaCD_Load;
            DatosRetiranteGroupBox.ResumeLayout(false);
            DatosRetiranteGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EstEntregadoLabel;
        private Label EstEnCDLabel;
        private Label EstEnCaminoCDLabel;
        private Button CancelarButton;
        private Button RegistarEntregaButton;
        private TextBox MailRetiranteTextbox;
        private TextBox TelefonoRetiranteTextbox;
        private TextBox NomApRetiranteTextbox;
        private Label MailRetiranteLabel;
        private TextBox NumeroGuiaTextbox;
        private Label NumeroGuiaLabel;
        private Label DniLabel;
        private TextBox DniTextBox;
        private GroupBox DatosRetiranteGroupBox;
        private Label EstadoActualLabel;
        private TextBox EstadoActualTextBox;
    }
}