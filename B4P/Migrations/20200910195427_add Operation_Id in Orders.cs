using Microsoft.EntityFrameworkCore.Migrations;

namespace B4P.Migrations
{
    public partial class addOperation_IdinOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "OrderOperation_Id",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Operation_Id",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
