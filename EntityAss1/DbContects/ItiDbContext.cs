using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAss1.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAss1.DbContects
{
    // By Conventio
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext():base(){
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= ItiDb; Trusted_Connection= true; TrustServerCertificate=true");
        }
        DbSet<Student>Students { get; set; }
        DbSet<Course> Courses { get; set; }

        DbSet<Department>Departments { get; set; }

        DbSet<Std_Course> Std_Courses { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Course_Inst> Course_Insts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Std_Course>().HasKey(e => new
            {
                e.Std_Id,
                e.Course_Id

            });
            modelBuilder.Entity<Course_Inst>().HasKey(e => new
            {
                e.Course_Id,
                e.Ins_Id,
            });
        }
    }
}
