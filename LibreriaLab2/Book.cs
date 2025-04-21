public class Libro{
    private string title;
    private string author;
    private int year;
    private string genre;

    public Libro(string title, string author, int year, string genre)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.genre = genre;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public int GetYear()
    {
        return year;
    }

    public string GetGenre()
    {
        return genre;
    }

}