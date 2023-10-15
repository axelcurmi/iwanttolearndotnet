using Characters.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Application.Services
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
    }
}
