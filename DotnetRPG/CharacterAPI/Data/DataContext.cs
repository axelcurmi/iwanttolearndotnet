using CharacterAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
    }
}
