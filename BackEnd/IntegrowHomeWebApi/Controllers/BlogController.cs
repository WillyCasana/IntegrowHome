using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrowHomeBLL;
using IntegrowHomeBOL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegrowHomeWebApi.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [EnableCors("BlogOrigin")]
        public IActionResult GetBlogList()
        {
            return Ok("lista");
        }

        [EnableCors("BlogOrigin")]
        [HttpPost]
        public IActionResult PostBlogRegistrar(EntradaBlogEnt entradaObj)
        {
            entradaObj.ImagenEntrada = "TEST";
            IntegrowHomeLogic.BlogEntradaRegistrar(entradaObj);
            return Created("Ok", new { entradaObj });
        }
    }
}
