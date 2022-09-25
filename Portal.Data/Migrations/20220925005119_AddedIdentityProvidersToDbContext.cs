using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portal.Data.Migrations
{
    public partial class AddedIdentityProvidersToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_IdentityProvider_IdentityProviderId",
                table: "Organizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityProvider",
                table: "IdentityProvider");

            migrationBuilder.RenameTable(
                name: "IdentityProvider",
                newName: "IdentityProviders");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityProviderId",
                table: "Organizations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityProviders",
                table: "IdentityProviders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_IdentityProviders_IdentityProviderId",
                table: "Organizations",
                column: "IdentityProviderId",
                principalTable: "IdentityProviders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_IdentityProviders_IdentityProviderId",
                table: "Organizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityProviders",
                table: "IdentityProviders");

            migrationBuilder.RenameTable(
                name: "IdentityProviders",
                newName: "IdentityProvider");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityProviderId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityProvider",
                table: "IdentityProvider",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_IdentityProvider_IdentityProviderId",
                table: "Organizations",
                column: "IdentityProviderId",
                principalTable: "IdentityProvider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
