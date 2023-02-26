using AdminTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AdminTarefas.Infra.Data.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CategoryName).HasMaxLength(100).IsRequired();

            //Incluir dados a tabela Category
            //builder.HasData(
            //    new Category(1, "Setor Rh"),
            //    new Category(2, "Setor Informatica"),
            //    new Category(3, "Setor Administrativo"));


        }
    }
}
