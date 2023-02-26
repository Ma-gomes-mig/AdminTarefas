using AdminTarefas.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Assignments.Queries
{
    public class GetAssignmentByIdQuery : IRequest<Assignment>
    {
        public int Id { get; set; }
        public GetAssignmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
