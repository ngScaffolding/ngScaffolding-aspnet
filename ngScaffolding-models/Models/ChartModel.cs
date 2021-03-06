﻿using ngScaffolding.database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ngScaffolding.Models
{
    public class ChartDetailModel
    {
        public string title { get; set; }
        public InputBuilderDefinition filters { get; set; }

        public string xAxisName { get; set; }
        public string[] seriesNames { get; set; }
        public string chartOptions { get; set; }

        public string dataSourceName { get; set; }
    }
}
