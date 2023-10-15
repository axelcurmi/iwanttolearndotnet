using Characters.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Application.Repositories
{
    public interface ICharacterRepository
    {
        public List<Character> GetAll();
    }
}
