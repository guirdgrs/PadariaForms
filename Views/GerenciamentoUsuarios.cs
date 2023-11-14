﻿using System;
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
    public partial class GerenciamentoUsuarios : Form
    {
        int idSelecionado = 0; //Var de id global

        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            //Atribuir o método do select no DGV
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar o usuário
            Classes.Usuario usuario = new Classes.Usuario();

            //Obter os valores dos campos
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if (txbConfirmarSenhaCad.Text != txbSenhaCad.Text || txbConfirmarSenhaCad.Text == "")
            { //Confirmar senha
                MessageBox.Show("As senhas não coincidem");
                txbConfirmarSenhaCad.Clear();
                txbSenhaCad.Clear();
            }
            else
            {
                if (usuario.Cadastrar() == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    //Limpar os campos
                    txbNomeCad.Clear();
                    txbEmailCad.Clear();
                    txbSenhaCad.Clear();

                    //Atualizar o DGV
                    dgvUsuarios.DataSource = usuario.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário!");
                }
            }
            
        }

        private void pibMostrar_Click(object sender, EventArgs e)
        {
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os GRBS
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Obter a linha clicada
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            //Armazenar os dados da linha seleacionada em "linha"
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            //Preencher os campos
            txbNomeEdi.Text = linha.Cells[1].Value.ToString(); //Nome
            txbEmailEdi.Text = linha.Cells[2].Value.ToString(); //Email

            //Mudar o label do GRB apagar
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                             linha.Cells[1].Value.ToString();

            //Salvar o id selecionado na var global
            idSelecionado = (int)linha.Cells[0].Value;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            usuario.Id = idSelecionado;
        }
    }
}
