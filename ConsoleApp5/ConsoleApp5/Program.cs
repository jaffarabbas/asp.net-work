
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp5
{
    public delegate void hello(int a, int b);
    class neww
    {
        public static void sum(int a, int b)
        {
       

     
            int c = a + b;
            Console.WriteLine("Answwer is : {0} ", c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            hello man = new hello(neww.sum);
            man.Invoke(22,33);

        }
    }
}
