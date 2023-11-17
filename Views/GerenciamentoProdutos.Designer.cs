namespace PadariaForms.Views
{
    partial class GerenciamentoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblCategoriaEdi = new System.Windows.Forms.Label();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaEdi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(156, 81);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(611, 272);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(290, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCad);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPrecoCad);
            this.grbCadastrar.Controls.Add(this.txbNomeCad);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblPrecoCad);
            this.grbCadastrar.Controls.Add(this.lblNomeCad);
            this.grbCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.ForeColor = System.Drawing.Color.Crimson;
            this.grbCadastrar.Location = new System.Drawing.Point(63, 374);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(366, 190);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.ForeColor = System.Drawing.Color.Black;
            this.lblCategoriaCad.Location = new System.Drawing.Point(14, 93);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(73, 16);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.ForeColor = System.Drawing.Color.Black;
            this.lblPrecoCad.Location = new System.Drawing.Point(30, 63);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(43, 16);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCad.Location = new System.Drawing.Point(30, 31);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(45, 16);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(93, 28);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(204, 21);
            this.txbNomeCad.TabIndex = 4;
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoCad.Location = new System.Drawing.Point(93, 58);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(158, 21);
            this.txbPrecoCad.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(345, 25);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblCategoriaEdi);
            this.grbEditar.Controls.Add(this.lblPrecoEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.ForeColor = System.Drawing.Color.Crimson;
            this.grbEditar.Location = new System.Drawing.Point(524, 374);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(355, 190);
            this.grbEditar.TabIndex = 9;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(6, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(337, 27);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbPrecoEdi
            // 
            this.txbPrecoEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEdi.Location = new System.Drawing.Point(106, 61);
            this.txbPrecoEdi.Name = "txbPrecoEdi";
            this.txbPrecoEdi.Size = new System.Drawing.Size(160, 21);
            this.txbPrecoEdi.TabIndex = 5;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdi.Location = new System.Drawing.Point(106, 31);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(203, 21);
            this.txbNomeEdi.TabIndex = 4;
            // 
            // lblCategoriaEdi
            // 
            this.lblCategoriaEdi.AutoSize = true;
            this.lblCategoriaEdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEdi.ForeColor = System.Drawing.Color.Black;
            this.lblCategoriaEdi.Location = new System.Drawing.Point(27, 95);
            this.lblCategoriaEdi.Name = "lblCategoriaEdi";
            this.lblCategoriaEdi.Size = new System.Drawing.Size(73, 16);
            this.lblCategoriaEdi.TabIndex = 2;
            this.lblCategoriaEdi.Text = "Categoria";
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEdi.ForeColor = System.Drawing.Color.Black;
            this.lblPrecoEdi.Location = new System.Drawing.Point(41, 63);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(43, 16);
            this.lblPrecoEdi.TabIndex = 1;
            this.lblPrecoEdi.Text = "Preço";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdi.ForeColor = System.Drawing.Color.Black;
            this.lblNomeEdi.Location = new System.Drawing.Point(41, 33);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(45, 16);
            this.lblNomeEdi.TabIndex = 0;
            this.lblNomeEdi.Text = "Nome";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblAlerta);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.ForeColor = System.Drawing.Color.Crimson;
            this.grbApagar.Location = new System.Drawing.Point(195, 587);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(588, 83);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(396, 33);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(144, 33);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.Black;
            this.lblAlerta.Location = new System.Drawing.Point(51, 41);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(305, 18);
            this.lblAlerta.TabIndex = 1;
            this.lblAlerta.Text = "Selecione o produto que deseja apagar";
            // 
            // pibSair
            // 
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(890, 39);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(35, 35);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 11;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(93, 91);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(158, 23);
            this.cmbCategoriaCad.TabIndex = 9;
            // 
            // cmbCategoriaEdi
            // 
            this.cmbCategoriaEdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEdi.FormattingEnabled = true;
            this.cmbCategoriaEdi.Location = new System.Drawing.Point(106, 93);
            this.cmbCategoriaEdi.Name = "cmbCategoriaEdi";
            this.cmbCategoriaEdi.Size = new System.Drawing.Size(160, 23);
            this.cmbCategoriaEdi.TabIndex = 10;
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 726);
            this.Controls.Add(this.pibSair);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblCategoriaEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.ComboBox cmbCategoriaEdi;
    }
}