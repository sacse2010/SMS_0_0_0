using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Subject
{
   public interface ISubjectRepository
   {
       string SaveSubjectData(SubjectEntity objSubject);
        GridEntity<SubjectEntity> GetSubjectSummary(GridOptions options);
    }
}
