//using AdminTarefas.Application.Interfaces;
//using AdminTarefas.Application.Mappings;
//using AdminTarefas.Application.Services;
//using AdminTarefas.Domain.Interfaces;
//using AdminTarefas.Infra.Data.Context;
//using AdminTarefas.Infra.Data.Repositories;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
using AdminTarefas.Application.Interfaces; 
using AdminTarefas.Application.Mappings;
using AdminTarefas.Application.Services;
using AdminTarefas.Domain.Interfaces;
using AdminTarefas.Infra.Data.Context;
using AdminTarefas.Infra.Data.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AdminTarefas.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
             b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            //Registrando o Repository
            services.AddScoped<ICategoryRepository, CategoryRepository>();  
            services.AddScoped<IEmplooyerRepository, EmplooyerRepository>();
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();

            //Registrando o Service
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IEmplooyerService, EmplooyerService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            //Registrando o AutoMapper
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("AdminTarefas.Application");
            services.AddMediatR(myhandlers);

            return services;
        }
    }
}
