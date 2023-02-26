using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using AdminTarefas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AdminTarefas.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {   

        ApplicationDbContext _categoryContext;
        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;
        }

        public async Task<Category> GetById(int? id)
        {
            return await _categoryContext.Category.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryContext.Category.ToListAsync();
        }        

        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Delete(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
        
        
        
    }
}
