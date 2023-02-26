using AdminTarefas.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Interfaces
{
    public interface IEmplooyerService
    {
        Task<IEnumerable<EmplooyerDTO>> GetEmplooyers();
        Task<EmplooyerDTO> GetEmplooyerById(int id);
        Task Add(EmplooyerDTO emplooyerDTO);
        Task Update(EmplooyerDTO emplooyer);
        Task Delete(int id);
    }
}
