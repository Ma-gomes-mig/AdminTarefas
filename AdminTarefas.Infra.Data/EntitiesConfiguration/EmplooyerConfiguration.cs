using AdminTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AdminTarefas.Infra.Data.EntityConfiguration
{
    public class EmplooyerConfiguration : IEntityTypeConfiguration<Emplooyer>
    {        
        public void Configure(EntityTypeBuilder<Emplooyer> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.EmpName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.EmpRole).HasMaxLength(50).IsRequired();
        }
    }
}
