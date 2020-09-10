using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrowHomeBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegrowHomeWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        public IActionResult GetBlogList()
        {
            return Ok(IntegrowHomeLogic.GetBlogList());
        }
    }
}
