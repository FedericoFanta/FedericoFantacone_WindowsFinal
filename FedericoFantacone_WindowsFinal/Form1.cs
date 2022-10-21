using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FedericoFantacone_WindowsFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);
            string puesto = txtPuesto.Text;

            Validaciones(nombre, sueldo, puesto);
        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = txtPuesto.Text;

            Imprimir(nombre, apellido, puesto);
        }

       

        private void btnHoras_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int[] horas = new int[5];

            HorasTrabajadas(nombre, apellido, horas);

        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private static void Validaciones(string nombre, decimal sueldo, string puesto)
        {
            if (sueldo > 0)
            {
                MessageBox.Show("Tu sueldo cumple los requisitos");
            }
            else
                MessageBox.Show("Tu sueldo debe ser mayor a 0");

            if (puesto == "Soporte Tecnico")
            {
                MessageBox.Show("Tu puesto cumple los requisitos");
            }
            else if (puesto == "DBA")
            {
                MessageBox.Show("Tu puesto cumple los requisitos");
            }
            else if (puesto == "Desarrollador")
            {
                MessageBox.Show("Tu puesto cumple los requisitos");
            }
            else
                MessageBox.Show("Tu puesto no coincide con Soporte Tenico, DBA, Desarrollador");


            if (nombre.Length > 2 && nombre.Length < 50)
            {
                MessageBox.Show("Tu nombre cumple los requisitos");
            }
            else
                MessageBox.Show("Tu nombre debe tener mas de 2 caracteres y menos de 50");
        }
       
        private static void HorasTrabajadas(string nombre, string apellido, int[] horas)
        {
            int suma;

            for (int i = 0; i < horas.Length; i++)
            {
                horas[i]=Convert.ToInt32(Interaction.InputBox("Ingrese las horas del dia " + (i+1)));
            }

            suma=0;
            for (int i = 0; i < horas.Length; i++)
            {
                suma+=horas[i];
            }

            MessageBox.Show(nombre +" " + apellido + " \nTrabajo: " +suma + " horas");

            MessageBox.Show("El promedio de horas trabajadas es de "+suma/5);

            for (int i = 0; i < horas.Length; i++)
            {
                if (horas[i]<4)
                {
                    MessageBox.Show("El dia " +(i+1) + " trabajo menos de 4 horas");
                }
            }
        }
        private static void Imprimir(string nombre, string apellido, string puesto)
        {
            MessageBox.Show("Nombre: " + nombre.ToUpper());
            MessageBox.Show("Apellido: " + apellido.ToUpper());
            MessageBox.Show("Puesto: " +puesto.ToUpper());
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtSueldo.Clear();
            txtPuesto.Clear();
        }
    }
}
