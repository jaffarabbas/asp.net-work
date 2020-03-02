using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class mian
    {
        public void neew(int i,int j)
        {
            int m = i + j;
            Console.WriteLine(m);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            mian kk = new mian();
            
            kk.neew(a,b);
        }
    }

}
