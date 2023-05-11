using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> ContatoModels { get; set; }

    }
}
