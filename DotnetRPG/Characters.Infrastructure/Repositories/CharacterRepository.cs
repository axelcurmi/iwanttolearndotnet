using Characters.Application.Repositories;
using Characters.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Infrastructure.Repositories
{
    internal class CharacterRepository : ICharacterRepository
    {
        public List<Character> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
