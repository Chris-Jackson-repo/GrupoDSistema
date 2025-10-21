using GrupoD.Tutasa.DespachanteOmnibus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Tutasa.ReporteCostosVentas
{
    public partial class ReporteDeCostosvsVenta : Form
    {

        public ReporteCostosVentasModelo modelo = new();


        public ReporteDeCostosvsVenta()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Poblar ComboBox con los CUITs del modelo
            SeleccioneNúmeroCuitComboBox.Items.Clear();
            if (modelo?.CUITEmpresas != null && modelo.CUITEmpresas.Length > 0)
            {
                foreach (var cuit in modelo.CUITEmpresas)
                {
                    SeleccioneNúmeroCuitComboBox.Items.Add(cuit.ToString());
                }

                // Forzar estilo sólo selección (opcional)
                SeleccioneNúmeroCuitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                // Asegurar que no haya ningún elemento seleccionado y que el texto esté vacío
                SeleccioneNúmeroCuitComboBox.SelectedIndex = -1;
                SeleccioneNúmeroCuitComboBox.Text = string.Empty;
            }
        }

        private void DetalleOpcional_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpresaTransporte_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (SeleccioneNúmeroCuitComboBox.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un número de CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación: fecha 'Desde' no mayor que fecha 'Hasta'
            if (DesdedateTimePicker.Value.Date >= HastadateTimePicker.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DesdedateTimePicker.Focus();
                return;
            }

            // Parsear CUIT seleccionado
            if (!long.TryParse(SeleccioneNúmeroCuitComboBox.SelectedItem.ToString(), out var cuitSeleccionado))
            {
                MessageBox.Show("CUIT inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pedir al modelo las filas para el CUIT y rango de fechas
            var desde = DesdedateTimePicker.Value.Date;
            var hasta = HastadateTimePicker.Value.Date;
            var filas = modelo.GetDatosPorCUIT(cuitSeleccionado, desde, hasta);

            // Poblar el ListView (columnas: Empresa, Costo, Venta, Resultado)
            listView1.BeginUpdate();
            listView1.Items.Clear();

            if (filas == null || filas.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para el CUIT y rango seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var fila in filas)
                {
                    var items = new string[]
                    {
                        fila.Empresa,
                        fila.Costo.ToString("C2"),
                        fila.Venta.ToString("C2"),
                        fila.Resultado.ToString("C2")
                    };
                    var lvi = new ListViewItem(items);
                    listView1.Items.Add(lvi);
                }

                // Ajustar ancho de columnas al contenido
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            listView1.EndUpdate();
        }

        private void SeleccioneNúmeroCuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}