using Dal.DalApi;
using Dal.Models;
using Dal.Services;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
       public IClientService ClientService { get; set; }
      public IDietitianService Dietitians { get; }
        public IMeetingService Meetings { get; }
        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<NutritionInstitute>();
            //DBActions db = new DBActions(/*builder.*/Configuration);
            //string connStr = db.GetConnectionString("NutritionContext");
            //Services.AddDbContext<NutritionContext>(opt => opt.UseSqlServer(connStr));
            services.AddScoped<IDietitianService, DietitianService>();
            services.AddScoped<IMeetingService,MeetingService>();
            ServiceProvider servicesProvider = services.BuildServiceProvider();
            Dietitians= servicesProvider.GetRequiredService<IDietitianService>();
            Meetings= servicesProvider.GetRequiredService<IMeetingService>();

        }
    }
}
