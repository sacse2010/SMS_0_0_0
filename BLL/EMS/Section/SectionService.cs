using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Section
{
   public class SectionService: ISectionReposiroty
    {
        SectionDataService _sectionDataService =new SectionDataService();
       public string SectionDataSave(SectionEntity objSection)
       {
           return _sectionDataService.SectionDataSave(objSection);
       }

       public GridEntity<SectionEntity> GetSectionSummary(GridOptions options)
       {
           return _sectionDataService.GetGridData(options);
       }
    }
}
