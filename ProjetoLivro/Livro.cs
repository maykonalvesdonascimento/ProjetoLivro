using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    public class Livro
    {
        private int Id { get; set; }
        private string NomeLivro { get; set; }
        private string NomeAutor { get; set; }
        private int Pagina { get; set; }
        public Livro() { 
        

        }
        public Livro(int id , string nomeLivro, string nomeAutor, int pagina)
        {
            Id = id;
            NomeLivro = nomeLivro;
            NomeAutor = nomeAutor;
            Pagina = pagina;
        }




    }
}
