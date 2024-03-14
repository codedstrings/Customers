using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Helper
{
    public static class ReadWrite
    {
        public static string GetStringFromUser(string display)
        {
            Console.Write(display);
            return Console.ReadLine();
        }

        public static int GetIntFromUser(string display)
        {
            Console.Write(display);
            return int.Parse(Console.ReadLine());
        }

    }
}
