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
    public class DietitianService : IDietitianService
    {
        NutritionInstitute nutritionContext;
        public DietitianService(NutritionInstitute instance)
        {
            this.nutritionContext = instance;
        }
        public List<Meeting> GetMeetingsById(int id)
        {
            List<Dal.Models.Meeting> list = new List<Meeting>();
            list= nutritionContext.Meetings.Include(m=> m.Client ).Include(m => m.Client).Where(m => m.DieticanId == id).ToList();
            return list;
        }
 

        public List<Dietitian> GetAll()
        {
            return nutritionContext.Dietitians.ToList();
        }

        public Dietitian Add(Dietitian dietitian)
        {
            nutritionContext.Add(dietitian);
            nutritionContext.SaveChanges();
            return dietitian;
        }

        public int Delete(int id)
        {
            Dietitian dietitian = nutritionContext.Dietitians.FirstOrDefault(m => m.Id == id);
            nutritionContext.Dietitians.Remove(dietitian);
            nutritionContext.SaveChanges() ;
            return id;
        }
        //public int Delete(int id)
        //{
        //    return nutritionContext.D
        //}

    }
}
