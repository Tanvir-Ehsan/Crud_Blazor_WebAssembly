using Crud_Blazor_WebAssembly.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Crud_Blazor_WebAssembly.Server.Models
{
    public  partial class MyDbContext:DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.ToTable("Trainee");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Name).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.ContactAddress).HasMaxLength(500).IsUnicode(false);
                entity.Property(e => e.CellPhoneNo).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.EmailAddress).HasMaxLength(50).IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);


        }
        partial void  OnModelCreatingPartial(ModelBuilder modelBuilder);




    }
}
