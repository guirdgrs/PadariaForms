using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   //Instanciar um usuário
            Classes.Usuario usuario = new Classes.Usuario();

            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            var resultado = usuario.Logar(); //Resultado do SELECT no banco

            if (resultado.Rows.Count <= 0)
            { //Senha incorreta
                MessageBox.Show("E-mail ou senha inválidos",
                "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

                txbEmail.Clear();
                txbSenha.Clear();
            }
            else
            { //Senha correta
                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show("Usuário encontrado");

                MenuPrincipal janela = new MenuPrincipal();

                Hide();
                janela.ShowDialog(); //Mostrar o menu
                Show(); //Menu fechado tela volta a aparecer
            }
        }
    }
}
