using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class MeetingService : IMeetingService
    {
        NutritionContext nutritionContext; 
        public MeetingService(NutritionContext nutritionContext)
        {
            this.nutritionContext = nutritionContext;
        }

        public Meeting Add(Meeting obg)
        {
            throw new NotImplementedException();
        }

        public List<Meeting> GetAll()
        {
          return nutritionContext.Meetings.ToList();
        }
        public void SetMeetingsAsExist(Meeting meeting)
        {
           Meeting meeting1= nutritionContext.Meetings.FirstOrDefault(m=>m.Code==meeting.Code);
            meeting1.Status = "existed";
        }



    }
}
