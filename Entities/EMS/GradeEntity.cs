using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EMS
{
   public class GradeEntity
    {
       public int GradeId { get; set; }
       public string GradeName { get; set; }
       public decimal GradePoint { get; set; }
       public decimal MarkForm { get; set; }
       public decimal MarkUpto { get; set; }
       public string Description { get; set; }
       public int IsActive { get; set; }
    }
}
