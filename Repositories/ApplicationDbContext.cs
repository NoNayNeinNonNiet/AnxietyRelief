using Entities.DbEntities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public virtual DbSet<JournalEntry> JournalEntries { get; set; }
        public virtual DbSet<CrossOutList> CrossOutLists { get; set; }




        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<ApplicationUser>()
                .HasMany(x => x.JournalEntries)
                .WithRequired(x => x.User)
                .WillCascadeOnDelete(false);





            modelBuilder
                .Entity<JournalEntry>()
                .HasKey(x => x.Id);
            modelBuilder
                .Entity<JournalEntry>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            //modelBuilder
            //    .Entity<JournalEntry>()
            //    .HasRequired(x => x.User)
            //    .WithMany(x => x.JournalEntries)
            //    .HasForeignKey(x => x.UserId)
            //    .WillCascadeOnDelete(false);





            modelBuilder
                .Entity<CrossOutList>()
                .HasKey(x => x.UserId);
            modelBuilder
                .Entity<CrossOutList>()
                .HasRequired(x => x.User)
                .WithRequiredDependent(x => x.CrossOutList)
                .WillCascadeOnDelete(false);
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.Filtering)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.Overgeneralization)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.PolarizedThinking)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.Catastrophising)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.Shoulds)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.MindReading)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.EmotionalReasoning)
                .IsRequired();
            modelBuilder
                .Entity<CrossOutList>()
                .Property(x => x.Personalizing)
                .IsRequired();
        }
    }
}