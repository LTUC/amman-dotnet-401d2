using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "Courses",
                newName: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TechnologyId",
                table: "Courses",
                column: "TechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Technologies_TechnologyId",
                table: "Courses",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Technologies_TechnologyId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TechnologyId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "TechnologyId",
                table: "Courses",
                newName: "Technology");
        }
    }
}
