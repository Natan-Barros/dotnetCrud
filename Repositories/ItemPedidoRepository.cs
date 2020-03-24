using System.Linq;
using CasaDoCodigo.Models;

namespace dotnetCrud.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int id)
        {
             return 
             dbSet
            .Where(ip => ip.Id == id)
            .FirstOrDefault();;
        }

        public void RemoveItemPedido(int id)
        {
            dbSet.Remove(GetItemPedido(id));
        }
    }

    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int id);
        void RemoveItemPedido(int id);
    }
}