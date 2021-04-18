using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reservations.Data.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_CountryStates_CountryStateId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialists_CountryStates_CountryStateId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_CountryStateId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CountryStateId",
                table: "Clients");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "32c9f2ef-6ddf-4be2-a4fa-52431f114df117042021204005");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "836628a7-35e0-47c1-9ac0-fdeeac38976e17042021204005");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "b61f0f08-c914-4120-a396-3602713cedb917042021204005");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "cff6d2ca-ad6c-49fc-bd9a-543557599a4717042021204005");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "d2349b1c-fb6a-4e14-8426-704bbed004f717042021204005");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "e42b59c2-5f51-428c-b5cb-152a1246818817042021204005");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "05eff349-197d-4c13-8f54-b555cf82d01d17042021204005");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "9a9f5c14-8060-4e45-89be-71a7a3becf0617042021204005");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "b9973a78-551e-4cf9-91d6-046d55ebcf9717042021204005");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "f2a095a5-7431-4687-9f89-6f56fbc2743f17042021204005");

            migrationBuilder.RenameColumn(
                name: "CountryStateId",
                table: "Specialists",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CountryStateId",
                table: "Clients",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "text", nullable: false),
                    userCode = table.Column<string>(type: "text", nullable: false),
                    passWord = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    operatorId = table.Column<string>(type: "text", nullable: false),
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
                    birthCountryId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.operatorId);
                    table.ForeignKey(
                        name: "FK_Operators_Country",
                        column: x => x.addressCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operators_CountryNacinality",
                        column: x => x.birthCountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Operators_CountryState",
                        column: x => x.addressCountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "countryStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Operator",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "countryId", "description", "name" },
                values: new object[,]
                {
                    { "1beb0269-64f2-4c0b-8a6b-c95888d3d94d1804202140512", "", "Argentina" },
                    { "47c5484b-56da-469b-881b-43668ae5ed1b1804202140512", "", "Uruguay" },
                    { "d92a5134-cad9-48df-ac1e-7d6a5e3b02d01804202140512", "", "Brasil" },
                    { "8bbaf7bb-f6ed-43b4-8c16-64fe25f09d3e1804202140512", "", "Paraguay" },
                    { "571ae287-7d88-44bc-9db2-e57c950270db1804202140512", "", "Chile" },
                    { "9ce414b0-efda-475a-92c1-779b03ce4fb61804202140512", "", "Bolivia" }
                });

            migrationBuilder.InsertData(
                table: "CountryStates",
                columns: new[] { "countryStateId", "description", "name" },
                values: new object[,]
                {
                    { "d41e63c7-f10d-44f2-877b-ad3bbe831f321804202140512", "", "Buenos Aires" },
                    { "4639f6da-d0c9-4840-be23-eb9a9322e5271804202140512", "", "C.A.B.A" },
                    { "9ae17e1d-f5c4-440f-8a18-4bf17e30245f1804202140512", "", "Córdoba" },
                    { "7dd44d0f-99f5-45d8-b66a-a5bb7df1e8a31804202140512", "", "Entre Rios" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Specialists_UserId",
                table: "Specialists",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operators_addressCountryId",
                table: "Operators",
                column: "addressCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_addressCountryStateId",
                table: "Operators",
                column: "addressCountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_birthCountryId",
                table: "Operators",
                column: "birthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_UserId",
                table: "Operators",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Client",
                table: "Clients",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Specialist",
                table: "Specialists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Client",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Specialist",
                table: "Specialists");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Specialists_UserId",
                table: "Specialists");

            migrationBuilder.DropIndex(
                name: "IX_Clients_UserId",
                table: "Clients");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "1beb0269-64f2-4c0b-8a6b-c95888d3d94d1804202140512");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "47c5484b-56da-469b-881b-43668ae5ed1b1804202140512");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "571ae287-7d88-44bc-9db2-e57c950270db1804202140512");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "8bbaf7bb-f6ed-43b4-8c16-64fe25f09d3e1804202140512");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "9ce414b0-efda-475a-92c1-779b03ce4fb61804202140512");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "countryId",
                keyValue: "d92a5134-cad9-48df-ac1e-7d6a5e3b02d01804202140512");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "4639f6da-d0c9-4840-be23-eb9a9322e5271804202140512");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "7dd44d0f-99f5-45d8-b66a-a5bb7df1e8a31804202140512");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "9ae17e1d-f5c4-440f-8a18-4bf17e30245f1804202140512");

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "countryStateId",
                keyValue: "d41e63c7-f10d-44f2-877b-ad3bbe831f321804202140512");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Specialists",
                newName: "CountryStateId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Clients",
                newName: "CountryStateId");

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
                name: "IX_Specialists_CountryStateId",
                table: "Specialists",
                column: "CountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CountryStateId",
                table: "Clients",
                column: "CountryStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_CountryStates_CountryStateId",
                table: "Clients",
                column: "CountryStateId",
                principalTable: "CountryStates",
                principalColumn: "countryStateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialists_CountryStates_CountryStateId",
                table: "Specialists",
                column: "CountryStateId",
                principalTable: "CountryStates",
                principalColumn: "countryStateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
