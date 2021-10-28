using Microsoft.AspNetCore.Mvc;
using KwikkCallbackCore;
using System;
using System.Linq;

namespace KwikkCallbackCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KwikkController : ControllerBase
    {
        [HttpPost]
        [Route("callback")]
        public ActionResult Callback(CallbackDto callbackDto)
        {
            // ToDo: interesting things with callbackDto object

            return Ok("I saw a callback and it was good");
        }
    }
}
