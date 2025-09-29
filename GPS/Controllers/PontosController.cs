using GPS.DTOs;
using GPS.Services;
using Microsoft.AspNetCore.Mvc;

namespace GPS.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PontosController : ControllerBase {

        private readonly IPontosService _service;

        public PontosController(IPontosService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PontosInteresseDTO>>> Get() {
            try {
                var pontos = await _service.GetAll();
                return Ok(pontos);
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("PontosInteresse")]

        public async Task<ActionResult<IEnumerable<PontosInteresseDTO>>> Get([FromQuery]double x, double y, double dist) {

            try {
                var pontos = await _service.PontosProximos(x, y, dist);
                return Ok(pontos);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<PontosInteresseDTO>> Post(PontosInteresseDTO pontosDTO) {

            try {
                if (pontosDTO == null) return BadRequest("Ponto invalido!");
                var ponto = await _service.Post(pontosDTO);
                return Ok(ponto);
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
