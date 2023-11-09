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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Login janela = new Login(); //Instanciar a janela de login

            janela.ShowDialog(); //Mostrar a janela

            Application.Exit(); //Fechar tudo ao fechar a janela "login"
        }
    }
}
