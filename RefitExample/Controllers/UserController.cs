using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RefitExample.Controllers
{
    [Route("/users")]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        //public Task<IEnumerable<UserDto>> Users([FromServices] IUsersClient usersClient)
        //{
        //    return usersClient.GetAll();
        //}
    }
}
