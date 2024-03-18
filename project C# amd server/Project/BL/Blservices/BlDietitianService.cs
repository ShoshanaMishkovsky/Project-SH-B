using Dal.DalApi;
using Dal.Services;
using Dal.Models;
using Bl.Blservices;
using Bl.BlApi;
using Dal;
using Bl.BlModels;
using AutoMapper;

namespace Bl.Blservices
{

    public class BlDietitianService: IBlDietitianService
    {
        IDietitianService dietitianService;
        IMapper map;
        public BlDietitianService(DalManager instance, IMapper myMap)
        {
            this.dietitianService =instance.Dietitians;
            map = myMap;
        }

        #region get functions
     

        public List<BlDietitian> GetAll()
        {
            List<BlDietitian> blDietitians = new List<BlDietitian>();
            var list = dietitianService.GetAll();
            list.ForEach(d => blDietitians.Add(map.Map<Bl.BlModels.BlDietitian>(d)));
            return blDietitians;


        }
        List<MeetingForDietitian> IBlDietitianService.GetTodatMeetingsById(int Id)
        {
            List<BlModels.MeetingForDietitian> meetings = new List<BlModels.MeetingForDietitian>();
            var list = dietitianService.GetMeetingsById(Id).Where(d => d.Date == DateTime.Today).ToList();
            List<BlModels.Dietitian> dietitians = new List<BlModels.Dietitian>();

            list.ForEach(m => meetings.Add(new BlModels.MeetingForDietitian() { FirstName = m.Client.FirstName, LastName = m.Client.LastName, Age = DateTime.Now.Year - m.Client.BirthDate.Year, Hour = m.Hour, Phone = m.Client.Phone }));
            return meetings;
        }


        #endregion get functions

        #region add functions

        public BlModels.Dietitian Add(BlModels.Dietitian d)
        {
            Dal.Models.Dietitian dietitian = map.Map<Dal.Models.Dietitian>(d);
            dietitianService.Add(dietitian);
            return d;
        }

       

        #endregion add functions





        //public int Delete(Dietitian dietitian)
        //{
        //    nutritionContext.Dietitians.Remove(dietitian);
        //    nutritionContext.SaveChanges();
        //    return dietitian.Id;
        //}







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

