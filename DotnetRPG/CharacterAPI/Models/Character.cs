namespace CharacterAPI.Models
{
    public class Character
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Health { get; set; } = 10;
        public int Strength { get; set; } = 1;
        public int Dexterity { get; set; } = 1;
        public int Intelligence { get; set; } = 1;

        public Character(string name)
        {
            this.Name = name;
        }
    }
}
