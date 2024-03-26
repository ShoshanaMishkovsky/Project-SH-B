using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class MeetingService : IMeetingService
    {
        NutritionInstitute nutritionContext; 
        public MeetingService(NutritionInstitute nutritionContext)
        {
            this.nutritionContext = nutritionContext;
        }

        public Meeting Add(Meeting meeting)
        {
            nutritionContext.Add(meeting);
            return meeting;
        }

        public List<Meeting> GetAll()
        {
          return nutritionContext.Meetings.Include(m => m.Client).Include(m => m.Dietican).ToList();
        }
        //public Meeting SetMeetingsAsExist(Meeting meeting)
        //{
        //   Meeting meeting1= nutritionContext.Meetings.FirstOrDefault(m=>m.Code==meeting.Code);
        //    meeting1.Status = "existed";
        //    nutritionContext.SaveChanges();
        //    return meeting1;
        //}
        public Meeting SetMeetingStatus(Meeting meeting, string meetingStatus)
        {
            Meeting meeting1 = nutritionContext.Meetings.FirstOrDefault(m => m.Code == meeting.Code);
            meeting1.Status = meetingStatus;
            nutritionContext.SaveChanges();
            return meeting1;
        }

       
    }
}
