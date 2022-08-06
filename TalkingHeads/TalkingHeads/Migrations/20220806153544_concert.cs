using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TalkingHeads.Migrations
{
    public partial class concert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    ConcertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.ConcertId);
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "ConcertId", "Date", "Location", "Venue" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clarkston, Michigan, USA", "Pine Knob Music Theater" },
                    { 2, new DateTime(1982, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoffman Estates, Illinois, USA", "Poplar Creek" },
                    { 3, new DateTime(1982, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Des Moines, Iowa, USA", "Civic Center" },
                    { 4, new DateTime(1982, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minneapolis, Minnesota, USA", "Northrop Auditorium" },
                    { 5, new DateTime(1982, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staten Island, New York, USA", "Paramount Theater" },
                    { 6, new DateTime(1982, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Hills, New York, USA", "Tennis Stadium" },
                    { 7, new DateTime(1982, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saratoga Springs, New York, USA", "Performing Arts Center" },
                    { 8, new DateTime(1982, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbia, Maryland, USA", "Merriweather Post Pavilion" },
                    { 9, new DateTime(1982, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Hartford, Connecticut, USA", "Agora Ballroom" },
                    { 10, new DateTime(1982, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boston, Massachusetts, USA", "Orpheum Theater" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concerts");
        }
    }
}
