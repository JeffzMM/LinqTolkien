using LinqTolkien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTolkien.Data.Repository
{
    public interface IResenhaRepository
    {
        IEnumerable<Resenha> GetAll();
        Resenha GetById(int id);
    }
}
