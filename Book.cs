namespace BD90;

class Book
{
    private static int bookIdCounter = 0;
    private int bookid;
    public int BookId
    {
        get
        {
            return bookid;
        }
        set
        {
            bookid = ++bookIdCounter;
        }
    }

    private string bookAuthor;
    public string BookAuthor
    {
        get
        {
            return bookAuthor;
        }
        set
        {
            bookAuthor = value;
        }
    }

    private string bookTitle;
    public string BookTitle
    {
        get
        {
            return bookTitle;
        }

        set
        {
            bookTitle = value;
        }

    }

    private int bookPublished;
    public int BookPublished
    {
        get
        {
            return bookPublished;
        }

        set
        {
            bookPublished = value;
        }
    }

    private DateTime timePostCreated = DateTime.Now;
    public DateTime CreationDate
    {
        get { return timePostCreated; }
    }
}
