using GP.BLL.Interfaces;
using GP.DAL.Context;
using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.BLL.Repositories
{
    public class FacultyMemberRepsitory : IFacultyMemberRepsitory
    {
        private readonly AppDbContext _dbContext;

        public FacultyMemberRepsitory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<FacultyMember> GetHeads()
        {
            return _dbContext.Departments.Where(d => d.HeadId.HasValue).Select(d => d.Head).ToList();
        }
    }
}
