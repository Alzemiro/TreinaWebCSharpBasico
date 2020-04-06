using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 3) Um pequeno mercado está tentando organizar seus produtos. Você foi contratado para desenvolver um sistema 
 simples que irá ajudá-los a gerenciar o estoque.

 A aplicação precisa apenas armazenar as seguintes informações dos produtos:

 Nome dos produtos;
 Preço dos produtos;
 Quantidade dos produto;
 A aplicação deverá ser criada com o Windows Forms. Você também deverá se atentar 
 também à arquitetura da aplicação, tentando seguir ao máximo a arquitetura sugerida durante o curso.

 Salve os dados em um arquivo de texto.


 */

namespace Aula36Exercicio3
{
    public class ManipuladorDeArquivos
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "estoque.txt";

        public static List<Produto> LerArquivo()
        {
            List<Produto> produtoList = new List<Produto>();
            try
            {
                if (File.Exists(EnderecoArquivo))
                {
                    using (StreamReader sr = File.OpenText(EnderecoArquivo))
                    {

                        while (sr.Peek() >= 0)
                        {
                            string linha = sr.ReadLine();
                            string[] linhaSplit = linha.Split(';');
                            //Valida se as 3 linhas foram escritas
                            if (linhaSplit.Count() == 3)
                            {
                                Produto produto = new Produto();
                                produto.Descricao = linhaSplit[0];
                                produto.Preco = linhaSplit[1];
                                produto.Quantidade = Convert.ToInt32(linhaSplit[2]);
                                produtoList.Add(produto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return produtoList;
        }

        public static void EscreverArquivo(List<Produto> produtosList)
        {
            using (StreamWriter sw = new StreamWriter(@EnderecoArquivo, false))
            {
                foreach (Produto produto in produtosList)
                {

                    string linha = string.Format("{0};{1};{2}", produto.Descricao, produto.Preco, produto.Quantidade);
                    sw.WriteLine(linha);


                    sw.Flush();
                }
            }
        }

    }
}
