using BookApi.DBModel;
using BookApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

public class DataGenerator
{
    public static void Initialize(BookContext context)
    {

            // Look for any board games.
            if (context.Books.Any())
            {
                return;   // Data was already seeded
            }

            context.Books.AddRange(
                new Book
                {
                    Id = 1,
                    Name = "Candy Land",
                    PublishYear = "2010",
                    Author = "Unknown"
                },
                new Book
                {
                    Id = 2,
                    Name = "Children of Heaven",
                    PublishYear = "2015",
                    Author = "Unknown"
                },
                new Book
                {
                    Id = 3,
                    Name = "3 Ediots",
                    PublishYear = "2008",
                    Author = "Unknown"
                },
                new Book
                {
                    Id = 4,
                    Name = "Candy Land",
                    PublishYear = "2010",
                    Author = "Unknown"
                }
                );

            context.SaveChanges();
    }
}