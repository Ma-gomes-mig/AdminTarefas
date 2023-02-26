using AdminTarefas.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Entities
{
    public sealed class Category : Base
    {
        //Com o "Private set" eu estou assegurando que o meu modelo de dominio está isolado
        public string CategoryName { get; private set; }

        public Category() { }

        public Category(string name)
        {
            ValidadeDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id");
            ValidadeDomain(name);

        }

        public void Update(string name)
        {
            ValidadeDomain(name);
        }
        //Relacionamento com a tabela Task 1 Category N Tasks
        public ICollection<Assignment> Assignments { get; set; }

        private void ValidadeDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name, Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, Too short, minimum 3 characters");

            CategoryName = name;
        }

    }
}
