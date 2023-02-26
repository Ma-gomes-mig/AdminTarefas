using AdminTarefas.Application.Assignments.Commands;
using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Assignments.Handlers
{
    public class AssignmentRemoveCommandHandler : IRequestHandler<AssignmentRemoveCommand, Assignment>
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public AssignmentRemoveCommandHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository ?? throw new ArgumentNullException(nameof(assignmentRepository));
        }
        public async Task<Assignment> Handle(AssignmentRemoveCommand request, CancellationToken cancellationToken)
        {
            var assignment = await _assignmentRepository.GetAssignmentByIdAsync(request.Id);
            
            if(assignment == null)
            {
                throw new ApplicationException($"Entity couldn't be found");
            }
            else
            {
                var result = await _assignmentRepository.Delete(assignment);
                return result;
            }
        }
    }
}
