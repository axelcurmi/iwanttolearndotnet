using CharacterAPI.Controllers;
using CharacterAPI.Models;
using CharacterAPI.Models.DTO;

namespace CharacterAPI.Services
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacter(Guid id);
        Task<Character> AddCharacter(AddCharacterDTO characterDTO);
    }
}
