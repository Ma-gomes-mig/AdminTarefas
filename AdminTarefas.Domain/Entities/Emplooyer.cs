using AdminTarefas.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Entities
{
    public sealed class Emplooyer : Base
    {
        //Com o "Private set" eu estou assegurando que o meu modelo de dominio está isolado
        public string EmpName { get; private set; }
        public string EmpRole { get; private set; }
        public string EmpImage { get; private set; }

        public Emplooyer()
        {           
        }

        public Emplooyer(int id, string name, string role, string image) 
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidateDomain(name, role);            
            EmpImage = image;
        }

        public void Update(string name, string role, string image)
        {
            ValidateDomain(name, role);            
            EmpImage = image;
        }

        //Relacionamento com a tabela Task (1 Emplooyer N Tasks)
        public ICollection<Assignment> Assignments { get; set; }

        private void ValidateDomain(string name, string role)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, Too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(role), "Invalid, role is required");

            DomainExceptionValidation.When(EmpImage?.Length > 250, "Invalid image name, too long, maximum 250 characters");

            EmpName = name;
            EmpRole = role;
        }

        
    }
}
