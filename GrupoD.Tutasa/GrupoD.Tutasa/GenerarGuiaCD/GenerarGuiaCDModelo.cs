using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.GenerarGuiaCD
{
    internal class GenerarGuiaCDModelo
    {
        //Cargo Provincias en el ComboBox Provincias
        public string[] Provincias { get; } = [
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Ciudad Autónoma de Buenos Aires",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego",
            "Tucumán",

            ];


        //Agregar las opciones tamaños a TamañoEncomiendaComboBox
        public string[] TamañosEncomienda { get; } = [
            "S",
            "M",
            "L",
            "XL",
            ];


        //Agregar las opciones tamaños a Combobox Tipos de Entrega
        public string[] TiposEntrega { get; } = [
            "A Domicilio",
            "Centro de Distribución",
            "Agencia",
            ];


        public string[] CentrosDistibucion { get; } = [
            "10-CD Retiro",
            "15-CD Rosario",
            "20-CD Córdoba",
            "25-CD Mendoza",
            "30-CD Ushuaia",

            ];

        public string[] Agencias { get; } = [
            "001-Microcentro",
            "002-Palermo",
            "003-Belgrano",
            "004-Caballito",
            "005-Flores",

            ];


        public List<Cliente> ValidarCliente(long cuit)
        {

            //Validar que Cuit tenga 11 digitos
            string cuitString = cuit.ToString();
            if (cuitString.Length != 11)
            {
                MessageBox.Show("El CUIT debe tener 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            //Validar que cuit no sea un numero negativo
            if (cuit < 0)
            {
                MessageBox.Show("El CUIT no puede ser un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            //Datos de Prueba
            return new List<Cliente>{
                new Cliente
                {
                    Cuit = 30205869953,
                    RazonSocial = "EnvasesArg",
                    Provincia = "Buenos Aires",
                    Ciudad = "Lanus",
                    Direccion = "9 de Julio 3821",
                    CodigoPostal = 1824,
                },


                new Cliente
                {
                    Cuit= 30725648921,
                    RazonSocial = "RepuestosCorSA",
                    Provincia = "Cordoba",
                    Ciudad = "Cordoba",
                    Direccion = "Av. Colon 1234",
                    CodigoPostal = 5000,
                },

                new Cliente
                {
                    Cuit= 20314567891,
                    RazonSocial = "TecnologiaHoy",
                    Provincia = "Santa Fe",
                    Ciudad = "Rosario",
                    Direccion = "Calle Falsa 123",
                    CodigoPostal = 2000,
                }
            };
        }



        internal void GenerarGuia(Guia guia)
        {

        }





        internal bool ValidarDni(long dni)
        {

            //Validar que DNI cumple rango

            if (dni < 10_000_000 || dni > 99_999_999)
            {
                MessageBox.Show("El DNI ingresado es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


            //Validar que DNI tenga 8 digitos
            string dniString = dni.ToString();
            if (dniString.Length != 8)
            {
                MessageBox.Show("El DNI ingresado debe tener ocho dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;



        }


        internal bool ValidarCodigoPostal(long cpDestinatario)
        {
            //Validar que Codigo Postal tenga 4 o 5 digitos
            string cpDestinatarioString = cpDestinatario.ToString();

            if (cpDestinatarioString.Length != 4)
            {
                MessageBox.Show("El código postal debe tener 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

    

