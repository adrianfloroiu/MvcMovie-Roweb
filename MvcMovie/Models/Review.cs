using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Review")]
        public string ReviewText { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
