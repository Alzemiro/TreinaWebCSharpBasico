using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatosTreinaWeb
{
    public partial class frmAgendaContatos : Form
    {
        private OperacaoEnum acao;
        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            CarregarListaContatos();
            AlterarEstadoCampos(false);
        }

        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        private void AlterarBotoesAlterarIncluirExcluir(bool estado)
        {
            btnExcluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnIncluir.Enabled = estado;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesAlterarIncluirExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesAlterarIncluirExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesAlterarIncluirExcluir(true);
            AlterarEstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                NumeroTelefone = txbTelefone.Text

            };
            List<Contato> contatosList = new List<Contato>();
            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                 contatosList.Add(contatoDaLista);
            }

            if(acao == OperacaoEnum.INCLUIR)
            {
                contatosList.Add(contato);
            }

            if (acao == OperacaoEnum.ALTERAR)
            {               
                int indice = lbxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice, contato);
           }
            ManipuladorArquivos.EscreverArquivo(contatosList);
            CarregarListaContatos();
            AlterarBotoesAlterarIncluirExcluir(true);
            AlterarBotoesSalvarECancelar(false);
            LimparCampos();
            AlterarEstadoCampos(false);

        }

        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            //AddRange permite colocar um array de informações 
            lbxContatos.Items.AddRange(ManipuladorArquivos.LerArquivo().ToArray());
            lbxContatos.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            txbEmail.Text = "";
            txbNome.Text = "";
            txbTelefone.Text = "";
        }

        private void AlterarEstadoCampos(bool estado)
        {
            txbEmail.Enabled = estado;
            txbNome.Enabled = estado;
            txbTelefone.Enabled = estado;
        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
            txbNome.Text = contato.Nome;
            txbEmail.Text = contato.Email;
            txbTelefone.Text = contato.NumeroTelefone;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indiceExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }
                ManipuladorArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
            }
        }
    }
}
