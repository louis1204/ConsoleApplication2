using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            while (control)
            {
                Console.WriteLine("Enter decimal number: ");
                string num = Console.In.ReadLine();
                Console.Out.WriteLine(Convert.ToString(int.Parse(num), 2));
            }
        }
    }
}