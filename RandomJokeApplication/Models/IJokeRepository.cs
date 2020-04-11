using System.Threading.Tasks;

namespace RandomJokeApplication.Models
{
    interface IJokeRepository
    {
        Task<JokeResponse> AddJokeAsync(JokeResponse item);
    }
}