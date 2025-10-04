using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class ColumnDataCriacaoTblPessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAtualizacao",
                table: "PESSOAS",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "SISTEMA",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "SISTEMA");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "PESSOAS",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "PESSOAS",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "PESSOAS");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAtualizacao",
                table: "PESSOAS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "SISTEMA",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "SISTEMA");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "PESSOAS",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
