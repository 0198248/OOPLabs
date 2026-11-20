namespace Lab10Models
{
    public class BookEntry : IEntry
    {
        public string Code { get; }
        public string Title { get; }
        public string Author { get; }
        public int PageCount { get; }
        public int PublicationYear { get; }

        public BookEntry(string code, string title, string author,
            int pageCount, int publicationYear)
        {
            Code = code;
            Title = title;
            Author = author;
            PageCount = pageCount;
            PublicationYear = publicationYear;
        }

        public string GetInfo()
        {
            return $"Код: {Code}, назва: {Title}, автор: {Author}, " +
                   $"сторінок: {PageCount}, рік видання: {PublicationYear}";
        }
    }
}