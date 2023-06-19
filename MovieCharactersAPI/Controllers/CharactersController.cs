using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCharactersAPI.Data;
using MovieCharactersAPI.DataTransferObjects.CharacterDTO;
using MovieCharactersAPI.Model;

namespace MovieCharactersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("Application/json")] //for documenting the media type
    [Consumes("Application/json")]

    public class CharactersController : ControllerBase
    {
        private readonly MovieCharactersDbContext _context;
        private readonly IMapper _mapper; //underscore mapper is a local variable (but it's unused - necessary?)

        public CharactersController(MovieCharactersDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all the characters
        /// </summary>
        /// <returns>Return the list of characters</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        // GET: api/Characters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DTOReadCharacter>>> GetCharacters()
        {
          if (_context.Characters == null)
          {
              return NotFound();
          }
            var characterModel = await _context.Characters.ToListAsync();
            var characterDto = _mapper.Map<List<DTOReadCharacter>>(characterModel);
            return Ok(characterDto);
        }

        // GET: api/Characters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DTOReadCharacter>> GetCharacter(int id)
        {
          if (_context.Characters == null)
          {
              return NotFound();
          }
            var character = await _context.Characters.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return _mapper.Map<DTOReadCharacter>(character);
        }

        // PUT: api/Characters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter(int id, Character character)
        {
            if (id != character.Id)
            {
                return BadRequest();
            }

            _context.Entry(character).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Characters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DTOReadCharacter>> PostCharacter(DTOCreateCharacter character)
        {
          if (_context.Characters == null)
          {
              return Problem("Entity set 'MovieCharactersDbContext.Characters'  is null.");
          }
            var characterModel = _mapper.Map<Character>(character);
            _context.Characters.Add(characterModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = characterModel.Id }, character);
        }

        // DELETE: api/Characters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            if (_context.Characters == null)
            {
                return NotFound();
            }
            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterExists(int id)
        {
            return (_context.Characters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
