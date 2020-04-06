using System;

namespace ConhecendoDebugDNF
{
    namespace ConhecendoDebug
    {
        class Program
        {
            static void Main(string[] args)
            {
                (new Program()).ExecutarPrograma();
            }

            public void ExecutarPrograma()
            {
                int numero1 = LerInteiro();
                int numero2 = LerInteiro();
                int soma = SomarNumeros(numero1, numero2);
                Console.WriteLine("O resultado da soma é {0}", soma);
                Console.ReadKey();
            }

            int LerInteiro()
            {
                Console.Write("Digite um número: ");
                return int.Parse(Console.ReadLine());
            }

            int SomarNumeros(int num1, int num2)
            {
                int resultado = num1 + num2;
                return resultado;
            }
        }
    }
}
