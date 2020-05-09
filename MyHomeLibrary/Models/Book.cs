using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeLibrary.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Page { get; set; }
        public double Rating { get; set; }
    }
}
