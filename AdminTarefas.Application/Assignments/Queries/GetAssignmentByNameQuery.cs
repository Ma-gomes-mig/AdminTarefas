using AdminTarefas.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Assignments.Queries
{
    public class GetAssignmentByNameQuery : IRequest<Assignment>
    {
        public string AssignmentName { get; set; }
        public GetAssignmentByNameQuery(string name)
        {
            AssignmentName = name;
        }
    }
}
