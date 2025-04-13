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
    
    public partial class Form1 : Form
    {
        public List<Livro> livros = new List<Livro>();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Livro> l) {
            InitializeComponent();
             livros = l;
        }

        private void btnFormCadastro_Click(object sender, EventArgs e)
        {



            FormCadastro formcad = new FormCadastro(livros);
            formcad.Show();
            Hide();
        }
    }
}
