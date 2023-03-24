using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
        public async Task<Student> GetStudentAsync(Guid studentId)
        {
            return await _context.Student
                        .Include(nameof(Gender))
                        .Include(nameof(Address))
                        .FirstOrDefaultAsync(x=>x.Id == studentId);
        }

    }
}
