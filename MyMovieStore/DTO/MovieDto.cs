﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMovieStore.DTO
{
    public class MovieDto
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]

        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public GenreDto genre { get ; set; }
        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}