using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMovieStore.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }
    }
}