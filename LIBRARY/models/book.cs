using models;

namespace models
{
    public class book
    {   public int Id {get;}
        public string Name {get;set;}
        public string Genre {get;set;}
        public string Author {get;set;}
        public int Pages {get;set;}
    }
    public book (int id, string name, string genre, string author, int pages)
    {
        Id = id;
        Name = name;
        Genre = genre;
        Author = author;
        Pages = pages;
    }    
}