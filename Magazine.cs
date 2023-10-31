namespace BD90;

class Magazine // yeah
{
    private static int magazinecounter = 0;
    private int magazineId;
    public int MagazineId
    {
        get
        {
            return magazineId;
        }
        set
        {
            magazineId = ++magazinecounter;
        }
    }

    private int magazinenumber;
    public int MagazineNumber
    {
        get
        {
            return magazinenumber;
        }
        set
        {
            magazinenumber = value;
        }
    }

    private string magazinetitle;
    public string MagazineTitle
    {
        get
        {
            return magazinetitle;
        }
        set
        {
            magazinetitle = value;
        }
    }

    private int magazinePublished;
    public int MagazinePublished
    {
        get
        {
            return magazinePublished;
        }

        set
        {
            magazinePublished = value;
        }
    }


    private DateTime timePostCreated = DateTime.Now;
    public DateTime CreationDate
    {
        get
        {
            return timePostCreated;
        }
    }
}
