using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_With_DB.UI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countaries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countaries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContryId = table.Column<int>(type: "int", nullable: false),
                    CountaryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.ID);
                    table.ForeignKey(
                        name: "FK_State_Countaries_CountaryID",
                        column: x => x.CountaryID,
                        principalTable: "Countaries",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateIdd = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Citys_State_StateID",
                        column: x => x.StateID,
                        principalTable: "State",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citys_StateID",
                table: "Citys",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountaryID",
                table: "State",
                column: "CountaryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Countaries");
        }
    }
}
