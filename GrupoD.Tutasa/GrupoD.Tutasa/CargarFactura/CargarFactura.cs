using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrupoD.Tutasa.CargarFactura
{
    public partial class CargarFactura : Form

    {
        internal CargarFacturaModelo.CargarFacturaModelo modelo = new CargarFacturaModelo.CargarFacturaModelo().Ejemplo();
        public CargarFactura()
        {
            InitializeComponent();
        }
        private void btnGrabarFactura_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
            NumFacturaTextBox.Text = modelo.NumeroFactura.ToString();
            FechaFacturaDtp.Text = DateTime.Now.ToShortDateString();
            FechaVencimientoDtp.Text = DateTime.Now.AddDays(30).ToShortDateString();
            //Cargar las encomiendas en el ListView
            ItemsFacturaListView.Items.Clear();
            foreach (var encomienda in cliente.Factura.Encomiendas)
            {
                //Simulación de la obtención de datos desde una base de datos o servicio     
                    var listItem = new ListViewItem(encomienda.Cantidad.ToString());
                    listItem.SubItems.Add(encomienda.Descripcion);
                    listItem.SubItems.Add(encomienda.Precio.ToString());
                    listItem.SubItems.Add((encomienda.Precio * 1.21m).ToString());

                    ItemsFacturaListView.Items.Add(listItem);
                
                //ItemsFacturaListView.Items.Add(encomienda.Cantidad.ToString(), encomienda.Descripcion, encomienda.Precio.ToString(), (encomienda.Precio*1.21m).ToString());
            }
        }       
    }
}
