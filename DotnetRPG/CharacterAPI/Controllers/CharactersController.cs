using CharacterAPI.Models;
using CharacterAPI.Models.DTO;
using CharacterAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharacterAPI.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ILogger<CharactersController> _logger;
        private readonly ICharacterService _characterService;

        public CharactersController(ILogger<CharactersController> logger,
            ICharacterService characterService)
        {
            _logger = logger;
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(Guid id) {
            return Ok(await _characterService.GetCharacter(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCharacter(AddCharacterDTO characterDTO)
        {
            return Ok(await _characterService.AddCharacter(characterDTO));
        }
    }
}
