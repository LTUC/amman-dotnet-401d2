using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateStudentsTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Studetns_StudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Transcripts_Studetns_StudentId",
                table: "Transcripts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studetns",
                table: "Studetns");

            migrationBuilder.RenameTable(
                name: "Studetns",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transcripts_Students_StudentId",
                table: "Transcripts",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Transcripts_Students_StudentId",
                table: "Transcripts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studetns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studetns",
                table: "Studetns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Studetns_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Studetns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transcripts_Studetns_StudentId",
                table: "Transcripts",
                column: "StudentId",
                principalTable: "Studetns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
