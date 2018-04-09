using Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Infra.Data.Context
{
    public class ProjetoLivroContext : DbContext
    {
        public ProjetoLivroContext()
            :base("ProjetoLivro")
        {

        }

        public DbSet<Livro.Domain.Entities.Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties()
                .Where(_ => _.Name == _.ReflectedType.Name + "Id")
                .Configure(_ => _.IsKey());

            modelBuilder.Properties<string>()
                .Configure(_ => _.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(_ => _.HasMaxLength(50));

            modelBuilder.Configurations.Add(new LivroConfiguration());
        }
    }
}
