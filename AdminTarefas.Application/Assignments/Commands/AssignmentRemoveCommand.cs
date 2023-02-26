using AdminTarefas.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Assignments.Commands
{
    public class AssignmentRemoveCommand : IRequest<Assignment>
    {
        public int Id { get; set; }
        public AssignmentRemoveCommand(int id) 
        {
            Id = id;
        }
    }
}
