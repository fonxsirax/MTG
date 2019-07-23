using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG.Migrations
{//criado automaticamente pelo Framework utilizando "add InicioBanco" a partir das configurações
    public partial class InicioBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {//O que vai ser realizado no banco de dados
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    manaCost = table.Column<string>(maxLength: 20, nullable: false),
                    CMC = table.Column<int>(maxLength: 20, nullable: false),
                    colorIdentity = table.Column<string>(maxLength: 5, nullable: false),
                    typePermanent = table.Column<string>(maxLength: 50, nullable: false),
                    superType = table.Column<string>(maxLength: 50, nullable: false),
                    rarity = table.Column<string>(maxLength: 10, nullable: false),
                    set = table.Column<string>(maxLength: 10, nullable: false),
                    text = table.Column<string>(maxLength: 500, nullable: false),
                    artist = table.Column<string>(maxLength: 50, nullable: false),
                    power = table.Column<int>(maxLength: 5, nullable: false),
                    toughness = table.Column<int>(maxLength: 5, nullable: false),
                    imgURL = table.Column<string>(maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {//Serve para desfazer aquilo que foi feito
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
