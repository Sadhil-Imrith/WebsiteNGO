using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SA_Outreach_Website.Models;
using System.Diagnostics.CodeAnalysis;

namespace SA_Outreach_Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         

      
        public DbSet<Events> Event { get; set; }

        public DbSet<Volunteers> Volunteer { get; set; }

        public DbSet<Donation> Donations { get; set; }

        public DbSet<Donors> Donor { get; set; }
    }
}
