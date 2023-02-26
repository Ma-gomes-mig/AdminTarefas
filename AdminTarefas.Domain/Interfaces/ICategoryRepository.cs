using AdminTarefas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTarefas.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(int? id);
        Task<IEnumerable<Category>> GetCategoriesAsync();                
        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task<Category> Delete(Category category);
    }
}
