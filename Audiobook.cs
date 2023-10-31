namespace BD90;

class Audiobook : Book
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
    private int audiolength;
    public int AudioLength
    {
        get
        {
            return audiolength;
        }
        set
        {
            audiolength = value;
        }
    }
    private string narrator;
    public string Narrator
    {
        get
        {
            return narrator;
        }
        set
        {
            narrator = value;
        }
    }
}
