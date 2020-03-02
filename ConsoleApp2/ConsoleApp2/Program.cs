using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class opper
    {
            public string name = "jaffar";
            public string adress = "hello";
    }

    class Program
    {
        static void Main(string[] args)
        {
            opper jackkk = new opper();

            Console.WriteLine(jackkk.name);
            Console.WriteLine(jackkk.adress);
        }
    }
}
