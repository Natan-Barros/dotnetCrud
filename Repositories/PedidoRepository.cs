using System;
using System.Linq;
using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace dotnetCrud.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        public PedidoRepository(ApplicationContext contexto,  IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
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


    }

    public interface IPedidoRepository
    {
        void AddItem(string codigo);
        Pedido GetPedido();
    }
}