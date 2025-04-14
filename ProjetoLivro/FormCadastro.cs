using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoLivro
{
    public partial class FormCadastro : Form
    {
        public static List<Livro> livros ;
        public FormCadastro()
        {
            InitializeComponent();
        }
        public FormCadastro(List<Livro> l)
        {
            InitializeComponent();
            this.FormClosed += FormCadastro_FormClosed;
            livros = l;
        }

        public FormCadastro(List<Livro> l, Livro livro) {
            InitializeComponent();
            this.FormClosed += FormCadastro_FormClosed;
            livros = l;

            preencherCampos(livro);


        }

        private void FormCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fechando toda a aplicação
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!verificarVazio())
            {
                {
                    int id = (int)Convert.ToInt64(txtId.Text);
                    int pagina = (int)Convert.ToInt64(txtPagina.Text);
                    bool existe = false;
                    if (livros.Count > 0)
                    {
                        existe = livros.Any(l => l.ID == id);
                    }

                    if (existe)
                    {
                        MessageBox.Show("O ID do Livro já foi cadastrado");
                    }
                    else
                    {
                        Livro livro = new Livro(id, txtNome.Text, txtAutor.Text, pagina);
                        livros.Add(livro);

                        limpar();

                        MessageBox.Show("Cadastro Feito com Sucesso");
                    }
                }





                /**Form1 form1 = new Form1(livros);
                form1.Show();
                Hide();*/
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)){

                MessageBox.Show("Preencha o Campo ID para pesquisar");
            }
            else { 
                int id = (int)Convert.ToInt64(txtId.Text);
                Livro livro = livros.FirstOrDefault(l => l.ID == id);

                if (livro == null)
                {
                    MessageBox.Show("Nenhum livro encontrado com esse ID");
                }
                else {
                    MessageBox.Show($"Livro {livro.NomeLivro} encontrado ");
                    preencherCampos(livro);
                }
            }
        }

        private void preencherCampos(Livro livro) {

            txtId.Text = livro.ID.ToString();
            txtNome.Text = livro.NomeLivro;
            txtAutor.Text = livro.NomeAutor;
            txtPagina.Text = livro.Pagina.ToString();
        }

        private void pesquisar() { 
        
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!verificarVazio()) { 
                int id = (int) Convert.ToInt64(txtId.Text);
                Livro livro = livros.FirstOrDefault(l => l.ID == id);
                livro.NomeLivro = txtNome.Text;
                livro.NomeAutor = txtAutor.Text;
                livro.Pagina = (int)Convert.ToInt64(txtPagina.Text.ToString());
                limpar();
                MessageBox.Show($"Livro {livro.NomeLivro} alterado com sucesso");
            
            }

        }

        private bool verificarVazio() {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtAutor.Text) || string.IsNullOrWhiteSpace(txtPagina.Text))
            {
                MessageBox.Show("Digite Todos os campos");
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    txtId.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    txtNome.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtAutor.Text))
                {
                    txtAutor.Focus();
                }
                else
                {
                    txtPagina.Focus();
                }
                return true;
            }
            else {
                return false;
            }
        }

        private void limpar() {
            txtId.Clear();
            txtNome.Clear();
            txtAutor.Clear();
            txtPagina.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(livros);
            frm.Show();
            Hide();

        }
    }
}
