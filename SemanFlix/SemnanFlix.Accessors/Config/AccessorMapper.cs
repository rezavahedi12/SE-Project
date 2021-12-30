using AutoMapper;
using SemnanFlix.Accessors.Models.DTO;
using SemnanFlix.Accessors.Models.EF;

namespace SemnanFlix.Accessors.Config
{
    public class AccessorMapper : Profile
    {
        public AccessorMapper()
        {
            CreateMap<CastMember, CastMemberDTO>().ReverseMap();
            CreateMap<CrewMember, CrewMemberDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<MovieGenre, MovieGenreDTO>().ReverseMap();
            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<UserMovie, UserMovieDTO>().ReverseMap();
            CreateMap<RatingAndReview, RatingAndReviewDTO>().ReverseMap();
        }

        public override string ProfileName
        {
            get { return GetType().ToString(); }
        }
    }
}
