using DataConsole.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConsole.DAL
{
    public class DataConsoleDbContext : DbContext
    {
        private readonly string _connectionString = "Data Source=localhost;Database=DataConsole;Integrated Security=sspi;";

        public DbSet<Something> Somethings { get; set; }
        public DbSet<SomethingElse> SomethingElses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
