using Microsoft.AspNetCore.Mvc;
using Movie_M.Api.Services;
using System.Threading.Tasks;

namespace Movie_M.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMovieController : ControllerBase
    {
        private readonly MainServise _mainServise;
        public GetMovieController()
        {
            _mainServise = new MainServise();
        }
        [HttpGet("movie")]
        [HttpGet("movie/{keyword}")]
        [HttpGet("movie/{keyword}/{page}")]
        [HttpGet("movie/{keyword}/{page}/{year}")]
        [HttpGet("movie/{keyword}/{page}/{year}/{type}")]
        public async Task<IActionResult> GetMovieByName([FromRoute] string keyword, string page = "", string year = "", string type = "")
        {
            var result = await _mainServise.GetByKeyWord(keyword, page, year, type);
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "Aradığınız kriterlerde sonuç bulamadık.");
                return NotFound(ModelState);
            }

            return Ok(result);

        }
        [HttpGet("movieId")]
        [HttpGet("movieId/{i}")]
        [HttpGet("movieId/{i}/{type}")]
        [HttpGet("movieId/{i}/{type}/{callback}")]
        [HttpGet("movieId/{i}/{type}/{callback}/{r}")]
        [HttpGet("movieId/{i}/{type}/{callback}/{r}/{y}/{plot}")]
        public async Task<IActionResult> GetMovieByID([FromRoute] string i, string type = "", string callback = "", string r = "", string y = "", string plot="")
        {
            var result = await _mainServise.GetByID(i, type, callback, r,  y, plot);
            if (string.IsNullOrEmpty(result))
            {
                ModelState.AddModelError("", "Aradığınız kriterlerde sonuç bulamadık.");
                return NotFound(ModelState);
            }

            return Ok(result);

        }

    }
}
