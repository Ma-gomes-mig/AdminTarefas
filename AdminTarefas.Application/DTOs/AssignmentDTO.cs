using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.DTOs
{
    public class AssignmentDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome")]
        [MinLength(3)]
        [MaxLength(50)]
        public string AssignmentName { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [Display(Name = "Descrição")]
        [MinLength(3)]
        [MaxLength(200)]
        public string AssignmentDescription { get; set; }

        [Required(ErrorMessage = "A prioridade é obrigatória")]
        [Display(Name = "Prioridade")]
        [MinLength(3)]
        [MaxLength(30)]
        public string AssignmentPriority { get; set; }

        [Required(ErrorMessage = "A´data de inicio é necessária")]
        [Display(Name = "Inicio")]        
        public DateTime AssignmentBeginDate { get; set; }

        [Required(ErrorMessage = "A´data de final é necessária")]
        [Display(Name = "Fim")]
        public DateTime AssignmentEndDate { get; set; }
        public bool Status { get; set; }
        public Category category { get; set; }

        [DisplayName("Categories")]
        public int CategoryId { get; set; }
        public Emplooyer emplooyer { get; set; }

        [DisplayName("Emplooyers")]
        public int EmplooyerId { get; set; }
    }
}
