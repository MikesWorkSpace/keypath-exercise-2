﻿// <auto-generated />
using Keypath.API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Keypath.API.Migrations
{
    [DbContext(typeof(KeypathContext))]
    [Migration("20200912215020_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Keypath.API.Models.ExampleItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ExampleItem");

                    b.HasData(
                        new
                        {
                            Id = 1001L,
                            SortOrder = 1,
                            Word = "The"
                        },
                        new
                        {
                            Id = 1002L,
                            SortOrder = 2,
                            Word = "rain"
                        },
                        new
                        {
                            Id = 1003L,
                            SortOrder = 3,
                            Word = "in"
                        },
                        new
                        {
                            Id = 1004L,
                            SortOrder = 4,
                            Word = "Spain"
                        },
                        new
                        {
                            Id = 1005L,
                            SortOrder = 5,
                            Word = "falls"
                        },
                        new
                        {
                            Id = 1006L,
                            SortOrder = 6,
                            Word = "mainly"
                        },
                        new
                        {
                            Id = 1007L,
                            SortOrder = 7,
                            Word = "on"
                        },
                        new
                        {
                            Id = 1008L,
                            SortOrder = 8,
                            Word = "the"
                        },
                        new
                        {
                            Id = 1009L,
                            SortOrder = 9,
                            Word = "plain"
                        },
                        new
                        {
                            Id = 1010L,
                            SortOrder = 101,
                            Word = "Now "
                        },
                        new
                        {
                            Id = 1011L,
                            SortOrder = 102,
                            Word = "is "
                        },
                        new
                        {
                            Id = 1012L,
                            SortOrder = 103,
                            Word = "the"
                        },
                        new
                        {
                            Id = 1013L,
                            SortOrder = 104,
                            Word = "time "
                        },
                        new
                        {
                            Id = 1014L,
                            SortOrder = 105,
                            Word = "for"
                        },
                        new
                        {
                            Id = 1015L,
                            SortOrder = 106,
                            Word = "all"
                        },
                        new
                        {
                            Id = 1016L,
                            SortOrder = 107,
                            Word = "good"
                        },
                        new
                        {
                            Id = 1017L,
                            SortOrder = 108,
                            Word = "men"
                        },
                        new
                        {
                            Id = 1018L,
                            SortOrder = 109,
                            Word = "to "
                        },
                        new
                        {
                            Id = 1019L,
                            SortOrder = 110,
                            Word = "come"
                        },
                        new
                        {
                            Id = 1020L,
                            SortOrder = 111,
                            Word = "to "
                        },
                        new
                        {
                            Id = 1021L,
                            SortOrder = 112,
                            Word = "the "
                        },
                        new
                        {
                            Id = 1022L,
                            SortOrder = 113,
                            Word = "aid"
                        },
                        new
                        {
                            Id = 1023L,
                            SortOrder = 114,
                            Word = "of"
                        },
                        new
                        {
                            Id = 1024L,
                            SortOrder = 115,
                            Word = "their"
                        },
                        new
                        {
                            Id = 1025L,
                            SortOrder = 116,
                            Word = "country"
                        },
                        new
                        {
                            Id = 1026L,
                            SortOrder = 201,
                            Word = "The"
                        },
                        new
                        {
                            Id = 1027L,
                            SortOrder = 202,
                            Word = "quick"
                        },
                        new
                        {
                            Id = 1028L,
                            SortOrder = 203,
                            Word = "brown"
                        },
                        new
                        {
                            Id = 1029L,
                            SortOrder = 204,
                            Word = "fox"
                        },
                        new
                        {
                            Id = 1030L,
                            SortOrder = 205,
                            Word = "jumped"
                        },
                        new
                        {
                            Id = 1031L,
                            SortOrder = 206,
                            Word = "over"
                        },
                        new
                        {
                            Id = 1032L,
                            SortOrder = 207,
                            Word = "the"
                        },
                        new
                        {
                            Id = 1033L,
                            SortOrder = 208,
                            Word = "lazy"
                        },
                        new
                        {
                            Id = 1034L,
                            SortOrder = 209,
                            Word = "dog"
                        },
                        new
                        {
                            Id = 1035L,
                            SortOrder = 301,
                            Word = "How"
                        },
                        new
                        {
                            Id = 1036L,
                            SortOrder = 302,
                            Word = "now "
                        },
                        new
                        {
                            Id = 1037L,
                            SortOrder = 303,
                            Word = "brown"
                        },
                        new
                        {
                            Id = 1038L,
                            SortOrder = 304,
                            Word = "cow"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
