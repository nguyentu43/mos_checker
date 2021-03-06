﻿using NetOffice.ExcelApi;
using System;
using System.Collections.Generic;

namespace Checker.Base
{
    public abstract class BaseExcelTest : BaseTest
    {
        public Workbook Workbook { get; set; }
        public String ThemeXmlContent { get; set; }

        public override List<bool> Points
        {
            get
            {
                if (this.Workbook == null) throw new Exception("Workbook not found");
                return base.Points;
            }

        }
    }
}
