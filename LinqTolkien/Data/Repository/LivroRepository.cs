using LinqTolkien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Data.Repository
{
    public class LivroRepository : ILivroRepository
    {
        // Dados fictícios
        private static readonly List<Livro> Livros = new List<Livro>
        {
            new Livro { Id = 1, Titulo = "O Hobbit", Autor = "J.R.R. Tolkien" },
            new Livro { Id = 2, Titulo = "O Senhor dos Anéis: A Sociedade do Anel", Autor = "J.R.R. Tolkien" },
            new Livro { Id = 3, Titulo = "O Senhor dos Anéis: As Duas Torres", Autor = "J.R.R. Tolkien" },
            new Livro { Id = 4, Titulo = "O Senhor dos Anéis: O Retorno do Rei", Autor = "J.R.R. Tolkien" },
            new Livro { Id = 5, Titulo = "O Silmarillion", Autor = "J.R.R. Tolkien" }
        };

        public IEnumerable<Livro> GetAll()
        {
            return Livros;
        }

        public Livro GetById(int id)
        {
            return Livros.FirstOrDefault(l => l.Id == id);
        }
    }
}
