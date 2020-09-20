using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace B4P.Models
{
    public partial class B4PTestContext : DbContext
    {
        public B4PTestContext()
        {
        }

        public B4PTestContext(DbContextOptions<B4PTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Good> Good { get; set; }
        public virtual DbSet<OrderGood> OrderGood { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=B4PTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>(entity =>
            {
                entity.Property(e => e.GoodsId)
                    .HasColumnName("GoodsID")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Goods)
                    .WithMany(p => p.Basket)
                    .HasForeignKey(d => d.GoodsId)
                    .HasConstraintName("FK__Basket__GoodsID__503BEA1C");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Basket)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK__Basket__SizeID__51300E55");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Basket)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Basket__UserID__4F47C5E3");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId)
                    .HasColumnName("CommentID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Comment1)
                    .IsRequired()
                    .HasColumnName("Comment")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsId)
                    .HasColumnName("GoodsID")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Goods)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.GoodsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__GoodsID__17F790F9");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__UserID__6B24EA82");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");

                entity.Property(e => e.DeliveryName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Good>(entity =>
            {
                entity.HasKey(e => e.GoodsId)
                    .HasName("PK__tmp_ms_x__663DA8C0B68AD163");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("GoodsID")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.GoodAmount).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.GoodDescription).HasMaxLength(50);

                entity.Property(e => e.GoodDiscount).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GoodName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.GoodPhotoUrl)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GoodPrice).HasColumnType("numeric(7, 2)");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Good)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Good__SizeID__17036CC0");
            });

            modelBuilder.Entity<OrderGood>(entity =>
            {
                entity.HasKey(e => e.OrderGood1)
                    .HasName("PK__tmp_ms_x__4579AAADD6841D92");

                entity.Property(e => e.OrderGood1).HasColumnName("OrderGood");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("GoodsID")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Goods)
                    .WithMany(p => p.OrderGood)
                    .HasForeignKey(d => d.GoodsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderGood__Goods__18EBB532");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderGood)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderGood__Order__68487DD7");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tmp_ms_x__C3905BAFB0B67ADC");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CommentId)
                    .HasColumnName("CommentID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderDateDelivery).HasColumnType("date");

                entity.Property(e => e.OrderSum).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OrderSumAll).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__CommentI__66603565");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DeliveryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Delivery__6754599E");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__PaymentT__656C112C");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__StatusID__6EF57B66");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__UserID__6C190EBB");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.PaymentType1)
                    .IsRequired()
                    .HasColumnName("PaymentType")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.Property(e => e.Size1)
                    .IsRequired()
                    .HasColumnName("Size")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasColumnName("Status")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tmp_ms_x__1788CCAC8BCBF29A");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAdress).HasMaxLength(40);

                entity.Property(e => e.UserBirthday).HasColumnType("date");

                entity.Property(e => e.UserDiscount).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UserFamily)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UserIp)
                    .HasColumnName("UserIP")
                    .HasMaxLength(20);

                entity.Property(e => e.UserLastName).HasMaxLength(40);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserMail).HasMaxLength(30);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UserPhone).HasMaxLength(20);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__RoleID__03F0984C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
