/// Tech Proj #3b: Array processing
/// ISM 4300 
/// University of South Florida
/// Programmed by Lewis Morgan
/// 
using System;

namespace TechProj3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] numbers = new int[25];

            // Populate the array with random numbers (can't use a foreach here because you're assigning elements to the array)
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 1337);
            }

            // Output the contents of the array

            int index = 0;
            foreach(int num in numbers)
            {
                // It would of been better for me to use a regular 'for' iteration with i, but I wanted to display the use of
                // both the loops. Doing it this way is a little bit more code since you don't know what the index is with foreach.
                // Array.IndexOf might work, but it could be wrong if the array has duplicates.
                Console.WriteLine("Element " + index + "= " + num);
                index++;
            }
        }
    }
}
