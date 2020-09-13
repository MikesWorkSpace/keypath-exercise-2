using Microsoft.EntityFrameworkCore.Migrations;

namespace Keypath.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExampleItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(maxLength: 100, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExampleItem",
                columns: new[] { "Id", "SortOrder", "Word" },
                values: new object[,]
                {
                    { 1001L, 1, "The" },
                    { 1022L, 113, "aid" },
                    { 1023L, 114, "of" },
                    { 1024L, 115, "their" },
                    { 1025L, 116, "country" },
                    { 1026L, 201, "The" },
                    { 1027L, 202, "quick" },
                    { 1028L, 203, "brown" },
                    { 1029L, 204, "fox" },
                    { 1030L, 205, "jumped" },
                    { 1031L, 206, "over" },
                    { 1032L, 207, "the" },
                    { 1033L, 208, "lazy" },
                    { 1034L, 209, "dog" },
                    { 1035L, 301, "How" },
                    { 1036L, 302, "now " },
                    { 1021L, 112, "the " },
                    { 1020L, 111, "to " },
                    { 1019L, 110, "come" },
                    { 1018L, 109, "to " },
                    { 1002L, 2, "rain" },
                    { 1003L, 3, "in" },
                    { 1004L, 4, "Spain" },
                    { 1005L, 5, "falls" },
                    { 1006L, 6, "mainly" },
                    { 1007L, 7, "on" },
                    { 1008L, 8, "the" },
                    { 1037L, 303, "brown" },
                    { 1009L, 9, "plain" },
                    { 1011L, 102, "is " },
                    { 1012L, 103, "the" },
                    { 1013L, 104, "time " },
                    { 1014L, 105, "for" },
                    { 1015L, 106, "all" },
                    { 1016L, 107, "good" },
                    { 1017L, 108, "men" },
                    { 1010L, 101, "Now " },
                    { 1038L, 304, "cow" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleItem");
        }
    }
}
