using Microsoft.EntityFrameworkCore.Migrations;

namespace Diary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Entry = table.Column<string>(type: "TEXT", nullable: true),
                    Day = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaryTable",
                columns: new[] { "Id", "Day", "Entry", "Title" },
                values: new object[] { 1, 2, "Wpisik jakiś", "Test 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryTable");
        }
    }
}
