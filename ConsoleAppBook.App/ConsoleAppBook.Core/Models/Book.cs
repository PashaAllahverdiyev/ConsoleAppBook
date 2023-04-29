

using ConsoleApp.Core.Enums;
using ConsoleApp.Core.Models.Base;

namespace ConsoleApp.Core.Models
{
    public class Book:BaseModel

    {
        private static int _id;
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public string  Description { get; set; }
        public BookCategory Category { get; set; }
        public BookWriter BookWriter { get; set; }

        public Book(string name,double price,double discountprice,string description,BookCategory category,BookWriter bookWriter)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            DiscountPrice = discountprice;
            Description = description;
            Category = category;

            
        }
    }
}
