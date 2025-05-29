using Microsoft.EntityFrameworkCore;
using Web.MVC.Controllers;

namespace Web.MVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
