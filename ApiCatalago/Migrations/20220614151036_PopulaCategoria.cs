using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalago.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into categoria (Nome, ImagemUrl) values ('Bebidas', 'bebidas.jpg'),('Lanches', 'lanches.jpg'),('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from categoria");
        }
    }
}
