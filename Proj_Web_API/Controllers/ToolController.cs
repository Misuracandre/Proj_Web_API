using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proj_Web_API.Models;
using Proj_Web_API.Services;

namespace Proj_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolController : ControllerBase
    {
        [HttpGet(Name = "Get")]
        public List<Tool> Get()
        {
            //return new List<Tool>();
            return new ToolService().GetAll();
        }

        [HttpPost(Name = "Insert")]
        public ActionResult Insert(Tool tool)
        {
            return new ToolService().Insert(tool) ? StatusCode(200) : BadRequest();
        }
    }
}
