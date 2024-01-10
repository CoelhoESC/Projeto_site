using Microsoft.EntityFrameworkCore;
using Projeto_site.Models;

namespace Projeto_site.Database
{
    public class Db_Context: DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> op): base(op)
        {  
        }
        public DbSet<Cadastro> cadastros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cadastro>()
                .HasKey(i => i.id);


            base.OnModelCreating(modelBuilder);
        }

    }
}
