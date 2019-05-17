using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryCatalogue.Client.Models
{
    public class LibraryContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}