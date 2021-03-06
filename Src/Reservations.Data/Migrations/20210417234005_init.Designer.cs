// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Reservations.Data.Context;

namespace Reservations.Data.Migrations
{
    [DbContext(typeof(ReservationsContext))]
    [Migration("20210417234005_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CountryStateId")
                        .HasColumnType("text");

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

                    b.HasKey("ClientId");

                    b.HasIndex("AddressCountryId");

                    b.HasIndex("AddressCountryStateId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("CountryStateId");

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
                            CountryId = "b61f0f08-c914-4120-a396-3602713cedb917042021204005",
                            Description = "",
                            Name = "Argentina"
                        },
                        new
                        {
                            CountryId = "e42b59c2-5f51-428c-b5cb-152a1246818817042021204005",
                            Description = "",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryId = "32c9f2ef-6ddf-4be2-a4fa-52431f114df117042021204005",
                            Description = "",
                            Name = "Brasil"
                        },
                        new
                        {
                            CountryId = "cff6d2ca-ad6c-49fc-bd9a-543557599a4717042021204005",
                            Description = "",
                            Name = "Paraguay"
                        },
                        new
                        {
                            CountryId = "d2349b1c-fb6a-4e14-8426-704bbed004f717042021204005",
                            Description = "",
                            Name = "Chile"
                        },
                        new
                        {
                            CountryId = "836628a7-35e0-47c1-9ac0-fdeeac38976e17042021204005",
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
                            CountryStateId = "f2a095a5-7431-4687-9f89-6f56fbc2743f17042021204005",
                            Description = "",
                            Name = "Buenos Aires"
                        },
                        new
                        {
                            CountryStateId = "b9973a78-551e-4cf9-91d6-046d55ebcf9717042021204005",
                            Description = "",
                            Name = "C.A.B.A"
                        },
                        new
                        {
                            CountryStateId = "9a9f5c14-8060-4e45-89be-71a7a3becf0617042021204005",
                            Description = "",
                            Name = "Córdoba"
                        },
                        new
                        {
                            CountryStateId = "05eff349-197d-4c13-8f54-b555cf82d01d17042021204005",
                            Description = "",
                            Name = "Entre Rios"
                        });
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

                    b.Property<string>("CountryStateId")
                        .HasColumnType("text");

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

                    b.HasKey("SpecialistId");

                    b.HasIndex("AddressCountryId");

                    b.HasIndex("AddressCountryStateId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("CountryStateId");

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

                    b.HasOne("Reservations.Domain.Entities.CountryState", null)
                        .WithMany("ClientsNacionality")
                        .HasForeignKey("CountryStateId");

                    b.Navigation("AddressCountry");

                    b.Navigation("AddressCountryState");

                    b.Navigation("BirthCountry");
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

                    b.HasOne("Reservations.Domain.Entities.CountryState", null)
                        .WithMany("SpecialistNacionality")
                        .HasForeignKey("CountryStateId");

                    b.Navigation("AddressCountry");

                    b.Navigation("AddressCountryState");

                    b.Navigation("BirthCountry");
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

                    b.Navigation("SpecialistNacionality");

                    b.Navigation("Specialists");
                });

            modelBuilder.Entity("Reservations.Domain.Entities.CountryState", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("ClientsNacionality");

                    b.Navigation("SpecialistNacionality");

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
#pragma warning restore 612, 618
        }
    }
}
