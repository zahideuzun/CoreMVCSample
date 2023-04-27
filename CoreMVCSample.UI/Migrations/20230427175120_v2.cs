using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMVCSample.UI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAllergy_Content_ContentId",
                table: "UserAllergy");

            migrationBuilder.DropIndex(
                name: "IX_UserAllergy_ContentId",
                table: "UserAllergy");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "UserAllergy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "UserAllergy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergy_ContentId",
                table: "UserAllergy",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAllergy_Content_ContentId",
                table: "UserAllergy",
                column: "ContentId",
                principalTable: "Content",
                principalColumn: "ContentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
