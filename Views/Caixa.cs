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
    public partial class Caixa : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();

            btnEncerrarComanda.BackColor = Color.IndianRed; //Mudando a cor do botão
            this.usuario = usuario;
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (txbNumComanda.Text != "") //Condição para iniciar apenas com o valor da comanda
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();

                ordem.IdFicha = int.Parse(txbNumComanda.Text);
                var r = ordem.BuscarFicha();

                dgvComandas.DataSource = r; //Preenchendo o DGV com o SELECT

                lblTotal.Text = "Total: R$ " + r.Compute("SUM(Total_Item)", "True").ToString(); //Mostrando o valor total
            }
            else
            {
                MessageBox.Show("Digite o número da ficha", "Erro",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrarComanda.Enabled = chbPagamento.Checked; //Mudando o botão de acordo com a CHECKBOX

            if (btnEncerrarComanda.Enabled) //True
            {
                btnEncerrarComanda.BackColor = Color.LightGreen; //Botão habilitado - cor verde
            }
            else //False
            {
                btnEncerrarComanda.BackColor = Color.IndianRed; //Botão desabilititado - cor vermelha
            }
        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            Classes.OrdemComanda ordem = new Classes.OrdemComanda();
            ordem.IdFicha = int.Parse(txbNumComanda.Text);

            try
            {
                var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (ordem.AtualizarComanda()) //Atualizando a situação da comanda para inativa
                    {
                        MessageBox.Show("Ficha encerrada", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txbNumComanda.Clear();
                        dgvComandas.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
