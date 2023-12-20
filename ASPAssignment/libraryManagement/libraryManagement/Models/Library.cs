using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libraryManagement.Models
{
    public enum Department
    {
        IT=1,
        Electronics,
        Mechanical,
        Civil,
        Electricals,
        Economics
    }
    public class Library
    {
        [Required(ErrorMessage = "Please enter the Category of the Book.")]
        public Department? CategoryName { get; set; }
        [Required(ErrorMessage = "Please enter the Updated Date of the Book.")]
        public DateTime? UpdatedOn { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Key]
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Please enter the Book name.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Please enter the Author name.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Please enter the Published year.")]
        public int? PublishedYear { get; set; }
        [Required(ErrorMessage = "Please enter the Price of the Book.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid Price of the Book.")]
        public int Price { get; set; }
    }
}
