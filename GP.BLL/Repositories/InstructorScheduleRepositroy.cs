using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.BLL.Interfaces;
using GP.DAL.Context;
using GP.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace GP.BLL.Repositories
{
    public class InstructorScheduleRepositroy : IInstructorScheduleRepositroy
    {
        private readonly AppDbContext _dbContext;

        public InstructorScheduleRepositroy(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<InstructorSchedule> GetInstructorSchedule()
        {

            var result =_dbContext.InstructorSchedules.AsNoTracking().ToList();
            return result;

        }
    }
}
