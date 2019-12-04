using Microsoft.EntityFrameworkCore;

namespace Lecture.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<Trail> Trails {get;set;}
    }
}