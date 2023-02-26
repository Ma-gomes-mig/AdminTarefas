using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using AdminTarefas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace AdminTarefas.Infra.Data.Repositories
{
    public class EmplooyerRepository : IEmplooyerRepository
    {
        ApplicationDbContext _emplooyerContext;
        public EmplooyerRepository(ApplicationDbContext context)
        {
            _emplooyerContext = context;
        }

        public async Task<IEnumerable<Emplooyer>> GetEmplooyersAsync()
        {
            return await _emplooyerContext.Employeer.ToListAsync();
        }

        public async Task<Emplooyer> GetEmplooyerByIdAsync(int id)
        {
            return await _emplooyerContext.Employeer.FindAsync(id);
        }

        public async Task<Emplooyer> GetEmplooyerByNameAsync(string name)
        {
            return await _emplooyerContext.Employeer.FindAsync(name);
        }

        public async Task<Emplooyer> Create(Emplooyer emplooyer)
        {
            _emplooyerContext.Employeer.Add(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;

        }

        public async Task<Emplooyer> Update(Emplooyer emplooyer)
        {
            _emplooyerContext.Employeer.Update(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }

        public async Task<Emplooyer> Delete(Emplooyer emplooyer)
        {
            _emplooyerContext.Employeer.Remove(emplooyer);
            await _emplooyerContext.SaveChangesAsync();
            return emplooyer;
        }
                
    }
}
