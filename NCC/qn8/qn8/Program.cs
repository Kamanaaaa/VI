using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            5,12,8,20,15,30,7,18,25,14
        };
        var result = numbers.Where(n => n > 10 && n % 2 == 0).OrderByDescending(n => n);
        Console.WriteLine("even numbers greater than 10 in descending order:");

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}
