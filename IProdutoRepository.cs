using System.Collections.Generic;
using CasaDoCodigo.Models;
using dotnetCrud.Repositories;

namespace dotnetCrud
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}