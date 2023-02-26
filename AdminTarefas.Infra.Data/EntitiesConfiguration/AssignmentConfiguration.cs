using AdminTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AdminTarefas.Infra.Data.EntitiesConfiguration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {

            builder.HasKey(k => k.Id);
            builder.Property(p => p.AssignmentName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.AssignmentDescription).HasMaxLength(200).IsRequired();
            builder.Property(p=> p.AssignmentPriority).HasMaxLength(30).IsRequired();
            builder.Property(p => p.AssignmentBeginDate).IsRequired();
            builder.Property(p => p.AssignmentEndDate).IsRequired();
            builder.Property(p => p.Status);

            builder.HasOne(e => e.Emplooyer).WithMany(a => a.Assignments).HasForeignKey(e => e.EmplooyerId);
            builder.HasOne(c => c.Category).WithMany(a => a.Assignments).HasForeignKey(c => c.CategoryId);
        }
    }
}
