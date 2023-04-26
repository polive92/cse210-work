using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       List<int> numbers = new List<int>();
       while (true) {
        
       
       Console.Write("Enter number: ");
       int num = int.Parse(Console.ReadLine());
       if (num == 0) {
           break;
       }
       numbers.Add(num);

       }
       Console.WriteLine("The sum is: {0}", numbers.Sum());
       Console.WriteLine("The average is: {0}", numbers.Average());
       Console.WriteLine("The largest number is: {0}", numbers.Max());
      
    }
}