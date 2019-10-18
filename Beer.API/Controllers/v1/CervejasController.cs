using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beer.Contratos.v1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bebidas.API.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CervejasController : ControllerBase
    {
        private readonly ILogger<CervejasController> _logger;

        private static List<Cerveja> Cervejas;

        public CervejasController(ILogger<CervejasController> logger)
        {
            _logger = logger;

            if (Cervejas == null)
                Cervejas = new List<Cerveja>
                {
                    new Cerveja{ rotulo="Skol", marca=Marca.Ambev, tipo=TipoCerveja.Pilsen,  apresentacao = new FormaApresentacao{ formato=FormatoApresentacao.Garrafa, litragem=1 } },
                    new Cerveja{ rotulo="Vertigem", marca=Marca.HocusPocus, tipo=TipoCerveja.IPA},
                    new Cerveja{ rotulo="Caium", marca=Marca.Colorado, tipo=TipoCerveja.APA },
                };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Cervejas);
        }

        [HttpGet("{rotulo}")]
        public IActionResult GetOne([FromRoute]string rotulo)
        {
            var cerveja = Cervejas.FirstOrDefault(c => c.rotulo == rotulo);

            if (cerveja == null)
                return NotFound($"Não encontrada a Cerveja '{rotulo}'");

            return Ok(cerveja);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Cerveja cerveja)
        {
            Cervejas.Add(cerveja);

            return Ok();
        }

        [HttpPut("{rotulo}")]
        public IActionResult Update([FromRoute] string rotulo, [FromBody]Cerveja cerveja)
        {
            var cervejaRetirada = Cervejas.FirstOrDefault(c => c.rotulo == rotulo);

            if (cervejaRetirada == null)
                return NotFound($"Não encontrada a Cerveja '{rotulo}'");

            Cervejas.Remove(cervejaRetirada);
            Cervejas.Add(cerveja);

            return Ok();
        }

    }
}
