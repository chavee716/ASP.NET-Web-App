using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; } 
        public List<Customer> Customers { get; set; }
    }
}
