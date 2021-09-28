using System;
using System.ComponentModel.DataAnnotations;
using demo.Data;

namespace demo.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title is required.")]
        [MaxLength(30)]
        [MinLength(5)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}