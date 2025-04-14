using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivro
{
    public partial class FormPesquisar : Form
    {
        public List<Livro> livros;
        public FormPesquisar()
        {
            InitializeComponent();
        }
        public FormPesquisar(List<Livro> l)
        {
            this.FormClosed += FormPesquisar_FormClosed;
            InitializeComponent();
            livros = l;

            listLivros.Columns.Add("ID",50);
            listLivros.Columns.Add("Titulo", 200);
            listLivros.Columns.Add("Autor", 100);
            listLivros.Columns.Add("Páginas", 100);

            preencherListViewLivros(livros);
            
        }
        private void FormPesquisar_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fechando toda a aplicação
            Application.Exit();
        }

        private void txtNomeLivro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLivro.Text.ToLower();

            var livrosFiltrados = livros
                .Where(livro => livro.NomeLivro.ToLower().Contains(filtro))
                .ToList();

            listLivros.Items.Clear();
            preencherListViewLivros(livrosFiltrados);


        }

        private void preencherListViewLivros(List<Livro> la) {
           
            foreach (var livro in la)

            {
               
                ListViewItem item = new ListViewItem(livro.ID.ToString());
                item.SubItems.Add(livro.NomeLivro);
                item.SubItems.Add(livro.NomeAutor);
                item.SubItems.Add(livro.Pagina.ToString());
                listLivros.Items.Add(item);

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(livros);
            frm.Show();
            Hide();
        }
    }
}
