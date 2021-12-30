using SemnanFlix.Common.Models;
using SemnanFlix.ViewModels.Movie;
using System.Collections.Generic;

namespace SemnanFlix.Managers.Interfaces
{
    public interface IMovieManager
    {
        MovieViewModel Get(int id, string userId);

        MoviesViewModel GetAll();

        MoviesViewModel GetAllForUser(string userId);

        void Purchase(int id, string userId);

        void Rent(int id, string userId);

        EditMovieViewModel GetForEditing(int? id);

        MoviesViewModel GetAllByRequest(DataTableRequest query);

        EditMovieViewModel Save(EditMovieViewModel vm);

        MovieViewModel Delete(int id);

        string GetDepartmentSelectData(string query);

        string GetPersonSelectData(string query);

        MoviesViewModel Search(string name);

        void RatingAndReview(RatingAndReviewViewModel model);

        List<RatingAndReviewViewModel> getReview(int id);
    }
}
