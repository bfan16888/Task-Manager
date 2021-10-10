using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taskman.Models;

namespace Taskman.Data
{
    public class TaskManDbContext : DbContext
    {
        public TaskManDbContext(DbContextOptions<TaskManDbContext> options) : base(options)
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EmployeeTask>()
            //    .HasOne(t => t.Employee)
            //    .WithMany(e => e.Tasks)
            //    .HasForeignKey(t=>t.EmployeeId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
    }
}
