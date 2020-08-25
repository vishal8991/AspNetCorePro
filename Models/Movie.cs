using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string genre { get; set; }
        public decimal Price { get; set; }
    }
}
