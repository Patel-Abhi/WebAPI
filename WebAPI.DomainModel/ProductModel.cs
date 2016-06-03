using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
    public class ProductModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public Departments Departments { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
    }

    public enum Departments
    {
        Electronics = 0,
        LifeStyle = 1,
        HomeLiving = 2,
        Appliances = 3,
        Automotive = 4,
        BooksStationary = 5,
        SportsEntertainment = 6,
        GiftCards = 7
    }
}
