using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

            //if (guiasADescargar == null)
           // {
           //     MessageBox.Show("No se encontraron guías para la patente ingresada.", "Información");
           //     GuiasDescargaListView.Items.Clear();
           //     return;
           // }

            GuiasDescargaListView.Items.Clear();

            foreach (var guia in guiasADescargar)
            {
                var listItem = new ListViewItem(guia.Guia);
                listItem.SubItems.Add(guia.CDOrigen);
                listItem.SubItems.Add(guia.DireccionDeDestino);
                listItem.SubItems.Add(guia.TipoPaquete);
               

                GuiasDescargaListView.Items.Add(listItem);
            }

            var guiasACargar = modelo.ObtenerGuiasACargarPorPatente(patente);

            GuiasCargaListView.Items.Clear();

            foreach (var guia in guiasACargar)
            {
                var listItem = new ListViewItem(guia.Guia);
                listItem.SubItems.Add(guia.CDDestino);
                listItem.SubItems.Add(guia.DireccionDeDestino);
                listItem.SubItems.Add(guia.TipoPaquete);
                

                GuiasCargaListView.Items.Add(listItem);
            }

           





        }

        private void Confirmarbutton_Click(object sender, EventArgs e)
        {

            if (PatenteTextBox.Text == "")
            {
                MessageBox.Show("Ingrese una patente antes de confirmar.", "Error");
                return;
            }

            List<string> guiasDescargadas = new();

            foreach (ListViewItem item in GuiasDescargaListView.Items)
            {
                if (item.Checked)
                    guiasDescargadas.Add(item.SubItems[0].Text);
            }

            List<string> guiasCargadas = new();

            foreach (ListViewItem item in GuiasCargaListView.Items)
            {
                if (item.Checked)
                    guiasCargadas.Add(item.SubItems[0].Text);
            }

           
            modelo.AceptarYCambiarEstado(guiasDescargadas);
            modelo.AceptarYCambiarEstado(guiasCargadas);
            string error = modelo.AceptarYCambiarEstado(guiasDescargadas);
           


            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }

            GuiasCargaListView.Items.Clear();
            GuiasDescargaListView.Items.Clear();
            PatenteTextBox.Text = "";
            MessageBox.Show("Operación realizada con éxito.", "Éxito");



        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
