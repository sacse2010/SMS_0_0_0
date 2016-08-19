using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Grade
{
    public interface IGradeRepository
    {
        string GradeDataSave(GradeEntity objGrade);
        GridEntity<GradeEntity> GetGradeSummary(GridOptions options);
    }
}
