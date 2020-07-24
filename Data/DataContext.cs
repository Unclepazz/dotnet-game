using dotnet_game.Models;
using Microsoft.EntityFrameworkCore;


namespace dotnet_game.Data.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Character> Characters { get; set; }
    }
}