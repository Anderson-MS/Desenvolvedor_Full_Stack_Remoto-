using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi_Candidatos.Models
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> GetAll();
        Produto Get(int id);
        Produto Add(Produto item);
        void Remove(int id);
        bool Update(Produto item);
    }
}