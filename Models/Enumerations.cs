using System;
using System.Collections.Generic;
using System.Linq;

namespace shop.Models
{
    public class Enumerations
    {
        public void Test()
        {
            var numbersList = Enumerable.Range(1,100).ToList();
            IEnumerable<int> numbers = GetNumbers();
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var users = GetUsers().ToList();
            foreach(var user in users)
            {
            }
        }
            public IQueryable<User> GetUsers()
            {
                return users;
            }
    }
}