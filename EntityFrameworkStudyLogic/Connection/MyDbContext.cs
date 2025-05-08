using EntityFrameworkStudyLogic.Models;
using System.Data.Entity;

namespace EntityFrameworkStudyLogic.Connection
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(string connString) : base(connString) { }

        public DbSet<UsuarioRecord> Usuarios { get; set; }

    }
}
