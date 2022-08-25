using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Services;
using VoeAirlines.ViewModels.Aeronave;

namespace VoeAirlines.Controllers
{
    [Route("api/aeronaves")]
    [ApiController]
    public class AeronaveController : ControllerBase
    {
        private readonly AeronaveService _aeronaveService;

        public AeronaveController(AeronaveService aeronaveService)
        {
            _aeronaveService = aeronaveService;
        }

        [HttpPost]
        public IActionResult AdicionarAeronave(AdicionarAeronaveViewModel dados)
        {
            var aeronave = _aeronaveService.AdicionarAeronave(dados);
            return Ok(aeronave);            
        }

        [HttpPut]
        public IActionResult AtualizarAeronave(int id, AtualizarAeronaveViewModel dados)
        {
            var aeronave = _aeronaveService.AtualizarAeronave(id, dados);
            return Ok(aeronave);
        }

        [HttpGet]
        public IActionResult ListarAeronaves()
        {
            var aeronave = _aeronaveService.ListarAeronaves();
            return Ok(aeronave);
        }
        [HttpGet("{id:int}")]
        public IActionResult ListarAeronavesPorId(int id)
        {
            var aeronave = _aeronaveService.ListarAeronavePorId(id);
            return Ok(aeronave);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoverAeronave(int id)
        {
            var aeronave = _aeronaveService.RemoverAeronave(id);
            return Ok(aeronave);
        }
    }
}
