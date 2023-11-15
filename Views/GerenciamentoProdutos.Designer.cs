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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblRespCad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(155, 67);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(632, 283);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(288, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.lblRespCad);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblPrecoCad);
            this.grbCadastrar.Controls.Add(this.lblNomeCad);
            this.grbCadastrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.ForeColor = System.Drawing.Color.Crimson;
            this.grbCadastrar.Location = new System.Drawing.Point(46, 387);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(417, 161);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(7, 35);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(53, 18);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(7, 61);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(51, 18);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.Location = new System.Drawing.Point(7, 87);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(83, 18);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria";
            // 
            // lblRespCad
            // 
            this.lblRespCad.AutoSize = true;
            this.lblRespCad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespCad.Location = new System.Drawing.Point(7, 117);
            this.lblRespCad.Name = "lblRespCad";
            this.lblRespCad.Size = new System.Drawing.Size(100, 18);
            this.lblRespCad.TabIndex = 3;
            this.lblRespCad.Text = "Responsável";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 672);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GerenciamentoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblRespCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
    }
}