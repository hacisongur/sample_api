using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sample_api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    firstName = table.Column<string>(type: "text", nullable: true),
                    lastName = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    workEmail = table.Column<string>(type: "text", nullable: true),
                    mobilePhone = table.Column<string>(type: "text", nullable: true),
                    workPhone = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    accessType = table.Column<string>(type: "text", nullable: true),
                    nationality = table.Column<string>(type: "text", nullable: true),
                    idNumber = table.Column<int>(type: "integer", nullable: false),
                    employmentStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    contractType = table.Column<string>(type: "text", nullable: true),
                    contractEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    maritalStatus = table.Column<string>(type: "text", nullable: true),
                    partnerWorkStatus = table.Column<string>(type: "text", nullable: true),
                    militaryService = table.Column<string>(type: "text", nullable: true),
                    militaryServiceDelayDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    educationLevel = table.Column<string>(type: "text", nullable: true),
                    educationStatus = table.Column<string>(type: "text", nullable: true),
                    educationalInstitution = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false),
                    tourStatus = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    levelOfDisability = table.Column<string>(type: "text", nullable: true),
                    numberOfChildren = table.Column<int>(type: "integer", nullable: false),
                    bloodType = table.Column<string>(type: "text", nullable: true),
                    accrualStartDate = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "unitLists",
                columns: table => new
                {
                    unitId = table.Column<string>(type: "text", nullable: false),
                    unitItemId = table.Column<string>(type: "text", nullable: true),
                    unitItemName = table.Column<string>(type: "text", nullable: true),
                    unitName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitLists", x => x.unitId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "unitLists");
        }
    }
}
