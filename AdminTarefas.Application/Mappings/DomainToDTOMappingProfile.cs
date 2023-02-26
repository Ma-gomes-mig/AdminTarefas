using AdminTarefas.Application.DTOs;
using AdminTarefas.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Emplooyer, EmplooyerDTO>().ReverseMap();
            CreateMap<Assignment, AssignmentDTO>().ReverseMap();

        }
    }
}
