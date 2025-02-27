using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SklepInternetowy.Models;
using System;
using System.Linq;

namespace SklepInternetowy.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Categories.Any() || context.Products.Any())
                {
                    return; // Baza danych została już zainicjalizowana
                }

                var category = new Category { Name = "Elektronika" };
                context.Categories.Add(category);
                context.SaveChanges();

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Laptop",
                        Price = 2999.99m,
                        Description = "Wydajny laptop gamingowy.",
                        CategoryId = category.Id
                    },
                    new Product
                    {
                        Name = "Telefon",
                        Price = 1999.99m,
                        Description = "Nowoczesny smartfon.",
                        CategoryId = category.Id
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
