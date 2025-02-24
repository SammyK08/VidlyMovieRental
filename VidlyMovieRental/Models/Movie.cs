﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieRental.Models
{
    public class Movie
    {
        public int Id { get; set; } 
        
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        
        [Required]
        [Display (Name ="Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }


        public int Avilability { get; set; }


        public Genre Genre { get; set; }

        [Display(Name ="Genre")]
        public int GenreId { get; set; }

    }
}