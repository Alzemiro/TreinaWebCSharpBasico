using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula36Exercicio3
{
    public partial class Form1 : Form
    {
        private FluxoEnum acao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EstadoCampos(false);
            EstadoBotesSalvarCancelar(false);
            CarregarListaProdutos();
        }

        private void EstadoCampos(bool estado)
        {
            txbPreco.Enabled = estado;
            txbQuantidade.Enabled = estado;
            txbDescricao.Enabled = estado;
        }

        private void EstadoBotesSalvarCancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }

        private void EstadoBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void CarregarListaProdutos()
        {
            lbxLista.Items.Clear();
            lbxLista.Items.AddRange(ManipuladorDeArquivos.LerArquivo().ToArray());
        }

        private void LimparCampos()
        {
            txbDescricao.Text = "";
            txbPreco.Text = "";
            txbQuantidade.Text = "";
        }

        private void lbxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Produto produto = (Produto)lbxLista.Items[lbxLista.SelectedIndex];
                txbDescricao.Text = produto.Descricao;
                txbPreco.Text = Convert.ToString(produto.Preco);
                txbQuantidade.Text = Convert.ToString(produto.Quantidade);

            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show("Erro: " + ie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            EstadoBotesSalvarCancelar(true);
            EstadoBotoesIncluirAlterarExcluir(false);
            EstadoCampos(true);
            acao = FluxoEnum.INCLUIR;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EstadoBotesSalvarCancelar(true);
            EstadoBotoesIncluirAlterarExcluir(false);
            EstadoCampos(true);
            acao = FluxoEnum.ALTERAR;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoBotesSalvarCancelar(false);
            EstadoBotoesIncluirAlterarExcluir(true);
            EstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    Descricao = txbDescricao.Text,
                    Preco = txbPreco.Text.Replace(',', '.'),
                    Quantidade = Convert.ToInt32(txbQuantidade.Text)

                };
                List<Produto> produtoList = new List<Produto>();
                foreach (Produto produtos in lbxLista.Items)
                {
                    produtoList.Add(produtos);
                }

                if (acao == FluxoEnum.INCLUIR)
                {
                    produtoList.Add(produto);
                }
                if (acao == FluxoEnum.ALTERAR)
                {
                    int indice = lbxLista.SelectedIndex;
                    produtoList.RemoveAt(indice);
                    produtoList.Insert(indice, produto);
                }
                ManipuladorDeArquivos.EscreverArquivo(produtoList);
                CarregarListaProdutos();
                EstadoBotoesIncluirAlterarExcluir(true);
                EstadoBotesSalvarCancelar(false);
                LimparCampos();
                EstadoCampos(false);
            }
            catch (FormatException fx)
            {
                MessageBox.Show("Formato Inválido: " + fx);
            }
        }

        private void ValidaCampo(string campo)
        {
            Regex rx = new Regex("[A-z]");
            if (rx.IsMatch(campo))
            {
                MessageBox.Show("O campo Preço e Quantidade aceitam apenas números");
                txbPreco.Clear();
                txbQuantidade.Clear();
            }

        }
        private void txbPreco_TextChanged(object sender, EventArgs e)
        {
            ValidaCampo(txbPreco.Text);

        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            ValidaCampo(txbQuantidade.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = lbxLista.SelectedIndex;
                lbxLista.SelectedIndex = 0;
                lbxLista.Items.RemoveAt(indiceExcluido);
                List<Produto> produtosList = new List<Produto>();
                foreach(Produto produto in lbxLista.Items)
                {
                    produtosList.Add(produto);
                }
                ManipuladorDeArquivos.EscreverArquivo(produtosList);
                CarregarListaProdutos();
                LimparCampos();
            }
        }
    }
}
