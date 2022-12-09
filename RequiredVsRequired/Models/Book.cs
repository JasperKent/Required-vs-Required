using System.ComponentModel.DataAnnotations;

namespace RequiredVsRequired.Models
{
    public class Book
    {
        public int Id { get; set; }

        public required string Title { get; set; }
        public int? Year { get; set; }
        public string? Author { get; set; }
    }
}
