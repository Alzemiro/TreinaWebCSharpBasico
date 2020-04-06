using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Nestes exercícios não há regra de como deve ser a aplicação, ou a interface dela, você pode cria-la da forma que achar mais fácil.

//1) A condição física de uma pessoa pode ser medida com base no cálculo do índice de Massa Corporal(IMC). O mesmo é calculado dividindo-se o peso desta pessoa pelo quadrado da altura em m.Escreva um programa que leia o peso em kg e a altura de uma pessoa em m, calcule e mostre o IMC.

//2) Faça um programa que, a partir da leitura das medidas dos lados de um retângulo(comprimento e largura), lidos do teclado, calcule e imprima a área e o perímetro do retângulo.

//A fórmula da área do retângulo é A = C* L e do perímetro P = 2 * C + 2 * L.

//3) Faça um programa que aceite n elementos inteiros e crie um método que ordene de forma crescente esses elementos.
namespace Aula14Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Calculador da Area do Retangulo
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string entradaComprimento = Validar(txbRetComprimento.Text);
                string entradaLargura = Validar(txbRetLargura.Text);
                double comprimento = Convert.ToDouble(entradaComprimento);
                double largura = Convert.ToDouble(entradaLargura);
                double area = comprimento * largura;
                double perimetro = (2 * comprimento) + (2 * largura);

                area = Math.Round(area, 2);
                lblRetanguloArea.Text = area.ToString();
                lblRetanguloArea.Visible = true;

                perimetro = Math.Round(perimetro, 2);
                lblRetanguloPerimetro.Text = perimetro.ToString();
                lblRetanguloPerimetro.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorreto nos campos de preenchimento: " + ex.Message);
            }
        }

        //Calulador do IMC com arrendodamento
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string entradaAltura = Validar(txbAltura.Text);
                string entradaPeso = Validar(txbPeso.Text);
                double peso = Convert.ToDouble(entradaPeso);
                double altura = Convert.ToDouble(entradaAltura);
                double resultado = peso / (altura * altura);

                resultado *= 10000;
                resultado = Math.Round(resultado, 2);
                lblResultadoIMC.Text = resultado.ToString();
                lblResultadoIMC.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorreto nos campos de preenchimento: " + ex.Message);
            }

        }
        //Validador utilizado no retangulo e IMC
        public string Validar(string str1)
        {
            str1 = str1.Replace(",", ".");
            return str1;
        }

        //Ordenador com BubbleSort
        private void btnOrdenacao_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string elemVetor = txbElemVetor.Text;
                int iElemVetor = Convert.ToInt32(elemVetor);

                string[] entradaValores = new string[iElemVetor];
                entradaValores = txbOrdenacao.Text.Split(',');

                int[] vetor = new int[iElemVetor];

                lblResultadoOrdencao.Visible = true;


                for (var i = 0; i < entradaValores.Length; i++)
                {
                    vetor[i] = Convert.ToInt32(entradaValores[i]);
                }

                BubbleSort(vetor);

                for (var i = 0; i < entradaValores.Length; i++)
                {
                    entradaValores[i] = Convert.ToString(vetor[i]);
                    sb.Append(entradaValores[i]);
                    sb.Append(", ");
                    lblResultadoOrdencao.Text = sb.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorreto nos campos de preenchimento: " + ex.Message);
            }
        }

       public void BubbleSort(int[] vetor)
        {
            int aux;
            
            for (int i = 0; i < vetor.Length; i++)
            {
                
                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[i] > vetor[j])
                    {
                        
                        {
                            
                            aux = vetor[j];

                            
                            vetor[j] = vetor[i];

                            
                            vetor[i] = aux;
                        }
                    }
            }
        }
    }
}
