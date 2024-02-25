using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IMeetingService:Icrud<Meeting>
    {
        public void SetMeetingsAsExist(Meeting meeting);
        //public int AddMeeting(Meeting meeting);
    }
}
