using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    public partial class AddedIdentityProviders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdentityProviderId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "IdentityProvider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityProvider", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_IdentityProviderId",
                table: "Organizations",
                column: "IdentityProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_IdentityProvider_IdentityProviderId",
                table: "Organizations",
                column: "IdentityProviderId",
                principalTable: "IdentityProvider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_IdentityProvider_IdentityProviderId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "IdentityProvider");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_IdentityProviderId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "IdentityProviderId",
                table: "Organizations");
        }
    }
}
