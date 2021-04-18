
using Microsoft.EntityFrameworkCore;
using Reservations.Domain.Entities;
using Reservations.Data.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Context
{
    public partial class ReservationsContext: DbContext 
    {
        public ReservationsContext(DbContextOptions <ReservationsContext> options) : base(options) {}

        public virtual DbSet<Specialist> Specialists { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<SpecialistSpecialty> SpecialistsSpecialties { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryState> CountryStates { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Specialist>(entity =>
            {
    
            entity.HasKey(e => e.SpecialistId);
            entity.Property(e => e.SpecialistId).HasColumnName("specialistId").ValueGeneratedNever();                 
            entity.Property(e => e.Name).HasColumnName("name").IsRequired();
            entity.Property(e => e.Name2).HasColumnName("name2");
            entity.Property(e => e.Surname).HasColumnName("surname").IsRequired();
            entity.Property(e => e.Surname2).HasColumnName("surname2");
            entity.Property(e => e.Document).HasColumnName("document").HasMaxLength(8).IsRequired();
            entity.Property(e => e.TaxId).HasColumnName("taxId").HasMaxLength(11).IsRequired();            
            entity.Property(e => e.AddressStreet).HasColumnName("addressStreet").IsRequired();
            entity.Property(e => e.AddressNumber).HasColumnName("addressNumber").IsRequired();
            entity.Property(e => e.AddressLocality).HasColumnName("addressLocality").IsRequired();
            entity.Property(e => e.AddressCP).HasColumnName("addressCP");
            entity.Property(e => e.AddressCountryId).HasColumnName("addressCountryId").IsRequired();
            entity.Property(e => e.BirthDate).HasColumnName("birthDate").HasColumnType("timestamp without time zone");
            entity.Property(e => e.AddressCountryStateId).HasColumnName("addressCountryStateId").IsRequired();
            entity.Property(e => e.BirthCountryId).HasColumnName("birthCountryId").IsRequired();

                entity.HasOne(e => e.BirthCountry)
                   .WithMany(x => x.SpecialistNacionality)
                   .HasForeignKey(e => e.BirthCountryId)
                   .HasConstraintName("FK_Specialist_CountryNacinality");

                entity.HasOne(e => e.AddressCountryState)
                 .WithMany(x => x.Specialists)
                 .HasForeignKey(e => e.AddressCountryStateId)
                 .HasConstraintName("FK_Specialist_CountryState");

                entity.HasOne(e => e.AddressCountry)
                   .WithMany(x => x.Specialists)
                   .HasForeignKey(e => e.AddressCountryId)
                   .HasConstraintName("FK_Specialist_Country");

                

            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.SpecialtyId);
                entity.Property(e => e.SpecialtyId).HasColumnName("specialtyId").ValueGeneratedNever();
                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Description).HasColumnName("description").IsRequired();

            });

            modelBuilder.Entity<SpecialistSpecialty>(entity =>
            {
                entity.HasKey(e => e.SpecialistSpecialtyId);
                entity.Property(e => e.SpecialistSpecialtyId).HasColumnName("specialistSpecialtyId").ValueGeneratedNever();
                entity.Property(e => e.SpecialistId).HasColumnName("specialistId").IsRequired();
                entity.Property(e => e.SpecialtyId).HasColumnName("specialtyId").IsRequired();

                entity.HasOne(e => e.Specialist)
                .WithMany(p => p.SpecialistSpecialties)
                .HasForeignKey(e => e.SpecialistId)
                .HasConstraintName("FK_SpecialistSpecialties_Specialist");

                entity.HasOne(e => e.Specialty)
                .WithMany(p => p.SpecialistSpecialties)
                .HasForeignKey(e => e.SpecialtyId)
                .HasConstraintName("FK_SpecialistSpecialties_Specialty");

            });


            modelBuilder.Entity<Client>(entity =>
            {

                entity.HasKey(e => e.ClientId);
                entity.Property(e => e.ClientId).HasColumnName("clientId").ValueGeneratedNever();
                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Name2).HasColumnName("name2");
                entity.Property(e => e.Surname).HasColumnName("surname").IsRequired();
                entity.Property(e => e.Surname2).HasColumnName("surname2");
                entity.Property(e => e.Document).HasColumnName("document").HasMaxLength(8).IsRequired();
                entity.Property(e => e.TaxId).HasColumnName("taxId").HasMaxLength(11).IsRequired();
                entity.Property(e => e.AddressStreet).HasColumnName("addressStreet").IsRequired();
                entity.Property(e => e.AddressNumber).HasColumnName("addressNumber").IsRequired();
                entity.Property(e => e.AddressLocality).HasColumnName("addressLocality").IsRequired();
                entity.Property(e => e.AddressCP).HasColumnName("addressCP");
                entity.Property(e => e.AddressCountryId).HasColumnName("addressCountryId").IsRequired();
                entity.Property(e => e.BirthDate).HasColumnName("birthDate").HasColumnType("timestamp without time zone");
                entity.Property(e => e.AddressCountryStateId).HasColumnName("addressCountryStateId").IsRequired();
                entity.Property(e => e.BirthCountryId).HasColumnName("birthCountryId").IsRequired();


                entity.HasOne(e => e.BirthCountry)
                .WithMany(x => x.ClientsNacionality)
                .HasForeignKey(e => e.BirthCountryId)
                .HasConstraintName("FK_Clients_CountryNacinality");

                entity.HasOne(e => e.AddressCountryState)
                 .WithMany(x => x.Clients)
                 .HasForeignKey(e => e.AddressCountryStateId)
                 .HasConstraintName("FK_Clients_CountryState");

                entity.HasOne(e => e.AddressCountry)
                   .WithMany(x => x.Clients)
                   .HasForeignKey(e => e.AddressCountryId)
                   .HasConstraintName("FK_Clients_Country");




            });


            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);
                entity.Property(e => e.CountryId).HasColumnName("countryId").ValueGeneratedNever();
                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Description).HasColumnName("description").IsRequired();

            });
            modelBuilder.Entity<Country>().HasData(
                
                new Country { CountryId = IdGenerator.Generate(), Name = "Argentina", Description = ""},
                new Country { CountryId = IdGenerator.Generate(), Name = "Uruguay", Description = "" },
                new Country { CountryId = IdGenerator.Generate(), Name = "Brasil", Description = "" },
                new Country { CountryId = IdGenerator.Generate(), Name = "Paraguay", Description = "" },
                new Country { CountryId = IdGenerator.Generate(), Name = "Chile", Description = "" },
                new Country { CountryId = IdGenerator.Generate(), Name = "Bolivia", Description = "" }
                );


            modelBuilder.Entity<CountryState>(entity =>
            {
                entity.HasKey(e => e.CountryStateId);
                entity.Property(e => e.CountryStateId).HasColumnName("countryStateId").ValueGeneratedNever();
                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Description).HasColumnName("description").IsRequired();

            });

            modelBuilder.Entity<CountryState>().HasData(

               new CountryState { CountryStateId = IdGenerator.Generate(), Name = "Buenos Aires", Description = "" },
               new CountryState { CountryStateId = IdGenerator.Generate(), Name = "C.A.B.A", Description = "" },
               new CountryState { CountryStateId = IdGenerator.Generate(), Name = "Córdoba", Description = "" },
               new CountryState { CountryStateId = IdGenerator.Generate(), Name = "Entre Rios", Description = "" }

               );
            modelBuilder.Entity<Operator>(entity =>
            {

                entity.HasKey(e => e.OperatorId);
                entity.Property(e => e.OperatorId).HasColumnName("operatorId").ValueGeneratedNever();
                entity.Property(e => e.Name).HasColumnName("name").IsRequired();
                entity.Property(e => e.Name2).HasColumnName("name2");
                entity.Property(e => e.Surname).HasColumnName("surname").IsRequired();
                entity.Property(e => e.Surname2).HasColumnName("surname2");
                entity.Property(e => e.Document).HasColumnName("document").HasMaxLength(8).IsRequired();
                entity.Property(e => e.TaxId).HasColumnName("taxId").HasMaxLength(11).IsRequired();
                entity.Property(e => e.AddressStreet).HasColumnName("addressStreet").IsRequired();
                entity.Property(e => e.AddressNumber).HasColumnName("addressNumber").IsRequired();
                entity.Property(e => e.AddressLocality).HasColumnName("addressLocality").IsRequired();
                entity.Property(e => e.AddressCP).HasColumnName("addressCP");
                entity.Property(e => e.AddressCountryId).HasColumnName("addressCountryId").IsRequired();
                entity.Property(e => e.BirthDate).HasColumnName("birthDate").HasColumnType("timestamp without time zone");
                entity.Property(e => e.AddressCountryStateId).HasColumnName("addressCountryStateId").IsRequired();
                entity.Property(e => e.BirthCountryId).HasColumnName("birthCountryId").IsRequired();


                entity.HasOne(e => e.BirthCountry)
                .WithMany(x => x.OperatorsNacionality)
                .HasForeignKey(e => e.BirthCountryId)
                .HasConstraintName("FK_Operators_CountryNacinality");

                entity.HasOne(e => e.AddressCountryState)
                 .WithMany(x => x.Operators)
                 .HasForeignKey(e => e.AddressCountryStateId)
                 .HasConstraintName("FK_Operators_CountryState");

                entity.HasOne(e => e.AddressCountry)
                   .WithMany(x => x.Operators)
                   .HasForeignKey(e => e.AddressCountryId)
                   .HasConstraintName("FK_Operators_Country");

                
            });


            modelBuilder.Entity<User>(entity =>
            {

                entity.HasKey(e => e.UserId);
                entity.Property(e => e.UserId).HasColumnName("userId").ValueGeneratedNever();
                entity.Property(e => e.UserCode).HasColumnName("userCode").IsRequired();
                entity.Property(e => e.PassWord).HasColumnName("passWord");

                entity.HasOne(e => e.Client)
                .WithOne(x => x.User)
                .HasForeignKey<Client>(e => e.UserId)
                .HasConstraintName("FK_Users_Client");

                entity.HasOne(e => e.Operator)
                .WithOne(x => x.User)
                .HasForeignKey<Operator>(e => e.UserId)
                .HasConstraintName("FK_Users_Operator");

                entity.HasOne(e => e.Specialist)
                .WithOne(x => x.User)
                .HasForeignKey<Specialist>(e => e.UserId)
                .HasConstraintName("FK_Users_Specialist");


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);



    }
}
