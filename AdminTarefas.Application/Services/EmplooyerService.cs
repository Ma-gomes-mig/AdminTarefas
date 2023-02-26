using AdminTarefas.Application.DTOs;
using AdminTarefas.Application.Interfaces;
using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.Services
{
    public class EmplooyerService : IEmplooyerService
    {
        private IEmplooyerRepository _emplooyerRepository;
        private readonly IMapper _mapper;
        public EmplooyerService(IEmplooyerRepository emplooyerRepository, IMapper mapper)
        {
            _emplooyerRepository = emplooyerRepository ?? throw new ArgumentNullException(nameof(emplooyerRepository));
            _mapper = mapper;
        }
        
        public async Task<EmplooyerDTO> GetEmplooyerById(int id)
        {
            var emplooyerEntity = await _emplooyerRepository.GetEmplooyerByIdAsync(id);
            return _mapper.Map<EmplooyerDTO>(emplooyerEntity); 
        }

        public async Task<IEnumerable<EmplooyerDTO>> GetEmplooyers()
        {
            var emplooyerEntity = _emplooyerRepository.GetEmplooyersAsync();
            return _mapper.Map<IEnumerable<EmplooyerDTO>>(emplooyerEntity);
        }

        public async Task Add(EmplooyerDTO emplooyerDto)
        {
            var emplooyerEntity = _mapper.Map<Emplooyer>(emplooyerDto);
            await _emplooyerRepository.Create(emplooyerEntity);
        }

        public async Task Update(EmplooyerDTO emplooyerDto)
        {
            var categoryEntity = _mapper.Map<Emplooyer>(emplooyerDto);
            await _emplooyerRepository.Update(categoryEntity);
        }

        public async Task Delete(int id)
        {
            var emplooyerEntity = _emplooyerRepository.GetEmplooyerByIdAsync(id).Result;
            await _emplooyerRepository.Delete(emplooyerEntity);
        }

       

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
