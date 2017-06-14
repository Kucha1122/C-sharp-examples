using System;
using System.Linq;
using System.Reflection;

namespace shop.Models
{
    public class Reflections
    {
        public void Test()
        {
            var user = new User("user@email.com", "haselko");
            var type = user.GetType().GetTypeInfo();
            Console.WriteLine($"{type.Name} {type.Namespace} {type.FullName}");

            var methods = type.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine($"{method.Name}");
            }
            user.Activate();
            Console.WriteLine($"Is active: {user.isActive}.");

            var deactivateMethod = methods.First(x => x.Name == "Deactivate");
            deactivateMethod.Invoke(user, null);
            Console.WriteLine($"Is active: {user.isActive}.");
            
            Console.WriteLine($"Email: {user.Email}.");
            var setEmailMethod = type.GetMethod("SetEmail");
            setEmailMethod.Invoke(user, new []{"user2@o2.pl"});
            Console.WriteLine($"Email: {user.Email}.");

            var email = type.GetProperty("Email").GetValue(user);
            Console.WriteLine($"Email: {email}.");

            var databaseTypes = Assembly.GetEntryAssembly()
                                        .GetTypes()
                                        .Where(x => x.Name.Contains("Database"));
            
            foreach(var databaseType in databaseTypes)
            {
                Console.WriteLine($"{databaseType}");
            }

            var user5 = (User)Activator.CreateInstance(typeof(User), new []{"user5gmail.com", "hpassword"});
            Console.WriteLine($"{user5.Email}");
        }
    }
}