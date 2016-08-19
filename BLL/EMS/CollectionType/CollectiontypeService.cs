using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.CollectionType
{
  public class CollectiontypeService:ICollectionTypeRepository
    {
        CollectionTypeDataService _collectionTypeDataService =new CollectionTypeDataService();
      public string CollectionTypeDataSave(CollectionTypeEntity objCollectionType)
      {
          return _collectionTypeDataService.CollectionTypeDataSave(objCollectionType);
      }

      public GridEntity<CollectionTypeEntity> GetCollectionTypeSummary(GridOptions options)
      {
          return _collectionTypeDataService.GetGridData(options);
      }
    }
}
