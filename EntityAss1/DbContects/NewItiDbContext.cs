using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAss1.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityAss1.DbContects
{
    //Data Annotations
    internal class NewItiDbContext:DbContext
    {
        public NewItiDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database= NewItiDb; Trusted_Connection= true; TrustServerCertificate=true");
        }
        DbSet<NewStudent> Students { get; set; }
        DbSet<NewCourse> Courses { get; set; }

        DbSet<NewDepartment> Departments { get; set; }

        DbSet<NewStd_Course> Std_Courses { get; set; }
        DbSet<NewInstructor> Instructors { get; set; }
        DbSet<NewTopic> Topics { get; set; }
        DbSet<NewCourse_Inst> Course_Insts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewStd_Course>().HasKey(e => new
            {
                e.Std_Id,
                e.Course_Id

            });
            modelBuilder.Entity<NewCourse_Inst>().HasKey(e => new
            {
                e.Course_Id,
                e.Ins_Id,
            });
        }
    }
}
