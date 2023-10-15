using CharacterAPI.Controllers;
using CharacterAPI.Models;
using CharacterAPI.DTOs;

namespace CharacterAPI.Services
{
    public interface ICharacterService
    {
        Task<ResponseDTO<List<Character>>> GetAllCharacters();
        Task<ResponseDTO<Character>> GetCharacter(Guid id);
        Task<ResponseDTO<Character>> AddCharacter(AddCharacterDTO characterDTO);
    }
}
