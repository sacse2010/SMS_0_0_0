using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Semester
{
   public interface ISemesterRepository
    {
       string SemesterDataSave(SemesterEntiry objSemester);
       GridEntity<SemesterEntiry> GetSemesterSummary(GridOptions options);
    }
}
