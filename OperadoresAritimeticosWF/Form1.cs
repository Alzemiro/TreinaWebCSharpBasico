using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritimeticosWF
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbN1.Text);
            int numero2 = Convert.ToInt32(txbN2.Text);           
            txbResultado.Text = Somar(numero1, numero2).ToString();
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbN1.Text);
            int numero2 = Convert.ToInt32(txbN2.Text);            
            txbResultado.Text = Subtrair(numero1, numero2).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbN1.Text);
            int numero2 = Convert.ToInt32(txbN2.Text);          
            txbResultado.Text = Multiplicar(numero1, numero2).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
       
            int numero1 = Convert.ToInt32(txbN1.Text);
            int numero2 = Convert.ToInt32(txbN2.Text);
            txbResultado.Text = Dividir(numero1, numero2).ToString();

        }

        int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach (var numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        int Subtrair(params int[] numeros)
        {
            int resultado = 0;
            foreach (var numero in numeros)
            {
                resultado -= numero;
            }
            return resultado;
        }


        int Multiplicar(params int[] numeros)
        {
            int resultado = 0;
            foreach (var numero in numeros)
            {
                resultado *= numero;
            }
            return resultado;
        }

        int Dividir(params int[] numeros)
        {
            int resultado = 0;
            foreach (var numero in numeros)
            {
                resultado /= numero;
            }
            return resultado;
        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
