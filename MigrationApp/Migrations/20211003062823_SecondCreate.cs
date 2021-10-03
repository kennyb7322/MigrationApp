using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationApp.Migrations
{
    public partial class SecondCreate : Migration
    {
        // コンテキストの変更を適用するメソッド
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Blog",
                type: "TEXT",
                nullable: true);
        }

        // コンテキストの変更を元に戻すメソッド
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Blog");
        }
    }
}
