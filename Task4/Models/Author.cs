using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task4.Areas.Models;

namespace Task4.Models
{
    [Table("Authors")]
    public class Author
    {

        [Key]
        public int AuthorId { get; set; }


        [Required, StringLength(100)]
        public string AuthorName { get; set; }


        #region Navigation Properties to the Book Model


        [Required]
        public int BookId { get; set; }


        [ForeignKey(nameof(Author.BookId))]
        public Book Book { get; set; }


        #endregion

    }
}