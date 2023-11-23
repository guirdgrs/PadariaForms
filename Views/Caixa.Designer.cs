namespace PadariaForms.Views
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.txbNumComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // pibSair
            // 
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(716, 32);
            this.pibSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(41, 43);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 13;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(12, 112);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(760, 273);
            this.dgvComandas.TabIndex = 14;
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(134, 62);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(250, 25);
            this.lblNumeroComanda.TabIndex = 15;
            this.lblNumeroComanda.Text = "Número da Comanda: ";
            // 
            // txbNumComanda
            // 
            this.txbNumComanda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumComanda.Location = new System.Drawing.Point(390, 59);
            this.txbNumComanda.Name = "txbNumComanda";
            this.txbNumComanda.Size = new System.Drawing.Size(100, 33);
            this.txbNumComanda.TabIndex = 16;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(496, 59);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(127, 33);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(459, 430);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(258, 28);
            this.chbPagamento.TabIndex = 18;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(92, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 36);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: ";
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarComanda.Location = new System.Drawing.Point(423, 475);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(319, 34);
            this.btnEncerrarComanda.TabIndex = 20;
            this.btnEncerrarComanda.Text = "Encerrar Comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = false;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbNumComanda);
            this.Controls.Add(this.lblNumeroComanda);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.pibSair);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.TextBox txbNumComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEncerrarComanda;
    }
}