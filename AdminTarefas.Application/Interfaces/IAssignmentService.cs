using AdminTarefas.Application.DTOs;
using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Interfaces
{
    public interface IAssignmentService
    {

        Task<IEnumerable<AssignmentDTO>> GetAssignmentAsync();
        //Task<AssignmentDTO> GetAssignmentByIdAsync(int? id);
        //Task<AssignmentDTO> GetAssignmentByNameAsync(string name);
        //Task<AssignmentDTO> GetAssignmentForEmplooyer(int? id);
        //Task Create(AssignmentDTO assignmentDto);
        //Task Update(AssignmentDTO assignmentDto);
        //Task Delete(int id);

    }
}
