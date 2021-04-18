using System;
using Microsoft.AspNetCore.Mvc;

namespace ventaOxigenoB.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        
        [HttpGet]
        public string pepito()
        {
            return "hola alan cornejo s";
        }
    }
}
