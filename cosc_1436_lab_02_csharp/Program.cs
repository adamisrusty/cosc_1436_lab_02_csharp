using System;

namespace cosc_1436_lab_02_csharp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the score for test 1: ");
            var test1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 2: ");
            var test2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 3: ");
            var test3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 4: ");
            var test4 = Convert.ToDouble(Console.ReadLine());

            var testAverage = (test1 + test2 + test3 + test4) / 4;
            
            Console.WriteLine($"The test average is: { testAverage }");
        }
    }
}