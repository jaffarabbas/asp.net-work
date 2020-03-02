using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class neww
        {
        int a = 3;
        }
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your :  ");
            char c = Convert.ToChar(Console.ReadLine());

            if(c == '+')
            {
                int add = a + b;
                Console.WriteLine("Addition of "+add);
            }
            else if(c == '-')
            {
                int sub = a - b;
                Console.WriteLine("Subtraction of "+sub);
            }
            else if (c == '*')
            {
                int mul = a * b;
                Console.WriteLine("multiplication of"+mul);
            }
            else if (c == '/')
            {
                int di = a * b;
                Console.WriteLine("Division of "+di);
            }

            neww oo = new neww();
            
        }
    }
}
