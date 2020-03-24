class Carrinho{

        clickIncremento(btn) {
            let dados = this.getData(btn);  
            dados.Quantidade++;
            this.postQuantidade(dados);
        }

        clickDecremento(btn) {
            let dados = this.getData(btn);  
            dados.Quantidade--;
            this.postQuantidade(dados);
        }

        updateQuantidade(input) {
            let data = this.getData(input);
            this.postQuantidade(data);
        }

        getData(elemento) {
            var linhaDoItem = $(elemento).parents('[item-id]');
            var itemId = $(linhaDoItem).attr("item-id");
            var novaQtde = $(linhaDoItem).find('input').val();
            
            return {
                Id : itemId,
                Quantidade : novaQtde
            }
        }

        postQuantidade(data) {
            $.ajax({
                url : "/pedido/updatequantidade",
                type : "POST",
                contentType : "application/json",
                data : JSON.stringify(data)
            }).done(function(response){
               let itemPedido = response.itemPedido;
               let linhaDoItem = $('[item-id = ' + itemPedido.id + ']');
               linhaDoItem.find('input').val(itemPedido.quantidade);
               linhaDoItem.find('[subtotal]').html(itemPedido.subtotal .duasCasas());
               let carrinhoViewModel = response.carrinhoViewModel;
              
               $('[numero-itens]').html('Total: ' + carrinhoViewModel.itens.length + ' itens');
               $('[total]').html((carrinhoViewModel.total).duasCasas());

                if (itemPedido.quantidade == 0) {
                   linhaDoItem.remove();
                }
              
                debugger;
            });
        }
}

Number.prototype.duasCasas = function() {
    return this.toFixed(2).replace('.',',');
}
var carrinho = new Carrinho();