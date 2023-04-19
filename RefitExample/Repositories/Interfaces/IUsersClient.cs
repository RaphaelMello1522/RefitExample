using Refit;
using RefitExample.Dtos;

namespace RefitExample.Repositories.Interfaces
{
    public interface IUsersClient
    {
        [Get("/users")]
        Task<IEnumerable<UserDto>> GetAll();
    }
}
