// <auto-generated />
using System;
using Attachment.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Attachment.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220310051228_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Attachment.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Age = 44,
                            CreatedAOn = new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "razhog@gmail.com",
                            FirstName = "Raziyah",
                            LastName = "Hogans",
                            PhoneNumber = "202-333-4444",
                            StartDate = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2,
                            Age = 44,
                            CreatedAOn = new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "mfrank@gmail.com",
                            FirstName = "Mike",
                            LastName = "Franklin",
                            PhoneNumber = "202-561-2367",
                            StartDate = new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 3,
                            Age = 44,
                            CreatedAOn = new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "jsmith@gmail.com",
                            FirstName = "John",
                            LastName = "Smith",
                            PhoneNumber = "202-723-4434",
                            StartDate = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Attachment.Models.Files", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("DataFiles")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DocumentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Attachment.Models.Files", b =>
                {
                    b.HasOne("Attachment.Models.Employee", "Employee")
                        .WithMany("Files")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Attachment.Models.Employee", b =>
                {
                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
