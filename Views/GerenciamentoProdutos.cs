using PadariaForms.Classes;
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
    public partial class GerenciamentoProdutos : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        int idSelecionado = 0; //Var global

        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            Classes.Produto produto = new Classes.Produto();
            Classes.Categoria categoria = new Classes.Categoria();

            dgvProdutos.DataSource = produto.ListarProdutos();

            cmbCategoriaCad.DataSource = categoria.ListarCategoria();
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Atualizar() //Método para atualizar o forms
        {
            Classes.Produto produto = new Classes.Produto();

            dgvProdutos.DataSource = produto.ListarProdutos(); //Atualizar o DGV

            //Limpar os campos
            txbNomeCad.Clear();
            txbNomeEdi.Clear();
            txbPrecoCad.Clear();
            txbPrecoEdi.Clear();

            //Desabilitar os GRB's
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto(); //Instanciar o produto
            try
            {
                //Obter os valores
                produto.Nome = txbNomeCad.Text;
                produto.Preco = Double.Parse(txbPrecoCad.Text);

                produto.IdCategoria = int.Parse(cmbCategoriaCad.Text.First().ToString());

                produto.IdRespCadastro = usuario.Id;

                if (produto.CadastrarProduto())
                {
                    MessageBox.Show("Produto cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar produto", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os GRB's
            grbApagar.Enabled = true;
            grbEditar.Enabled = true;

            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            var linha = dgvProdutos.Rows[linhaSelecionada];

            //Obtendos os valores do DGV e preenchendo os TXB's
            txbNomeEdi.Text = linha.Cells[1].Value.ToString(); //Nome
            txbPrecoEdi.Text = linha.Cells[2].Value.ToString(); //Preço

            //Mudando o label do GRB Apagar
            lblAlerta.Text = linha.Cells[0].Value.ToString() + " - " + //Id do produto
                             linha.Cells[1].Value.ToString(); //Nome do produto

            idSelecionado = (int)linha.Cells[0].Value; //Armazenando o id do produto na var global
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            produto.Id = idSelecionado;

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", //Janela de confirmação
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) //Sim = apagar
            {
                if (produto.ApagarProduto()) //True
                {
                    MessageBox.Show("Produto removido!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();

                    lblAlerta.Text = "Selecione o produto que deseja apagar";
                }
                else //False
                {
                    MessageBox.Show("Erro ao remover produto", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            try
            {
                produto.Id = idSelecionado;

                produto.Nome = txbNomeEdi.Text;
                produto.Preco = Double.Parse(txbPrecoEdi.Text);
                produto.IdCategoria = int.Parse(cmbCategoriaCad.Text.First().ToString());


                if (produto.EditarProduto() == true)
                {
                    MessageBox.Show("Produto editado!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao editar produto", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar produto", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
