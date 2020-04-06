using System;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuVetor = new int[10];
            for(int i = 0; i <= 9; i++)
            {
                meuVetor[i] = i + 1;
            }
            /*for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Posição vetor[{0}] = {1}", i, meuVetor[i]);
            }*/
            foreach(int numero in meuVetor)
            {
                Console.WriteLine("{0}", numero);
            }
        }

    }
}
