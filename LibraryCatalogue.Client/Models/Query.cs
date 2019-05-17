using System;
namespace LibraryCatalogue.Client.Models
{
    public class Query
    {
        public Item item { get; set; }
        public string parameter { get; set; }
        public string query { get; set; }
    }
}
