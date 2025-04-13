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
    public partial class FormCadastro : Form
    {
        public static List<Livro> livros;
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

        private void FormCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fechando toda a aplicação
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           

            Form1 form1 = new Form1(livros);
            form1.Show();
            Hide();
        }
    }
}
