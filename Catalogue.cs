using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using Microsoft.VisualBasic;

namespace BD90;

class Catalogue
{
    private List<Book> books = new();
    private List<Magazine> magazines = new();
    private List<Audiobook> audiobooks = new();

    private Audiobook singleAudiobook = new();
    private Magazine singleMagazine = new();
    private Book singleBook = new();

    public Book SingleBook
    {
        get
        {
            return singleBook;
        }
        set
        {
            singleBook = value;

        }
    }
    public Magazine SingleMagazine
    {
        get
        {
            return singleMagazine;
        }
        set
        {
            singleMagazine = value;
        }
    }
    public Audiobook SingleAudiobook
    {
        get
        {
            return singleAudiobook;
        }
        set
        {
            singleAudiobook = value;
        }

    }
    public void SetBookTitle(string title)
    {
        singleBook.BookTitle = title;
    }
    public void SetPublishedYearBook(int year)
    {
        singleBook.BookPublished = year;
    }
    public void SetBookAuthor(string author)
    {
        singleBook.BookAuthor = author;
    }
    public void SetBookId()
    {
        singleBook.BookId++;
    }
    public void InsertSingleBookToBooks()
    {
        books.Add(singleBook);
    }


    public void SetMagazineTitle(string title)
    {
        singleMagazine.MagazineTitle = title;
    }
    public void SetPublishedYearMagazine(int year)
    {
        singleMagazine.MagazinePublished = year;
    }
    public void SetMagazineNumber(int number)
    {
        singleMagazine.MagazineNumber = number;
    }
    public void SetMagazineId()
    {
        singleMagazine.MagazineId++;
    }
    public void InsertSingleMagazineToMagazines()
    {
        magazines.Add(singleMagazine);
    }


    public void SetAudiobookTitle(string title)
    {
        singleAudiobook.BookTitle = title;
    }
    public void SetPublishedYearAudiobook(int year)
    {
        singleAudiobook.BookPublished = year;
    }
    public void SetAudiobookAuthor(string author)
    {
        singleAudiobook.BookAuthor = author;
    }
    public void SetAudiobookLength(int lenght)
    {
        singleAudiobook.AudioLength = lenght;
    }
    public void SetAudiobookNarrator(string narrator)
    {
        singleAudiobook.Narrator = narrator;
    }
    public void SetAudiobookId()
    {
        singleAudiobook.BookId++;
    }
    public void InsertSingleAudiobookToAudiobooks()
    {
        audiobooks.Add(singleAudiobook);
    }


    public List<Book> ListAllBooks()
    {
        return books;
    }
    public List<Magazine> ListAllMagazines()
    {
        return magazines;
    }
    public List<Audiobook> ListAllAudiobooks()
    {
        return audiobooks;
    }
    public string Search(string inquery)
    {
        inquery = inquery.ToLower();

        foreach (Book item in books)
        {

            if (inquery.Equals(item.BookTitle.ToLower()) || inquery.Equals(item.BookAuthor.ToLower()) || inquery == item.BookPublished.ToString())
            {
                string bookAnswer = $"Yes, we have it!\nID: {item.BookId}\nTitle: {item.BookTitle}\nAuthor: {item.BookAuthor}\nYear published: {item.BookPublished}\n";
                return bookAnswer;
            }

        }

        foreach (Magazine item in magazines)
        {
            if (inquery.Equals(item.MagazineTitle.ToLower()) || inquery == item.MagazineNumber.ToString() || inquery == item.MagazinePublished.ToString())
            {
                string magazineAnswer = $"Yes, we have it!\nID: {item.MagazineId}\nTitle: {item.MagazineTitle}\nNumber: {item.MagazineNumber}\nYear published: {item.MagazinePublished}\n";
                return magazineAnswer;
            }

        }

        foreach (Audiobook item in audiobooks)
        {
            if (inquery.Equals(item.BookTitle.ToLower()) || inquery.Equals(item.BookAuthor.ToLower()) || inquery == item.BookPublished.ToString())
            {
                string audiobookAnser = $"Yes, we have it!\nTitle: {item.BookTitle}\nAuthor: {item.BookAuthor}\nYear published: {item.BookPublished}\nLength: {item.AudioLength}\nNarrator: {item.Narrator}\n";
                return audiobookAnser;
            }

        }
        return "Media object not found";
    }
}