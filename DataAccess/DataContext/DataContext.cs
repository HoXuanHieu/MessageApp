using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataContext
{
    public class DataContext : DbContext
    {
        public DbSet<Friends> friends { get; set; }
        public DbSet<Messages> messages { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = string.Format("Data Source=localhost;Initial Catalog=MessageApp;User ID=sa;Password=hieuhohieuho123;TrustServerCertificate=true;");
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
