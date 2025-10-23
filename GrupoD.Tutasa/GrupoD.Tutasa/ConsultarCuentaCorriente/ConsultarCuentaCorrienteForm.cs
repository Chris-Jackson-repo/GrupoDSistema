using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Tutasa.ConsultarCuentaCorriente
{
    public partial class ConsultarCuentaCorrienteForm : Form
    {
        internal ConsultarCuentaCorrienteModelo modelo = new ConsultarCuentaCorrienteModelo().Ejemplo();
        public ConsultarCuentaCorrienteForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButtonClick(object sender, EventArgs e)
        {
            //Validar que no esté vacío el campo CUIT 
            if (string.IsNullOrWhiteSpace(CuitTextBox.Text))
            {
                MessageBox.Show("El campo CUIT no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que se ingresó un numero en CUIT y que no es decimal
            if (!long.TryParse(CuitTextBox.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un número válido sin puntos, guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que el CUIT tenga 11 dígitos
            if (CuitTextBox.Text.Length != 11)
            {
                MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cliente cliente = modelo.ObtenerCliente(cuit);
            //Ya se mostró el error y se cancela
            if (cliente == null)
            {
                return;
            }
            CuitEmpresaTextBox.Text = cliente.CuitEmpresa.ToString();
            RazonSocialTextBox.Text = cliente.RazonSocial;
            DireccionTextBox.Text = cliente.Direccion;
            //Cargar las encomiendas en el ListView
            ItemsCompListView.Items.Clear();

            SaldoTextBox.Text = cliente.Comprobantes.Sum(comp => comp.Importe).ToString("F2");
            foreach (var comprobante in cliente.Comprobantes)
            {
                //Simulación de la obtención de datos desde una base de datos o servicio     
                var listItem = new ListViewItem(comprobante.Fecha.ToShortDateString());
                listItem.SubItems.Add(comprobante.DetalleComprobante);
                listItem.SubItems.Add(comprobante.Importe.ToString("F2"));
                listItem.SubItems.Add(comprobante.FechaVencimiento.ToShortDateString());
                ItemsCompListView.Items.Add(listItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelarButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
