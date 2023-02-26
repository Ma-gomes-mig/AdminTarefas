using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.DTOs
{
    public class EmplooyerDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório")]
        [Display(Name ="Nome")]
        [MinLength(3)]
        [MaxLength(50)]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "A função é obrigatório")]
        [Display(Name = "Função")]
        [MinLength(3)]
        [MaxLength(50)]
        public string EmpRole { get; set; }  
        
        [Display(Name = "Foto")]
        [MinLength(5)]
        [MaxLength(200)]
        public string EmpImage { get; set; }

        public IEnumerable<AssignmentDTO> assignmentDTOs { get; set; }
    }
}
