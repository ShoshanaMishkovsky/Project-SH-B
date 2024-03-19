//using Dal.Models;
using Bl.BlModels;
//using Dal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl;
using Bl.BlApi;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        IBlClientService BlClientService;
        public ClientsController(BlManager blManager)
        {
            BlClientService = blManager.Clients;
        }
        [HttpPost]
        public ActionResult<Client> AddClient(Client client)
        {
            return BlClientService.Add(client);
        }
    }
}
