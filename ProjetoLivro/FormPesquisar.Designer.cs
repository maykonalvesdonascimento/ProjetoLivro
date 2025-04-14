namespace ProjetoLivro
{
    partial class FormPesquisar
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
            this.listLivros = new System.Windows.Forms.ListView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLivros
            // 
            this.listLivros.FullRowSelect = true;
            this.listLivros.HideSelection = false;
            this.listLivros.Location = new System.Drawing.Point(192, 167);
            this.listLivros.Name = "listLivros";
            this.listLivros.Size = new System.Drawing.Size(512, 229);
            this.listLivros.TabIndex = 0;
            this.listLivros.UseCompatibleStateImageBehavior = false;
            this.listLivros.View = System.Windows.Forms.View.Details;
            this.listLivros.SelectedIndexChanged += new System.EventHandler(this.listLivros_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(592, 37);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(175, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar Para Tela Inicial";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(192, 136);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(205, 21);
            this.txtNomeLivro.TabIndex = 2;
            this.txtNomeLivro.TextChanged += new System.EventHandler(this.txtNomeLivro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Livro";
            // 
            // FormPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLivro.Properties.Resources.backgroundpesquisar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listLivros);
            this.Name = "FormPesquisar";
            this.Text = "FormPesquisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listLivros;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label1;
    }
}