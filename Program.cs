using System;

// Reginald Beason
// 2/22/2018
// Even or Odd... Exercise #2 C# Foundations

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please Write Your Name...");
            // var userName = Console.ReadLine();
            // Console.WriteLine("Hello " + userName);

            // Console.WriteLine("Please Write Your Age...");
            // var userAge = Console.ReadLine();
            // int convertAge = int.Parse(userAge);
            // Console.WriteLine(userAge);

            
           Console.WriteLine("Please enter a number between 5-20:");
            string enteredValue = Console.ReadLine();
            int convertedValue = int.Parse(enteredValue);
 
            for (int i = 0; i < convertedValue; i++)
            {
                Console.WriteLine(i.ToString() + " is " + (i % 2 == 0 ? "Even" : "Odd"));
            }
        }
    }
}
