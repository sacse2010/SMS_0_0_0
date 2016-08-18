using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Semester
{
   public class SemesterService:ISemesterRepository
    {
        SemesterDataService _semesterDataService =new SemesterDataService();
       public string SemesterDataSave(SemesterEntiry objSemester)
       {
           return _semesterDataService.SemesterDataSave(objSemester);
       }

       public GridEntity<SemesterEntiry> GetSemesterSummary(GridOptions options)
       {
           return _semesterDataService.GetGridData(options);
       }
    }
}
