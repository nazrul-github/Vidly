using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieGenreViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DisplayName("Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [DisplayName("Date Added")]
        [Required]
        public DateTime? DateAdded { get; set; }


        [DisplayName("Number In Stock")]
        [Range(1, 20, ErrorMessage = "Number of stock should be between 1 and 20")]
        [Required]
        public byte? NumberInStock { get; set; }

        [ForeignKey("Genre")]
        [DisplayName("Genre")]
        public int GenreId { get; set; }

        public string Title => Id == 0 ? "Create Movie": "Edit Movie";

        public List<Genre> Genres { get; set; }

        public MovieGenreViewModel()
        {
        }

        public MovieGenreViewModel(Movie movie)
        {
            Id = movie.Id;
            DateAdded = movie.DateAdded;
            GenreId = movie.GenreId;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
        }
    }
}