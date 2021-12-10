// See https://aka.ms/new-console-template for more information
using UserModule;

namespace hello_world
{
    class Program
    {
        static void Main() {
            User user = new User("Ifeanyi", 27);
            string[] names = new string[] { "Odogwu", "001" };

            

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];

                if (name.Length > 3) {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
