using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EMS
{
   public class CollectionTypeEntity
    {
       public int CollectionId { get; set; }
       public string CollectionType { get; set; }
       public string Description { get; set; }
       public int IsActive { get; set; }    
    }
}
