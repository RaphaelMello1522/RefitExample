using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RefitExample.Dtos;
using RefitExample.Repositories.Interfaces;

namespace RefitExample.Controllers
{
    [Route("/api/[Controller]")]
    [AllowAnonymous]
    public class DigitalOceanController : ControllerBase
    {
        [HttpGet]
        public Task<DigitalOceanDto> GetData([FromServices] IDigitalOceanRepository digitalOceanRepository)
        {
            return digitalOceanRepository.GetDataFromAPI();
        }
    }
}
