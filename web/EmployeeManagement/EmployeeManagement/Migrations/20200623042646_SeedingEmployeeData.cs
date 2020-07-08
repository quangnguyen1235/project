using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ava", "departerment", "email", "fullName" },
                values: new object[] { 1, "~/images/unknownPerson.jpg", 0, "nguyendangquanghbt12b7@gmail.com", "Nguyễn Đăng Quang" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ava", "departerment", "email", "fullName" },
                values: new object[] { 2, "~/images/unknownPerson.jpg", 2, "minhminh.codegym@gmail.com", "Tôn Thất Anh Minh" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ava", "departerment", "email", "fullName" },
                values: new object[] { 3, "~/images/unknownPerson.jpg", 0, "xuantrung.nguyen@gmail.com", "Nguyễn Xuân Trung" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
