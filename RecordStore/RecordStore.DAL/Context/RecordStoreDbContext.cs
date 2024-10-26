using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Context
{
    public class RecordStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string[] server = {"DESKTOP-QJIAQ3L" , "LAPTOP-3HH2461E", "DESKTOP-M590E2O\\SAMETLESSON" };
            string connectionString = $"Data Source={server[0]};Database=RecordStoreDb;Trusted_Connection=True;Encrypt=No";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
