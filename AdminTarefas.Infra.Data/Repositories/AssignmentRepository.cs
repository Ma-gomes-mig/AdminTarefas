using AdminTarefas.Domain.Entities;
using AdminTarefas.Domain.Interfaces;
using AdminTarefas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace AdminTarefas.Infra.Data.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        ApplicationDbContext _assignmentContext;
        public AssignmentRepository(ApplicationDbContext context)
        {
            _assignmentContext = context;
        }

        public async Task<IEnumerable<Assignment>> GetAssignmentAsync()
        {
            return await _assignmentContext.Assignment.ToListAsync();
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int? id)
        {
            return await _assignmentContext.Assignment.FindAsync(id);
        }

        public async Task<Assignment> GetAssignmentByNameAsync(string name)
        {
            return await _assignmentContext.Assignment.FindAsync(name);
        }

        //public async Task<IEnumerable<Assignment>> GetPeriodAsync(DateTime beginDate, DateTime endDate)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<Assignment>> GetStatusAsync(bool status)
        //{
        //    throw new NotImplementedException();
        //}   

        public async Task<Assignment> GetAssignmentForEmplooyer(int? id)
        {
            return await _assignmentContext.Assignment.Include(c => c.Emplooyer).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Assignment> Create(Assignment assignment)
        {
            _assignmentContext.Assignment.Add(assignment);
            await _assignmentContext.SaveChangesAsync();
            return assignment;
        }

        public async Task<Assignment> Update(Assignment assignment)
        {
            _assignmentContext.Assignment.Update(assignment);
            await _assignmentContext.SaveChangesAsync();   
            return assignment;
        }

        public async Task<Assignment> Delete(Assignment assignment)
        {
            _assignmentContext.Assignment.Remove(assignment);
            await _assignmentContext.SaveChangesAsync();
            return assignment;
        }
    }
}
