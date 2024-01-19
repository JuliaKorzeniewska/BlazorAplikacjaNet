using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

        new Product
        {
            Id = 1,
            Title = "Duma i uprzedzenie",
            Description = "Fabuła skupia się na historii córek państwa Bennetów, uwikłanych w sieci ówcześnie obowiązujących konwenansów. Przeszkodą na drodze do szczęścia młodych kobiet są brak majątku oraz status społeczny, a intrygi, niedomówienia i tajemnice piętrzą kolejne trudności na drodze do happy endu.",
            ImageUrl = "https://wydawnictwoswiatksiazki.pl/wp-content/uploads/duma-i-uprzedzenie-wydanie-1.jpg",
            Price = 39.99m

        },
         new Product
         {
             Id = 2,
             Title = "Hobbit, czyli tam i z powrotem",
             Description = "Charakteryzuje ich bardzo niski wzrost, zdecydowanie mniejszy od krasnoludów, ale większy od liliputów. Kiedyś byli wyżsi, jednak rasa z biegiem wieków stała się niższa. Przed laty potrafili mierzyć do czterech stóp wysokości, jednak obecnie trudno znaleźć przedstawiciela rasy, który przekracza trzy stopy wzrostu.",
             ImageUrl = "https://woblink.com/image-cache/sellable_cover/products/images/620c9f4aa206b.jpeg",
             Price = 37.99m

         },
         new Product
         {
             Id = 3,
             Title = "Harry Potter i Zakon Feniksa",
             Description = "Harry znów spędza nudne, samotne wakacje w domu Dursleyów. Czeka go piąty rok nauki w Hogwarcie i chciałby jak najszybciej spotkać się ze swoimi najlepszymi przyjaciółmi, Ronem i Hermioną. Ci jednak wyraźnie go zaniedbują. Gdy Harry ma już dość wszystkiego i postanawia zmienić swoją nieznośną sytuację, sprawy przyjmują całkiem nieoczekiwany obrót.",
             ImageUrl = "https://ecsmedia.pl/cdn-cgi/image/format=webp,/c/harry-potter-i-zakon-feniksa-tom-5-b-iext139870623.jpg",
             Price = 35.99m

         }
      );
        }


        public DbSet<Product> Products { get; set; }
    }
}
    

