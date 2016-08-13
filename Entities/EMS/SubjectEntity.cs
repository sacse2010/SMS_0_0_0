﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EMS
{
  public class SubjectEntity
    {
      public int SubjectId { get; set; }
      public string SubjectCode { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public string IsActive { get; set; }
    }
}
