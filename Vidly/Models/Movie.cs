using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}