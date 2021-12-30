using SemnanFlix.Accessors.Models.DTO;

namespace SemnanFlix.Engines.Interfaces
{
    public interface IMoviePurchaseEngine
    {
        UserMovieDTO GetUserMovie(int id, string userId);

        UserMovieDTO Purchase(UserMovieDTO userMovieDto);

        UserMovieDTO Rent(UserMovieDTO userMovieDto);
    }
}
