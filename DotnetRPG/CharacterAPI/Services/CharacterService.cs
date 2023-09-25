using AutoMapper;
using CharacterAPI.Controllers;
using CharacterAPI.Data;
using CharacterAPI.Models;
using CharacterAPI.DTOs;
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

        public async Task<ResponseDTO<Character>> AddCharacter(AddCharacterDTO characterDTO)
        {
            var character = _mapper.Map<Character>(characterDTO);
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();

            return new ResponseDTO<Character> { Data = character };
        }

        public async Task<ResponseDTO<List<Character>>> GetAllCharacters()
        {
            return new ResponseDTO<List<Character>> { Data = await _context.Characters.ToListAsync() };
        }

        public async Task<ResponseDTO<Character>> GetCharacter(Guid id)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(c => c.ID == id);
            if (character == null)
            {
                return new ResponseDTO<Character>
                {
                    Success = false,
                    ErrorMessage = "A character with the given ID does not exist."
                };
            }

            return new ResponseDTO<Character> { Data = character };
        }
    }
}
