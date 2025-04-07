using KnihovnaWeb.Models;

namespace KnihovnaWeb.Managers;

public class BookManager
{
    public List<Book> books = new List<Book>();
    private int Id = 1;

    public BookManager()
    {
        books.Add(new Book(Id++, "Auto", "Auto"));
        books.Add(new Book(Id++, "Book", "Book"));
    }

    public int NextId()
    {
        return Id++;
    }
}
