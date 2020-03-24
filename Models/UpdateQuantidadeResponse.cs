using CasaDoCodigo.Models;
using dotnetCrud.Models.ViewModels;

namespace dotnetCrud.Models
{
    public class UpdateQuantidadeResponse
    {

        public ItemPedido ItemPedido { get;}
        public CarrinhoViewModel CarrinhoViewModel {get;}
        
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }
    }
}