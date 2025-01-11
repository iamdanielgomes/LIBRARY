using models;

namespace models
{
    public class book
    {   public int Id {get;}
        public string Name {get;set;}
        public string Gender {get;set;}
        public string Author {get;set;}
        public int Pages {get;set;}
    }
    public book (int id, string name, string gender, string author, int pages)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Author = author;
        Pages = pages;
    }    
}