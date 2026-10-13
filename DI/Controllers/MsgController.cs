using DI.Interface;
using DI.notifiacation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MsgController : ControllerBase
    {
        private readonly INotification _notification;
        public MsgController(INotification Notification)
        { 
            this._notification = Notification;
        }

        public IActionResult Get()
        {
            string output= _notification.Notify("Hello from MsgController!");

            return Ok(output);
        }

    }
}
