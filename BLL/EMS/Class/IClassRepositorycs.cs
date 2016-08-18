using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Class
{
    public interface IClassRepositorycs
    {
        string ClassDataSave(ClassEntity objClass);
        GridEntity<ClassEntity> GetClassSummary(GridOptions options);
    }
}
