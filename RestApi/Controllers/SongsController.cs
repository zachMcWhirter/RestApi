using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Models;
using RestApi.Repositorties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Policy1")]

    public class SongsController : ControllerBase
    {
        private readonly ISongRepository _songRepository;

        public SongsController(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        // GET: api/<SongsController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_songRepository.GetAll());
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var song = _songRepository.GetById(id);

            if(!_songRepository.IsExistingId(id))
            {
                return NotFound("No record found matching this request");
            }
            else
            {
                return Ok(song);
            }           
        }

        // POST api/<SongsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _songRepository.Create(song);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != song.Id)
            {
                return BadRequest("Oops Something went wrong...");
            }
            try
            {
               _songRepository.Update(song);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return NotFound("No Record Found matching this Id...");
            }
            return Ok("Song Updated...");
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _songRepository.GetById(id);

            if (song == null)
            {
                return NotFound("No Record Found matching this Id...");
            }

            _songRepository.Delete(song);

            return Ok("Song Deleted...");
        }

    }
}
