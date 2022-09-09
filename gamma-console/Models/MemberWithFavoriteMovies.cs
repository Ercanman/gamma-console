namespace gamma_console.Models
{
    public class MemberWithFavoriteMovies
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Team { get; set; }
        public List<Movie> FavoriteMovies { get; set; }
    }
}
