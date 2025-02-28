using GP.BLL.Interfaces;
using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.BLL.Repositories
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly AppDbContext _dbContext;

        public CollegeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<College> GetColleges()
        {
            var result = _dbContext.Colleges.AsNoTracking().ToList();
            return result;
        }
        public async Task<College> GetCollegeById(int id)
        {
            var college = await _dbContext.Colleges.FindAsync(id);//// find op search in cache if found return it else search in database
            return college;
        }
        public int AddCollege(College college)
        {
            _dbContext.Add(college);
            return _dbContext.SaveChanges();
        }
        public int UpdateCollege(College college)
        {
            _dbContext.Colleges.Update(college);
            return _dbContext.SaveChanges();
        }
        public int DeleteCollege(int collegeid)
        {
            _dbContext.Remove(collegeid);
            return _dbContext.SaveChanges();
        }
    }
}
