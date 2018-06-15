using Mini_projekat_2___Entity_Framework_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_projekat_2___Entity_Framework_MVVM.Data
{
    class MiniDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");
                    cs.MapRightKey("CourseRefId");
                    cs.ToTable("StudentCourse");
                });

            modelBuilder.Entity<Student>()
                .HasOptional(s => s.Address)
                .WithRequired(ad => ad.Student);

            modelBuilder.Entity<Student>()
                .Property(s => s.sFirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Course>()
                .Property(s => s.cName).HasColumnType("nvarchar").HasMaxLength(120).IsRequired();

            modelBuilder.Entity<Address>()
                .Property(s => s.Address1).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Address>()
                .Property(s => s.City).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Address>()
                .Property(s => s.Country).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();



            base.OnModelCreating(modelBuilder);
        }
    }
}
