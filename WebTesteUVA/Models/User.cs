using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTesteUVA.Models
{
    [DisplayName("Usuário")]
    [Table("User")]
    //Classe responsável por representar um usuário.
    public class User
    {
        [Column("Id")]
        public int Id { get; set; }
        [DisplayName("Nome")]
        [Column("FullName")]
        public string FullName { get; set; }
        [DisplayName("Telefone")]
        [Column("Telephone")]
        public string Telephone { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [DisplayName("Criado em")]
        [Column("CreatedAt")]
        public string CreatedAt { get; set; }

        [DisplayName("Ativo")]
        [Column("Active")]
        public Boolean Active { get; set; }
    }
}
