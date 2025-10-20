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
            ProvinciaComboBox.Items.Add("Ciudad Aut�noma de Buenos Aires");
            ProvinciaComboBox.Items.Add("C�rdoba");
            ProvinciaComboBox.Items.Add("Corrientes");
            ProvinciaComboBox.Items.Add("Entre R�os");
            ProvinciaComboBox.Items.Add("Formosa");
            ProvinciaComboBox.Items.Add("Jujuy");
            ProvinciaComboBox.Items.Add("La Pampa");
            ProvinciaComboBox.Items.Add("La Rioja");
            ProvinciaComboBox.Items.Add("Mendoza");
            ProvinciaComboBox.Items.Add("Misiones");
            ProvinciaComboBox.Items.Add("Neuqu�n");
            ProvinciaComboBox.Items.Add("R�o Negro");
            ProvinciaComboBox.Items.Add("Salta");
            ProvinciaComboBox.Items.Add("San Juan");
            ProvinciaComboBox.Items.Add("San Luis");
            ProvinciaComboBox.Items.Add("Santa Cruz");
            ProvinciaComboBox.Items.Add("Santa Fe");
            ProvinciaComboBox.Items.Add("Santiago del Estero");
            ProvinciaComboBox.Items.Add("Tierra del Fuego");
            ProvinciaComboBox.Items.Add("Tucum�n");




            //Agregar las opciones tama�os a Tama�oEncomiendaComboBox

            Tama�oComboBox.Items.Add("S");
            Tama�oComboBox.Items.Add("M");
            Tama�oComboBox.Items.Add("L");
            Tama�oComboBox.Items.Add("XL");


            //Agregar las opciones tama�os a Tipo de Entrega ComboBox
            TipoEntregaComboBox.Items.Add("A Domicilio");
            TipoEntregaComboBox.Items.Add("Centro de Distribuci�n");
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
            //Validar que no est� vac�o el campo CUIT 
            if (string.IsNullOrWhiteSpace(CuitTextBox.Text))
            {
                MessageBox.Show("El campo CUIT no puede estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que se ingres� un numero en CUIT y que no es decimal
            if (!long.TryParse(CuitTextBox.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un n�mero v�lido sin puntos, guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Este c�digo evita que el usuario escriba letras, signos o espacios,
            //y adem�s muestra un mensaje solo una vez si intenta hacerlo

            // Permitir solo n�meros y la tecla de borrado
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela el ingreso del car�cter
                MessageBox.Show("El C�digo Postal debe contener solo n�meros.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }*/

        /*private void DniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que sea num�rico y no tenga decimales
            if (!long.TryParse (DniTextBox.Text, out long dni))
            {
                MessageBox.Show("El DNI debe ser un n�mero entero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }
        }*/

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            //Validar que no est� vac�o el campo Ciudad 
            if (string.IsNullOrWhiteSpace(CiudadDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo Ciudad no debe estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que no est� vac�o el campo Direcci�n 
            if (string.IsNullOrWhiteSpace(DirecDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo Direcci�n no debe estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar que no est� vac�o el campo C�digoPostal 
            if (string.IsNullOrWhiteSpace(CPDestinatarioTextBox.Text))
            {
                MessageBox.Show("El campo C�digo Postal no debe estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Verificar que C�digo Postal sea num�rico y no tenga decimales
            if (!int.TryParse(CPDestinatarioTextBox.Text, out int cpDestinatario))
            {
                MessageBox.Show("El C�digo Postal debe contener s�lo n�meros, sin decimales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }


            //Validar que no est� vac�o el campo DNI
            if (string.IsNullOrWhiteSpace(DniTextBox.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Verificar que DNI sea num�rico y no tenga decimales
            if (!long.TryParse(DniTextBox.Text, out long dni))
            {
                MessageBox.Show("El DNI debe ser un n�mero entero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTextBox.Focus();
                return;
            }

            //Validar que no est� vac�o el campo Nombre
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MessageBox.Show("El campo Nombre no debe estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar que no est� vac�o el campo Apellido
            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vac�o.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Validar que no quede sin elegir opcion en el ComboBox de tama�o de Encomienda
            if (Tama�oComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tama�o de encomienda.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tama�oComboBox.Focus();
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

        private void Tama�oComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
            
          
    }
}
