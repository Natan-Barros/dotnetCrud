using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCrud.Repositories
{


    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
           return dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var produto in livros)
            {
                if(!dbSet.Where(p => p.Codigo == produto.Codigo).Any())
                  dbSet.Add(new Produto(produto.Codigo, produto.Nome, produto.Preco));
            }

            contexto.SaveChanges();
        }

    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
}