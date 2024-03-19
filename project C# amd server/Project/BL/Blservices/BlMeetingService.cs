using AutoMapper;
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
        IMapper mapper;
        public BlMeetingService(DalManager dalManager, IMapper mapper)
        {
            this.meetingService = (IMeetingService)dalManager.Meetings;
            this.mapper = mapper;
        }

        public AllTheDetailsOfMeeting Add(AllTheDetailsOfMeeting obg)
        {
            throw new NotImplementedException();
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
            list.ForEach(m => BlList.Add(mapper.Map<Bl.BlModels.AllTheDetailsOfMeeting>(m)));
            return BlList;
        }

        public AllTheDetailsOfMeeting SetMeetingsAsExist(General_meeting_details meeting_details)
        {
            Dal.Models.Meeting meeting = meetingService.GetAll().Find(m => (m.DieticanId == meeting_details.DieticanId && m.ClientId == meeting_details.ClientId && m.Date == meeting_details.Date));

            if (meeting != null)
            {
               return mapper.Map<AllTheDetailsOfMeeting>(meetingService.SetMeetingsAsExist(meeting));

            }
            return null;
          
        }

       

      

       

     
    }
}

