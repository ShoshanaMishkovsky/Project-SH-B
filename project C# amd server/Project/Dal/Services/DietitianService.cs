using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class DietitianService : IDietitianService
    {
        NutritionContext nutritionContext;
        public DietitianService(NutritionContext nutritionContext)
        {
            this.nutritionContext = nutritionContext;
        }
        public List<Meeting> GetMeetingsById(int id)
        {
            List<Meeting> list = new List<Meeting>();
            list= nutritionContext.Meetings.Where(m => m.DieticanId == id).ToList();
            return list;
        }
        //    public Dietitian Add(Dietitian dietitian)
        //    {
        //       nutritionContext.Dietitians.Add(dietitian);
        //        nutritionContext.SaveChanges();
        //        return dietitian;

        //    }

        //    public int Delete(Dietitian dietitian)
        //    {
        //        nutritionContext.Dietitians.Remove(dietitian);
        //        nutritionContext.SaveChanges();
        //      return dietitian.Id;
        //    }

        public List<Dietitian> GetAll()
        {
            return nutritionContext.Dietitians.ToList();
        }

     

        //    public Dietitian Update(Dietitian dietitian, int id)
        //    {
        //        Dietitian dietitian1 = nutritionContext.Dietitians.FirstOrDefault(d => d.Id == id);
        //        dietitian1.Email= dietitian.Email;
        //        dietitian1.FirstName = dietitian.FirstName;
        //        dietitian1.LastName = dietitian.LastName;
        //        dietitian1.Phone = dietitian.Phone;
        //        nutritionContext.SaveChanges();
        //        return dietitian;
        //    }
        //}
    }
}
