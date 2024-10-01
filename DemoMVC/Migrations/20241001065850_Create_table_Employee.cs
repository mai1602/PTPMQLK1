using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    CanCuocCongDan = table.Column<string>(type: "TEXT", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    QueQuan = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    MaThue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.CanCuocCongDan);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<string>(type: "TEXT", nullable: false),
                    SinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    Lop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
