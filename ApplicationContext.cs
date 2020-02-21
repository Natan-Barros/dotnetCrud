using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCrud
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
            modelBuilder.Entity<Produto>().HasKey(t => t.Id);

                        modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
                        modelBuilder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido).HasForeignKey(pt => pt.PedidoId);;
                        modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).IsRequired();

                        modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
                        modelBuilder.Entity<ItemPedido>().HasOne(t => t.Pedido);
                        modelBuilder.Entity<ItemPedido>().HasOne(t => t.Produto);

                        modelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
                        modelBuilder.Entity<Cadastro>().HasOne(t => t.Pedido);
        }
    }
}