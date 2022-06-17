using ApiCatalago.Models;

namespace ApiCatalago.Repository
{
    public interface ICategoriaRepository: IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriaProdutos();
    }
}
