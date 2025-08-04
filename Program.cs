using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Result: {isPalindrome(input)}");
        }

        static bool isPalindrome(string n)
        {
            int[] num = new int[n.Length];


            if (int.TryParse(n, out int number))
            {
                try
                {
                    if (number < 0)
                    {
                        throw new ArgumentException("Negative numbers are not considered palindromes.");
                    }

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                for (int i = 0; i < n.Length; i++)
                {
                    num[i] = number % 10;
                    number /= 10;
                }
                for (int i = 0; i < n.Length / 2; i++)
                {
                    if (num[i] != num[n.Length - 1 - i])
                    {
                        return false;
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return false;
            }

            return true;
        }
    }
}
