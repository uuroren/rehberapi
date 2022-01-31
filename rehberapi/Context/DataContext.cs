using Microsoft.EntityFrameworkCore;
using rehberapi.models;

namespace rehberapi.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<rehber> Rehbers { get; set; }
    }
}
