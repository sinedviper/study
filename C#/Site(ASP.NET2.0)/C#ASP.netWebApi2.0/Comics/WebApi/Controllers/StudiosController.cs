using System.Collections.Generic;
using Business.DTOs;
using Business.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers {
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    // здесь описываем взаимодействие с категорией студии но уже через сайт вызывая методы с бекенда
    public class StudiosController : ControllerBase {
        private readonly StudioService studioService;

        public StudiosController() {
            this.studioService = new StudioService();
        }

        [HttpGet]
        public IEnumerable<StudioDto> GetAll(string title) {
            return studioService.GetAll(title);
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public ActionResult<StudioDto> Get([FromRoute] int id) {
            var result = studioService.GetById(id);

            if (result == null) {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/Genres
        [HttpPost]
        public IActionResult Create([FromBody] StudioDto company) {
            if (!company.IsValid()) {
                return BadRequest();
            }

            if (studioService.Create(company)) {
                return NoContent();
            }

            return BadRequest();
        }

        // PUT: api/Genres/5
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] StudioDto company) {
            if (!company.IsValid()) {
                return BadRequest();
            }

            company.Id = id;

            if (studioService.Update(company)) {
                return NoContent();
            }

            return BadRequest();
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            if (studioService.Delete(id)) {
                return NoContent();
            }

            return BadRequest();
        }
    }
}