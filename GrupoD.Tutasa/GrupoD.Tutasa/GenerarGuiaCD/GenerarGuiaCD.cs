using GrupoD.Tutasa.GenerarGuiaCD;
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
            //Agregar las opciones provincias a Combobox Provincia
            foreach (var provincia in modelo.Provincias)
            {
                ProvinciaComboBox.Items.Add(provincia);
            }

            //Agregar las opciones tipos de entrega a Combobox Tipos de Entrega
            foreach (var tipoEntrega in modelo.TiposEntrega)
            {
                TipoEntregaComboBox.Items.Add(tipoEntrega);
            }

            //Agregar las opciones tama�os a Combobox Tama�o de Encomienda
            foreach (var tama�o in modelo.Tama�osEncomienda)
            {
                Tama�oComboBox.Items.Add(tama�o);
            }


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

            /*// Crear el objeto Cliente requerido para la gu�a
            var cliente = new Cliente
            {
                Cuit = CuitTextBox.Text
                // Asignar otras propiedades si es necesario
            };*/

            var guia = new Guia
            {
                
                CuitCliente = CuitTextBox.Text,
                DniDestinatario = dni,
                NombreDestinatario = NombreTextBox.Text,
                ApellidoDestinatario = ApellidoTextBox.Text,
                ProvinciaDestinatario = ProvinciaComboBox.SelectedItem.ToString(),
                CiudadDestinatario = CiudadDestinatarioTextBox.Text,
                DireccionDestinatario = DirecDestinatarioTextBox.Text,
                CodigoPostalDestinatario = CPDestinatarioTextBox.Text,
                Tama�oEncomienda = Tama�oComboBox.SelectedItem.ToString(),
                TipoEntrega = TipoEntregaComboBox.SelectedItem.ToString()
                // Asignar Destinatario y FechaGeneracion si es necesario
            };

            // Aqu� puedes agregar la l�gica para guardar o procesar la gu�a generada
            MessageBox.Show("Gu�a generada con �xito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            modelo.GenerarGuia(guia);
        }



       



           /* var cuitCliente = modelo.ValidarCliente(cuit);
            if (cuitCliente == null)
            {
                return;

            }


            foreach (var cliente in cuitCliente)
            {
                var listItem = new ListViewItem(cliente.Cuit);
                listItem.SubItems.Add(cliente.RazonSocial);
                listItem.SubItems.Add(cliente.Provincia);
                listItem.SubItems.Add(cliente.Ciudad);
                listItem.SubItems.Add(cliente.Direccion);
                listItem.SubItems.Add(cliente.CodigoPostal.ToString());

            }
        }*/

        private void Tama�oComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
           
          
    }
}
