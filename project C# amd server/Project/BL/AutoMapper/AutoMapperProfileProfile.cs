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
    public class AutoMapperProfileProfile : Profile
    {
        public AutoMapperProfileProfile()
        {
            {
                CreateMap<BlModels.Dietitian, Dal.Models.Dietitian>();
                  


            }
        }
    }
}
