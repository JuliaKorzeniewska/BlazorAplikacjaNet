using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Fabuła skupia się na historii córek państwa Bennetów, uwikłanych w sieci ówcześnie obowiązujących konwenansów. Przeszkodą na drodze do szczęścia młodych kobiet są brak majątku oraz status społeczny, a intrygi, niedomówienia i tajemnice piętrzą kolejne trudności na drodze do happy endu.", "https://wydawnictwoswiatksiazki.pl/wp-content/uploads/duma-i-uprzedzenie-wydanie-1.jpg", 39.99m, "Duma i uprzedzenie" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Charakteryzuje ich bardzo niski wzrost, zdecydowanie mniejszy od krasnoludów, ale większy od liliputów. Kiedyś byli wyżsi, jednak rasa z biegiem wieków stała się niższa. Przed laty potrafili mierzyć do czterech stóp wysokości, jednak obecnie trudno znaleźć przedstawiciela rasy, który przekracza trzy stopy wzrostu.", "https://woblink.com/image-cache/sellable_cover/products/images/620c9f4aa206b.jpeg", 37.99m, "Hobbit, czyli tam i z powrotem" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Harry znów spędza nudne, samotne wakacje w domu Dursleyów. Czeka go piąty rok nauki w Hogwarcie i chciałby jak najszybciej spotkać się ze swoimi najlepszymi przyjaciółmi, Ronem i Hermioną. Ci jednak wyraźnie go zaniedbują. Gdy Harry ma już dość wszystkiego i postanawia zmienić swoją nieznośną sytuację, sprawy przyjmują całkiem nieoczekiwany obrót.", "https://ecsmedia.pl/cdn-cgi/image/format=webp,/c/harry-potter-i-zakon-feniksa-tom-5-b-iext139870623.jpg", 35.99m, "Harry Potter i Zakon Feniksa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
