using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeProduto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 250, nullable: true),
                    DescricaoProduto = table.Column<string>(type: "text", nullable: true),
                    ValorProduto = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Ativo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 1, nullable: true),
                    DataFabricacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataValidade = table.Column<DateTime>(type: "datetime", nullable: true),
                    FotoProduto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 250, nullable: true),
                    ProdutoPromocao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeUsuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 250, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 250, nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    QuantidadeEstrela = table.Column<int>(nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true),
                    AvaliacaoUtil = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 1, nullable: true),
                    ProdutoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Produto",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Usuario",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_ProdutoId",
                table: "Avaliacoes",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_UsuarioId",
                table: "Avaliacoes",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
