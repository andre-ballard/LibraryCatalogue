using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalogue.Client.Models
{
    public class Query
    {
        public string item { get; set; }
        public string parameter { get; set; }
        [Required]
        public string query { get; set; }
    }
}
