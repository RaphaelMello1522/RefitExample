using Refit;
using RefitExample.Dtos;

namespace RefitExample.Repositories.Interfaces
{
    public interface INewsPapperRepository
    {
        [Get("")]
        Task<NewsPapperDto> ReturnNewsPapper();
    }
}
