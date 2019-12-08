using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarathonSkills.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MarathonSkills
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbContextOptionsBuilder<MarathonContext> builder = new DbContextOptionsBuilder<MarathonContext>();
            MarathonContext context = new MarathonContext(builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MarathonDB;Trusted_Connection=True;").Options);
            context.Database.EnsureCreated();
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
