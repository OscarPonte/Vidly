using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display (Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Display (Name = "Number in Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
        [Display(Name = "Available Movies")]
        [Range(1, 20)]
        public byte NumberAvailable { get; set; }   
        public MoviesGenre MoviesGenre { get; set; }
        [Display (Name = "Genre")]
        public int MoviesGenreId { get; set; }

        public static implicit operator Movie(DbSet<Movie> v)
        {
            throw new NotImplementedException();
        }
    }
}