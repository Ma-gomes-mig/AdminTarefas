using AdminTarefas.Domain.Entities;
using AdminTarefas.Infra.Data.EntitiesConfiguration;
using AdminTarefas.Infra.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Category> Category { get; set; }   
        public DbSet<Emplooyer> Employeer { get; set; }
        public DbSet<Assignment> Assignment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //Usar o builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            //Ou

            //builder.ApplyConfiguration(new CategoryConfiguration());
            //builder.ApplyConfiguration(new AssignmentConfiguration());
            //builder.ApplyConfiguration(new EmplooyerConfiguration());            

            //ApplyConfigurationsFromAssembly: Quando fizer a configuração em um arquivo separado (EntitiesConfiguration) e usar o
            //"ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext)" ele vai vasculhar o arquivo de contexto,
            //vai verificar as entidades e como na pasta "EntitiesConfiguration" as classes herdam da interface "IEntityTypeConfiguration"
            // ele vai ver que as configurações foram definidas.
        }
    }
}
