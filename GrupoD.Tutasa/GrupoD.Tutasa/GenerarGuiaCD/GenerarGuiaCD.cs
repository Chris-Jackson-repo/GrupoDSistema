using GrupoD.Tutasa.RendirHojaDeRuta;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrupoD.Tutasa.GenerarGuiaCD
{
    public partial class GenerarGuiaCDForm : Form
    {
        private GenerarGuiaCDModelo modelo = new();
        public GenerarGuiaCDForm()
        {
            InitializeComponent();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImposicionForm_Load(object sender, EventArgs e)
        {
            //Agregar las opciones a ProvinciaComboBox
            ProvinciaComboBox.Items.Add("Buenos Aires");
            ProvinciaComboBox.Items.Add("Catamarca");
            ProvinciaComboBox.Items.Add("Chaco");
            ProvinciaComboBox.Items.Add("Chubut");
            ProvinciaComboBox.Items.Add("Ciudad Autónoma de Buenos Aires");
            ProvinciaComboBox.Items.Add("Córdoba");
            ProvinciaComboBox.Items.Add("Corrientes");
            ProvinciaComboBox.Items.Add("Entre Ríos");
            ProvinciaComboBox.Items.Add("Formosa");
            ProvinciaComboBox.Items.Add("Jujuy");
            ProvinciaComboBox.Items.Add("La Pampa");
            ProvinciaComboBox.Items.Add("La Rioja");
            ProvinciaComboBox.Items.Add("Mendoza");
            ProvinciaComboBox.Items.Add("Misiones");
            ProvinciaComboBox.Items.Add("Neuquén");
            ProvinciaComboBox.Items.Add("Río Negro");
            ProvinciaComboBox.Items.Add("Salta");
            ProvinciaComboBox.Items.Add("San Juan");
            ProvinciaComboBox.Items.Add("San Luis");
            ProvinciaComboBox.Items.Add("Santa Cruz");
            ProvinciaComboBox.Items.Add("Santa Fe");
            ProvinciaComboBox.Items.Add("Santiago del Estero");
            ProvinciaComboBox.Items.Add("Tierra del Fuego");
            ProvinciaComboBox.Items.Add("Tucumán");




            //Agregar las opciones tamaños a TamañoEncomiendaComboBox

            TamañoComboBox.Items.Add("S");
            TamañoComboBox.Items.Add("M");
            TamañoComboBox.Items.Add("L");
            TamañoComboBox.Items.Add("XL");


            //Agregar las opciones tamaños a Tipo de Entrega ComboBox
            TipoEntregaComboBox.Items.Add("A Domicilio");
            TipoEntregaComboBox.Items.Add("Centro de Distribución");
            TipoEntregaComboBox.Items.Add("Agencia");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void CuitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
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






        }

        private void CiudadDestinatarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPDestinatarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void CPDestinatarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Este código evita que el usuario escriba letras, signos o espacios,
            //y además muestra un mensaje solo una vez si intenta hacerlo

            // Permitir solo números y la tecla de borrado
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela el ingreso del carácter
                MessageBox.Show("El Código Postal debe contener solo números.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }*/

        /*private void DniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que sea numérico y no tenga decimales
            if (!long.TryParse (DniTextBox.Text, out long dni))
            {
                MessageBox.Show("El DNI debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }
        }*/

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            //Validar que no esté vacío el campo Ciudad 
            if (string.IsNullOrWhiteSpace(CiudadDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo Ciudad no debe estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que no esté vacío el campo Dirección 
            if (string.IsNullOrWhiteSpace(DirecDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo Dirección no debe estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar que no esté vacío el campo CódigoPostal 
            if (string.IsNullOrWhiteSpace(CPDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo Código Postal no debe estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Verificar que Código Postal sea numérico y no tenga decimales
            if (!int.TryParse(CPDestinatarioTextBox.Text, out int cpDestinatario))
            {
                MessageBox.Show("El Código Postal debe contener sólo números, sin decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }


            //Validar que no esté vacío el campo DNI
            if (string.IsNullOrWhiteSpace(DniTextBox.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Verificar que DNI sea numérico y no tenga decimales
            if (!long.TryParse(DniTextBox.Text, out long dni))
            {
                MessageBox.Show("El DNI debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }

            //Validar que no esté vacío el campo Nombre
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MessageBox.Show("El campo Nombre no debe estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar que no esté vacío el campo Apellido
            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que no quede sin elegir opcion en el ComboBox Provincia
            if (ProvinciaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una provincia de la lista", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProvinciaComboBox.Focus();
                return;
            }

            // Validar que no quede sin elegir opcion en el ComboBox de tamaño de Encomienda
            if (TamañoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tamaño de encomienda.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TamañoComboBox.Focus();
                return;
            }



            // Validar que no quede sin elegir opcion en el ComboBox de tipo de entrega
            if (TipoEntregaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TipoEntregaComboBox.Focus(); // Vuelve a enfocar el control
                return;
            }

            



            /* var nuevoDestinatario = new Destinatario
             {

                 DniDesti = dniDesti,
                 Nombre = nombre,
                 Apellido = apellido,
                 Provincia = provincia,
                 Ciudad = ciudad,
                 Direccion = direccion,
                 CodigoPostal = codigoPostal
             };*/

            // modelo.ValidarDestinatario(nuevoDestinatario);




        }

        private void TamañoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
            
          
    }
}
