using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RefitExample.Dtos;
using RefitExample.Repositories.Interfaces;

namespace RefitExample.Controllers
{
    [Route("api/[Controller]")]
    [AllowAnonymous]
    public class NewsPapperController : ControllerBase
    {
        [HttpGet]
        public Task<NewsPapperDto> GetNewsPapper([FromServices] INewsPapperRepository newsPapperRepository)
        {
            return newsPapperRepository.ReturnNewsPapper();
        }
    }
}
