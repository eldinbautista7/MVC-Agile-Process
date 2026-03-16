using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Agile_Process.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        public int Rating { get; set; }

        public string Genre { get; set; }
    }
}