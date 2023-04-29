
using ConsoleApp.Core.Models.Base;

namespace ConsoleApp.Core.Models
{
    public class BookWriter:BaseModel
    {
        private static int _id; 
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int Review { get; set; }
        public List<Book> Books;

        public BookWriter(string name,string surname,string phonenumber,int review)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            PhoneNumber = phonenumber;
            Review = review;
            Books = new List<Book>();
            CreatedDate = DateTime.UtcNow.AddHours(4);
            

        }

        
    }
}
