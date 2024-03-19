using AutoMapper;
using Bl.BlApi;
using Bl.Blservices;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class BlManager
    {
        public IBlDietitianService Dietitians { get; set; }
        public IBlClientService Clients { get; set; }
        public IBlMeetingService Meetings { get; set; }
      
        public BlManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<DalManager>();
            services.AddScoped<IBlDietitianService,BlDietitianService>();
            services.AddScoped<IBlMeetingService, BlMeetingService>();
            services.AddScoped<IBlClientService, BlClientService>();
            services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            Dietitians = serviceProvider.GetRequiredService<IBlDietitianService>();
            Meetings = serviceProvider.GetRequiredService<IBlMeetingService>();

            Clients = serviceProvider.GetRequiredService<IBlClientService>();
        }
    }
}
