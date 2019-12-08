using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Models
{
    public class MarathonSkillsContext: IdentityDbContext<User>
    {
        public MarathonSkillsContext(DbContextOptions<MarathonSkillsContext> options):
            base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Charity> Charities{ get; set; }
        public DbSet<Country> Countries{ get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Marathon> Marathons { get; set; }
        public DbSet<RaceKitOption> RaceKitOptions { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RegistrationEvent> RegistrationEvents { get; set; }
        public DbSet<RegistrationStatus> RegistrationStatuses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<TempUser> TempUser{ get; set; }
    }
}
