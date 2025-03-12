using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WlodCar.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Color = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Fuel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Gearbox = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Body = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Drive = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Seats = table.Column<byte>(type: "tinyint", nullable: false),
                    Doors = table.Column<byte>(type: "tinyint", nullable: false),
                    TrunkCapacity = table.Column<byte>(type: "tinyint", nullable: false),
                    EngineCapacity = table.Column<byte>(type: "tinyint", nullable: false),
                    Power = table.Column<byte>(type: "tinyint", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<DateOnly>(type: "date", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    VIN = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "smallmoney", nullable: false),
                    GPSLatitude = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    GPSLongitude = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cars__3214EC073199146D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<short>(type: "smallint", nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PESEL = table.Column<short>(type: "smallint", nullable: true),
                    NIP = table.Column<short>(type: "smallint", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    REGON = table.Column<short>(type: "smallint", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: false),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: true),
                    IdCardNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DrivingLicenseNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DrivingLicenseIssueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DrivingLicenseExpirationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CustomerType = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCardPicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DrivingLicensePicture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ballance = table.Column<decimal>(type: "money", nullable: false, defaultValueSql: "((0.00))"),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__3214EC071380398B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reservat__3214EC07B9AA1EED", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Reservati__CarId__2D27B809",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Reservati__Custo__2E1BDC42",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CarId",
                table: "Reservations",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
