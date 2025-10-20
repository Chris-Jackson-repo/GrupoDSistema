using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Tutasa.DespachanteOmnibus
{
    public partial class DespachanteForm : Form
    {

        public DespachanteModelo modelo = new();



        public DespachanteForm()
        {
            InitializeComponent();
        }

        private void BuscarPatentebutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PatenteTextBox.Text))
            {
                MessageBox.Show("La patente no puede estar vacía.", "Error");
                return;
            }
            var patente = PatenteTextBox.Text.Trim();

            var guiasADescargar = modelo.ObtenerGuiasADescargarPorPatente(patente);

            if(guiasADescargar == null)
            {
                MessageBox.Show("No se encontraron guías para la patente ingresada.", "Información");
                GuiasDescargaListView.Items.Clear();    
                return;
            }

            GuiasDescargaListView.Items.Clear();

            foreach (var guia in guiasADescargar)
            {
                var listItem = new ListViewItem(guia.Guia);
                listItem.SubItems.Add(guia.CDOrigen);
                listItem.SubItems.Add(guia.DireccionDeDestino);
                listItem.SubItems.Add(guia.TipoPaquete);
                listItem.SubItems.Add(guia.Estado);

                GuiasDescargaListView.Items.Add(listItem);
            }

            var guiasACargar = modelo.ObtenerGuiasACargarPorPatente(patente);

            GuiasCargaListView.Items.Clear();

            foreach (var guia in guiasACargar)
            {
                var listItem = new ListViewItem(guia.Guia);
                listItem.SubItems.Add(guia.CDOrigen);
                listItem.SubItems.Add(guia.DireccionDeDestino);
                listItem.SubItems.Add(guia.TipoPaquete);
                listItem.SubItems.Add(guia.Estado);

                GuiasCargaListView.Items.Add(listItem);
            }
        }
    }
}
