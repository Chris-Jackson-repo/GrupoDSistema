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
            RegistarEntregaButton = new Button();
            CancelarButton = new Button();
            EstadoActualLabel = new Label();
            DniLabel = new Label();
            DniTextBox = new TextBox();
            DatosRetiranteGroupBox = new GroupBox();
            EstadoActualTextBox = new TextBox();
            DatosRetiranteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NumeroGuiaLabel
            // 
            NumeroGuiaLabel.AutoSize = true;
            NumeroGuiaLabel.Font = new Font("Segoe UI", 12F);
            NumeroGuiaLabel.Location = new Point(34, 15);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(123, 21);
            NumeroGuiaLabel.TabIndex = 0;
            NumeroGuiaLabel.Text = "Número de guía";
            NumeroGuiaLabel.Click += label1_Click;
            // 
            // NumeroGuiaTextbox
            // 
            NumeroGuiaTextbox.Font = new Font("Segoe UI", 8F);
            NumeroGuiaTextbox.Location = new Point(34, 38);
            NumeroGuiaTextbox.Margin = new Padding(3, 2, 3, 2);
            NumeroGuiaTextbox.Name = "NumeroGuiaTextbox";
            NumeroGuiaTextbox.Size = new Size(271, 22);
            NumeroGuiaTextbox.TabIndex = 1;
            NumeroGuiaTextbox.TextChanged += NumeroGuiaTextbox_TextChanged;
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(87, 221);
            RegistarEntregaButton.Margin = new Padding(3, 2, 3, 2);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(117, 22);
            RegistarEntregaButton.TabIndex = 18;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(220, 279);
            CancelarButton.Margin = new Padding(3, 2, 3, 2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(117, 22);
            CancelarButton.TabIndex = 19;
            CancelarButton.Text = "VOLVER";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EstadoActualLabel
            // 
            EstadoActualLabel.AutoSize = true;
            EstadoActualLabel.Font = new Font("Segoe UI", 12F);
            EstadoActualLabel.Location = new Point(34, 72);
            EstadoActualLabel.Name = "EstadoActualLabel";
            EstadoActualLabel.Size = new Size(101, 21);
            EstadoActualLabel.TabIndex = 22;
            EstadoActualLabel.Text = "Estado actual";
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Font = new Font("Segoe UI", 8F);
            DniLabel.Location = new Point(9, 26);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(26, 13);
            DniLabel.TabIndex = 26;
            DniLabel.Text = "DNI";
            // 
            // DniTextBox
            // 
            DniTextBox.Font = new Font("Segoe UI", 8F);
            DniTextBox.Location = new Point(106, 26);
            DniTextBox.Margin = new Padding(3, 2, 3, 2);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.ReadOnly = true;
            DniTextBox.Size = new Size(183, 22);
            DniTextBox.TabIndex = 27;
            // 
            // DatosRetiranteGroupBox
            // 
            DatosRetiranteGroupBox.Controls.Add(DniTextBox);
            DatosRetiranteGroupBox.Controls.Add(DniLabel);
            DatosRetiranteGroupBox.Font = new Font("Segoe UI", 10F);
            DatosRetiranteGroupBox.Location = new Point(30, 136);
            DatosRetiranteGroupBox.Margin = new Padding(3, 2, 3, 2);
            DatosRetiranteGroupBox.Name = "DatosRetiranteGroupBox";
            DatosRetiranteGroupBox.Padding = new Padding(3, 2, 3, 2);
            DatosRetiranteGroupBox.Size = new Size(275, 57);
            DatosRetiranteGroupBox.TabIndex = 28;
            DatosRetiranteGroupBox.TabStop = false;
            DatosRetiranteGroupBox.Text = "Datos del retirante";
            // 
            // EstadoActualTextBox
            // 
            EstadoActualTextBox.Font = new Font("Segoe UI", 8F);
            EstadoActualTextBox.Location = new Point(34, 96);
            EstadoActualTextBox.Margin = new Padding(3, 2, 3, 2);
            EstadoActualTextBox.Name = "EstadoActualTextBox";
            EstadoActualTextBox.ReadOnly = true;
            EstadoActualTextBox.Size = new Size(271, 22);
            EstadoActualTextBox.TabIndex = 30;
            // 
            // RegEntregaAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 334);
            Controls.Add(EstadoActualTextBox);
            Controls.Add(DatosRetiranteGroupBox);
            Controls.Add(EstadoActualLabel);
            Controls.Add(CancelarButton);
            Controls.Add(RegistarEntregaButton);
            Controls.Add(NumeroGuiaTextbox);
            Controls.Add(NumeroGuiaLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegEntregaAgenciaForm";
            Text = "Registrar entrega en agencia";
            DatosRetiranteGroupBox.ResumeLayout(false);
            DatosRetiranteGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumeroGuiaLabel;
        private TextBox NumeroGuiaTextbox;
        private Button RegistarEntregaButton;
        private Button CancelarButton;
        private Label EstadoActualLabel;
        private Label DniLabel;
        private TextBox DniTextBox;
        private GroupBox DatosRetiranteGroupBox;
        private TextBox EstadoActualTextBox;
    }
}
