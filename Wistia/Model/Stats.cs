using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wistia
{
    public class Stats : WistiaBase
    {
        public int PageLoads { get; set; }
        public int Visitors { get; set; }
        public int PercentOfVisitorsClickingPlay { get; set; }
        public int Plays { get; set; }
        public int AveragePercentWatched { get; set; }

    }
}
