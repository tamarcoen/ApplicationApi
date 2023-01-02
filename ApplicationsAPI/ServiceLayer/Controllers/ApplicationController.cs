using BuisnessLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private IApplicationBO applicationBo;
        public ApplicationController(IApplicationBO _applicationBO)
        {
            applicationBo = _applicationBO;
        }
        [HttpGet("[action]")]
        public IActionResult GetApplications()
        {
            var res= applicationBo.GetApplications();
            if(res!=null)
            return Ok(res);
            return BadRequest();
        }

        [HttpGet("GetCards")]
        public IActionResult GetCards([FromQuery] string appId)
        {
            var res = applicationBo.GetCards(appId);
            if (res != null)
                return Ok(res);
            return BadRequest();
        }

        [HttpGet("GetTrans")]
        public IActionResult GetTrans([FromQuery] string appId)
        {
            var res = applicationBo.GetTrans(appId);
            if (res != null)
                return Ok(res);
            return BadRequest();
        }
    }
}
