using Microsoft.AspNetCore.Mvc;
using Movie_M.Api.Services;
using System.Threading.Tasks;

namespace Movie_M.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImdbController : ControllerBase
    {
        private readonly ImdbService _imdbService;
        public ImdbController()
        {
            _imdbService = new ImdbService();
        }

        [HttpGet("top250")]
        public async Task<IActionResult> GetTop250()
        {
           var result= await  _imdbService.GetTop250();
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "somethings got wrong when we access to Top 250 Movie list");
                return NotFound(ModelState);
            }
            

            return Ok(result);
        }

        [HttpGet("comingsoon")]
        public async Task<IActionResult> ComingSoon()
        {
            var result = await _imdbService.GetComingSoonmovie();
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "somethings got wrong when we access to Coming Soon Movies list");
                return NotFound(ModelState);
            }

            return Ok(result);
        }
        [HttpGet("mostpopullar")]
        public async Task<IActionResult> GetMostPopular()
        {
            var result = await _imdbService.GetMostpopularMovie();
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "somethings got wrong when we access to Most Popullar Movies list");
                return NotFound(ModelState);
            }

            return Ok(result);
        }
        [HttpGet("extarnalinks/{imdbId}")]
        public async Task<IActionResult> GetExtarnalLinks(string imdbId)
        {
            var result = await _imdbService.GetExternalsites(imdbId);
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "somethings got wrong when we access to Extarnal Links list");
                return NotFound(ModelState);
            }

            return Ok(result);
        }
    }
}
