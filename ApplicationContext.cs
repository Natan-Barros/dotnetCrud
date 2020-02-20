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
        }
    }
}