using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController: ControllerBase
    {
        [HttpGet]
        public string SayHello() => "hello";
    }
}