using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bebidas.API.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class DominioController : ControllerBase
    {
        public static List<string> Dominios;

        private readonly ILogger<DominioController> _logger;

        public DominioController(ILogger<DominioController> logger)
        {
            _logger = logger;

            if (Dominios == null)
                Dominios = new List<string>
                {
                    "Marca",
                    "TipoCerveja",
                    "TipoSuco",
                    "FormatoApresentacao"
                };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Dominios);
        }
    }
}
