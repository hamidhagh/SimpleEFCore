﻿namespace EntityFrameworkCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public AuthorBiography Biagraphy { get; set; }
    }
}
