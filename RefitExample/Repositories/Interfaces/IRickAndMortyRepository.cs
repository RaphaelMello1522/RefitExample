using Refit;
using RefitExample.Dtos;

namespace RefitExample.Repositories.Interfaces
{
    public interface IRickAndMortyRepository
    {
        [Get("/character/{id}")]
        Task<RickAndMortyDto> GetCharacter(int id);
    }
}
