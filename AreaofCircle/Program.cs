using System;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(“What is the radius of your circle ?”);
            var radius = double.Parse(Console.ReadLine());

            (Math.PI * radius * radius)
        }
    }
}
