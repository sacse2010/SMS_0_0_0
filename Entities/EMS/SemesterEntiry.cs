﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EMS
{
   public class SemesterEntiry
    {
       public int SemesterId { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public int IsActive { get; set; }    
    }
}
