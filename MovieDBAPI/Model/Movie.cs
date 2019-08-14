using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieDBAPI.Model
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(255)]
        public string MovieTitle { get; set; }
        [Required]
        [StringLength(255)]
        public string MovieDetail { get; set; }
        [Required]
        [StringLength(255)]
        public string MovieSummary { get; set; }
        [Required]
        [StringLength(255)]
        public string MoviePoster { get; set; }
        [Required]
        [Column("imdbID")]
        [StringLength(255)]
        public string ImdbId { get; set; }
        public int PersonalRating { get; set; }
    }
}
