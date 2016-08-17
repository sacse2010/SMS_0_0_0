using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Class
{
   public class ClassService:IClassRepositorycs
    {
        ClassDataService _classDataService = new ClassDataService();
       public string ClassDataSave(ClassEntity objClass)
       {
           return _classDataService.ClassDataSave(objClass);
       }

       public GridEntity<ClassEntity> GetClassSummary(GridOptions options)
       {
           return _classDataService.GetGridData(options);
       }
    }
}
