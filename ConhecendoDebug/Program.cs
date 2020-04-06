using System;

namespace ConhecendoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).ExecutarPrograma();
        }

        public int LerInteiro()
        {
            Console.WriteLine("Digite um número: ");
            return int.Parse(Console.ReadLine());
        }

        public int CalcularSoma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public void ExecutarPrograma()
        {
            int numero1 = LerInteiro();
            int numero2 = LerInteiro();
            int soma = CalcularSoma(numero1, numero2);
            Console.WriteLine("O resultado da some é {0}", soma);
        }
    }
}
