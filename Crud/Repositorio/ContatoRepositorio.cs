using Crud.Data;
using Crud.Models;

namespace Crud.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio

    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
             _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.ContatoModels.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

    }
    
}
