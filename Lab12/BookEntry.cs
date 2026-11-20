namespace Lab12
{
    public class BookEntry
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }

        public BookEntry(string code, string title, int pageCount)
        {
            Code = code;
            Title = title;
            PageCount = pageCount;
        }
    }
}