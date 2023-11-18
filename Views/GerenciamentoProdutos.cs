using PadariaForms.Classes;
using System;
using System.Collections;
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
        Classes.Usuario usuario = new Classes.Usuario(); // "Usuario global"
        int idProdutoSelecionado = 0; //Var global p/ armazenar id do produto
        int idCategoriaSelecionada = 0; //           ''         id da categoria

        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            //Instanciando um produto e uma categoria
            Classes.Produto produto = new Classes.Produto();
            Classes.Categoria categoria = new Classes.Categoria();

            //Preenchendo os DGV's com os métodos de listagem
            dgvCategorias.DataSource = categoria.ListarCategoria(); 
            dgvProdutos.DataSource = produto.ListarProdutos();

            //Adicionando as linhas da tabela ao ComboBox
            var r = categoria.ListarCategoria(); //Método de listagem de categorias

            foreach (DataRow linha in r.Rows)
            {
                cmbCategoriaCad.Items.Add(linha.ItemArray[0].ToString() + " - " //Id
                                        + linha.ItemArray[1].ToString()); //Nome

                cmbCategoriaEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());
            }

            //Refazendo porém para o ComboBox de usuários
            var r1 = usuario.ListarUsuários();

            foreach (DataRow linha in r1.Rows)
            {
                cmbUsuarios.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());

            }
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close(); //Sair da janela
        }

        public void Atualizar() //Método para atualizar o forms
        {
            Classes.Produto produto = new Classes.Produto();
            Classes.Categoria cateogira = new Classes.Categoria();

            //Atualizar os DGV's
            dgvProdutos.DataSource = produto.ListarProdutos();
            dgvCategorias.DataSource = cateogira.ListarCategoria();

            //Limpar os campos
            txbNomeCad.Clear();
            txbNomeEdi.Clear();
            txbPrecoCad.Clear();
            txbPrecoEdi.Clear();
            txbNovaCategoria.Clear();
            txbNovaCatEdi.Clear();

            //Desabilitar os GRB's
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
            grbEditarCategoria.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto(); //Instanciar o produto

            try
            {
                //Obter os valores
                produto.Nome = txbNomeCad.Text;
                produto.Preco = Double.Parse(txbPrecoCad.Text);
                produto.IdCategoria = int.Parse(cmbCategoriaCad.Text.Split('-')[0]);
                produto.IdRespCadastro = usuario.Id;

                if (produto.CadastrarProduto()) //Produto cadastrado (true)
                {
                    MessageBox.Show("Produto cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();
                }
                else //Produto não cadastrado (false)
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

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) //Quando o DGV é clicado
        {
            idCategoriaSelecionada = 0; //Id da cateogira passa a ser 0 para evitar possível exclusão dupla acidental

            //Ativar os GRB's
            grbEditarCategoria.Enabled = false;
            grbApagar.Enabled = true;
            grbEditar.Enabled = true;

            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex; //Armazenando a linha selecionada

            var linha = dgvProdutos.Rows[linhaSelecionada];

            //Obtendos os valores do DGV e preenchendo os TXB's
            txbNomeEdi.Text = linha.Cells[1].Value.ToString(); //Nome
            txbPrecoEdi.Text = linha.Cells[2].Value.ToString(); //Preço

            //Mudando o label do GRB Apagar
            lblAlerta.Text = "Produto: " +
                             linha.Cells[0].Value.ToString() + " - " + //Id do produto
                             linha.Cells[1].Value.ToString(); //Nome do produto

            idProdutoSelecionado = (int)linha.Cells[0].Value; //Armazenando o id do produto na var global
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            Classes.Categoria categoria = new Classes.Categoria();

            produto.Id = idProdutoSelecionado; //Id do produto = id armazenado anteriormente
            categoria.Id = idCategoriaSelecionada;  //              ''

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", //Janela de confirmação
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(idProdutoSelecionado == 0) //Nenhum produto selecionado
            {
                if (r == DialogResult.Yes)
                {
                    if (categoria.ApagarCategoria()) //Remover categoria
                    {
                        MessageBox.Show("Categoria removida!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();

                        lblAlerta.Text = "Selecione o produto ou a \ncategoria que deseja apagar";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover categoria", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (r == DialogResult.Yes) 
                {
                    if (produto.ApagarProduto()) //Remover produto
                    {
                        MessageBox.Show("Produto removido!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Atualizar();

                        lblAlerta.Text = "Selecione o produto ou a \ncategoria que deseja apagar";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover produto", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            try
            {
                //Valores do produto = TXB's do grbEditar
                produto.Id = idProdutoSelecionado;
                produto.Nome = txbNomeEdi.Text;
                produto.Preco = Double.Parse(txbPrecoEdi.Text);

                produto.IdCategoria = int.Parse(cmbCategoriaEdi.Text.Split('-')[0]); //Id da cateogoria no ComboBox
                produto.IdRespCadastro = int.Parse(cmbUsuarios.Text.Split('-')[0]); //Id do usuário no ComboBox

                if (produto.EditarProduto())
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

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();

            try
            {
                categoria.Nome = txbNovaCategoria.Text; //Nome da categoria

                if (categoria.NovaCategoria())
                {
                    MessageBox.Show("Categoria cadastrada", "Sucesso", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar categoria", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();

            try
            {
                categoria.Id = idCategoriaSelecionada; //Id da categoria = var global
                categoria.Nome = txbNovaCatEdi.Text;

                if (categoria.EditarCategoria())
                {
                    MessageBox.Show("Categoria editada!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Atualizar();
                }
                else
                {
                    MessageBox.Show("Erro ao editar categoria", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar categoria", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdutoSelecionado = 0; //Id do produto passa a ser 0 para evitar conflitos

            grbEditar.Enabled = false;
            grbApagar.Enabled = true;
            grbEditarCategoria.Enabled = true;

            int linhaSelecionada = dgvCategorias.CurrentCell.RowIndex;

            var linha = dgvCategorias.Rows[linhaSelecionada];

            txbNovaCatEdi.Text = linha.Cells[1].Value.ToString();

            lblAlerta.Text = "Categoria: " +
                             linha.Cells[0].Value.ToString() + " - " + 
                             linha.Cells[1].Value.ToString();

            idCategoriaSelecionada = (int)linha.Cells[0].Value; //Armazenando o Id da categoria selecionado
        }
    }
}
