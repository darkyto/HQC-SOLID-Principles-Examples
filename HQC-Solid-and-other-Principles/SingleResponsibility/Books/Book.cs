namespace HQC_Solid_and_other_Principles.SingleResponsibility.Books
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string TurnPage(int page)
        {
            return "Current page " + page;
        }
    }
}
