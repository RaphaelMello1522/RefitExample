using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Refit;
using RefitExample.Dtos;
using RefitExample.Repositories.Interfaces;

namespace RefitExample.Controllers
{
    [Route("/api/[Controller]")]
    [AllowAnonymous]
    public class RickAndMortyController : ControllerBase
    {
        [HttpGet]
        public Task<RickAndMortyDto> GetData([Body][FromServices] IRickAndMortyRepository rickAndMortyRepository, int id)
        {
            return rickAndMortyRepository.GetCharacter(id);
        }
    }
}
