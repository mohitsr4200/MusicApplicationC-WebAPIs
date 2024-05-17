using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DBcontent
{
    public class SongSql : DbContext
    {
        
        public SongSql(DbContextOptions<SongSql> dbcontextoption) : base(dbcontextoption)
        {
        }
        public DbSet<Album> Album { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasKey(e => e.SongID);
            base.OnModelCreating(modelBuilder);
        }
        

    }
}
