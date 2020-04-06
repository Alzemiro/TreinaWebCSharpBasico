using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula36Exercicio3
{
    public class Produto
    {
        public string Descricao;
        public int Quantidade;
        public string Preco;
        
        public Produto(string descricao = "", int quantidade = 0, string preco = "0")
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return string.Format("{0} - R$ {1} - Qtd: {2}", this.Descricao, this.Preco, this.Quantidade);
        }
    }

}
