using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ORM_Grundlagen.db;

namespace ORM_Grundlagen.Migrations
{
    [DbContext(typeof(OnlineshopContext))]
    partial class OnlineshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("ORM_Grundlagen.models.Person", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<DateTime>("Birthdate")
                    .HasColumnType("datetime");

                b.Property<char>("Department")
                    .HasColumnType("char");

                b.Property<string>("FirstName")
                    .HasColumnType("text");

                b.Property<int>("Gender")
                    .HasColumnType("int");

                b.Property<string>("LastName")
                    .HasColumnType("text");

                b.Property<decimal>("Salary")
                    .HasColumnType("decimal(18, 4)");

                b.HasKey("Id");

                b.ToTable("People");
            });
#pragma warning restore 612, 618
        }
    }
}