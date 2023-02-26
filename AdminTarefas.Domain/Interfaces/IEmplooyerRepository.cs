using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Interfaces
{
    public interface IEmplooyerRepository
    {
        Task<IEnumerable<Emplooyer>> GetEmplooyersAsync();
        Task<Emplooyer> GetEmplooyerByIdAsync(int id);
        Task<Emplooyer> GetEmplooyerByNameAsync(string name);
        Task<Emplooyer> Create(Emplooyer emplooyer);
        Task<Emplooyer> Update(Emplooyer emplooyer);
        Task<Emplooyer> Delete(Emplooyer emplooyer);
    }
}
