﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Reservations.Data.Context;

namespace Reservations.Data.Migrations
{
    [DbContext(typeof(ReservationsContext))]
    partial class ReservationsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Reservations.Domain.Entities.Client", b =>
                {
                    b.Property<string>("ClientId")
                        .HasColumnType("text")
                        .HasColumnName("clientId");

                    b.Property<string>("AddressCP")
                        .HasColumnType("text")
                        .HasColumnName("addressCP");

                    b.Property<string>("AddressCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryId");

                    b.Property<string>("AddressCountryStateId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryStateId");

                    b.Property<string>("AddressLocality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressLocality");

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressNumber");

                    b.Property<string>("AddressStreet")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressStreet");

                    b.Property<string>("BirthCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("birthCountryId");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birthDate");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("document");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Name2")
                        .HasColumnType("text")
                        .HasColumnName("name2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.Property<string>("Surname2")
                        .HasColumnType("text")
                        .HasColumnName("surname2");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("taxId");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("ClientId");

                    b.HasIndex("AddressCountryId");

                    b.HasIndex("AddressCountryStateId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Country", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnType("text")
                        .HasColumnName("countryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = "1beb0269-64f2-4c0b-8a6b-c95888d3d94d1804202140512",
                            Description = "",
                            Name = "Argentina"
                        },
                        new
                        {
                            CountryId = "47c5484b-56da-469b-881b-43668ae5ed1b1804202140512",
                            Description = "",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryId = "d92a5134-cad9-48df-ac1e-7d6a5e3b02d01804202140512",
                            Description = "",
                            Name = "Brasil"
                        },
                        new
                        {
                            CountryId = "8bbaf7bb-f6ed-43b4-8c16-64fe25f09d3e1804202140512",
                            Description = "",
                            Name = "Paraguay"
                        },
                        new
                        {
                            CountryId = "571ae287-7d88-44bc-9db2-e57c950270db1804202140512",
                            Description = "",
                            Name = "Chile"
                        },
                        new
                        {
                            CountryId = "9ce414b0-efda-475a-92c1-779b03ce4fb61804202140512",
                            Description = "",
                            Name = "Bolivia"
                        });
                });

