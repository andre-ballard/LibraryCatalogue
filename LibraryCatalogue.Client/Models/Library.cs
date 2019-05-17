using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryCatalogue.Client.Models
{
    public class Library
    {
        private LibraryContext _context;
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }
        public List<Movie> Movies { get; set; }

        public Library()
        {
            _context = new LibraryContext();
        }


       public List<Book> GetItems(Book item, int search)
        {
            switch (search)
            {
                case 0:
                    return _context.Books.Where(i => i.Title.Contains(item.Title)).ToList();
                case 1:
                    return _context.Books.Where(i => i.Subject == item.Subject).ToList();
                case 2:
                    return _context.Books.Where(i => i.Author.Contains(item.Author)).ToList();   
                default:
                    return null;
            }
        }

        public List<Movie> GetItems(Movie item, int search)
        {
            switch (search)
            {
                case 0:
                    return _context.Movies.Where(i => i.Title.Contains(item.Title)).ToList();
                case 1:
                    return _context.Movies.Where(i => i.Subject == item.Subject).ToList();
                case 2:
                    return _context.Movies.Where(i => i.Director.Contains(item.Director)).ToList();
                default:
                    return null;
            }
        }
        /*
        public Magazine GetItems(Magazine item)
        {
            return item;
        }*/
        
    }
}
