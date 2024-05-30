using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class BlQueuesForDietitian
    {
        public int Code { get; set; }

        public int DieticanId { get; set; }

        public bool Available { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Hour { get; set; }
    }
}
