// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ItemDB.Migrations
{
    [DbContext(typeof(ItemDBContext))]
    [Migration("20220315232615_TablesCreated")]
    partial class TablesCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ItemDB.Models.item", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("itemId"), 1L, 1);

                    b.Property<string>("Archetype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personal_Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("itemId");

                    b.HasIndex("OrderId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("ItemDB.Models.order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<DateTime>("EstimatedDelivery")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("ItemDB.Models.recipient", b =>
                {
                    b.Property<int>("recipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("recipientId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemOrdered")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("recipientId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("recipient");
                });

            modelBuilder.Entity("ItemDB.Models.item", b =>
                {
                    b.HasOne("ItemDB.Models.order", "order")
                        .WithMany("item")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("ItemDB.Models.recipient", b =>
                {
                    b.HasOne("ItemDB.Models.order", "order")
                        .WithOne("recipient")
                        .HasForeignKey("ItemDB.Models.recipient", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");
                });

            modelBuilder.Entity("ItemDB.Models.order", b =>
                {
                    b.Navigation("item");

                    b.Navigation("recipient")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
