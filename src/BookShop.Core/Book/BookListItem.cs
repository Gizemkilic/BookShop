using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookShop.Core.Book
{
    public class BookListItem
    {
        private static int bookListId;

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(300)]
        [Required]
        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;  

        [ForeignKey("BookListId")]
        public virtual BookList BookList { get; set; }
        public virtual int BookListId { get; set; }

        [Required]
        public string CreatorUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public static BookListItem Create(string name, string description, int bookrListId, string creatorUserId)
        {
            return new BookListItem
            {
                Name = name,
                BookListId = bookListId,
                CreatorUserId = creatorUserId,
                CreatedDate = DateTime.Now,
                Description = description,
                IsCompleted = false
            };

            
        }

    }
}
