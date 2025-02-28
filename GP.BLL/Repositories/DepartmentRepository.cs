using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.BLL.Interfaces;
using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace GP.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;

        public DepartmentRepository( AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddDepartment(Department department)
        {
            _dbContext.Add(department);
            return  _dbContext.SaveChanges();
        }

        public int DeleteDepartment(int departmentId)
        {
            _dbContext.Remove(departmentId);
            return _dbContext.SaveChanges();
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            //var department = _dbContext.Departments.Where(D=>D.Id==id).FirstOrDefault();
            //Best Performance
            var department = await _dbContext.Departments.FindAsync(id);//// find op search in cache if found return it else search in database
            return department;

        }

        public IEnumerable<Department> GetDepartments()
        {
           var result=_dbContext.Departments.Include(d => d.College).AsNoTracking().ToList();
            return result;
        }

        public int UpdateDepartment(Department department)
        {
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
