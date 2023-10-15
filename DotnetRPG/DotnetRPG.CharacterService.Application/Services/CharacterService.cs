using Characters.Application.Repositories;
using Characters.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Application.Services
{
    internal class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public List<Character> GetAllCharacters()
        {
            return _characterRepository.GetAll();
        }
    }
}
