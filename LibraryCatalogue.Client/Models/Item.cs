using LibraryCatalogue.Client.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalogue.Client.Models
{

    public class Item 
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
    }
}
