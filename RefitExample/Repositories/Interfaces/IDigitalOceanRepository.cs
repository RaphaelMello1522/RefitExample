using Refit;
using RefitExample.Dtos;

namespace RefitExample.Repositories.Interfaces
{
    public interface IDigitalOceanRepository
    {
        [Get("/v2/summary.json")]
        Task<DigitalOceanDto> GetDataFromAPI();

        [Get("")]
        Task<DigitalOceanDto> GetDataFromAPIByID();
    }
}
