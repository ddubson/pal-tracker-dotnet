using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController: ControllerBase
    {
        private readonly WelcomeMessage _welcomeMessage;
            
        [HttpGet]
        public string SayHello() => this._welcomeMessage.Message;

        public WelcomeController(WelcomeMessage message)
        {
            this._welcomeMessage = message;
        }
    }
}