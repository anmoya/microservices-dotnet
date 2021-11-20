using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService
{
    [ApiController]
    [Route("api/c/[controller]")]
    public class PlatformsController : ControllerBase
    {

        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Ibound test from Platforms Controller");
        }

    }
}