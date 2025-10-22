using GrupoD.Tutasa.RegEntregaAgencia;
using System.Reflection;

namespace GrupoD.Tutasa.RegEntregaAgencia
{
    public partial class RegEntregaAgenciaForm : Form
    {
        internal RegEntregaAgenciaModelo modelo = new RegEntregaAgenciaModelo().Ejemplo();
        public RegEntregaAgenciaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumeroGuiaTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstadoActualCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void EstadoActLabel_Click(object sender, EventArgs e)
        {

        }

        private void MailRetiranteLabel_Click(object sender, EventArgs e)
        {

        }

        private void TelefonoRetiranteLabel_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButtonClick(object sender, EventArgs e)
        {
            // Validar que no esta vacío
            if (string.IsNullOrWhiteSpace(NumeroGuiaTextbox.Text))
            {
                MessageBox.Show("El número de guía no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea numérico
            if (!int.TryParse(NumeroGuiaTextbox.Text, out var numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que exista la guía
            var estadoActual = modelo.ObtenerEstadoActual(numeroGuia);

            //Ya se mostró el error y se cancela
            if (estadoActual == null)
            {
                return;
            }
            EstadoActualTextBox.Text = estadoActual.Estado;
            DniTextBox.Text = estadoActual.Dni.ToString();
        }

        private void LimpiarButtonClick(object sender, EventArgs e)
        {
            NumeroGuiaTextbox.Clear();
            DniTextBox.Clear();
            EstadoActualTextBox.Clear();
        }

        private void RegistrarEntregaButtonClick(object sender, EventArgs e)
        {
            // Validar que no esta vacío
            if (string.IsNullOrWhiteSpace(NumeroGuiaTextbox.Text))
            {
                MessageBox.Show("El número de guía no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea numérico
            if (!int.TryParse(NumeroGuiaTextbox.Text, out var numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que se haya buscado la guía
            if (string.IsNullOrWhiteSpace(DniTextBox.Text))
            {
                MessageBox.Show("Por favor, primero busque el número de guía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que exista la guía
            var estadoActual = modelo.ObtenerEstadoActual(numeroGuia);

            //Ya se mostró el error y se cancela
            if (estadoActual == null)
            {
                return;
            }
            // Actualizar el estado de la guía a "Entregado"
            modelo.ActualizarEstado(numeroGuia, "Entregado");
            MessageBox.Show("La entrega ha sido registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
