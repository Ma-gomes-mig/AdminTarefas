using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminTarefas.Domain.Entities;
using Task = AdminTarefas.Domain.Entities.Assignment;

namespace AdminTarefas.Domain.Teste
{
    public class AssignmentUnitTest
    {
        //Lembrar de mudar o nome de Task para Assignment nos testes!!!

        //[Fact]
        //public void CreateTask_WithValidParameters_ResultObjectValidState()
        //{
        //    Action action = () => new Task(1, "Name Task", "description Task", "Task Priority", 2020 / 02 / 03 00:00:00, true);
        //    action.Should()
        //        .NotThrow<AdminTarefas.Domain.Validation.DomainExceptionValidation>();
        //}

        //[Fact]
        //public void CreateTask_NegativeIdValue_DomainExceptionInvalidId()
        //{
        //    Action action = () => new Task(-1, "Name Task", "description Task", "Task Priority", 2020 / 02 / 03 00:00:00,2020/03/04 00:00:00, true);
        //    action.Should()
        //        .Throw<AdminTarefas.Domain.Validation.DomainExceptionValidation>()
        //        .WithMessage("Invalid Id");
        //}

        //[Fact]
        //public void CreateTask_ShortNameValue_DomainExceptionShortName()
        //{
        //    Action action = () => new Task(-1, "Name Task", "description Task", "Task Priority", 2020 / 02 / 03 00:00:00,2020 / 03 / 04 00:00:00, true);
        //    action.Should()
        //        .Throw<AdminTarefas.Domain.Validation.DomainExceptionValidation>()
        //        .WithMessage("Invalid name, Too short, minimum 3 characters");
        //}
    }
}
