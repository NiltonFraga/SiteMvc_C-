using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeigKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_departmentId",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Sellers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_departmentId",
                table: "Sellers",
                newName: "IX_Sellers_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Sellers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Department_DepartmentId",
                table: "Sellers");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Sellers",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                newName: "IX_Sellers_departmentId");

            migrationBuilder.AlterColumn<int>(
                name: "departmentId",
                table: "Sellers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Department_departmentId",
                table: "Sellers",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
