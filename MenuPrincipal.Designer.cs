﻿namespace PadariaForms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.pibSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Crimson;
            this.lblMenu.Location = new System.Drawing.Point(236, 84);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(329, 41);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "| Menu Principal |";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComandas
            // 
            this.btnComandas.BackColor = System.Drawing.Color.LightPink;
            this.btnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComandas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.Location = new System.Drawing.Point(159, 199);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(468, 31);
            this.btnComandas.TabIndex = 1;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = false;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.LightPink;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(159, 236);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(468, 34);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.LightPink;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaixa.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(159, 276);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(468, 34);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.LightPink;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(159, 316);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(468, 38);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.Location = new System.Drawing.Point(283, 146);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(0, 30);
            this.lblSaudacao.TabIndex = 5;
            this.lblSaudacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pibSair
            // 
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.InitialImage = null;
            this.pibSair.Location = new System.Drawing.Point(737, 34);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(43, 46);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 6;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 457);
            this.Controls.Add(this.pibSair);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.PictureBox pibSair;
    }
}