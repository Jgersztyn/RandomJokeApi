using RandomJokeApplication.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace RandomJokeApplication.Controllers
{
    public class JokeController : ApiController
    {
        static IJokeRepository repository = new JokeRepository();

        [Route("api/joke")]
        [HttpPost]
        public async Task<IHttpActionResult> PostJokeAsync([FromBody]JokeResponse randomJoke)
        {
            if (randomJoke == null)
            {
                return BadRequest("No joke to be found.");
            }

            JokeResponse newJoke = await repository.AddJokeAsync(randomJoke);

            return Ok(newJoke);
        }
    }
}
