using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro.Domain.Entities.Livro>
    {
        public LivroConfiguration()
        {
            Property(_ => _.Nome).IsRequired();
            Property(_ => _.NomeAutor).IsRequired();
        }
    }
}
