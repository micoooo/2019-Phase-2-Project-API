using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TODOlistAPI.Model
{
    public partial class TODOlistContext : DbContext
    {
        public TODOlistContext()
        {
        }

        public TODOlistContext(DbContextOptions<TODOlistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Todo> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:todoolist.database.windows.net,1433;Initial Catalog=TODOlist;Persist Security Info=False;User ID=micoo;Password=Lollies1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>(entity =>
            {
                entity.Property(e => e.TaskDescription).IsUnicode(false);

                entity.Property(e => e.TaskTitle).IsUnicode(false);
            });
        }
    }
}
