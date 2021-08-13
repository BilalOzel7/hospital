using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class HastaneContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-V3FGGNT\SQLEXPRESS;Database=Hastane;Trusted_Connection=true");
        }

        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<TibbiBirim> TibbiBirim { get; set; }
        public DbSet<DoktorImage> DoktorImage { get; set; }
    }
}
