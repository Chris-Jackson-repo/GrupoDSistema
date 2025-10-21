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

        internal List<Cliente> ValidarCliente(Cliente cuit)
        {
            /*
             //Validar que Cuit tenga 11 digitos
             if (cuit.Length != 11)
             {
                 MessageBox.Show("El CUIT debe tener 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }


             //Validar que cuit no sea un numero negativo
             if (cuit < 0)
             {
                 MessageBox.Show("El CUIT no puede ser un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/


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
                }

            };
        }
            


            internal void GenerarGuia (Guia guia)
            { 
                
            }





       /* internal void ValidarDestinatario(Destinatario nuevoDestinatario)
        {
            //Validar que DNI cumple rango
            if (nuevoDestinatario.Dni < 10_000_000 || nuevoDestinatario.Dni > 99_999_999)
            {
                MessageBox.Show("El DNI ingresado es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que DNI tenga 8 digitos
            if (DniTextBox.Length != 8)
            {
                MessageBox.Show("El DNI ingresado debe tener ocho dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que Codigo Postal tenga 4 digitos
            if (codigoPostalTexto.Length != 4)
            {
                MessageBox.Show("El CUIT debe tener 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       */


        }
    }

