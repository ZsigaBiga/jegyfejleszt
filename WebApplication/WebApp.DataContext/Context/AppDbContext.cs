using Microsoft.EntityFrameworkCore;
using WebApp.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DataContext.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UnregisteredUser> UnregisteredUser { get; set; }
        public DbSet<RegisteredUser> RegisteredUser { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Screening> Screening { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Cashier> Cashier { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
