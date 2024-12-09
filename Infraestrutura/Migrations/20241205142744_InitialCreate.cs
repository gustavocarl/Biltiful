using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTES",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    UltimaCompra = table.Column<DateOnly>(type: "date", nullable: false),
                    DataCadastro = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(1)", nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.CPF);
                });

            migrationBuilder.CreateTable(
                name: "FORNECEDORES",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataAbertura = table.Column<DateOnly>(type: "date", nullable: false),
                    UltimaCompra = table.Column<DateOnly>(type: "date", nullable: false),
                    DataCadastro = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(1)", nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDORES", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "MATERIASPRIMAS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UltimaCompra = table.Column<DateOnly>(type: "date", nullable: false),
                    DataCadastro = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(1)", nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATERIASPRIMAS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    CodigoBarras = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    UltimaVenda = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(1)", nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.CodigoBarras);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTES");

            migrationBuilder.DropTable(
                name: "FORNECEDORES");

            migrationBuilder.DropTable(
                name: "MATERIASPRIMAS");

            migrationBuilder.DropTable(
                name: "PRODUTOS");
        }
    }
}
