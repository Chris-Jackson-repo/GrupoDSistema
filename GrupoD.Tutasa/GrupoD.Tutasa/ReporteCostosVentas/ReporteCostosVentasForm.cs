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

            var Cuit = SeleccioneNúmeroCuitComboBox.SelectedItem.ToString();
            







        }

    }
}
