using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    public class Livro
    {
        private int id;
        private string nomeLivro;
        private string nomeAutor;
        private int pagina;
        public Livro() { 
        

        }
        public Livro(int ID , string NomeLivro, string NomeAutor, int Pagina)
        {
            id = ID;
            nomeLivro = NomeLivro;  
            nomeAutor = NomeAutor;
            pagina = Pagina;
        }

        public int ID
        {
            get { return id; } // Retorna o valor do atributo privado 'id'
            set
            {
                if (value > 0) // Validação para garantir que o ID seja positivo
                    id = value;
                else
                    throw new ArgumentException("O ID deve ser maior que zero.");
            }
        }

        public string NomeLivro {
            get { return nomeLivro; }
            set {
                nomeLivro = value;
            }
        
        }

        public string NomeAutor
        {
            get { return nomeAutor; }
            set { 
                nomeAutor = value;
            }
        
        }

        public int Pagina { 
            get { return pagina; }
            set { pagina = value; }
        }




    }
}
