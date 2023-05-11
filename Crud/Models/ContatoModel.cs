using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class ContatoModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
