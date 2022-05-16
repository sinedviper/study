using System.Collections.Generic;
using Business.DTOs;
using Business.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SC.WebApi.Controllers {
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    // здесь описываем взаимодействие с категорией комиксов но уже через сайт вызывая методы с бекенда
    public class ComicsController : ControllerBase {
        private readonly ComicsService comicsService;

        public ComicsController() {
            this.comicsService = new ComicsService();
        }

        // GET: api/Genres
        [HttpGet]
        public IEnumerable<ComicsDto> GetAll(string title) {
            return comicsService.GetAll(title);
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public ActionResult<ComicsDto> Get([FromRoute] int id) {
            var result = comicsService.GetById(id);

            if (result == null) {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/Genres
        [HttpPost]
        public IActionResult Create([FromBody] ComicsDto comics) {
            if (!comics.IsValid()) {
                return BadRequest();
            }

            if (comicsService.Create(comics)) {
                return NoContent();
            }

            return BadRequest();
        }

        // PUT: api/Genres/5
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] ComicsDto comics) {
            if (!comics.IsValid()) {
                return BadRequest();
            }

            comics.Id = id;

            if (comicsService.Update(comics)) {
                return NoContent();
            }

            return BadRequest();
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            if (comicsService.Delete(id)) {
                return NoContent();
            }

            return BadRequest();
        }
    }
}