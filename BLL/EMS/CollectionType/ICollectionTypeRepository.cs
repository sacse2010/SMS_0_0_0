using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.CollectionType
{
   public interface ICollectionTypeRepository
    {
       string CollectionTypeDataSave(CollectionTypeEntity objCollectionType);
       GridEntity<CollectionTypeEntity> GetCollectionTypeSummary(GridOptions options);
    }
}
