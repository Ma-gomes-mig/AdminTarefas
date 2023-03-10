using AdminTarefas.Application.Assignments.Queries;
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
    public class GetAssignmentByNameQueryHandler : IRequestHandler<GetAssignmentByNameQuery, Assignment>
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public GetAssignmentByNameQueryHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task<Assignment> Handle(GetAssignmentByNameQuery request, CancellationToken cancellationToken)
        {
            return await _assignmentRepository.GetAssignmentByNameAsync(request.AssignmentName);
        }

      
    }
}
