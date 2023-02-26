using AdminTarefas.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Assignments.Commands
{
    public abstract class AssignmentCommand : IRequest<Assignment>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public int EmplooyerId { get; set; }
    }
}
