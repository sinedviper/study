using System.Collections.Generic;
using Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers {
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    // здесь описываем взаимодействие с категорией жанров но уже через сайт вызывая методы с бекенда
    public class GenresController : ControllerBase {
        private readonly Business.Services.GenreService genreService;

        public GenresController() {
            this.genreService = new Business.Services.GenreService();
        }

        // GET: api/Genres
        [HttpGet]
        public IEnumerable<GenreDto> GetAll(string title) {
            return genreService.GetAll(title);
        }

        // GET: api/Genres/5
        [HttpGet("{id}")]
        public ActionResult<GenreDto> Get([FromRoute] int id) {
            var result = genreService.GetById(id);

            if (result == null) {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/Genres
        [HttpPost]
        public IActionResult Create([FromBody] GenreDto genre) {
            if (!genre.IsValid()) {
                return BadRequest();
            }

            if (genreService.Create(genre)) {
                return NoContent();
            }

            return BadRequest();
        }

        // PUT: api/Genres/5
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] GenreDto genre) {
            if (!genre.IsValid()) {
                return BadRequest();
            }

            genre.Id = id;

            if (genreService.Update(genre)) {
                return NoContent();
            }

            return BadRequest();
        }

        // DELETE: api/Genres/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            if (genreService.Delete(id)) {
                return NoContent();
            }

            return BadRequest();
        }
    }
}