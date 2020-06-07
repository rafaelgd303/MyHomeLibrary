using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeLibrary.Models
{
    public class Book
    {
        public int Id { get; set; } 

        [DisplayName("Tytuł książki")]
        public string Title { get; set; }

        [DisplayName("Autor")]
        public string Author { get; set; }

        [DisplayName("Wydawnictwo")]
        public string PublishingHouse { get; set; }

        [DisplayName("Data wydania")]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("Ilość stron")]
        public int Page { get; set; }

        [DisplayName("Ocena")]
        public double Rating { get; set; }
    }
}
