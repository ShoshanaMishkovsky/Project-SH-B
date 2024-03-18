using AutoMapper;
using Bl.BlModels;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bl.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            {
                CreateMap<Bl.BlModels.Dietitian, Dal.Models.Dietitian>();
                CreateMap<Dal.Models.Dietitian, Bl.BlModels.BlDietitian>();
                CreateMap<Dal.Models.Dietitian, Bl.BlModels.Dietitian>();
                CreateMap<Dal.Models.Meeting, Bl.BlModels.AllTheDetailsOfMeeting>();

            }
        }
    }
}
