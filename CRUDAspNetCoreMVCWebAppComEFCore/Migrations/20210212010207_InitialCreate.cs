using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDAspNetCoreMVCWebAppComEFCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    EmpregadosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Funcao = table.Column<string>(type: "varchar(10)", nullable: true),
                    LocalizacaoEscritorio = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.EmpregadosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empregados");
        }
    }
}
