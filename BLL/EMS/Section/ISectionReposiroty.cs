using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Section
{
    public interface ISectionReposiroty
    {
        string SectionDataSave(SectionEntity objSection);
        GridEntity<SectionEntity> GetSectionSummary(GridOptions options);
      
    }
}
