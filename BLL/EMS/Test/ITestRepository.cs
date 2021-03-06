﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Test
{
    public interface ITestRepository
    {
        string SaveTestData(TestEntity objTest);
        GridEntity<TestEntity> GetTestSummary(GridOptions options);
        List<TestEntity> GetTestTypeComboData();
    }
}
