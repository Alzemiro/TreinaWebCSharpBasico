using System;

namespace EstudoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2,4];
            int numero = 0;
            for(int linha = 0; linha <= 1; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    matriz[linha, coluna] = numero;
                    numero++;
                }
            }
            for (int linha = 0; linha <= 1; linha++)
            {
                for(int coluna = 0; coluna <= 3; coluna++)
                {
                    Console.WriteLine("MinhaMatriz[{0}, {1}] = {2}", linha, coluna, matriz[linha, coluna]);
                }
            }
            Console.WriteLine("Quantidade de Dimensões: {0}", matriz.Rank);
            Console.WriteLine("Tamanho da matriz: {0}", matriz.Length);
        }
    }
}
