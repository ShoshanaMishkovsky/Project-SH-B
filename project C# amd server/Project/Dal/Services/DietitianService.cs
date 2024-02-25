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
        public DietitianService(NutritionContext instance)
        {
            this.nutritionContext = instance;
        }
        public List<Meeting> GetMeetingsById(int id)
        {
            List<Meeting> list = new List<Meeting>();
            list= nutritionContext.Meetings.Where(m => m.DieticanId == id).ToList();
            return list;
        }
 

        public List<Dietitian> GetAll()
        {
            return nutritionContext.Dietitians.ToList();
        }

        public Dietitian Add(Dietitian dietitian)
        {
            nutritionContext.Add(dietitian);
            return dietitian;
        }

    }
}
