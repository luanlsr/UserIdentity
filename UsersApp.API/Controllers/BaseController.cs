using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UAParser;
using UsersApp.Domain.Entities;
using UsersApp.Domain.Entities.User;

namespace UsersApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public User userHttpContext => (User)HttpContext.Items["User"];

        protected string IpAddress()
        {
            // get source ip address for the current request
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
        protected UserAgentInfo DeviceType()
        {
            var userAgent = HttpContext.Request.Headers["User-Agent"];
            var uaParser = Parser.GetDefault();
            UserAgentInfo client = new UserAgentInfo(uaParser.Parse(userAgent));
            return client;
        }



    }
}
