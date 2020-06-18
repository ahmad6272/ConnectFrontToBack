using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectFrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectFrontToBack.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base( options )
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bio> Bios { get; set; }
    }
}
