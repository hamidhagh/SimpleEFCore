﻿namespace EntityFrameworkCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        //public List<Category> Categories { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
