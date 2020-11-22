using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DiskInventory.Models
{
    public partial class disk_inventorydbContext : DbContext
    {
        public disk_inventorydbContext()
        {
        }

        public disk_inventorydbContext(DbContextOptions<disk_inventorydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistItem> ArtistItem { get; set; }
        public virtual DbSet<ArtistType> ArtistType { get; set; }
        public virtual DbSet<BorrowedItem> BorrowedItem { get; set; }
        public virtual DbSet<Borrower> Borrower { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<ViewIndividualArtist> ViewIndividualArtist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=disk_inventorydb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("artist");

                entity.Property(e => e.ArtistId).HasColumnName("artistID");

                entity.Property(e => e.ArtistFname)
                    .IsRequired()
                    .HasColumnName("artistFName")
                    .HasMaxLength(60);

                entity.Property(e => e.ArtistLname)
                    .HasColumnName("artistLName")
                    .HasMaxLength(60);

                entity.Property(e => e.ArtistTypeId).HasColumnName("artistTypeID");

                entity.HasOne(d => d.ArtistType)
                    .WithMany(p => p.Artist)
                    .HasForeignKey(d => d.ArtistTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__artist__artistTy__2D27B809");
            });

            modelBuilder.Entity<ArtistItem>(entity =>
            {
                entity.HasKey(e => new { e.ArtistId, e.ItemId })
                    .HasName("PK__artistIt__FA2981E372B39A9A");

                entity.ToTable("artistItem");

                entity.Property(e => e.ArtistId).HasColumnName("artistID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistItem)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__artistIte__artis__38996AB5");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ArtistItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__artistIte__itemI__398D8EEE");
            });

            modelBuilder.Entity<ArtistType>(entity =>
            {
                entity.ToTable("artistType");

                entity.Property(e => e.ArtistTypeId).HasColumnName("artistTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<BorrowedItem>(entity =>
            {
                entity.HasKey(e => new { e.BorrowDate, e.BorrowerId, e.ItemId })
                    .HasName("PK__borrowed__3BD586977EAB7902");

                entity.ToTable("borrowedItem");

                entity.Property(e => e.BorrowDate)
                    .HasColumnName("borrowDate")
                    .HasColumnType("date");

                entity.Property(e => e.BorrowerId).HasColumnName("borrowerID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("returnDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Borrower)
                    .WithMany(p => p.BorrowedItem)
                    .HasForeignKey(d => d.BorrowerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__borrowedI__borro__34C8D9D1");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BorrowedItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__borrowedI__itemI__35BCFE0A");
            });

            modelBuilder.Entity<Borrower>(entity =>
            {
                entity.ToTable("borrower");

                entity.Property(e => e.BorrowerId).HasColumnName("borrowerID");

                entity.Property(e => e.BorrowerFname)
                    .IsRequired()
                    .HasColumnName("borrowerFName")
                    .HasMaxLength(60);

                entity.Property(e => e.BorrowerLname)
                    .HasColumnName("borrowerLName")
                    .HasMaxLength(60);

                entity.Property(e => e.BorrowerPhone)
                    .IsRequired()
                    .HasColumnName("borrowerPhone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.Property(e => e.GenreId).HasColumnName("genreID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__inventor__56A1284ABBCABC7F");

                entity.ToTable("inventory");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.GenreId).HasColumnName("genreID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(60);

                entity.Property(e => e.ItemStatusId).HasColumnName("itemStatusID");

                entity.Property(e => e.ItemTypeId).HasColumnName("itemTypeID");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("releaseDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__inventory__genre__300424B4");

                entity.HasOne(d => d.ItemStatus)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__inventory__itemS__30F848ED");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__inventory__itemT__31EC6D26");
            });

            modelBuilder.Entity<ItemStatus>(entity =>
            {
                entity.ToTable("itemStatus");

                entity.Property(e => e.ItemStatusId).HasColumnName("itemStatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.ToTable("itemType");

                entity.Property(e => e.ItemTypeId).HasColumnName("itemTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ViewIndividualArtist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Individual_Artist");

                entity.Property(e => e.ArtistFname)
                    .IsRequired()
                    .HasColumnName("artistFName")
                    .HasMaxLength(60);

                entity.Property(e => e.ArtistId)
                    .HasColumnName("artistID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArtistLname)
                    .HasColumnName("artistLName")
                    .HasMaxLength(60);

                entity.Property(e => e.ArtistTypeId).HasColumnName("artistTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
