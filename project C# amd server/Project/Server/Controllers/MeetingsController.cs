using Bl;
using Bl.BlApi;
using Bl.BlModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        IBlMeetingService BlMeetingService;
        public MeetingsController(BlManager instance)
        {
            this.BlMeetingService = instance.Meetings;
        }
       
        [HttpPut]
        public void SetMeetingsAsExist(General_meeting_details general_Meeting_Details)
        {
            BlMeetingService.SetMeetingsAsExist(general_Meeting_Details);
        }

    }
}
