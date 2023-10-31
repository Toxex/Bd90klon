using System.ComponentModel;
using System.Dynamic;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace BD90;

internal class Program
{
    private static void Main(string[] args)
    {
        Catalogue theChosenOne = new();

        theChosenOne.SetBookTitle("Robinson Crusoe");
        theChosenOne.SetPublishedYearBook(1719);
        theChosenOne.SetBookAuthor("Daniel Defoe");
        theChosenOne.SetBookId();
        theChosenOne.InsertSingleBookToBooks();
        theChosenOne.SingleBook = new();

        theChosenOne.SetBookTitle("1984");
        theChosenOne.SetPublishedYearBook(1949);
        theChosenOne.SetBookAuthor("George Orwell");
        theChosenOne.SetBookId();
        theChosenOne.InsertSingleBookToBooks();
        theChosenOne.SingleBook = new();

        theChosenOne.SetBookTitle("Bilbo");
        theChosenOne.SetPublishedYearBook(1937);
        theChosenOne.SetBookAuthor("J.R.R Tolkien");
        theChosenOne.SetBookId();
        theChosenOne.InsertSingleBookToBooks();
        theChosenOne.SingleBook = new();

        theChosenOne.SetMagazineTitle("Rolling stone");
        theChosenOne.SetPublishedYearMagazine(1967);
        theChosenOne.SetMagazineNumber(1);
        theChosenOne.SetMagazineId();
        theChosenOne.InsertSingleMagazineToMagazines();
        theChosenOne.SingleMagazine = new();

        theChosenOne.SetAudiobookTitle("Vägen till Jerusalem");
        theChosenOne.SetPublishedYearAudiobook(1998);
        theChosenOne.SetAudiobookAuthor("Jan Guillou");
        theChosenOne.SetAudiobookLength(921);
        theChosenOne.SetAudiobookNarrator("Tomas Bolme");
        theChosenOne.SetAudiobookId();
        theChosenOne.InsertSingleAudiobookToAudiobooks();
        theChosenOne.SingleAudiobook = new();

        while (true)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Choose an option between 1-4\n1. Add media\n2. Show media in library\n3. Search\n4. Terminate program");
            Console.BackgroundColor = ConsoleColor.Black;
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:

                    Console.WriteLine("What type of media do you wish to add?\n1. Book\n2. Magazine\n3. Audiobook");
                    int secondSelection = int.Parse(Console.ReadLine());
                    switch (secondSelection)
                    {
                        case 1:

                            Console.WriteLine("What is the title of the book?");
                            string bookTitleInput = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(bookTitleInput))
                            {
                                theChosenOne.SetBookTitle(bookTitleInput);
                            }
                            else
                            {
                                Console.WriteLine("The book must have a title!");
                                break;
                            }

                            Console.WriteLine("What year was the book published? For years BC, use '-' before the number");
                            int bookYearInput = int.Parse(Console.ReadLine());
                            if (bookYearInput < 2023 && bookYearInput > -1800)
                            {
                                theChosenOne.SetPublishedYearBook(bookYearInput);
                            }
                            else
                            {
                                Console.WriteLine("You can't add litterature before it was conceieved nor future books that doesn't exist yet!");
                                break;
                            }

                            Console.WriteLine("Whom is the author of the book?");
                            string bookAuthorInput = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(bookAuthorInput))
                            {
                                theChosenOne.SetBookAuthor(bookAuthorInput);
                            }
                            else
                            {
                                Console.WriteLine("Surely someone MUST have written this?!");
                                break;
                            }

                            theChosenOne.SetBookId();
                            theChosenOne.InsertSingleBookToBooks();
                            theChosenOne.SingleBook = new();

                            break;

                        case 2:

