namespace Model;


public class Collection
{
    public required string Name { get; set; }
    public List<Book> Books { get; set; } = [];
    public List<Collection> SubCollections { get; set; } = [];
}

public enum CollectionType
{
    Global, Universe, Series
}