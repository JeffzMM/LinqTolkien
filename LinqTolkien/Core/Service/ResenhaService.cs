using LinqTolkien.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Core.Service
{
    public class ResenhaService
    {
        private readonly IResenhaRepository _resenhaRepository;

        public ResenhaService(IResenhaRepository resenhaRepository)
        {
            _resenhaRepository = resenhaRepository;
        }

        public IEnumerable<ResenhaAgrupada> GetResenhasAgrupadas()
        {
            var resenhas = _resenhaRepository.GetAll();

            var consulta = from resenha in resenhas
                           group resenha by new { resenha.Autor, resenha.Filme } into grupo
                           orderby grupo.Key.Autor, grupo.Key.Filme
                           select new ResenhaAgrupada
                           {
                               Autor = grupo.Key.Autor,
                               Filme = grupo.Key.Filme,
                               QuantidadeDeResenhas = grupo.Count(),
                               AvaliacaoMedia = grupo.Average(r => r.Avaliacao),
                               AvaliacaoTotal = grupo.Sum(r => r.Avaliacao)
                           };

            return consulta.ToList();
        }
    }

    public class ResenhaAgrupada
    {
        public string Autor { get; set; }
        public string Filme { get; set; }
        public int QuantidadeDeResenhas { get; set; }
        public double AvaliacaoMedia { get; set; }
        public int AvaliacaoTotal { get; set; }
    }
}
