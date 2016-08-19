using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Subject
{
   public class SubjectService:ISubjectRepository
    {
        SubjectDataService _subjectDataService=new SubjectDataService();

       public string SaveSubjectData(SubjectEntity objSubject)
       {
           return _subjectDataService.SaveSubjectData(objSubject);
       }
        public GridEntity<SubjectEntity> GetSubjectSummary(GridOptions options)
        {
            return _subjectDataService.GetGridData(options);
        }

    }
}
