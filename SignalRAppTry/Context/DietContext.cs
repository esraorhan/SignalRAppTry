using Microsoft.EntityFrameworkCore;
using SignalRAppTry.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAppTry.Context
{
    public class DietContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8AK4CAP;Database=DietitianAutomationDB;User Id=sa;Password=esra1905;");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-EK3IE5F;Database=DietitianAutomationDB;User Id=sa;Password=123456;");
        }

        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
