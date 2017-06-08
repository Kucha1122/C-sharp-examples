using System;
using shop.Models;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App is running!");
            Order order1 = new Order(1, 100);
            User user = new User("uyu1@o2.pl", "haselko");
        }
    }
}
