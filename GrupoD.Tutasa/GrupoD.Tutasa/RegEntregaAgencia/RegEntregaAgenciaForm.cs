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
            // Validar que no esta vac�o
            if (string.IsNullOrWhiteSpace(NumeroGuiaTextbox.Text))
            {
                MessageBox.Show("El n�mero de gu�a no puede estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea num�rico
            if (!int.TryParse(NumeroGuiaTextbox.Text, out var numeroGuia))
            {
                MessageBox.Show("El n�mero de gu�a debe ser num�rico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que exista la gu�a
            var estadoActual = modelo.ObtenerEstadoActual(numeroGuia);

            //Ya se mostr� el error y se cancela
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
            // Validar que no esta vac�o
            if (string.IsNullOrWhiteSpace(NumeroGuiaTextbox.Text))
            {
                MessageBox.Show("El n�mero de gu�a no puede estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que sea num�rico
            if (!int.TryParse(NumeroGuiaTextbox.Text, out var numeroGuia))
            {
                MessageBox.Show("El n�mero de gu�a debe ser num�rico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que se haya buscado la gu�a
            if (string.IsNullOrWhiteSpace(DniTextBox.Text))
            {
                MessageBox.Show("Por favor, primero busque el n�mero de gu�a.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que exista la gu�a
            var estadoActual = modelo.ObtenerEstadoActual(numeroGuia);

            //Ya se mostr� el error y se cancela
            if (estadoActual == null)
            {
                return;
            }
            // Actualizar el estado de la gu�a a "Entregado"
            modelo.ActualizarEstado(numeroGuia, "Entregado");
            MessageBox.Show("La entrega ha sido registrada con �xito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
