// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp_HW_13.infrastructure.DataBase;

#nullable disable

namespace WebApp_HW_13.Migrations
{
    [DbContext(typeof(LibararyContext))]
    [Migration("20220611153247_amanat2")]
    partial class amanat2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.Amanat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("MemberID");

                    b.ToTable("Amanats");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountPage")
                        .HasColumnType("int");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.BookLibarary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("CountBook")
                        .HasColumnType("int");

                    b.Property<int>("LibraryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("LibraryID");

                    b.ToTable("BookLibararys");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.Library", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("LibraryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibraryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Librarys");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Codemeli")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.Amanat", b =>
                {
                    b.HasOne("WebApp_HW_13.Models.Entity.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp_HW_13.Models.Entity.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("WebApp_HW_13.Models.Entity.BookLibarary", b =>
                {
                    b.HasOne("WebApp_HW_13.Models.Entity.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp_HW_13.Models.Entity.Library", "library")
                        .WithMany()
                        .HasForeignKey("LibraryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("library");
                });
#pragma warning restore 612, 618
        }
    }
}
