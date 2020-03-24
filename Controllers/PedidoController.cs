using CasaDoCodigo.Models;
using dotnetCrud;
using dotnetCrud.Models;
using dotnetCrud.Models.ViewModels;
using dotnetCrud.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;

        private readonly IItemPedidoRepository itemPedidoRepository;
        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Carrossel()
        { 
            List<Produto> aux = new List<Produto>();
            return View(produtoRepository.GetProdutos());
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }

            Pedido pedido = pedidoRepository.GetPedido();
            var carrinhoViewModel = new CarrinhoViewModel(pedido.Itens);
            return View(carrinhoViewModel);
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();

            return View(pedido);
        }

        [HttpPost]
        public UpdateQuantidadeResponse UpdateQuantidade([FromBody]ItemPedido item) 
        {
            return pedidoRepository.UpdateQuantidade(item);
        }
    }
}
