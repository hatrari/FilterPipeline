using Microsoft.AspNetCore.Mvc;
using FilterPipeline.Filters;

namespace FilterPipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CustomControllerFilter]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Items";
        }
    }
}
