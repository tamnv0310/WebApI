using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapBull.Controllers
{
    [Route("/")]
    [ApiVersion("1.0")]
    [RequireHttps]
    public class RootController : Controller
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                users = new { href = Url.Link(nameof(UsersController.GetUsers), null) },
            };

            return Ok(response);
        }
    }
}
