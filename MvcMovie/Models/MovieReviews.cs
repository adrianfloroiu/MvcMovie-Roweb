namespace MvcMovie.Models
{
    public class MovieReviews
    {
        public MovieReviews(Movie movieItem, List<Review> reviews)
        {
            MovieItem = movieItem;
            Reviews = reviews;
        }
        public Movie MovieItem { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
