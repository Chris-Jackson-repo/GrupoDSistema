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
            SeleccioneNumeroCuitComboBox.Items.Clear();
            if (modelo?.CUITEmpresas != null && modelo.CUITEmpresas.Length > 0)
            {
                foreach (var cuit in modelo.CUITEmpresas)
                {
                    SeleccioneNumeroCuitComboBox.Items.Add(cuit.ToString());
                }

                // Forzar estilo sólo selección (opcional)
                SeleccioneNumeroCuitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                // Asegurar que no haya ningún elemento seleccionado y que el texto esté vacío
                SeleccioneNumeroCuitComboBox.SelectedIndex = -1;
                SeleccioneNumeroCuitComboBox.Text = string.Empty;
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
            if (SeleccioneNumeroCuitComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un CUIT.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SeleccioneNumeroCuitComboBox.Focus();
                return;
            }

            if (!long.TryParse(SeleccioneNumeroCuitComboBox.SelectedItem.ToString(), out var cuit))
            {
                MessageBox.Show("El valor seleccionado no es un DNI válido.", "Error");
                return;
            }

            var desde = DesdedateTimePicker.Value.Date;
            var hasta = HastadateTimePicker.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DesdedateTimePicker.Focus();
                return;
            }

            var resultados = modelo.ObtenerResultadosParaCUITYFechas(cuit, desde, hasta);

            ReporteCostosVentaslistView.Items.Clear();

            if (resultados == null || resultados.Count == 0)
            {
                MessageBox.Show("No hay datos entre las fechas seleccionadas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var resultado in resultados)
            {
                var listItem = new ListViewItem(resultado.empresa.ToString());
                listItem.SubItems.Add(resultado.costo.ToString());
                listItem.SubItems.Add(resultado.ventas.ToString());
                listItem.SubItems.Add(resultado.resultado.ToString());


                ReporteCostosVentaslistView.Items.Add(listItem);
            }
        }

        private void SeleccioneNúmeroCuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
