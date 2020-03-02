using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class make
    {
        int c;
        public void add()
        {
            int[] obb = new int[5];
            

            for (int i = 0; i < 5; i++)
            {
                obb[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Array {0} : {1}",i,obb[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                c += obb[i];
                
            }
            Console.WriteLine(c);


        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            make obj = new make();
            obj.add();
        }
    }
}
