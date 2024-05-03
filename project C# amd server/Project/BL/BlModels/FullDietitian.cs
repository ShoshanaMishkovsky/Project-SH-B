using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlModels
{
    public class FullDietitian
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; }

        public string Phone { get; set; } = null!;

        public string Kind { get; set; } = null!;
       public List<WorkHour> WorkHours { get; set; }

    }
}
