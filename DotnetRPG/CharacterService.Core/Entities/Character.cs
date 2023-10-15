using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Core.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Hitpoints { get; set; } = 10;
        public int Attack { get; set; } = 1;
        public int Strength { get; set; } = 1;
        public int Defence { get; set; } = 1;
    }
}
