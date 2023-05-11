using Crud.Models;

namespace Crud.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
