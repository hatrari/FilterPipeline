using Microsoft.AspNetCore.Mvc;

namespace FilterPipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Items";
        }
    }
}
