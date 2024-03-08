using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlDietitianService:Icrud<BlDietitian>
    {
        public List<MeetingForDietitian> GetTodatMeetingsById(int Id);

    }
}
