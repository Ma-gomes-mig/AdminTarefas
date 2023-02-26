using AdminTarefas.Application.Assignments.Queries;
using AdminTarefas.Application.DTOs;
using AdminTarefas.Application.Interfaces;
using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Services
{
    public class AssignmentService : IAssignmentService
    {
        
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public AssignmentService(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AssignmentDTO>> GetAssignmentAsync()
        {   
            var assignmentQuery = new GetAssignmentsQuery();

            if (assignmentQuery == null)
                throw new Exception($"Entity couldn't be loaded.");

            var result = await _mediator.Send(assignmentQuery);
            return _mapper.Map<IEnumerable<AssignmentDTO>>(result);  
        }

        //public async Task<AssignmentDTO> GetAssignmentByIdAsync(int? id)
        //{
        //    var assignmentEntity = await _assignmentRepository.GetAssignmentByIdAsync(id);
        //    return _mapper.Map<AssignmentDTO>(assignmentEntity);
        //}

        //public async Task<AssignmentDTO> GetAssignmentByNameAsync(string name)
        //{
        //    var assignmentEntity = await _assignmentRepository.GetAssignmentByNameAsync(name);
        //    return _mapper.Map<AssignmentDTO>(assignmentEntity);
        //}

        //public async Task<AssignmentDTO> GetAssignmentForEmplooyer(int? id)
        //{
        //    var assignmentEntity = await _assignmentRepository.GetAssignmentForEmplooyer(id);
        //    return _mapper.Map<AssignmentDTO>(assignmentEntity);
        //}

        //public async Task Create(AssignmentDTO assignmentDto)
        //{
        //    var assignmentEntity = _mapper.Map<Assignment>(assignmentDto);
        //    await _assignmentRepository.Create(assignmentEntity);
        //}

        //public async Task Update(AssignmentDTO assignmentDto)
        //{
        //    var assignmentEntity = _mapper.Map<Assignment>(assignmentDto);
        //    await _assignmentRepository.Update(assignmentEntity);
        //}

        //public async Task Delete(int id)
        //{
        //    var assignmentEntity = _assignmentRepository.GetAssignmentByIdAsync(id).Result;
        //    await _assignmentRepository.Delete(assignmentEntity);
        //}

    }
}
