using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Accessors.Models.EF;
using SemnanFlix.Common.Models;
using System.Collections.Generic;

namespace SemnanFlix.Accessors.Interfaces
{
    public interface IMovieAccessor
    {
        MovieDTO Get(int id);

        List<MovieDTO> GetAll();

        List<MovieDTO> GetAllByRequest(DataTableRequest query);

        int GetCount(string search = null);

        MovieDTO Save(MovieDTO dto);

        MovieDTO Delete(int id);
        List<RatingAndReviewDTO> GetReview(int id);
        void SaveRatingAndReview(RatingAndReviewDTO model);
    }
}
