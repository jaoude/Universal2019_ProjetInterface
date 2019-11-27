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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Person>().HasData(
       new Person
       {
           Id = 1,
           FirstName = "Alaa",
           LastName = "Hijazi",
           Age = 12,
           Title = "President",
           Photo = ImgToByteArray(@"../download.jpg")

       });
       }
        
        


        public byte[] ImgToByteArray(string FileName)

        {

            var img = Image.FromFile(FileName);
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
    }
}
