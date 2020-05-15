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
                        // DB has been seeded
                }
                else
                { 
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
                // Look for any uberCategories.
                if (context.Topic.Any())
                {
                    // DB has been seeded
                }
                else
                {
                    context.Topic.AddRange(
                        new Topic
                        {
                            Title = "Introduction: An Overview",
                            LatestReleaseDate = DateTime.Parse("2020-5-14"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 5.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "Visual Studio",
                            LatestReleaseDate = DateTime.Parse("2020-5-15"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 10.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "Console-based Applications",
                            LatestReleaseDate = DateTime.Parse("2020-5-16"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 10.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "C#",
                            LatestReleaseDate = DateTime.Parse("2020-5-17"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 10.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "Console-based Applications: A deeper look",
                            LatestReleaseDate = DateTime.Parse("2020-5-18"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 25.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "Front-End Development",
                            LatestReleaseDate = DateTime.Parse("2020-5-19"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 15.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "CSS and HTML",
                            LatestReleaseDate = DateTime.Parse("2020-5-20"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 15.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "ASP.NET Core",
                            LatestReleaseDate = DateTime.Parse("2020-5-21"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 25.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "The MVC Approach",
                            LatestReleaseDate = DateTime.Parse("2020-5-22"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 40.00M,
                            Price = 0.00M
                        },
                        new Topic
                        {
                            Title = "Working with Databases",
                            LatestReleaseDate = DateTime.Parse("2020-5-23"),
                            UberCategory = "Cloud Computing Fundamentals",
                            UberCategoryId = 1,
                            Complexity = 25.00M,
                            Price = 0.00M
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
