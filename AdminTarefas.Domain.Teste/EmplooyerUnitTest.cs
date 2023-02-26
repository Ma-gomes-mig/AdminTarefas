using AdminTarefas.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdminTarefas.Domain.Teste
{
    public class EmplooyerUnitTest
    {
        [Fact]
        public void CreateEmplooyer_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Emplooyer(1, "Emplooyer Name", "Setor RH","Emplooyer Image");
            action.Should()
                .NotThrow<AdminTarefas.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateEmplooyer_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Emplooyer(-1, "Emplooyer Name", "Setor RH", "Emplooyer Image");
            action.Should()
                .Throw<AdminTarefas.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id");
        }

        [Fact]
        public void CreateEmplooyer_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Emplooyer(1, "Ca", "Setor Rh", "Emplooyer image");
            action.Should() 
                .Throw<AdminTarefas.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, Too short, minimum 3 characters");
        }

        [Fact]
        public void CreateEmplooyer_RoleIsRequired_DomainExceptionDisplayRole()
        {
            Action action = () => new Emplooyer(1, "Emplooyer1", null, "Image Emplooyer");
            action.Should()
                .Throw<AdminTarefas.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid, role is required");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Emplooyer(1, "Emplooyer1", "Programação", null);
            action.Should().NotThrow<NullReferenceException>();
        }
        
    }
}