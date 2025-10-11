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
            NumeroGuiaLabel.Location = new Point(21, 9);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(154, 28);
            NumeroGuiaLabel.TabIndex = 0;
            NumeroGuiaLabel.Text = "Número de guía";
            NumeroGuiaLabel.Click += label1_Click;
            // 
            // NumeroGuiaTextbox
            // 
            NumeroGuiaTextbox.Font = new Font("Segoe UI", 8F);
            NumeroGuiaTextbox.Location = new Point(21, 40);
            NumeroGuiaTextbox.Name = "NumeroGuiaTextbox";
            NumeroGuiaTextbox.Size = new Size(309, 25);
            NumeroGuiaTextbox.TabIndex = 1;
            NumeroGuiaTextbox.TextChanged += NumeroGuiaTextbox_TextChanged;
            // 
            // RegistarEntregaButton
            // 
            RegistarEntregaButton.Location = new Point(56, 279);
            RegistarEntregaButton.Name = "RegistarEntregaButton";
            RegistarEntregaButton.Size = new Size(134, 30);
            RegistarEntregaButton.TabIndex = 18;
            RegistarEntregaButton.Text = "Registar Entrega";
            RegistarEntregaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(196, 279);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(134, 30);
            CancelarButton.TabIndex = 19;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EstadoActualLabel
            // 
            EstadoActualLabel.AutoSize = true;
            EstadoActualLabel.Font = new Font("Segoe UI", 12F);
            EstadoActualLabel.Location = new Point(21, 86);
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
            DniTextBox.Location = new Point(99, 32);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.ReadOnly = true;
            DniTextBox.Size = new Size(209, 25);
            DniTextBox.TabIndex = 27;
            // 
            // DatosRetiranteGroupBox
            // 
            DatosRetiranteGroupBox.Controls.Add(DniTextBox);
            DatosRetiranteGroupBox.Controls.Add(DniLabel);
            DatosRetiranteGroupBox.Font = new Font("Segoe UI", 10F);
            DatosRetiranteGroupBox.Location = new Point(16, 171);
            DatosRetiranteGroupBox.Name = "DatosRetiranteGroupBox";
            DatosRetiranteGroupBox.Size = new Size(314, 76);
            DatosRetiranteGroupBox.TabIndex = 28;
            DatosRetiranteGroupBox.TabStop = false;
            DatosRetiranteGroupBox.Text = "Datos del retirante";
            // 
            // EstadoActualTextBox
            // 
            EstadoActualTextBox.Font = new Font("Segoe UI", 8F);
            EstadoActualTextBox.Location = new Point(21, 117);
            EstadoActualTextBox.Name = "EstadoActualTextBox";
            EstadoActualTextBox.ReadOnly = true;
            EstadoActualTextBox.Size = new Size(309, 25);
            EstadoActualTextBox.TabIndex = 30;
            // 
            // RegEntregaAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 311);
            Controls.Add(EstadoActualTextBox);
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
