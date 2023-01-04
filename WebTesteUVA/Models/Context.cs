using Microsoft.EntityFrameworkCore;

namespace WebTesteUVA.Models
{
    //Classe responsável por definir uma entidade User.
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
