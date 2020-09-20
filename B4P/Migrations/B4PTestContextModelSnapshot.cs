﻿// <auto-generated />
using System;
using B4P.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace B4P.Migrations
{
    [DbContext(typeof(B4PTestContext))]
    partial class B4PTestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("B4P.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<decimal?>("GoodsId")
                        .HasColumnName("GoodsID")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<int?>("SizeId")
                        .HasColumnName("SizeID")
                        .HasColumnType("int");

                    b.Property<decimal?>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("GoodsId");

                    b.HasIndex("SizeId");

                    b.HasIndex("UserId");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("B4P.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("B4P.Models.Comment", b =>
                {
                    b.Property<decimal>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CommentID")
                        .HasColumnType("numeric(18, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment1")
                        .IsRequired()
                        .HasColumnName("Comment")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<decimal>("GoodsId")
                        .HasColumnName("GoodsID")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<decimal>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("CommentId");

                    b.HasIndex("GoodsId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("B4P.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DeliveryID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("DeliveryId");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("B4P.Models.Good", b =>
                {
                    b.Property<decimal>("GoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GoodsID")
                        .HasColumnType("numeric(20, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CategoryId")
                        .HasColumnName("CategoryID")
                        .HasColumnType("numeric(10, 0)");

                    b.Property<decimal>("GoodAmount")
                        .HasColumnType("numeric(5, 0)");

                    b.Property<string>("GoodDescription")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal?>("GoodDiscount")
                        .HasColumnType("numeric(2, 0)");

                    b.Property<string>("GoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("GoodPhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("GoodPrice")
                        .HasColumnType("numeric(7, 2)");

                    b.Property<int>("SizeId")
                        .HasColumnName("SizeID")
                        .HasColumnType("int");

                    b.HasKey("GoodsId")
                        .HasName("PK__tmp_ms_x__663DA8C0B68AD163");

                    b.HasIndex("SizeId");

                    b.ToTable("Good");
                });

            modelBuilder.Entity("B4P.Models.OrderGood", b =>
                {
                    b.Property<int>("OrderGood1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderGood")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GoodsId")
                        .HasColumnName("GoodsID")
                        .HasColumnType("numeric(20, 0)");

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.HasKey("OrderGood1")
                        .HasName("PK__tmp_ms_x__4579AAADD6841D92");

                    b.HasIndex("GoodsId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderGood");
                });

            modelBuilder.Entity("B4P.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CommentId")
                        .HasColumnName("CommentID")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<int>("DeliveryId")
                        .HasColumnName("DeliveryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("OrderDateDelivery")
                        .HasColumnType("date");

                    b.Property<string>("OrderOperation_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OrderSum")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<decimal>("OrderSumAll")
                        .HasColumnType("numeric(18, 2)");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnName("PaymentTypeID")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnName("StatusID")
                        .HasColumnType("int");

                    b.Property<decimal>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("OrderId")
                        .HasName("PK__tmp_ms_x__C3905BAFB0B67ADC");

                    b.HasIndex("CommentId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("B4P.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PaymentTypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaymentType1")
                        .IsRequired()
                        .HasColumnName("PaymentType")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("B4P.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("B4P.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SizeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Size1")
                        .IsRequired()
                        .HasColumnName("Size")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.HasKey("SizeId");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("B4P.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("StatusID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status1")
                        .IsRequired()
                        .HasColumnName("Status")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("B4P.Models.Users", b =>
                {
                    b.Property<decimal>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasColumnType("numeric(18, 0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleID")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("UserAdress")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime?>("UserBirthday")
                        .HasColumnType("date");

                    b.Property<decimal?>("UserDiscount")
                        .HasColumnType("numeric(2, 0)");

                    b.Property<string>("UserFamily")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("UserIp")
                        .HasColumnName("UserIP")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserMail")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UserId")
                        .HasName("PK__tmp_ms_x__1788CCAC8BCBF29A");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("B4P.Models.Basket", b =>
                {
                    b.HasOne("B4P.Models.Good", "Goods")
                        .WithMany("Basket")
                        .HasForeignKey("GoodsId")
                        .HasConstraintName("FK__Basket__GoodsID__503BEA1C");

                    b.HasOne("B4P.Models.Size", "Size")
                        .WithMany("Basket")
                        .HasForeignKey("SizeId")
                        .HasConstraintName("FK__Basket__SizeID__51300E55");

                    b.HasOne("B4P.Models.Users", "User")
                        .WithMany("Basket")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Basket__UserID__4F47C5E3");
                });

            modelBuilder.Entity("B4P.Models.Comment", b =>
                {
                    b.HasOne("B4P.Models.Good", "Goods")
                        .WithMany("Comment")
                        .HasForeignKey("GoodsId")
                        .HasConstraintName("FK__Comment__GoodsID__17F790F9")
                        .IsRequired();

                    b.HasOne("B4P.Models.Users", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Comment__UserID__6B24EA82")
                        .IsRequired();
                });

            modelBuilder.Entity("B4P.Models.Good", b =>
                {
                    b.HasOne("B4P.Models.Size", "Size")
                        .WithMany("Good")
                        .HasForeignKey("SizeId")
                        .HasConstraintName("FK__Good__SizeID__17036CC0")
                        .IsRequired();
                });

            modelBuilder.Entity("B4P.Models.OrderGood", b =>
                {
                    b.HasOne("B4P.Models.Good", "Goods")
                        .WithMany("OrderGood")
                        .HasForeignKey("GoodsId")
                        .HasConstraintName("FK__OrderGood__Goods__18EBB532")
                        .IsRequired();

                    b.HasOne("B4P.Models.Orders", "Order")
                        .WithMany("OrderGood")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderGood__Order__68487DD7")
                        .IsRequired();
                });

            modelBuilder.Entity("B4P.Models.Orders", b =>
                {
                    b.HasOne("B4P.Models.Comment", "Comment")
                        .WithMany("Orders")
                        .HasForeignKey("CommentId")
                        .HasConstraintName("FK__Orders__CommentI__66603565")
                        .IsRequired();

                    b.HasOne("B4P.Models.Delivery", "Delivery")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryId")
                        .HasConstraintName("FK__Orders__Delivery__6754599E")
                        .IsRequired();

                    b.HasOne("B4P.Models.PaymentType", "PaymentType")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentTypeId")
                        .HasConstraintName("FK__Orders__PaymentT__656C112C")
                        .IsRequired();

                    b.HasOne("B4P.Models.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK__Orders__StatusID__6EF57B66")
                        .IsRequired();

                    b.HasOne("B4P.Models.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Orders__UserID__6C190EBB")
                        .IsRequired();
                });

            modelBuilder.Entity("B4P.Models.Users", b =>
                {
                    b.HasOne("B4P.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__Users__RoleID__03F0984C")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}