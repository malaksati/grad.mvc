using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.DAL.Models;

namespace GP.BLL.Interfaces
{
    public interface IInstructorScheduleRepositroy
    {
        // Task<IEnumerable<InstructorSchedule>> GetInstructorSchedulesAsync();
        IEnumerable<InstructorSchedule> GetInstructorScheduleByScheduleId(int ScheduleId);
        IEnumerable<InstructorSchedule> GetAssistantScheduleByScheduleId(int ScheduleId);
      ////  Task<InstructorSchedule> CreateInstructorScheduleAsync(InstructorSchedule instructorSchedule);
        //Task<InstructorSchedule> UpdateInstructorScheduleAsync(InstructorSchedule instructorSchedule);
        //Task<InstructorSchedule> DeleteInstructorScheduleAsync(int id);
    }
}
