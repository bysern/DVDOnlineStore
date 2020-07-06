using Microsoft.EntityFrameworkCore.Migrations;

namespace DVDRentalStore.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "employees");

            migrationBuilder.AlterColumn<float>(
                name: "salary",
                table: "employees",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "salary",
                table: "employees",
                type: "real",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "employees",
                type: "character varying",
                nullable: true);
        }
    }
}
