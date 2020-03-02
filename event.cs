using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nnnn
{
	public delegate void hello();
	class Program
	{
		public event hello Print;
		public void show()
		{
			int a = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= a ; i++)
			{
				Console.WriteLine("Answer is {0}",a+1);
			}
		}
		static void Main(string[] args)
		{
			Program ob = new Program();
			ob.Print += new hello(ob.show);
			ob.Print();
		}
	}
}
