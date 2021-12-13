using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjCalcularEdad
{
    public partial class CalculadoraEdades : Form
    {
        public CalculadoraEdades()
        {
            InitializeComponent();
        }
        //Declaración y asignación de variables de tipo int privado
        private int year, dayy, monthh, fa = 2021, edad, mes, dia;

        //Cód. validación campos number, letters
        public void validarTexto(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }   

        public void validarNumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }        

        public void txt_Valiciones(object sender, EventArgs e)
        {           
        }

        private void CalculadoraEdades_Load(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {           
        }
        //Validación de campos (texto)
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(sender, e);
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumero(sender, e);
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {            
        }
        //Validación de campos (números)
        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumero(sender, e);
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {                                
        }
        //Validación de campos (números)
        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumero(sender, e);
        }
        //Salir de la app (confirmación de salida)
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir?", "Confirma salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {                                    
            txtNombres.Text = String.Empty;                        
            txtAnio.Text = String.Empty;                        
            txtMes.Text = String.Empty;                        
            txtDia.Text = String.Empty;
            lblEdadT.Text = String.Empty;
            lblMVividosT.Text = String.Empty;
            lblDiasVT.Text = String.Empty;
            txtNombres.Focus();
        }

        private void btnCalcularE_Click(object sender, EventArgs e)
        {
            //Condicionales para validar vacíos
            if (txtNombres.Text == "" || txtAnio.Text == "" || txtMes.Text == "" || txtDia.Text == "")
            {
                MessageBox.Show("Debe de introducir la información necesaria para continuar.");
            }
            else if (monthh >= 1 && monthh <= 12)
            {
                MessageBox.Show("El mes introducido no es válido.");
            }
            else
            {
                year = Convert.ToInt16(txtAnio.Text);
                edad = fa - year; //Años
                lblEdadT.Text = edad.ToString();

                monthh = Convert.ToInt16(txtMes.Text);
                mes = edad * 12; //Meses
                lblMVividosT.Text = mes.ToString();

                dayy = Convert.ToInt16(txtDia.Text);
                dia = edad * 365; //Días
                lblDiasVT.Text = dia.ToString();
            }
            //Asignación de valores a variables de tipo int y string
            int sigloxxI = 1901, sigloxxF = 2000, sigloxxiI = 2001, sigloxxiF = 2100;
            string nombre = txtNombres.Text;
            //Condicionales para validar si es del siglo XX o XXI
            if (year >= sigloxxI && year <= sigloxxF)
            {
                MessageBox.Show(nombre + " eres del siglo XX.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (year >= sigloxxiI && year <= sigloxxiF)
            {
                MessageBox.Show(nombre + " eres del siglo XXI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
