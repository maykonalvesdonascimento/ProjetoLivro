namespace ProjetoLivro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFormCadastro = new System.Windows.Forms.Button();
            this.btnFormPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCadastro
            // 
            this.btnFormCadastro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFormCadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFormCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFormCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnFormCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormCadastro.Location = new System.Drawing.Point(316, 142);
            this.btnFormCadastro.Name = "btnFormCadastro";
            this.btnFormCadastro.Size = new System.Drawing.Size(143, 23);
            this.btnFormCadastro.TabIndex = 0;
            this.btnFormCadastro.Text = "Cadastrar Livro";
            this.btnFormCadastro.UseVisualStyleBackColor = false;
            this.btnFormCadastro.Click += new System.EventHandler(this.btnFormCadastro_Click);
            // 
            // btnFormPesquisar
            // 
            this.btnFormPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFormPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFormPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFormPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnFormPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPesquisar.Location = new System.Drawing.Point(316, 188);
            this.btnFormPesquisar.Name = "btnFormPesquisar";
            this.btnFormPesquisar.Size = new System.Drawing.Size(143, 23);
            this.btnFormPesquisar.TabIndex = 1;
            this.btnFormPesquisar.Text = "Pesquisar Livro";
            this.btnFormPesquisar.UseVisualStyleBackColor = false;
            this.btnFormPesquisar.Click += new System.EventHandler(this.btnFormPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLivro.Properties.Resources.backgroundbook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormPesquisar);
            this.Controls.Add(this.btnFormCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projeto Livro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormCadastro;
        private System.Windows.Forms.Button btnFormPesquisar;
    }
}

