﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.DataBase;

namespace WebApplication.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Models.Algorithm.MrAlgorithm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.ToTable("MrAlgorithms");
                });

            modelBuilder.Entity("WebApplication.Models.Data.MrAnalyze", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("MrAlgorithmId");

                    b.Property<Guid>("MrRecordId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("MrAlgorithmId");

                    b.HasIndex("MrRecordId");

                    b.ToTable("MrAnalyzes");
                });

            modelBuilder.Entity("WebApplication.Models.Data.MrRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("HospitalId");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("MrRecords");
                });

            modelBuilder.Entity("WebApplication.Models.HospitalModels.Hospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("WebApplication.Models.HospitalModels.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessToken");

                    b.Property<DateTime>("End");

                    b.Property<Guid>("HospitalId");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("WebApplication.Models.Data.MrAnalyze", b =>
                {
                    b.HasOne("WebApplication.Models.Algorithm.MrAlgorithm", "MrAlgorithm")
                        .WithMany("MrAnalyzes")
                        .HasForeignKey("MrAlgorithmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication.Models.Data.MrRecord", "MrRecord")
                        .WithMany("MyProperty")
                        .HasForeignKey("MrRecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication.Models.Data.MrRecord", b =>
                {
                    b.HasOne("WebApplication.Models.HospitalModels.Hospital", "Hospital")
                        .WithMany("MrRecords")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication.Models.HospitalModels.Subscription", b =>
                {
                    b.HasOne("WebApplication.Models.HospitalModels.Hospital", "Hospital")
                        .WithMany("Subscriptions")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}