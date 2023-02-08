using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class Username
    {
        public static void DisplayUsername()
        {
            Console.WriteLine("print the username");
            string username = Console.ReadLine();

            int val = username.Length;
            Console.WriteLine("The number of character is " + val);

            if (username.Length > 3)
            {
                Console.WriteLine("Hello {0}, How are you?", username);
            }
            else
            {
                Console.WriteLine("The name is not having minimum 3 characters");
            }
        }
        
          

    }
}
