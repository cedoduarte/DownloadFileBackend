using Microsoft.AspNetCore.Mvc;
using ReturnFileEndpoint.Services;

namespace ReturnFileEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemporaryFileController : Controller
    {
        private readonly ITemporaryFileService _temporaryFileService;

        public TemporaryFileController(ITemporaryFileService temporaryFileService)
        {
            _temporaryFileService = temporaryFileService;
        }

        [HttpGet("person-file")]
        public async Task<IActionResult> GetFile()
        {
            var personFile = await _temporaryFileService.GetFile();
            return File(personFile.Bytes, personFile.AcceptHeader, personFile.FileName);
        }
    }
}
