using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Vvedite:  ");
			int[] a = new int[8];
			for (int i = 0; i < 8; i++)
			{
				a[i] = int.Parse(Console.ReadLine());
			}
			int[] b = new int[8];
			Console.WriteLine("Otvet:  ");
			for (int i = 0; i < 8; i++)
			{
				b[i] = a[i] % 10;
				Console.WriteLine(b[i]);
			}
		}
    }
}
