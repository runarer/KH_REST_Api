namespace Model;

public class Book
{
    public required string Name { get; set; }
    public List<Author> Authors { get; set; } = [];
    public string ISBN { get; set; } = string.Empty;
}
