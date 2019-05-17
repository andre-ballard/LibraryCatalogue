using System;
using System.Collections.Generic;
namespace LibraryCatalogue.Client.Models
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Movie> Movies { get; set; }

        public Item GetItem(Book item)
        {
            return item;
        }

        public Item GetItem(Movie item)
        {
            return item;
        }

        public Item GetItem(Magazine item)
        {
            return item;
        }
    }
}
