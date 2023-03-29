using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaruosadAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SparePartsModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Warehouse1 = table.Column<string>(type: "TEXT", nullable: true),
                    Warehouse2 = table.Column<string>(type: "TEXT", nullable: true),
                    Warehouse3 = table.Column<string>(type: "TEXT", nullable: true),
                    Warehouse4 = table.Column<string>(type: "TEXT", nullable: true),
                    WareHouse5 = table.Column<string>(type: "TEXT", nullable: true),
                    Warehouse6 = table.Column<string>(type: "TEXT", nullable: true),
                    WithoutVAT = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartsModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SparePartsModel");
        }
    }
}
