using CasaDoCodigo.Models;

namespace dotnetCrud.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }

    public interface IItemPedidoRepository
    {
    }
}