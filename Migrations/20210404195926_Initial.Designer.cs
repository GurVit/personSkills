﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonSkill.Models;

namespace PersonSkill.Migrations
{
    [DbContext(typeof(PSContext))]
    [Migration("20210404195926_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonSkill.Models.Person", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("PersonSkill.Models.Skill", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long?>("Personid")
                        .HasColumnType("bigint");

                    b.Property<byte>("level")
                        .HasColumnType("tinyint");

                    b.HasKey("name");

                    b.HasIndex("Personid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("PersonSkill.Models.Skill", b =>
                {
                    b.HasOne("PersonSkill.Models.Person", null)
                        .WithMany("skills")
                        .HasForeignKey("Personid");
                });

            modelBuilder.Entity("PersonSkill.Models.Person", b =>
                {
                    b.Navigation("skills");
                });
#pragma warning restore 612, 618
        }
    }
}
