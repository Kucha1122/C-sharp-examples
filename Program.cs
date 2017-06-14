using System;
using shop.Models;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var asynchronous = new Asynchronous();
            asynchronous.Test().Wait();
        }
    }
}
