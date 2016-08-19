using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Grade
{
   public class GradeService:IGradeRepository
    {
        GradeDataService _gradeDataService =new GradeDataService();
       public string GradeDataSave(GradeEntity objGrade)
       {
           return _gradeDataService.GradeDataSave(objGrade);
       }

       public GridEntity<GradeEntity> GetGradeSummary(GridOptions options)
       {
           return _gradeDataService.GetGridData(options);
       }
    }
}
