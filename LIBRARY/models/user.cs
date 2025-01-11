using models;

namespace models
{
    public class user
    {   public int Id {get;}
        public string Name {get;set;}
        public string Address {get;set;}
        public int Phone {get;set;}
    }

    public user (int id, string name, string address, int phone)
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
    }    
}



