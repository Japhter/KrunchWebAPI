using KrunchWebAPI.Dto;
using KrunchWebAPI.KrunchService;
using Microsoft.AspNetCore.Mvc;

namespace KrunchWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KrunchController : ControllerBase
    {
        private readonly IkrunchService _service;
        public KrunchController(IkrunchService krunchService)
        {
            _service = krunchService;
        }
        [HttpPost]
        [Route("CrunchPhrase")]
        public async Task<ActionResult<ResponseDto>> CrunchPhrase(InputDto model)
        {
            if (model == null)
            {
                return Problem(" model cannot be   null.");
            }
            if(model.phrase.Length<2 || model.phrase.Length > 70)
            {
                return Problem("The phrase is length should range from 2 to 70 characters");
            }

            var crunchedWord = _service.CrunchPhrase(model.phrase);

            return new ResponseDto
            {
                phrase = crunchedWord
            };
        }
    }
}
