using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class Meeting
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimeSpan Hour { get; set; }
        public string Phone { get; set; }
        public float Age { get; set; }
    }
}
