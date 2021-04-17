using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reservations.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    countryId = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.countryId);
                });

            migrationBuilder.CreateTable(
                name: "CountryStates",
                columns: table => new
                {
                    countryStateId = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryStates", x => x.countryStateId);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    specialtyId = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.specialtyId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<string>(type: "text", nullable: false),
                    CountryStateId = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false),
                    name2 = table.Column<string>(type: "text", nullable: true),
                    surname = table.Column<string>(type: "text", nullable: false),
                    surname2 = table.Column<string>(type: "text", nullable: true),
                    document = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    taxId = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    birthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    addressStreet = table.Column<string>(type: "text", nullable: false),
                    addressNumber = table.Column<string>(type: "text", nullable: false),
                    addressCountryStateId = table.Column<string>(type: "text", nullable: false),
                    addressLocality = table.Column<string>(type: "text", nullable: false),
                    addressCP = table.Column<string>(type: "text", nullable: true),
                    addressCountryId = table.Column<string>(type: "text", nullable: false),
                    birthCountryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                    table.ForeignKey(
                        name: "FK_Clients_Country",
                        column: x => x.addressCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_CountryNacinality",
                        column: x => x.birthCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_CountryState",
                        column: x => x.addressCountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "countryStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_CountryStates_CountryStateId",
                        column: x => x.CountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "countryStateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    specialistId = table.Column<string>(type: "text", nullable: false),
                    CountryStateId = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false),
                    name2 = table.Column<string>(type: "text", nullable: true),
                    surname = table.Column<string>(type: "text", nullable: false),
                    surname2 = table.Column<string>(type: "text", nullable: true),
                    document = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    taxId = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    birthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    addressStreet = table.Column<string>(type: "text", nullable: false),
                    addressNumber = table.Column<string>(type: "text", nullable: false),
                    addressCountryStateId = table.Column<string>(type: "text", nullable: false),
                    addressLocality = table.Column<string>(type: "text", nullable: false),
                    addressCP = table.Column<string>(type: "text", nullable: true),
                    addressCountryId = table.Column<string>(type: "text", nullable: false),
                    birthCountryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.specialistId);
                    table.ForeignKey(
                        name: "FK_Specialist_Country",
                        column: x => x.addressCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialist_CountryNacinality",
                        column: x => x.birthCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialist_CountryState",
                        column: x => x.addressCountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "countryStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialists_CountryStates_CountryStateId",
                        column: x => x.CountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "countryStateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialistsSpecialties",
                columns: table => new
                {
                    specialistSpecialtyId = table.Column<string>(type: "text", nullable: false),
                    specialtyId = table.Column<string>(type: "text", nullable: false),
                    specialistId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialistsSpecialties", x => x.specialistSpecialtyId);
                    table.ForeignKey(
                        name: "FK_SpecialistSpecialties_Specialist",
                        column: x => x.specialistId,
                        principalTable: "Specialists",
                        principalColumn: "specialistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialistSpecialties_Specialty",
                        column: x => x.specialtyId,
                        principalTable: "Specialties",
                        principalColumn: "specialtyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "countryId", "description", "name" },
                values: new object[,]
                {
                    { "b61f0f08-c914-4120-a396-3602713cedb917042021204005", "", "Argentina" },
                    { "e42b59c2-5f51-428c-b5cb-152a1246818817042021204005", "", "Uruguay" },
                    { "32c9f2ef-6ddf-4be2-a4fa-52431f114df117042021204005", "", "Brasil" },
                    { "cff6d2ca-ad6c-49fc-bd9a-543557599a4717042021204005", "", "Paraguay" },
                    { "d2349b1c-fb6a-4e14-8426-704bbed004f717042021204005", "", "Chile" },
                    { "836628a7-35e0-47c1-9ac0-fdeeac38976e17042021204005", "", "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "CountryStates",
                columns: new[] { "countryStateId", "description", "name" },
                values: new object[,]
                {
                    { "f2a095a5-7431-4687-9f89-6f56fbc2743f17042021204005", "", "Buenos Aires" },
                    { "b9973a78-551e-4cf9-91d6-046d55ebcf9717042021204005", "", "C.A.B.A" },
                    { "9a9f5c14-8060-4e45-89be-71a7a3becf0617042021204005", "", "Córdoba" },
                    { "05eff349-197d-4c13-8f54-b555cf82d01d17042021204005", "", "Entre Rios" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_addressCountryId",
                table: "Clients",
                column: "addressCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_addressCountryStateId",
                table: "Clients",
                column: "addressCountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_birthCountryId",
                table: "Clients",
                column: "birthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CountryStateId",
                table: "Clients",
                column: "CountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_addressCountryId",
                table: "Specialists",
                column: "addressCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_addressCountryStateId",
                table: "Specialists",
                column: "addressCountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_birthCountryId",
                table: "Specialists",
                column: "birthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_CountryStateId",
                table: "Specialists",
                column: "CountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistsSpecialties_specialistId",
                table: "SpecialistsSpecialties",
                column: "specialistId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialistsSpecialties_specialtyId",
                table: "SpecialistsSpecialties",
                column: "specialtyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "SpecialistsSpecialties");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CountryStates");
        }
    }
}
