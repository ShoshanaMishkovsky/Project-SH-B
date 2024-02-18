using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlMeetingService : Icrud<Meeting>
    {
        public void SetMeetingsAsExist(General_meeting_details general_Meeting_Details);


        }
}
