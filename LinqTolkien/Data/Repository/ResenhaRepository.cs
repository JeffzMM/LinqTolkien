using LinqTolkien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Data.Repository
{
    public class ResenhaRepository : IResenhaRepository
    {
        private static readonly List<Resenha> Resenhas = new List<Resenha>
        {
            new Resenha { Id = 1, Autor = "J.R.R. Tolkien", Filme = "O Hobbit: Uma Jornada Inesperada", Avaliacao = 8 },
            new Resenha { Id = 2, Autor = "J.R.R. Tolkien", Filme = "O Hobbit: A Desolação de Smaug", Avaliacao = 7 },
            new Resenha { Id = 3, Autor = "J.R.R. Tolkien", Filme = "O Hobbit: A Batalha dos Cinco Exércitos", Avaliacao = 6 },
            new Resenha { Id = 4, Autor = "J.R.R. Tolkien", Filme = "O Senhor dos Anéis: A Sociedade do Anel", Avaliacao = 9 },
            new Resenha { Id = 5, Autor = "J.R.R. Tolkien", Filme = "O Senhor dos Anéis: As Duas Torres", Avaliacao = 10 },
            new Resenha { Id = 6, Autor = "J.R.R. Tolkien", Filme = "O Senhor dos Anéis: O Retorno do Rei", Avaliacao = 10 },
            new Resenha { Id = 7, Autor = "J.R.R. Tolkien", Filme = "O Silmarillion (filme que infelizmente não irá existir)", Avaliacao = 8 },
            new Resenha { Id = 9, Autor = "J.R.R. Tolkien", Filme = "O Hobbit: Uma Jornada Inesperada", Avaliacao = 8 },
            new Resenha { Id = 10, Autor = "J.R.R. Tolkien", Filme = "O Senhor dos Anéis: A Sociedade do Anel", Avaliacao = 9 }
        };

        public IEnumerable<Resenha> GetAll()
        {
            return Resenhas;
        }

        public Resenha GetById(int id)
        {
            return Resenhas.FirstOrDefault(r => r.Id == id);
        }
    }
}
