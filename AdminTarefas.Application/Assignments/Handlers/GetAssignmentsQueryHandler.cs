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
    public class GetAssignmentsQueryHandler : IRequestHandler<GetAssignmentsQuery, IEnumerable<Assignment>>  
    {
        private readonly IAssignmentRepository _assignmentRepository;
        public GetAssignmentsQueryHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task<IEnumerable<Assignment>> Handle(GetAssignmentsQuery request, CancellationToken cancellationToken)
        {
            return await _assignmentRepository.GetAssignmentAsync();
        }

        
    }
}
