using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlDietitianService:Icrud<Bl.BlModels.Dietitian,BlDietitian>
    {
        public List<BlModels.Meeting> GetTodatMeetingsById(int Id);

    }
}
