using System.ComponentModel.DataAnnotations.Schema;

namespace Books.DataAccess.Models
{
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("genre")]
        public string Genre { get; set; }
    }
}
