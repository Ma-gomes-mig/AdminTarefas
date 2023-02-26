using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Application.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome")]
        [MinLength(3)]
        [MaxLength(50)]
        public string CategoryName { get; set; }
    }
}
