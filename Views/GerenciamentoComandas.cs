using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaForms.Views
{
    public partial class GerenciamentoComandas : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        int Comanda = 0; //Var global p/ armazenar o num. da comanda

        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            lblUsuario.Text = "Logado como: " + usuario.NomeCompleto; //Mensagem com o usuario logado

            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos(); //Listando os produtos

            nudQuantidade.Maximum = 100; //Estabelecendo a qtd. máxima
            nudQuantidade.Minimum = 1; //Estabelecendo a qtd. mínima
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparTudo() //Método de limpeza
        {
            txbCodProduto.Clear();
            txbComanda.Clear();
            txbProduto.Clear();
            nudQuantidade.Value = 1;

            grbLancamento.Enabled = false;
            grbInfos.Enabled = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txbComanda.Text != "" && txbCodProduto.Text != "") //Condição: campos não estão vazios
            {
                grbInfos.Enabled = false;
                grbLancamento.Enabled = true;

                Comanda = int.Parse(txbComanda.Text); //Armazenando o num. da comanda na var global
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;
            var linha = dgvProdutos.Rows[linhaSelecionada];

            //Preenchendo os campos conforme o DGV
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProduto.Text = linha.Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (r == DialogResult.Yes) //Lançando a comanda
                {
                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();

                    //Preenchendo de acordo com os campos
                    ordem.IdFicha = int.Parse(txbComanda.Text);
                    ordem.IdProduto = int.Parse(txbCodProduto.Text);
                    ordem.Quantidade = int.Parse(nudQuantidade.Text);
                    ordem.IdResp = usuario.Id;

                    if (ordem.NovoLancamento())
                    {
                        MessageBox.Show("Lançamento efetuado!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparTudo();

                        var r1 = MessageBox.Show("Deseja adicionar outro produto?", "Aviso!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Alerta para manter a comanda

                        if (r1 == DialogResult.Yes)
                        {
                            txbComanda.Text = Comanda.ToString(); //Preenchendo o campo com a comanda armazenada
                        }
                        else
                        {
                            LimparTudo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha no lançamento!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LimparTudo();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro no lançamento", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparTudo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}
