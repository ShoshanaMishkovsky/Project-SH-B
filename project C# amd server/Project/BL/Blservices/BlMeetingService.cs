using Bl.BlApi;
using Bl.BlModels;
using Dal;
using Dal.DalApi;
using Dal.Models;
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

        public BlModels.Meeting Add(BlModels.Meeting obg)
        {
            throw new NotImplementedException();
        }

        public List<BlModels.Meeting> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SetMeetingsAsExist(General_meeting_details meeting_details)
        {
            Dal.Models.Meeting meeting = meetingService.GetAll().Find(m => (m.DieticanId == meeting_details.DieticanId && m.ClientId == meeting_details.ClientId && m.Date == meeting_details.Date));

            if (meeting!=null)
          {
                meetingService.SetMeetingsAsExist(meeting);

            } }
      

       
    } }
    