            modelBuilder.Entity("Reservations.Domain.Entities.CountryState", b =>
                {
                    b.Property<string>("CountryStateId")
                        .HasColumnType("text")
                        .HasColumnName("countryStateId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("CountryStateId");

                    b.ToTable("CountryStates");

                    b.HasData(
                        new
                        {
                            CountryStateId = "d41e63c7-f10d-44f2-877b-ad3bbe831f321804202140512",
                            Description = "",
                            Name = "Buenos Aires"
                        },
                        new
                        {
                            CountryStateId = "4639f6da-d0c9-4840-be23-eb9a9322e5271804202140512",
                            Description = "",
                            Name = "C.A.B.A"
                        },
                        new
                        {
                            CountryStateId = "9ae17e1d-f5c4-440f-8a18-4bf17e30245f1804202140512",
                            Description = "",
                            Name = "Córdoba"
                        },
                        new
                        {
                            CountryStateId = "7dd44d0f-99f5-45d8-b66a-a5bb7df1e8a31804202140512",
                            Description = "",
                            Name = "Entre Rios"
                        });
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Operator", b =>
                {
                    b.Property<string>("OperatorId")
                        .HasColumnType("text")
                        .HasColumnName("operatorId");

                    b.Property<string>("AddressCP")
                        .HasColumnType("text")
                        .HasColumnName("addressCP");

                    b.Property<string>("AddressCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryId");

                    b.Property<string>("AddressCountryStateId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryStateId");

                    b.Property<string>("AddressLocality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressLocality");

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressNumber");

                    b.Property<string>("AddressStreet")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressStreet");

                    b.Property<string>("BirthCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("birthCountryId");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birthDate");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("document");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Name2")
                        .HasColumnType("text")
                        .HasColumnName("name2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.Property<string>("Surname2")
                        .HasColumnType("text")
                        .HasColumnName("surname2");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("taxId");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("OperatorId");

                    b.HasIndex("AddressCountryId");

                    b.HasIndex("AddressCountryStateId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Specialist", b =>
                {
                    b.Property<string>("SpecialistId")
                        .HasColumnType("text")
                        .HasColumnName("specialistId");

                    b.Property<string>("AddressCP")
                        .HasColumnType("text")
                        .HasColumnName("addressCP");

                    b.Property<string>("AddressCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryId");

                    b.Property<string>("AddressCountryStateId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressCountryStateId");

                    b.Property<string>("AddressLocality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressLocality");

                    b.Property<string>("AddressNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressNumber");

                    b.Property<string>("AddressStreet")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("addressStreet");

                    b.Property<string>("BirthCountryId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("birthCountryId");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birthDate");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("document");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Name2")
                        .HasColumnType("text")
                        .HasColumnName("name2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.Property<string>("Surname2")
                        .HasColumnType("text")
                        .HasColumnName("surname2");

                    b.Property<string>("TaxId")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("taxId");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("SpecialistId");

                    b.HasIndex("AddressCountryId");

                    b.HasIndex("AddressCountryStateId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Specialists");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.SpecialistSpecialty", b =>
                {
                    b.Property<string>("SpecialistSpecialtyId")
                        .HasColumnType("text")
                        .HasColumnName("specialistSpecialtyId");

                    b.Property<string>("SpecialistId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("specialistId");

                    b.Property<string>("SpecialtyId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("specialtyId");

                    b.HasKey("SpecialistSpecialtyId");

                    b.HasIndex("SpecialistId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("SpecialistsSpecialties");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Specialty", b =>
                {
                    b.Property<string>("SpecialtyId")
                        .HasColumnType("text")
                        .HasColumnName("specialtyId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("SpecialtyId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text")
                        .HasColumnName("userId");

                    b.Property<string>("PassWord")
                        .HasColumnType("text")
                        .HasColumnName("passWord");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("userCode");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Client", b =>
                {
                    b.HasOne("Reservations.Domain.Entities.Country", "AddressCountry")
                        .WithMany("Clients")
                        .HasForeignKey("AddressCountryId")
                        .HasConstraintName("FK_Clients_Country")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.CountryState", "AddressCountryState")
                        .WithMany("Clients")
                        .HasForeignKey("AddressCountryStateId")
                        .HasConstraintName("FK_Clients_CountryState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.Country", "BirthCountry")
                        .WithMany("ClientsNacionality")
                        .HasForeignKey("BirthCountryId")
                        .HasConstraintName("FK_Clients_CountryNacinality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.User", "User")
                        .WithOne("Client")
                        .HasForeignKey("Reservations.Domain.Entities.Client", "UserId")
                        .HasConstraintName("FK_Users_Client");

                    b.Navigation("AddressCountry");

                    b.Navigation("AddressCountryState");

                    b.Navigation("BirthCountry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Operator", b =>
                {
                    b.HasOne("Reservations.Domain.Entities.Country", "AddressCountry")
                        .WithMany("Operators")
                        .HasForeignKey("AddressCountryId")
                        .HasConstraintName("FK_Operators_Country")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.CountryState", "AddressCountryState")
                        .WithMany("Operators")
                        .HasForeignKey("AddressCountryStateId")
                        .HasConstraintName("FK_Operators_CountryState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.Country", "BirthCountry")
                        .WithMany("OperatorsNacionality")
                        .HasForeignKey("BirthCountryId")
                        .HasConstraintName("FK_Operators_CountryNacinality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.User", "User")
                        .WithOne("Operator")
                        .HasForeignKey("Reservations.Domain.Entities.Operator", "UserId")
                        .HasConstraintName("FK_Users_Operator");

                    b.Navigation("AddressCountry");

                    b.Navigation("AddressCountryState");

                    b.Navigation("BirthCountry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Specialist", b =>
                {
                    b.HasOne("Reservations.Domain.Entities.Country", "AddressCountry")
                        .WithMany("Specialists")
                        .HasForeignKey("AddressCountryId")
                        .HasConstraintName("FK_Specialist_Country")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.CountryState", "AddressCountryState")
                        .WithMany("Specialists")
                        .HasForeignKey("AddressCountryStateId")
                        .HasConstraintName("FK_Specialist_CountryState")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.Country", "BirthCountry")
                        .WithMany("SpecialistNacionality")
                        .HasForeignKey("BirthCountryId")
                        .HasConstraintName("FK_Specialist_CountryNacinality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.User", "User")
                        .WithOne("Specialist")
                        .HasForeignKey("Reservations.Domain.Entities.Specialist", "UserId")
                        .HasConstraintName("FK_Users_Specialist");

                    b.Navigation("AddressCountry");

                    b.Navigation("AddressCountryState");

                    b.Navigation("BirthCountry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.SpecialistSpecialty", b =>
                {
                    b.HasOne("Reservations.Domain.Entities.Specialist", "Specialist")
                        .WithMany("SpecialistSpecialties")
                        .HasForeignKey("SpecialistId")
                        .HasConstraintName("FK_SpecialistSpecialties_Specialist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reservations.Domain.Entities.Specialty", "Specialty")
                        .WithMany("SpecialistSpecialties")
                        .HasForeignKey("SpecialtyId")
                        .HasConstraintName("FK_SpecialistSpecialties_Specialty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialist");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Country", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("ClientsNacionality");

                    b.Navigation("Operators");

                    b.Navigation("OperatorsNacionality");

                    b.Navigation("SpecialistNacionality");

                    b.Navigation("Specialists");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.CountryState", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Operators");

                    b.Navigation("Specialists");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Specialist", b =>
                {
                    b.Navigation("SpecialistSpecialties");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.Specialty", b =>
                {
                    b.Navigation("SpecialistSpecialties");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.User", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Operator");

                    b.Navigation("Specialist");
                });
#pragma warning restore 612, 618
        }
    }
}
