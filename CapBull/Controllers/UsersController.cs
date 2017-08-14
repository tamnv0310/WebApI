using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CapBull.Controllers
{
    [Route("/[controller]")]
    public class UsersController : Controller
    {
        [Route("users")]
        public IActionResult GetUsers()
        {
            return null;
            //var result = AppUserManager.Users.ToList().Select(u => this.TheModelFactory.Create(u));
            //return Ok(result);
        }
        //[Route("user/{id:guid}", Name = "GetUserById")]

        //public async Task<IActionResult> GetUser(string Id)
        //{
        //    var user = await this.AppUserManager.FindByIdAsync(Id);

        //    if (user != null)
        //    {
        //        var createdUserResult = TheModelFactory.Create(user);
        //        return Ok(createdUserResult);
        //    }

        //    return NotFound();

        //}

        //[Route("user/{username}")]
        //public async Task<IActionResult> GetUserByName(string username)
        //{
        //    var user = await this.AppUserManager.FindByNameAsync(username);

        //    if (user != null)
        //    {
        //        var getUserResult = TheModelFactory.Create(user);
        //        return Ok(getUserResult);
        //    }

        //    return NotFound();

        //}

        //[Route("create")]
        //public async Task<IActionResult> CreateUser(CreateUserBindingModel createUserModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var user = new ApplicationUser()
        //    {
        //        UserName = createUserModel.Username,
        //        Email = createUserModel.Email,
        //        FirstName = createUserModel.FirstName,
        //        LastName = createUserModel.LastName,
        //        Level = 3,
        //        JoinDate = DateTime.Now.Date,
        //    };

        //    var addUserResult = await this.AppUserManager.CreateAsync(user, createUserModel.Password);

        //    if (!addUserResult.Succeeded)
        //    {
        //        return GetErrorResult(addUserResult);
        //    }

        //    var locationHeader = new Uri(Url.Link("GetUserById", new { id = user.Id }));

        //    return Created(locationHeader, TheModelFactory.Create(user));
        //}
    }
}
