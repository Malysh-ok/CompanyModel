﻿// <auto-generated />
using System;
using DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.DbContext.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("DataAccess.Entities.Communication", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id")
                        .HasName("PK_Communications");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ContactId");

                    b.ToTable("Communications", null, t =>
                        {
                            t.HasComment("Средства коммуникации");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ba452ad-9e91-433e-a7f5-fb3b72d57985"),
                            CompanyId = new Guid("234eaf6d-8d7e-4bc2-8c41-ae8263a34f3c"),
                            PhoneNumber = "+70000000000",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("4c0539e1-11ff-4f9b-bb7e-91e5960f2396"),
                            CompanyId = new Guid("234eaf6d-8d7e-4bc2-8c41-ae8263a34f3c"),
                            ContactId = new Guid("6d7ed6ef-9afd-4b5b-ae3c-3d62c24d33f1"),
                            PhoneNumber = "+70000000001",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("752cf451-11d7-4571-ba6e-8901b3bdc438"),
                            CompanyId = new Guid("7df6315e-16eb-4451-b107-43c646edbe33"),
                            PhoneNumber = "+71000000000",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("073680a6-0c64-4561-9099-fcbf4f34a3ec"),
                            CompanyId = new Guid("08344f4e-816d-4758-94eb-e585f1fc620b"),
                            ContactId = new Guid("180cdbea-46a4-48e7-816e-d23f78cebbc5"),
                            PhoneNumber = "+72000000000",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("1406c86b-d9b3-47cc-aba0-ea3a7873c5a2"),
                            ContactId = new Guid("180cdbea-46a4-48e7-816e-d23f78cebbc5"),
                            PhoneNumber = "+72000000001",
                            Type = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DecisionMakerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id")
                        .HasName("PK_Companies");

                    b.HasIndex("DecisionMakerId")
                        .IsUnique();

                    b.ToTable("Companies", null, t =>
                        {
                            t.HasComment("Компании");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("234eaf6d-8d7e-4bc2-8c41-ae8263a34f3c"),
                            Comment = "Добавлено с помощью миграции",
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2854),
                            Level = 1,
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2863),
                            Name = "СССР"
                        },
                        new
                        {
                            Id = new Guid("7df6315e-16eb-4451-b107-43c646edbe33"),
                            Comment = "Добавлено с помощью миграции",
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2888),
                            Level = 2,
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2889),
                            Name = "Китай"
                        },
                        new
                        {
                            Id = new Guid("08344f4e-816d-4758-94eb-e585f1fc620b"),
                            Comment = "Добавлено с помощью миграции",
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2891),
                            Level = 3,
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2891),
                            Name = "Noname"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasComputedColumnSql("Surname || ' ' || Name || IIF(MiddleName IS NULL, '', ' ' || MiddleName)", true);

                    b.Property<bool>("IsDecisionMaker")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id")
                        .HasName("PK_Contacts");

                    b.HasIndex("CompanyId");

                    b.ToTable("Contacts", null, t =>
                        {
                            t.HasComment("Сотрудники");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("1419da3b-a86c-4d83-b4f7-9b0e5b13c22c"),
                            CompanyId = new Guid("234eaf6d-8d7e-4bc2-8c41-ae8263a34f3c"),
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2899),
                            FullName = "Иванов Иван",
                            IsDecisionMaker = true,
                            JobTitle = "Менеджер",
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2900),
                            Name = "Иван",
                            Surname = "Иванов"
                        },
                        new
                        {
                            Id = new Guid("6d7ed6ef-9afd-4b5b-ae3c-3d62c24d33f1"),
                            CompanyId = new Guid("234eaf6d-8d7e-4bc2-8c41-ae8263a34f3c"),
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2910),
                            FullName = "Петров Петр",
                            IsDecisionMaker = false,
                            JobTitle = "Водитель",
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2911),
                            Name = "Петр",
                            Surname = "Петров"
                        },
                        new
                        {
                            Id = new Guid("0dc6dac6-a32a-4dda-9d4d-c65d8c2547a6"),
                            CompanyId = new Guid("7df6315e-16eb-4451-b107-43c646edbe33"),
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2914),
                            FullName = "Сидоров Сидор",
                            IsDecisionMaker = true,
                            JobTitle = "Менеджер",
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2914),
                            Name = "Сидор",
                            Surname = "Сидоров"
                        },
                        new
                        {
                            Id = new Guid("180cdbea-46a4-48e7-816e-d23f78cebbc5"),
                            CompanyId = new Guid("08344f4e-816d-4758-94eb-e585f1fc620b"),
                            CreationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2923),
                            FullName = "Кузьмин Кузьма",
                            IsDecisionMaker = false,
                            JobTitle = "Механик",
                            ModificationTime = new DateTime(2023, 9, 9, 20, 3, 51, 813, DateTimeKind.Local).AddTicks(2924),
                            Name = "Кузьма",
                            Surname = "Кузьмин"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Communication", b =>
                {
                    b.HasOne("DataAccess.Entities.Company", "Company")
                        .WithMany("Communications")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Communications_CompanyId");

                    b.HasOne("DataAccess.Entities.Contact", "Contact")
                        .WithMany("Communications")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_Communications_ContactId");

                    b.Navigation("Company");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("DataAccess.Entities.Company", b =>
                {
                    b.HasOne("DataAccess.Entities.Contact", "DecisionMaker")
                        .WithOne()
                        .HasForeignKey("DataAccess.Entities.Company", "DecisionMakerId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("FK_Companies_DecisionMakerId");

                    b.Navigation("DecisionMaker");
                });

            modelBuilder.Entity("DataAccess.Entities.Contact", b =>
                {
                    b.HasOne("DataAccess.Entities.Company", "Company")
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Contacts_CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataAccess.Entities.Company", b =>
                {
                    b.Navigation("Communications");

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("DataAccess.Entities.Contact", b =>
                {
                    b.Navigation("Communications");
                });
#pragma warning restore 612, 618
        }
    }
}
