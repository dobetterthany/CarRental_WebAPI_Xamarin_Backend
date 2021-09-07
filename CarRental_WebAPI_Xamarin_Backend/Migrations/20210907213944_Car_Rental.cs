using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;
namespace CarRental_WebAPI_Xamarin_Backend.Migrations
{
    public partial class Car_Rental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car_Details",
                columns: table => new
                {
                    RegNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Car_Maker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Car_Mileage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car_Details", x => x.RegNumber);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cust_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.UserName);
                });

            var sqlFile = Path.Combine(".\\Database", @"Data_Script.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car_Details");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
