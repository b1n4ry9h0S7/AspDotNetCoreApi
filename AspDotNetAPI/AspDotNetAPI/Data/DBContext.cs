using AspDotNetAPI.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetAPI.Data
{
    public class DBContext: DbContext
    {

        public DBContext(DbContextOptions<DBContext> options): base(options) { 
        

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalksDifficulty { get; set; }

    }
}
