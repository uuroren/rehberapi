// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rehberapi.Context;

namespace rehberapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220131080622_rehber2")]
    partial class rehber2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("rehberapi.models.rehber", b =>
                {
                    b.Property<int>("UUId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("konum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UUId");

                    b.ToTable("Rehbers");
                });
#pragma warning restore 612, 618
        }
    }
}
