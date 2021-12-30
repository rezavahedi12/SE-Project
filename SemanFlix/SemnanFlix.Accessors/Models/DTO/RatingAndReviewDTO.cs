using SemnanFlix.Accessors.Models.DTO.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemnanFlix.Accessors.Models.DTO
{
    public class RatingAndReviewDTO : EntityDTO
    {
        public int MovieId { get; set; }
        public string Review { get; set; }
        public int Rate { get; set; }
    }
}
