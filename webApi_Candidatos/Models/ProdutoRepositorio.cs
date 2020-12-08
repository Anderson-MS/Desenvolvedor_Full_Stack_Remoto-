using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi_Candidatos.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Luana Damasco", Email = "Luana@gmail", Idade = "29", Urllinkedin = "www.linkedin.com.br", Categoria = "C#" });

            Add(new Produto { Nome = "Bruno Couto", Email = "Bruno@gmail", Idade = "30", Urllinkedin = "www.linkedin.com.br", Categoria = "  Javascript  " });

            Add(new Produto { Nome = "Flavia bernades", Email = "Flavia@gmail", Idade = "31", Urllinkedin = "www.linkedin.com.br", Categoria = "Nodejs " });

            Add(new Produto { Nome = "Joao francisco", Email = "Joao@gmail", Idade = "28", Urllinkedin = "www.linkedin.com.br", Categoria = " Angular " });

            Add(new Produto { Nome = "Luana Damasco", Email = "Luana@gmail", Idade = "29", Urllinkedin = "www.linkedin.com.br", Categoria = "React " });

            Add(new Produto { Nome = "Bruno Couto", Email = "Bruno@gmail", Idade = "30", Urllinkedin = "www.linkedin.com.br", Categoria = "Ionic   " });

            Add(new Produto { Nome = "Flavia bernades", Email = "Flavia@gmail", Idade = "31", Urllinkedin = "www.linkedin.com.br", Categoria = "Mensageria" });

            Add(new Produto { Nome = "Joao francisco", Email = "Joao@gmail", Idade = "28", Urllinkedin = "www.linkedin.com.br", Categoria = " PHP " });

            Add(new Produto { Nome = "Bruno Couto", Email = "Bruno@gmail", Idade = "30", Urllinkedin = "www.linkedin.com.br", Categoria = " Laravel" });
        }

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = produtos.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}