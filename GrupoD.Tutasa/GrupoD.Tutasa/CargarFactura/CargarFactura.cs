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
        // Esta es la "caja" que contendrá los items de la factura actual.
        private List<Producto> miListaDeProductos = new List<Producto>();

        // --- AÑADE ESTA LÍNEA AQUÍ ---
        private int proximoNumeroFactura = 1; // La primera factura será la número 1
        public CargarFactura()
        {
            InitializeComponent();
        }
        // --- 1. SE EJECUTA AL ABRIR EL FORMULARIO ---
        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarEmpresas();
        }

        // --- 2. SE EJECUTA AL SELECCIONAR UNA EMPRESA ---
        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedItem == null || cmbEmpresa.SelectedIndex == 0)
            {
                // Limpiamos si el usuario selecciona "Seleccione una empresa..."
                miListaDeProductos.Clear();
            }
            else
            {
                string empresaSeleccionada = cmbEmpresa.SelectedItem.ToString();
                // Buscamos los productos para la empresa y los cargamos en nuestra lista
                miListaDeProductos = ObtenerProductosPorEmpresa(empresaSeleccionada);
            }

            // ¡NUEVO! Método específico para llenar el ListView
            ActualizarListView();
            CalcularTotales();
        }

        // --- 3. LÓGICA DE LOS BOTONES ---
        private void btnGrabarFactura_Click(object sender, EventArgs e)
        {
            // --- VALIDACIÓN AÑADIDA ---
            // Verificamos si la selección es la primera opción ("Seleccione una empresa...") o si no hay nada seleccionado.
            if (cmbEmpresa.SelectedIndex <= 0)
            {
                MessageBox.Show("NO SELECCIONÓ LA EMPRESA", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución del método aquí.
            }
            // AQUÍ IRÍA EL CÓDIGO PARA GUARDAR 'miListaDeProductos' Y LOS DATOS EN LA BASE DE DATOS

            MessageBox.Show("FACTURA GRABADA CORRECTAMENTE", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            proximoNumeroFactura++;
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- 4. MÉTODOS AYUDANTES ---

        private void LimpiarFormulario()
        {
            AsignarSiguienteNumeroFactura();
            dtpFechaFactura.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now;

            // Limpiamos la lista de productos y la tabla
            miListaDeProductos.Clear();
            lsvItemsFactura.Items.Clear(); // ¡MODIFICADO! Así se limpia un ListView

            CalcularTotales();

            if (cmbEmpresa.Items.Count > 0)
            {
                cmbEmpresa.SelectedIndex = 0;
            }
            cmbEmpresa.Focus();
        }

        private void ActualizarListView()
        {
            lsvItemsFactura.Items.Clear(); // Primero, vaciamos la lista visual

            foreach (var producto in miListaDeProductos)
            {
                // Creamos una nueva fila (ListViewItem)
                ListViewItem fila = new ListViewItem(producto.Cantidad.ToString());

                // Añadimos las otras columnas (sub-items)
                fila.SubItems.Add(producto.Descripcion);
                fila.SubItems.Add(producto.PrecioUnitario.ToString("C")); // Con formato de moneda
                fila.SubItems.Add(producto.Total.ToString("C")); // Con formato de moneda

                // Añadimos la fila completa al ListView
                lsvItemsFactura.Items.Add(fila);
            }
        }

        private void CalcularTotales()
        {
            decimal totalFactura = miListaDeProductos.Sum(p => p.Total);
            decimal totalConIva = totalFactura * 1.21m;

            txtTotalFactura.Text = totalFactura.ToString("C");
            txtTotalConIva.Text = totalConIva.ToString("C");
        }

        private void CargarEmpresas()
        {
            // **SIMULACIÓN**: Datos de tu base de datos
            cmbEmpresa.Items.Add("Seleccione una empresa...");
            cmbEmpresa.Items.Add("Empresa A");
            cmbEmpresa.Items.Add("Empresa B");
            cmbEmpresa.SelectedIndex = 0;
        }

        private void AsignarSiguienteNumeroFactura()
        {
            txtNumeroFactura.Text = proximoNumeroFactura.ToString();
        }

        private List<Producto> ObtenerProductosPorEmpresa(string nombreEmpresa)
        {
            // **SIMULACIÓN**: Consulta a tu base de datos
            List<Producto> productos = new List<Producto>();

            if (nombreEmpresa == "Empresa A")
            {
                productos.Add(new Producto { Cantidad = 1, Descripcion = "Servicio de Consultoría", PrecioUnitario = 1500 });
                productos.Add(new Producto { Cantidad = 10, Descripcion = "Soporte Técnico (horas)", PrecioUnitario = 75 });
            }
            else if (nombreEmpresa == "Empresa B")
            {
                productos.Add(new Producto { Cantidad = 1, Descripcion = "Licencia de Software Anual", PrecioUnitario = 3200 });
            }

            return productos;
        }
}
    // --- 5. EL "MOLDE" PARA CADA ÍTEM DE LA FACTURA ---
    public class Producto
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get { return Cantidad * PrecioUnitario; } }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CargarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
