using System.Text;

public interface IBook
{
    string Id { get { return Id; } }
    string Title { get { return Title; } }
    string Author { get { return Author; } }
    int Year { get { return Year; } }

    public void DisplayInfo();
}

public class Book : IBook
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages;
    public Book(string id,string title,string author,int year,int pages)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"[Book] {Id}| {Title}- {Author} ({Year}),{Pages} trang");
    }

}

public class EBook : Book
{
    public double FileSizeMB;

    public EBook(string id, string title, string author, int year, int pages,double filesizeMB) : base(id, title, author, year, pages)
    {
        FileSizeMB = filesizeMB;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Book] {Id}| {Title}- {Author} ({Year}),{Pages} trang,{FileSizeMB} MB");
    }
}

public class Library
{
    List<IBook> books = new List<IBook>();
    public void AddBook(IBook aibuc)
    {
        books.Add(aibuc);
    }
    public bool RemoveBook(IBook aibuc)
    {
        if(books.Contains(aibuc))
        {
            books.Remove(aibuc);
            return true;
        }
        return false;
    }
    public List<IBook> GetAll()
    {
         return books;
    }
    public void PrintInventory()
    {
        foreach (IBook book in books)
        {
            book.DisplayInfo();
        }
    }
    public void PrintInventory(string author)
    {
        foreach(IBook book in books)
        {
            if(book.Author.Equals(author))
            {
                book.DisplayInfo();
            }
        }
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Library library = new Library();
        IBook b1 = new Book("ID16677", "Vì cậu là bạn nhỏ của tớ", "Phạm Đăng Khôi", 2018, 80);
        IBook b2 = new Book("ID16678", "Vì bạn là cậu nhỏ của tớ", "Phạm Ngu Khôi", 2018, 80);
        IBook b3 = new Book("ID16679", "Vì cậu nhỏ là bạn của tớ", "Phạm Đăng Khôi", 2018, 80);
        library.AddBook(b1);
        library.AddBook(b2);
        library.AddBook(b3);
        library.GetAll();
        library.PrintInventory();
    }
}