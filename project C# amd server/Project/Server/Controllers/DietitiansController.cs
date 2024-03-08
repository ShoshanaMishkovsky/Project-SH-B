﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;
using Dal.Models;
using Bl.BlModels;
using Bl;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietitiansController : ControllerBase
    {
        IBlDietitianService dietitianService;

        public DietitiansController(BlManager BlManager)
        {
            this.dietitianService = BlManager.Dietitians;
        }
        [HttpGet]
        public ActionResult<List<BlDietitian>> GetAll()
        {
            return dietitianService.GetAll();
        }
        [HttpGet("{DietitianId}")]

        public ActionResult<List<Bl.BlModels.MeetingForDietitian>> GetTodayMeetingsById(int DietitianId)
        {
            return dietitianService.GetTodatMeetingsById(DietitianId);

        }
        //[HttpPost]
       //public ActionResult<BlDietitian> AddDietitian(Bl.BlModels.Dietitian dietitian)
       // {
       //     return dietitianService.Add(dietitian);
       // }


    }
}
