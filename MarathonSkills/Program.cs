using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MarathonSkills
{
    public class Program
    {
        private static void InitializeUsers ()
        {
            DbContextOptionsBuilder<MarathonSkillsContext> builder = new DbContextOptionsBuilder<MarathonSkillsContext>();
            MarathonSkillsContext context = new MarathonSkillsContext(builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MarathonDB;Trusted_Connection=True;").Options);
            context.Database.EnsureCreated();
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            foreach (var tempUser in context.TempUser.ToList())
            {
                var user = context.Users.First(u => u.Email == tempUser.Email);
                context.UserRoles.Add(new IdentityUserRole<string>() { UserId = user.Id, RoleId = tempUser.RoleId });
            }
            foreach (var tempUser in context.TempUser.ToList())
            {
                if (tempUser != null)
                {
                    var user = new User()
                    {
                        UserName = tempUser.Email,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnabled = false,
                        SecurityStamp = Guid.NewGuid().ToString().ToLower(),
                        FirstName = tempUser.FirstName,
                        LastName = tempUser.LastName,
                        Email = tempUser.Email
                    };
                    user.PasswordHash = passwordHasher.HashPassword(user, tempUser.Password);

                    context.Users.Add(user);
                }
            }
            context.SaveChanges();
        }

        public static void Main(string[] args)
        {
 

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
