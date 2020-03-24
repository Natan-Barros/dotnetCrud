using System;
using System.Linq;
using CasaDoCodigo.Models;
using dotnetCrud.Models;
using dotnetCrud.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace dotnetCrud.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IItemPedidoRepository itemPedidoRepository;
        public PedidoRepository(ApplicationContext contexto,  IHttpContextAccessor contextAccessor, 
        IItemPedidoRepository itemPedidoRepository) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public void AddItem(string codigo)
        {
           var produto = contexto.Set<Produto>()
                        .Where(p => p.Codigo == codigo)
                        .FirstOrDefault();

            if (produto == null) 
            {
                throw new ArgumentException("Produto não cadastrado");
            }

            var pedido = GetPedido();

            var itemPedido = contexto.Set<ItemPedido>()
                                     .Where(p => p.Produto.Codigo == codigo && p.Pedido.Id == pedido.Id)
                                     .SingleOrDefault();
                                     
            if(itemPedido == null) 
            {
                itemPedido = new ItemPedido(pedido, produto, 1, produto.Preco);
                contexto.Set<ItemPedido>().Add(itemPedido);
                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }
        }


        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet.Include(p => p.Itens)
                                 .ThenInclude(p => p.Produto)
                              .Where(p => p.Id == pedidoId).SingleOrDefault();

            if(pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                contexto.SaveChanges();
            }

            return pedido;
        }

        private int? GetPedidoId(){
          return contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId) {
            contextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
        public UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = itemPedidoRepository.GetItemPedido(itemPedido.Id);

            if (itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);
                
                if(itemPedidoDB.Quantidade == 0)
                {
                    itemPedidoRepository.RemoveItemPedido(itemPedido.Id);
                }
                contexto.SaveChanges();

                CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(GetPedido().Itens);
                return new UpdateQuantidadeResponse(itemPedidoDB, carrinhoViewModel);
            }

            throw new ArgumentException("Item Pedido não foi encontrado");
        }

    }

    public interface IPedidoRepository
    {
        void AddItem(string codigo);
        Pedido GetPedido();
        UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido);
    }
}