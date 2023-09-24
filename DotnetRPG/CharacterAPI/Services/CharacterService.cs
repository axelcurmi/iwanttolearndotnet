using AutoMapper;
using CharacterAPI.Controllers;
using CharacterAPI.Data;
using CharacterAPI.Models;
using CharacterAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace CharacterAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ILogger<CharacterService> _logger;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CharacterService(
            ILogger<CharacterService> logger,
            IMapper mapper,
            DataContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Character> AddCharacter(AddCharacterDTO characterDTO)
        {
            var character = _mapper.Map<Character>(characterDTO);
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return character;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character> GetCharacter(Guid id)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(c => c.ID == id);
            return character;
        }
    }
}
