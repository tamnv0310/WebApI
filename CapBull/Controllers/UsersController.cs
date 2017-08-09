using Microsoft.AspNetCore.Mvc;
using System;

namespace LandonApi.Controllers
{
    [Route("/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet(Name = nameof(GetUsers))]
        public IActionResult GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
