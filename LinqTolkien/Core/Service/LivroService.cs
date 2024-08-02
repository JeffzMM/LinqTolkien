using LinqTolkien.Core.Entities;
using LinqTolkien.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Core.Service
{
    public class LivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> GetAllLivros()
        {
            return _livroRepository.GetAll();
        }
    }
}
