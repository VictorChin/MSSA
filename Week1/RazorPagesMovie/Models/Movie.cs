using System.ComponentModel.DataAnnotations;
namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Movie Title")]
        
        public string Title { get; set; }= string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseData { get; set; }
        public string Genre { get; set; } = string.Empty;
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


    }
}
