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
    public class AssignmentCreateCommandHandler : IRequestHandler<AssignmentCreateCommand, Assignment>
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public AssignmentCreateCommandHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }
        public async Task<Assignment> Handle(AssignmentCreateCommand request, CancellationToken cancellationToken)
        {
            var assignment = new Assignment(request.Name, request.Description, request.Priority,request.BeginDate, request.EndDate, request.Status);

            if (assignment == null)
            {
                throw new ApplicationException($"Error creating entity");
            }                
            else
            {
                assignment.CategoryId = request.CategoryId;
                return await _assignmentRepository.Create(assignment);
            }

        }
    }
}
