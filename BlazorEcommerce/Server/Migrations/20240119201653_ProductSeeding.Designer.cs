﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240119201653_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fabuła skupia się na historii córek państwa Bennetów, uwikłanych w sieci ówcześnie obowiązujących konwenansów. Przeszkodą na drodze do szczęścia młodych kobiet są brak majątku oraz status społeczny, a intrygi, niedomówienia i tajemnice piętrzą kolejne trudności na drodze do happy endu.",
                            ImageUrl = "https://wydawnictwoswiatksiazki.pl/wp-content/uploads/duma-i-uprzedzenie-wydanie-1.jpg",
                            Price = 39.99m,
                            Title = "Duma i uprzedzenie"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Charakteryzuje ich bardzo niski wzrost, zdecydowanie mniejszy od krasnoludów, ale większy od liliputów. Kiedyś byli wyżsi, jednak rasa z biegiem wieków stała się niższa. Przed laty potrafili mierzyć do czterech stóp wysokości, jednak obecnie trudno znaleźć przedstawiciela rasy, który przekracza trzy stopy wzrostu.",
                            ImageUrl = "https://woblink.com/image-cache/sellable_cover/products/images/620c9f4aa206b.jpeg",
                            Price = 37.99m,
                            Title = "Hobbit, czyli tam i z powrotem"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Harry znów spędza nudne, samotne wakacje w domu Dursleyów. Czeka go piąty rok nauki w Hogwarcie i chciałby jak najszybciej spotkać się ze swoimi najlepszymi przyjaciółmi, Ronem i Hermioną. Ci jednak wyraźnie go zaniedbują. Gdy Harry ma już dość wszystkiego i postanawia zmienić swoją nieznośną sytuację, sprawy przyjmują całkiem nieoczekiwany obrót.",
                            ImageUrl = "https://ecsmedia.pl/cdn-cgi/image/format=webp,/c/harry-potter-i-zakon-feniksa-tom-5-b-iext139870623.jpg",
                            Price = 35.99m,
                            Title = "Harry Potter i Zakon Feniksa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
