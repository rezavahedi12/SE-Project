using SemnanFlix.Accessors.Models.EF.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemnanFlix.Accessors.Models.EF
{
    public class RatingAndReview : Entity
    {
        public int MovieId { get; set; }
        public string Review { get; set; }
        public int Rate { get; set; }
    }
}
