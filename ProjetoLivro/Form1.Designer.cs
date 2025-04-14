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
            this.btnFormCadastro = new System.Windows.Forms.Button();
            this.btnFormPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCadastro
            // 
            this.btnFormCadastro.Location = new System.Drawing.Point(316, 142);
            this.btnFormCadastro.Name = "btnFormCadastro";
            this.btnFormCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnFormCadastro.TabIndex = 0;
            this.btnFormCadastro.Text = "button1";
            this.btnFormCadastro.UseVisualStyleBackColor = true;
            this.btnFormCadastro.Click += new System.EventHandler(this.btnFormCadastro_Click);
            // 
            // btnFormPesquisar
            // 
            this.btnFormPesquisar.Location = new System.Drawing.Point(316, 188);
            this.btnFormPesquisar.Name = "btnFormPesquisar";
            this.btnFormPesquisar.Size = new System.Drawing.Size(143, 23);
            this.btnFormPesquisar.TabIndex = 1;
            this.btnFormPesquisar.Text = "Pesquisar Livro";
            this.btnFormPesquisar.UseVisualStyleBackColor = true;
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormCadastro;
        private System.Windows.Forms.Button btnFormPesquisar;
    }
}

