using SemnanFlix.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SemnanFlix.ViewModels.Movie
{
    public class RatingAndReviewViewModel : EntityViewModel
    {
        public int MovieId { get; set; }
        [MaxLength(length: 100 , ErrorMessage = "Your Review Should Less than 100 char")]
        public string Review { get; set; }
        [Range(1 , 5 , ErrorMessage = "Please Rate Between 1 To 5")]
        public int Rate { get; set; }
    }
}
