using System;

namespace Array
{
    class Program
    {
        static void Main(string[] arg)
        {
            int no1 = 5;
            int no2 = 10;
            int no3 = 15;

            int[] numbers = new int[3];

            Console.WriteLine("Enter ur first number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Enter ur second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Enter ur third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine($"{no1}, {no2}, {no3}");
            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");
        }
    }
}
