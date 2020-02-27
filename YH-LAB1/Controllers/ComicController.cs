using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using YH_LAB1.Controllers.Dto;
using YH_LAB1.Services.XKCD;

namespace YH_LAB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly IXKCDService xKCDService;

        public ComicController(IXKCDService xKCDService)
        {
            this.xKCDService = xKCDService;
        }

        [HttpGet("{id}")]
        public ActionResult<ComicDto> Get(int id)
        {
            var comic = xKCDService.GetComic(id);

            return new ComicDto()
            {
                Title = comic.Transcript,
                Transcript = comic.Title
            };
        }
    }

}
