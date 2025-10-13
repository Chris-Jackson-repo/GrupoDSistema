using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Tutasa.RendirHojaDeRuta
{
    public partial class RendirHojaDeRutaForm : Form
    {
        public RendirHojaDeRutaModelo modelo = new();


        public RendirHojaDeRutaForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DNIFleteroTextBox.Text, out var dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error");
                return;
            }

            // Le pido al modelo las guias a rendir (DNI)
            var guiasRendicion = modelo.ObtenerGuiasARendir(dni);

            //Ya se mostró el error y se cancela
            if (guiasRendicion == null)
            {
                return;
            }

            GuiasARendirListView.Items.Clear();

            //Simulación de la obtención de datos desde una base de datos o servicio

            foreach (var guia in guiasRendicion)
            {
                var listItem = new ListViewItem(guia.Guia);
                listItem.SubItems.Add(guia.Estado);
                listItem.SubItems.Add(guia.DireccionDeDestino);
                listItem.SubItems.Add(guia.Autorizado);
                listItem.SubItems.Add(guia.CUIT);
                listItem.SubItems.Add(guia.TipoPaquete);

                GuiasARendirListView.Items.Add(listItem);
            }

            // Ahora le pido al modelo las guias a realizar (DNI)

            var guiasARealizar = modelo.ObtenerGuiasARealizar(dni);

            GuiasARealizarListView.Items.Clear();

            //if (guiasARealizar == null)
            //{
            // return;
            //}

            foreach (var guiaRealizar in guiasARealizar)
            {
                var listItem = new ListViewItem(guiaRealizar.Guia);
                listItem.SubItems.Add(guiaRealizar.Estado);
                listItem.SubItems.Add(guiaRealizar.DireccionDeDestino);
                listItem.SubItems.Add(guiaRealizar.Autorizado);
                listItem.SubItems.Add(guiaRealizar.CUIT);
                listItem.SubItems.Add(guiaRealizar.TipoPaquete);

                GuiasARealizarListView.Items.Add(listItem);
            }




        }

        //Paso los cambios hechos en el formulario
        private void Confirmarbutton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DNIFleteroTextBox.Text, out var dni) || dni < 1_000_000 || dni > 99_999_999)
            {
                MessageBox.Show("Debe ingresar un DNI válido antes de confirmar.", "Error");
                return;
            }




            List<string> guiasCompletadas = new();

            foreach (ListViewItem item in GuiasARendirListView.CheckedItems)
            {
                if (item.Checked)
                {
                    guiasCompletadas.Add(item.Text);
                }
            }

            // if (guiasCompletadas.Count == 0)   //Claro...puede ser una devolución y no se indica como cumplida
            //  {
            //     MessageBox.Show("Debe seleccionar al menos una guía para rendir.", "Error");
            //  return;
            // }


            modelo.AceptarYCambiarEstado(guiasCompletadas);

            //Si está mal...
            string error = modelo.AceptarYCambiarEstado(guiasCompletadas);

            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }

            //Si está bien

            GuiasARendirListView.Items.Clear();
            GuiasARealizarListView.Items.Clear();
            DNIFleteroTextBox.Text = "";
            MessageBox.Show("Rendición realizada con éxito", "Éxito");



        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //private void label3_Click(object sender, EventArgs e)
        //{

        //}
    }
}
