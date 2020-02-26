using CasaDoCodigo.Models;

namespace dotnetCrud.Repositories
{
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }

    public interface ICadastroRepository
    {
    }
}