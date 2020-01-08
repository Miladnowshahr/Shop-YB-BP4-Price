using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopYB.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAccount> RoleAccount { get; set; }
        public virtual DbSet<SlideShow> SlideShow { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Photo> Photos { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<LikeDislike> LikeDislikes { get; set; }

        public virtual DbSet<PayMethod> PayMethods { get; set; }

        public virtual DbSet<ContactUs> ContactUs { get; set; } 

        public virtual DbSet<Config> Configs { get; set; }

        public virtual DbSet<ProductCategoryDiscount> ProductCategoryDiscounts { get; set; }

        public virtual DbSet<ProductDiscount> ProductDiscounts { get; set; }

        public virtual DbSet<UserRewardPoint> UserRewardPoints { get; set; }

        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        
        public virtual DbSet<PDiscount> PDiscounts { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParents)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Category_Category");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleAccount>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.AccountId })
                    .HasName("PK_RoleAccount_Tbl");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.RoleAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleAccount_Tbl_Account_Tbl");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAccounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleAccount_Tbl_Role_Tbl");
            });

            modelBuilder.Entity<Product>(entity =>
            {

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category_Product");


            });

            modelBuilder.Entity<Photo>(entity =>
            {

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Photo");


            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasOne(d => d.Payments)
                .WithOne(o => o.Invoice)
                .HasForeignKey<Payment>(d => d.InvoiceId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Account");
            });


            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.ProductId });
                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_Invoice");

                entity.HasOne(d => d.Product)
                   .WithMany(p => p.InvoiceDetails)
                   .HasForeignKey(d => d.ProductId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_InvoiceDetails_Product");
            });


            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasOne(d => d.Account)
                   .WithMany(p => p.Addresses)
                   .HasForeignKey(d => d.AccountId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_AddressTable_Account");

            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.AddressId });

                //entity.HasOne(d => d.Invoice)
                //    .WithOne(p => p.Ships)
                //    .HasForeignKey(d => d.)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Ship_Invoice");

                //entity.HasOne(d => d.Address)
                //   .WithMany(p => p.Ships)
                //   .HasForeignKey(d => d.AddressId)
                //   .OnDelete(DeleteBehavior.ClientSetNull)
                //   .HasConstraintName("FK_Ship_Product");
            });

            modelBuilder.Entity<Payment>(entity =>
            {


                entity.HasOne(d => d.Account)
                   .WithMany(p => p.Payments)
                   .HasForeignKey(d => d.AccountId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Payment_Product");


                entity.HasOne(d => d.PayMethods)
                .WithMany(p => p.Payments)
                .HasForeignKey(d => d.PayMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_PayMethod");
            });

            modelBuilder.Entity<Comment>(entity =>
            {

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Product");

            });

            modelBuilder.Entity<LikeDislike>(entity =>
            {

            entity.HasOne(d => d.Comment)
                .WithMany(p => p.LikeDislikes)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LikeDislike_Comment");

            });

           
        }
    }
}