using Bl;
using Bl.BlModels;
using Bl.Blservices;
using Dal.DalApi;
using Dal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    { Bl.BlApi.IBlMeetingService meetingService;
        public QueuesController(BlManager instance)
        {
            this.meetingService = instance.Meetings;
        }
        [HttpGet]
        public List<BlQueuesForDietitian> GetAll()
        {
            return meetingService.GetAllQueues();
        }
        [HttpGet("{dietitianId}")]
        public List<BlQueuesForDietitian> GetById( int dietitianId)
        {
            return meetingService.GetQueuesById(dietitianId);
        }
    }
}
