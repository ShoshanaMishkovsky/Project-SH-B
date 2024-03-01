using Dal.Models;
using Bl.BlModels;
using Dal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        //IBlClientService BlClientService;
        //public ClientsController(BlManager blManager)
        //{
        //    BlClientService= blManager;
        //}
        //[HttpPost]
        //public ActionResult<cli> AddClient(Bl.BlModels.Dietitian dietitian)
        //{
        //    return BlClientService.Add(dietitian);
        //}
    }
}
