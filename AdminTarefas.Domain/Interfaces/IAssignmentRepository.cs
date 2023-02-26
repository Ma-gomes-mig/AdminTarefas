using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Interfaces
{
    public interface IAssignmentRepository
    {
        Task<IEnumerable<Assignment>> GetAssignmentAsync();
        Task<Assignment> GetAssignmentByIdAsync(int? id);
        Task<Assignment> GetAssignmentByNameAsync(string name);

        //Task<IEnumerable<Assignment>> GetPeriodAsync(DateTime beginDate, DateTime endDate);
        //Task<IEnumerable<Assignment>> GetStatusAsync(bool status);
        Task<Assignment> GetAssignmentForEmplooyer(int? id);

        Task<Assignment> Create(Assignment assignment);
        Task<Assignment> Update(Assignment assignment);
        Task<Assignment> Delete(Assignment assignment);
    }
}
