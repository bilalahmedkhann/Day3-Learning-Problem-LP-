// Check employee daily wage if present or absent using RANDOM:


using System;

namespace UC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random rand = new Random();
            int num = rand.Next(0, 2);
            Console.WriteLine(num);
            if (num == 1)
            {
                Console.WriteLine("Employee is present and his daily wage is "+(20*8)+".");

            }
            else
            {
                Console.WriteLine("Employee is absent and his daily wage is 0.");
            }
        }
    }
}
