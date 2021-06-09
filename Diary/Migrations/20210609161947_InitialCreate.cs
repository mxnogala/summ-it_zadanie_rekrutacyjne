using Microsoft.EntityFrameworkCore.Migrations;

namespace Diary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Entry = table.Column<string>(type: "TEXT", nullable: false),
                    Day = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntry", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaryEntry",
                columns: new[] { "Id", "Day", "Entry", "Title" },
                values: new object[] { 1, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu scelerisque turpis. Aliquam consectetur pharetra mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur tincidunt et nisi sit amet rutrum. Nunc consequat, leo a mattis condimentum, orci mi consequat lacus, eu pulvinar tortor ante eu leo. Proin blandit mi eu nulla scelerisque gravida. Donec id sem nec velit congue ullamcorper a quis augue. Nunc posuere facilisis efficitur. Sed id lectus luctus, lobortis lectus vitae, eleifend lorem. Aliquam nulla est, vestibulum sit amet risus nec, iaculis molestie mauris. Vivamus congue augue ligula, quis blandit leocommodo vitae. Aliquam ornare quam at faucibus pharetra. Etiam condimentum a arcu et pretium. Pellentesque non mauris quis ipsum finibus faucibus.", "Wpis 1" });

            migrationBuilder.InsertData(
                table: "DiaryEntry",
                columns: new[] { "Id", "Day", "Entry", "Title" },
                values: new object[] { 2, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu scelerisque turpis. Aliquam consectetur pharetra mollis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur tincidunt et nisi sit amet rutrum. Nunc consequat, leo a mattis condimentum, orci mi consequat lacus, eu pulvinar tortor ante eu leo. Proin blandit mi eu nulla scelerisque gravida. Donec id sem nec velit congue ullamcorper a quis augue. Nunc posuere facilisis efficitur. Sed id lectus luctus, lobortis lectus vitae, eleifend lorem. Aliquam nulla est, vestibulum sit amet risus nec, iaculis molestie mauris. Vivamus congue augue ligula, quis blandit leocommodo vitae. Aliquam ornare quam at faucibus pharetra. Etiam condimentum a arcu et pretium. Pellentesque non mauris quis ipsum finibus faucibus.", "Wpis 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryEntry");
        }
    }
}
