using GP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.BLL.Interfaces
{
    public interface ICollegeRepository
    {
        IEnumerable<College> GetColleges();
        Task<College> GetCollegeById(int id);
        int AddCollege(College college);
        int UpdateCollege(College college);
        int DeleteCollege(int college);
    }
}
