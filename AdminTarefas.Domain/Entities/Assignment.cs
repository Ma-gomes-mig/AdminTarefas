using AdminTarefas.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Entities
{
    public sealed class Assignment : Base
    {
        //Com o "Private set" eu estou assegurando que o meu modelo de dominio está isolado "Encapsulamento"
        public string AssignmentName { get; private set; }
        public string AssignmentDescription { get; private set; }
        public string AssignmentPriority { get; private set; }
        public DateTime AssignmentBeginDate { get; private set; }
        public DateTime AssignmentEndDate { get; private set; }
        public bool Status { get; private set; }

        //Construtor vazio
        public Assignment()
        {
        }

        //Construtor para criar uma instancia de Emplooyer com todos os parâmetros
        public Assignment(int id, string name, string description, string priority, DateTime beginDate, DateTime endDate, bool status)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidadeNameDomain(name, description);
            AssignmentPriority = priority;
            AssignmentBeginDate = beginDate;
            AssignmentEndDate = endDate;
            Status = status;
        }
        //Construtor que está referenciado no AssignmentCreateCommandHandlers
        public Assignment(string name, string description, string priority, DateTime beginDate, DateTime endDate, bool status)
        {
            this.AssignmentName = name;
            this.AssignmentDescription = description;
            this.AssignmentPriority = priority;
            this.AssignmentBeginDate = beginDate;
            this.AssignmentEndDate = endDate;
            this.Status = status;
        }

        //Contrutor para Update Emplooyer
        public void Update(string name, string description, string priority, DateTime beginDate, DateTime endDate, bool status, int categoryId)
        {
            ValidadeNameDomain(name, description);            
            AssignmentPriority = priority;
            AssignmentBeginDate = beginDate;
            AssignmentEndDate = endDate;
            Status = status;
        }

        //Relacionamento com as tabelas Emplooyer/Category N Tasks 1 Employer/ 1 Category
        public int EmplooyerId { get; set; }
        public Emplooyer Emplooyer { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Validação de Tarefas
        private void ValidadeNameDomain(string name, string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, Too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid name, Name is required");

            DomainExceptionValidation.When(description.Length < 10, "Invalid name, Too short, minimum 3 characters");

            AssignmentName = name;
            AssignmentDescription = description;
        }

        
    }
}
