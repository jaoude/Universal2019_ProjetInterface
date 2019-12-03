using Microsoft.EntityFrameworkCore;
using MultiFace.DAL.Entities;
using System.IO;
using System.Drawing;

namespace MultiFace.DAL.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
