﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMovieRental.Dtos
{
    public class MoviesDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public GenreDto Genre { get; set; }


        [Required]
       [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

    }
}