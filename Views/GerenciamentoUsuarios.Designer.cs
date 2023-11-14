namespace PadariaForms.Views
{
    partial class GerenciamentoUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEdi = new System.Windows.Forms.TextBox();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblSenhaEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.lblGerenciamento = new System.Windows.Forms.Label();
            this.txbConfirmarSenhaCad = new System.Windows.Forms.TextBox();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.txbConfirmSenhaEdi = new System.Windows.Forms.TextBox();
            this.lblConfirmSenhaEdi = new System.Windows.Forms.Label();
            this.pibMostrar = new System.Windows.Forms.PictureBox();
            this.lblAlerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(74, 40);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(565, 238);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.lblAlerta);
            this.grbCadastro.Controls.Add(this.pibMostrar);
            this.grbCadastro.Controls.Add(this.txbConfirmarSenhaCad);
            this.grbCadastro.Controls.Add(this.lblConfirmSenha);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenhaCad);
            this.grbCadastro.Controls.Add(this.txbEmailCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.ForeColor = System.Drawing.Color.Crimson;
            this.grbCadastro.Location = new System.Drawing.Point(30, 297);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(312, 195);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(22, 149);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(266, 25);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCad.Location = new System.Drawing.Point(124, 75);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.PasswordChar = '•';
            this.txbSenhaCad.Size = new System.Drawing.Size(141, 21);
            this.txbSenhaCad.TabIndex = 5;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailCad.Location = new System.Drawing.Point(124, 48);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(141, 21);
            this.txbEmailCad.TabIndex = 4;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(124, 21);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(141, 21);
            this.txbNomeCad.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaCad.Location = new System.Drawing.Point(64, 77);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(47, 16);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCad.Location = new System.Drawing.Point(64, 50);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(43, 16);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email";
            this.lblEmailCad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 26);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(112, 16);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbConfirmSenhaEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblConfirmSenhaEdi);
            this.grbEditar.Controls.Add(this.txbSenhaEdi);
            this.grbEditar.Controls.Add(this.txbEmailEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblSenhaEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.Color.Crimson;
            this.grbEditar.Location = new System.Drawing.Point(372, 297);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(312, 195);
            this.grbEditar.TabIndex = 6;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(9, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(272, 25);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txbSenhaEdi
            // 
            this.txbSenhaEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaEdi.Location = new System.Drawing.Point(126, 80);
            this.txbSenhaEdi.Name = "txbSenhaEdi";
            this.txbSenhaEdi.PasswordChar = '•';
            this.txbSenhaEdi.Size = new System.Drawing.Size(141, 21);
            this.txbSenhaEdi.TabIndex = 5;
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailEdi.Location = new System.Drawing.Point(126, 53);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(141, 21);
            this.txbEmailEdi.TabIndex = 4;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdi.Location = new System.Drawing.Point(126, 26);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(141, 21);
            this.txbNomeEdi.TabIndex = 3;
            // 
            // lblSenhaEdi
            // 
            this.lblSenhaEdi.AutoSize = true;
            this.lblSenhaEdi.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaEdi.Location = new System.Drawing.Point(33, 82);
            this.lblSenhaEdi.Name = "lblSenhaEdi";
            this.lblSenhaEdi.Size = new System.Drawing.Size(85, 16);
            this.lblSenhaEdi.TabIndex = 2;
            this.lblSenhaEdi.Text = "Nova Senha";
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.ForeColor = System.Drawing.Color.Black;
            this.lblEmailEdi.Location = new System.Drawing.Point(64, 55);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(43, 16);
            this.lblEmailEdi.TabIndex = 1;
            this.lblEmailEdi.Text = "Email";
            this.lblEmailEdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdi.ForeColor = System.Drawing.Color.Black;
            this.lblNomeEdi.Location = new System.Drawing.Point(6, 28);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(112, 16);
            this.lblNomeEdi.TabIndex = 0;
            this.lblNomeEdi.Text = "Nome Completo";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.Transparent;
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbApagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.ForeColor = System.Drawing.Color.Crimson;
            this.grbApagar.Location = new System.Drawing.Point(111, 532);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(488, 65);
            this.grbApagar.TabIndex = 7;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.ForeColor = System.Drawing.Color.Black;
            this.lblApagar.Location = new System.Drawing.Point(15, 31);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(236, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um usuário para apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(328, 16);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(144, 43);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // pibSair
            // 
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(667, 32);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(35, 35);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 9;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // lblGerenciamento
            // 
            this.lblGerenciamento.AutoSize = true;
            this.lblGerenciamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamento.Location = new System.Drawing.Point(237, 9);
            this.lblGerenciamento.Name = "lblGerenciamento";
            this.lblGerenciamento.Size = new System.Drawing.Size(223, 19);
            this.lblGerenciamento.TabIndex = 10;
            this.lblGerenciamento.Text = "Gerenciamento de Usuários";
            // 
            // txbConfirmarSenhaCad
            // 
            this.txbConfirmarSenhaCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmarSenhaCad.Location = new System.Drawing.Point(124, 102);
            this.txbConfirmarSenhaCad.Name = "txbConfirmarSenhaCad";
            this.txbConfirmarSenhaCad.PasswordChar = '•';
            this.txbConfirmarSenhaCad.Size = new System.Drawing.Size(141, 21);
            this.txbConfirmarSenhaCad.TabIndex = 8;
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmSenha.Location = new System.Drawing.Point(2, 104);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(116, 16);
            this.lblConfirmSenha.TabIndex = 7;
            this.lblConfirmSenha.Text = "Confirmar Senha";
            // 
            // txbConfirmSenhaEdi
            // 
            this.txbConfirmSenhaEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmSenhaEdi.Location = new System.Drawing.Point(126, 112);
            this.txbConfirmSenhaEdi.Name = "txbConfirmSenhaEdi";
            this.txbConfirmSenhaEdi.PasswordChar = '•';
            this.txbConfirmSenhaEdi.Size = new System.Drawing.Size(141, 21);
            this.txbConfirmSenhaEdi.TabIndex = 10;
            // 
            // lblConfirmSenhaEdi
            // 
            this.lblConfirmSenhaEdi.AutoSize = true;
            this.lblConfirmSenhaEdi.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmSenhaEdi.Location = new System.Drawing.Point(6, 114);
            this.lblConfirmSenhaEdi.Name = "lblConfirmSenhaEdi";
            this.lblConfirmSenhaEdi.Size = new System.Drawing.Size(116, 16);
            this.lblConfirmSenhaEdi.TabIndex = 9;
            this.lblConfirmSenhaEdi.Text = "Confirmar Senha";
            // 
            // pibMostrar
            // 
            this.pibMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pibMostrar.Image")));
            this.pibMostrar.Location = new System.Drawing.Point(271, 77);
            this.pibMostrar.Name = "pibMostrar";
            this.pibMostrar.Size = new System.Drawing.Size(26, 21);
            this.pibMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibMostrar.TabIndex = 9;
            this.pibMostrar.TabStop = false;
            this.pibMostrar.Click += new System.EventHandler(this.pibMostrar_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.Location = new System.Drawing.Point(64, 130);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 16);
            this.lblAlerta.TabIndex = 10;
            this.lblAlerta.Visible = false;
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 641);
            this.Controls.Add(this.lblGerenciamento);
            this.Controls.Add(this.pibSair);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEdi;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblSenhaEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.Label lblGerenciamento;
        private System.Windows.Forms.TextBox txbConfirmarSenhaCad;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.TextBox txbConfirmSenhaEdi;
        private System.Windows.Forms.Label lblConfirmSenhaEdi;
        private System.Windows.Forms.PictureBox pibMostrar;
        private System.Windows.Forms.Label lblAlerta;
    }
}