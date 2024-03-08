using Bl.BlApi;
using Bl.BlModels;
using Dal;
using Dal.DalApi;
using Dal.Models;
using Dal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Blservices
{
    public class BlMeetingService : IBlMeetingService
    {
        IMeetingService meetingService;
        public BlMeetingService(DalManager dalManager)
        {
            this.meetingService = (IMeetingService)dalManager.Meetings;
        }

        //public Meeting Add(AllTheDetailsOfMeeting obg)
        //{
        //   Meeting meeting = new Meeting();
        //    meeting.Status = obg.Status;
        //    meeting.Date = obg.Date;
        //    meeting.ClientId = obg.ClientId;
        //    meeting.DieticanId = obg.DieticanId;
        //    meeting.Hour = obg.Hour;
            
        //    meetingService.Add(meeting);
        //    return meeting;

        //}

        //public AllTheDetailsOfMeeting Add(BlModels.Meeting.Meeting obg)
        //{

        //}

        public List<AllTheDetailsOfMeeting> GetAll()
        {
            List<AllTheDetailsOfMeeting> BlList = new List<AllTheDetailsOfMeeting>();
            var list = meetingService.GetAll();
            list.ForEach(m => BlList.Add(new BlModels.AllTheDetailsOfMeeting() {ClientFirstName=m.Client.FirstName,ClientLastName=m.Client.LastName,DieticanFirstName=m.Dietican.FirstName,DieticanLastName=m.Dietican.LastName,Date=m.Date, Hour=m.Hour,Status=m.Status  }));
            return BlList;
        }

        public void SetMeetingsAsExist(General_meeting_details meeting_details)
        {
            Dal.Models.Meeting meeting = meetingService.GetAll().Find(m => (m.DieticanId == meeting_details.DieticanId && m.ClientId == meeting_details.ClientId && m.Date == meeting_details.Date));

            if (meeting != null)
            {
                meetingService.SetMeetingsAsExist(meeting);

            }
          
        }

       

      

       

     
    }
}

