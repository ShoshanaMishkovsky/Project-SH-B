using Bl.BlModels;
using Dal.DalApi;
using Dal.Services;
using Dal.Models;
using Bl.Blservices;
using Bl.BlApi;

namespace Bl.Blservices
{

    public class BlDietitianService: IBlDietitianService
    {
        IDietitianService dietitianService;
        public BlDietitianService(IDietitianService dietitianService)
        {  this.dietitianService=
                dietitianService;
        }




        public List<BlModels.Meeting> GetTodatMeetingsById(int Id)
        {
            List<BlModels.Meeting> meetings = new List<BlModels.Meeting>();
            var list = dietitianService.GetMeetingsById(Id).Where(d => d.Date == DateTime.Today).ToList();
            list.ForEach(m => meetings.Add(new BlModels.Meeting() { FirstName = m.Client.FirstName, LastName = m.Client.LastName, Age = DateTime.Now.Year - m.Client.BirthDate.Year, Hour = m.Hour, Phone = m.Client.Phone }));
            return meetings;
        }
        //public Dietitian Add(Dietitian dietitian)
        //{
        //    nutritionContext.Dietitians.Add(dietitian);
        //    nutritionContext.SaveChanges();
        //    return dietitian;
        //}

        //public int Delete(Dietitian dietitian)
        //{
        //    nutritionContext.Dietitians.Remove(dietitian);
        //    nutritionContext.SaveChanges();
        //    return dietitian.Id;
        //}

        public List<BlDietitian> GetAll()
        {
           List<BlDietitian> blDietitians = new List<BlDietitian>();
            var list = dietitianService.GetAll();
            list.ForEach(d => blDietitians.Add(new BlDietitian() { Email = d.Email, Phone = d.Phone, FirstName = d.FirstName, LastName = d.LastName, Kind = d.Kind }));
            return blDietitians;


        }

        //public Dietitian Update(Dietitian dietitian, int id)
        //{
        //    Dietitian dietitian1 = nutritionContext.Dietitians.FirstOrDefault(d => d.Id == id);
        //    dietitian1.Email = dietitian.Email;
        //    dietitian1.FirstName = dietitian.FirstName;
        //    dietitian1.LastName = dietitian.LastName;
        //    dietitian1.Phone = dietitian.Phone;
        //    nutritionContext.SaveChanges();
        //    return dietitian;
        //}
    }
}

