using System;
using shop.Models;

namespace Episode3.Models
{
    public class Exceptions
    {
        public void Test()
        {
            try
            {
                User user = new User("user@email.com", "Secret");
                user = null;
                throw new ArgumentNullException(nameof(user));


                throw new Exception("Email in use.");
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine($"Null error: {exception}");
            }
            catch(Exception exception)
            {
                Console.WriteLine($"An error: {exception}");
            }
            finally
            {
                Console.WriteLine("Finally here!");
            }

            Console.WriteLine("OK");
        }
    }
}