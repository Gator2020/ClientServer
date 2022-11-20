using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext:DbContext
    {
        public DbSet<WeatherForecast> WeatherForeCast {get; set;}
        public string DbPath{get;}
        public DbSet<Post> Posts {get;set;}
        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.path.Join(path, "BlogBox.db");



        }
      protected override void onConfiguring(DbContextOptionsBuilder options)
      {
        options.UseSqlite($"Data Source={DbPath}");dotnet tool install --global dotnet-ef
      }

    

    }
}

