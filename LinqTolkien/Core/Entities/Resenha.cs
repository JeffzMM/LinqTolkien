using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Core.Entities
{
    public class Resenha
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Filme { get; set; }
        public int Avaliacao { get; set; }
    }
}
