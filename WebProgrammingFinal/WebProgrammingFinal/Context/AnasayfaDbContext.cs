using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgrammingFinal.Controllers;
using WebProgrammingFinal.Models;

namespace WebProgrammingFinal.CONTEXT

{
    public class AnasayfaDbContext : DbContext
    {
        public AnasayfaDbContext(DbContextOptions<AnasayfaDbContext> options) : base(options)
        {


        }

      
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBFINAL;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}

        public DbSet<Anasayfa>Anasayfa { get; set; }
        public DbSet<Hakkimda>Hakkimda { get; set; }
        public DbSet<Galerim>Galerim { get; set; }
        public DbSet<Projelerim>Projelerim { get; set; }
        public DbSet<Ulasim>Ulasim { get; set; }

        public static implicit operator AnasayfaDbContext(GalerimController v)
        {
            throw new NotImplementedException();
        }
    }
}
