using Microsoft.EntityFrameworkCore.Migrations;

namespace EntitiyFrameworkDemo.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Name", "Price", "Technology" },
                values: new object[,]
                {
                    { 1, "seattle-dotnet-401d5", 5000.00m, 0 },
                    { 2, "seattle-jave-401d2", 6000m, 1 },
                    { 3, "seattle-javascript-401d10", 3000m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 36, "Jack", "Shepard" },
                    { 2, 29, "Kate", "Austin" },
                    { 3, 16, "Araya", "Stark" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
