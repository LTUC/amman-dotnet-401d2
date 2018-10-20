using Microsoft.EntityFrameworkCore.Migrations;

namespace EntitiyFrameworkDemo.Migrations
{
    public partial class newInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCodes_CourseCodeIDID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCodeIDID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseCodeIDID",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Technology",
                table: "Courses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Technology",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "CourseCodeIDID",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCodeIDID",
                table: "Courses",
                column: "CourseCodeIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCodes_CourseCodeIDID",
                table: "Courses",
                column: "CourseCodeIDID",
                principalTable: "CourseCodes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
