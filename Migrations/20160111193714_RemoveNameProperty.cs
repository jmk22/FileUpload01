using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace FileUpload01.Migrations
{
    public partial class RemoveNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Name", table: "Uploads");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Uploads",
                nullable: true);
        }
    }
}
