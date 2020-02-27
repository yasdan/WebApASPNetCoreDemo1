using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApASPNetCoreDemo1.Models; // needed for models class
using Microsoft.EntityFrameworkCore; // needed for Dbcontext

namespace WebApASPNetCoreDemo1.Data
{
    public class BookContext :DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base( options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
