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
    public class AssignmentUpdateCommandHandler : IRequestHandler<AssignmentUpdateCommand, Assignment>
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public AssignmentUpdateCommandHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository ?? throw new ArgumentNullException(nameof(assignmentRepository));
        }        

        public async Task<Assignment> Handle(AssignmentUpdateCommand request, CancellationToken cancellationToken)
        {
            var assignment = await _assignmentRepository.GetAssignmentByIdAsync(request.Id);

            if(assignment == null)
            {
                throw new ApplicationException($"Entity couldn't be found");
            }
            else
            {
                assignment.Update(request.Name, request.Description, request.Priority, request.BeginDate, request.EndDate, request.Status, request.CategoryId);
                return await _assignmentRepository.Update(assignment);  
            }
        }
    }
}
