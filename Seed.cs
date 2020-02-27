using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApASPNetCoreDemo1.Data;
using Microsoft.Extensions.DependencyInjection;

namespace WebApASPNetCoreDemo1.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceprovider)
        {
            using(var context= new BookContext(
                serviceprovider.GetRequiredService<DbContextOptions<BookContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book {BTitle="My meories",
                        Category="Fiction",
                        Price=356.00,
                        AuthorName="Emma",
                        Publisher="Pengwin",
                        Releasedate=Convert.ToDateTime("21-02-2019")
                    },
                    new Book
                    {
                        BTitle = "Swirling waters",
                        Category = "Fiction",
                        Price = 556.00,
                        AuthorName = "Ameer",
                        Publisher = "Chetak",
                        Releasedate = Convert.ToDateTime("01-02-2019")
                    },
                    new Book
                    {
                        BTitle = "Indian Short Stories",
                        Category = "Fiction",
                        Price = 716.00,
                        AuthorName = "Narayan",
                        Publisher = "Pengwin",
                        Releasedate = Convert.ToDateTime("10-09-2014")
                    }
                    );
                context.SaveChanges();
            }

        }

    }
}
