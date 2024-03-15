using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    internal class ClientService : IClientService
    {

        NutritionInstitute nutritionContext;
        public ClientService(NutritionInstitute nutrition)
        {
            this.nutritionContext = nutrition;
        }

        public Client Add(Client client)
        {
            nutritionContext.Clients.Add(client);
            return client;
        }

        public List<Client> GetAll()
        {
           return nutritionContext.Clients.ToList();
        }
    }
}