                            Console.WriteLine("What is the title of the magazine?");
                            string magazineTitleInput = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(magazineTitleInput))
                            {
                                theChosenOne.SetMagazineTitle(magazineTitleInput);
                            }
                            else
                            {
                                Console.WriteLine("The magazine must have a title!");
                                break;
                            }

                            Console.WriteLine("What year was the magazine published?");
                            int magazineYearInput = int.Parse(Console.ReadLine());
                            if (magazineYearInput < 2023 && magazineYearInput > 1800)
                            {
                                theChosenOne.SetPublishedYearMagazine(magazineYearInput);
                            }
                            else
                            {
                                Console.WriteLine("You can't add magazines before it was conceieved nor future ones that doesn't exist yet!");
                                break;
                            }

                            Console.WriteLine("What is the number of the magazine?");
                            int magazineNumberInput = Convert.ToInt32(Console.ReadLine());
                            if (magazineNumberInput >= 1)
                            {
                                theChosenOne.SetMagazineNumber(magazineNumberInput);
                            }
                            else
                            {
                                Console.WriteLine("Input a magazine number!");
                                break;
                            }

                            theChosenOne.SetMagazineId();
                            theChosenOne.InsertSingleMagazineToMagazines();
                            theChosenOne.SingleMagazine = new();

                            break;

                        case 3:

                            Console.WriteLine("What is the title of the book?");
                            string audiobookTitleInput = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(audiobookTitleInput))
                            {
                                theChosenOne.SetAudiobookTitle(audiobookTitleInput);
                            }
                            else
                            {
                                Console.WriteLine("The audiobook must have a title!");
                                break;
                            }

                            Console.WriteLine("What year was the audiobook published? For years BC, use '-' before the number");
                            int audiobookYearInput = int.Parse(Console.ReadLine());
                            if (audiobookYearInput < 2023 && audiobookYearInput > -1800)
                            {
                                theChosenOne.SetPublishedYearAudiobook(audiobookYearInput);
                            }
                            else
                            {
                                Console.WriteLine("You can't add litterature before it was conceieved nor future books that doesn't exist yet!");
                                break;
                            }

                            Console.WriteLine("Whom is the author of the book?");
                            string audiobookAuthorInput = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(audiobookAuthorInput))
                            {
                                theChosenOne.SetAudiobookAuthor(audiobookAuthorInput);
                            }
                            else
                            {
                                Console.WriteLine("Surely someone MUST have written this?!");
                                break;
                            }

                            Console.WriteLine("How long is the playtime? specify in minutes rounded up or down");
                            int audiobookLength = int.Parse(Console.ReadLine());
                            if (audiobookLength > 0 && audiobookLength < 9004)
                            {
                                theChosenOne.SetAudiobookLength(audiobookLength);
                            }
                            else
                            {
                                Console.WriteLine("That's just wrong, mate");
                            }

                            Console.WriteLine("Whom is the narrator?");
                            string narrator = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(narrator))
                            {
                                theChosenOne.SetAudiobookNarrator(narrator);
                            }
                            else
                            {
                                Console.WriteLine("You must enter a narrator!");
                            }


                            theChosenOne.SetAudiobookId();
                            theChosenOne.InsertSingleAudiobookToAudiobooks();
                            theChosenOne.SingleAudiobook = new();

                            break;

                        default:

                            Console.WriteLine("Error!");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("BOOKS\n");
                    foreach (Book item in theChosenOne.ListAllBooks())
                    {
                        Console.WriteLine($"ID: {item.BookId}\nTitle: {item.BookTitle}\nAuthor: {item.BookAuthor}\nYear published: {item.BookPublished}\n");
                    }

                    Console.WriteLine("MAGAZINES\n");
                    foreach (Magazine item in theChosenOne.ListAllMagazines())
                    {
                        Console.WriteLine($"ID: {item.MagazineId}\nTitle: {item.MagazineTitle}\nMagazine Number: {item.MagazineNumber}\nYear published: {item.MagazinePublished}\n");
                    }

                    Console.WriteLine("AUDIOBOOKS\n");
                    foreach (Audiobook item in theChosenOne.ListAllAudiobooks())
                    {
                        Console.WriteLine($"ID: {item.BookId}\nTitle: {item.BookTitle}\nAuthor: {item.BookAuthor}\nYear published: {item.BookPublished}\nLength: {item.AudioLength}\nNarrator: {item.Narrator}\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("Kindly type your inquery here. You may search by author, title or year published");
                    string inquery = Convert.ToString(Console.ReadLine());
                    string answer = theChosenOne.Search(inquery);
                    Console.WriteLine(answer);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:

                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
