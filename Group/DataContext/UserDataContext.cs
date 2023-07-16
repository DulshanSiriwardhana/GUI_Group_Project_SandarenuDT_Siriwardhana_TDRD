using Desktop01.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop01.DataContext
{
    public class UserDataContext:DbContext
    {
        private readonly string path = @"C:\Users\rasin\OneDrive\Desktop\DATABASE.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            => optionBuilder.UseSqlite($"Data Source = {path}");
        public DbSet<User>? Users { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
