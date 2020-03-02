using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class triangle:shape
    {
        public void name1()
        {
            Console.WriteLine("************TRIANGLE************");
        }
        
    }
    class circle:shape
    {
        public void name2()
        {
            Console.WriteLine("************CIRCLE************");
        }
    }
    class rectangle:shape
    {
        public void name3()
        {
            Console.WriteLine("************RECTANGLE************");
        }
    }
    public class shape
    {
        public decimal w;
        public decimal r;
        public decimal h;
        public decimal pi = 3.142m;
        public decimal b;
        public decimal Area;
        public decimal Area2;
        public decimal Area3;
        public decimal diiv=0.5m;
        public char x;
      
        public void areacal()
        {
            Console.WriteLine("Enter area of :");
            x = Convert.ToChar(Console.ReadLine());
            if(x == 't' || x == 'T')
            {
                Console.WriteLine("\t\t\t\t************TRIANGLE************");
                Area = diiv * (b * h);
                Console.WriteLine("Area of Triangle : {0}", Area);
            }
            else if(x == 'c' || x == 'C')
            {
                Console.WriteLine("\t\t\t\t************CIRCLE************");
                Area2 = pi * (r * r);
                Console.WriteLine("Area of Circle : {0}",Area2);
            }
            else if (x == 'r' || x == 'R')
            {
                Console.WriteLine("\t\t\t\t************RECTANGLE************");
                Area3 = w * h;
                Console.WriteLine("Area of Rectangle : {0}",Area3);
            }

            
            
        }
        public void display()
        {
                Console.WriteLine("Enter width: ");
                w = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                h = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter base: ");
                b = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter radius: ");
                r = Convert.ToDecimal(Console.ReadLine());
            areacal();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
               shape code = new shape();

         
                code.display();    

        }
    }
}
