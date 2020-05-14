using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CADFundamentalsWebAPI.Data;
using System;
using System.Linq;

namespace CADFundamentalsWebAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CADFundamentalsWebAPIContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CADFundamentalsWebAPIContext>>()))
            {
                // Look for any uberCategories.
                if (context.UberCategory.Any())
                {
                    return;   // DB has been seeded
                }

                context.UberCategory.AddRange(
                    new UberCategory
                    {
                        Title = "Cloud Computing Fundamentals",
                        LatestReleaseDate = DateTime.Parse("2020-5-1"),
                        Genre = "Cloud Fundamentals",
                        Complexity = 30.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Microsoft Cloud Services",
                        LatestReleaseDate = DateTime.Parse("2020-9-1"),
                        Genre = "Cloud Fundamentals",
                        Complexity = 38.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Networking Fundamentals",
                        LatestReleaseDate = DateTime.Parse("2020-11-1"),
                        Genre = "Cloud Fundamentals",
                        Complexity = 40.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Planning Microsoft Azure Infrastructure",
                        LatestReleaseDate = DateTime.Parse("2020-11-1"),
                        Genre = "Azure Infrastructure",
                        Complexity = 30.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Managing Microsoft Azure Compute",
                        LatestReleaseDate = DateTime.Parse("2020-12-1"),
                        Genre = "Azure Infrastructure",
                        Complexity = 45.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Microsoft Azure Networking",
                        LatestReleaseDate = DateTime.Parse("2021-1-1"),
                        Genre = "Azure Infrastructure",
                        Complexity = 50.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Best Practices",
                        LatestReleaseDate = DateTime.Parse("2021-5-1"),
                        Genre = "Azure Security",
                        Complexity = 60.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = ".Net",
                        LatestReleaseDate = DateTime.Parse("2021-2-1"),
                        Genre = "Azure Development",
                        Complexity = 35.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Java",
                        LatestReleaseDate = DateTime.Parse("2021-2-1"),
                        Genre = "Azure Development",
                        Complexity = 30.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Node JS",
                        LatestReleaseDate = DateTime.Parse("2021-3-1"),
                        Genre = "Azure Development",
                        Complexity = 35.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Cloud Native",
                        LatestReleaseDate = DateTime.Parse("2021-4-1"),
                        Genre = "Azure Architecture",
                        Complexity = 50.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Microservices",
                        LatestReleaseDate = DateTime.Parse("2021-5-1"),
                        Genre = "Azure Architecture",
                        Complexity = 55.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Data Solutions",
                        LatestReleaseDate = DateTime.Parse("2021-2-1"),
                        Genre = "Azure Databases",
                        Complexity = 40.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Azure and SQL Databases",
                        LatestReleaseDate = DateTime.Parse("2021-4-1"),
                        Genre = "Azure Databases",
                        Complexity = 40.00M,
                        Price = 0.00M
                    },

                    new UberCategory
                    {
                        Title = "Cognitive Services",
                        LatestReleaseDate = DateTime.Parse("2021-8-1"),
                        Genre = "Azure Databases",
                        Complexity = 65.00M,
                        Price = 0.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
