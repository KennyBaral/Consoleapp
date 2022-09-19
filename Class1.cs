using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hello
    {
        public void HelloWorld()
        {
            Console.WriteLine("how do i do this damn");
        }
        public int addition()
        {
            Console.WriteLine("Please enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum =a+b;
            return sum;

        }
        public int sub()
        {
            Console.WriteLine("enter the first number:");
            int a = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Please enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int sub = a - b;
            return sub;
        }

    }
}
