using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero1 = 3;
            //int numero2 = numero1;
            //numero1 = 5;

            //Console.WriteLine("numero 1 = {0}, numero 2 = {0}", numero1, numero2);
            //Console.ReadKey();

            Teste teste1 = new Teste();
            teste1.Quantidade = 3;
            Teste teste2 = teste1;
            teste1.Quantidade = 5;

            Console.WriteLine("teste1 = {0},  teste2 = {1}", teste1.Quantidade, teste2.Quantidade);
            Console.ReadKey();

        }
    }

    class Teste
    {
        public int Quantidade;
    }
}
