﻿// <auto-generated />
using System;
using ConsentCode.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsentCode.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240929203653_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsentCode.Models.ProjectCondition", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("Budget")
                        .HasColumnType("integer");

                    b.Property<int>("Content")
                        .HasColumnType("integer");

                    b.Property<int>("Deadlines")
                        .HasColumnType("integer");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<int>("Progress")
                        .HasColumnType("integer");

                    b.Property<string>("ReportLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProjectsCondition");
                });

            modelBuilder.Entity("ConsentCode.Models.ProjectConditionView", b =>
                {
                    b.Property<int>("Budget")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Content")
                        .HasColumnType("integer");

                    b.Property<int>("Deadlines")
                        .HasColumnType("integer");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Progress")
                        .HasColumnType("integer");

                    b.Property<string>("ReportLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable((string)null);

                    b.ToView("ProjectConditionView", (string)null);
                });

            modelBuilder.Entity("ConsentCode.Models.ProjectGeneralInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Activity")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Monitoring")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Priority")
                        .HasColumnType("float4");

                    b.Property<string>("Program")
                        .HasColumnType("text");

                    b.Property<string>("RGT")
                        .HasColumnType("char");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StrategyBelonging")
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProjectsGeneralInfo");
                });

            modelBuilder.Entity("ConsentCode.Models.ProjectCondition", b =>
                {
                    b.HasOne("ConsentCode.Models.ProjectGeneralInfo", "GeneralInfo")
                        .WithOne("Condition")
                        .HasForeignKey("ConsentCode.Models.ProjectCondition", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralInfo");
                });

            modelBuilder.Entity("ConsentCode.Models.ProjectGeneralInfo", b =>
                {
                    b.Navigation("Condition")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
