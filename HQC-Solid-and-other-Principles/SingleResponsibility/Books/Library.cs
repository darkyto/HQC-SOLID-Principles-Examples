namespace HQC_Solid_and_other_Principles.SingleResponsibility.Books
{
    using System;
    using System.Collections.Generic;

    public class Library
    {
        private IList<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public int FindBook(string title)
        {
            // implement logic for finding book
            return 42;
        }
    }
}
