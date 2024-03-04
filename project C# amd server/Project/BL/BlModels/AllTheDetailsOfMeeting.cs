using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class AllTheDetailsOfMeeting
    {
        public int Code { get; set; }

        public int DieticanId { get; set; }

        public int ClientId { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Hour { get; set; }
    }
}
